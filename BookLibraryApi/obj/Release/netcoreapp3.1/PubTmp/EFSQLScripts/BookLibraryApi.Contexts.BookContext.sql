IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE TABLE [Genres] (
        [Id] uniqueidentifier NOT NULL,
        [Description] nvarchar(max) NULL,
        [GenreName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Genres] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE TABLE [Authors] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [PictureUrl] nvarchar(max) NULL,
        [Bio] nvarchar(1000) NOT NULL,
        [DateOfBirth] datetimeoffset NOT NULL,
        [DateOfDeath] datetimeoffset NOT NULL,
        [GenreId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_Authors] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Authors_Genres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [Genres] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE TABLE [Books] (
        [Id] uniqueidentifier NOT NULL,
        [BookTitle] nvarchar(max) NOT NULL,
        [BookCover] nvarchar(max) NULL,
        [DateOfPublish] datetimeoffset NOT NULL,
        [NumberOfBookPages] int NOT NULL,
        [Publisher] nvarchar(max) NULL,
        [Description] nvarchar(1000) NOT NULL,
        [AuthorId] uniqueidentifier NOT NULL,
        [GenreId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_Books] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Books_Authors_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [Authors] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Books_Genres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [Genres] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE TABLE [Reviews] (
        [Id] uniqueidentifier NOT NULL,
        [ReviewerName] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [ReviewDescription] nvarchar(800) NOT NULL,
        [BookRate] int NOT NULL,
        [BookId] uniqueidentifier NOT NULL,
        [UpVote] int NOT NULL,
        [DownVote] int NOT NULL,
        CONSTRAINT [PK_Reviews] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Reviews_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [Books] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'GenreName') AND [object_id] = OBJECT_ID(N'[Genres]'))
        SET IDENTITY_INSERT [Genres] ON;
    EXEC(N'INSERT INTO [Genres] ([Id], [Description], [GenreName])
    VALUES (''00000000-0000-0000-abcd-000000000000'', N''Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.'', N''Art''),
    (''00000000-0000-0000-abcd-000000000001'', N''Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.'', N''Fantasy''),
    (''00000000-0000-0000-abcd-000000000002'', N''Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.'', N''History''),
    (''00000000-0000-0000-abcd-000000000003'', N''Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.'', N''Poetry'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'GenreName') AND [object_id] = OBJECT_ID(N'[Genres]'))
        SET IDENTITY_INSERT [Genres] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bio', N'DateOfBirth', N'DateOfDeath', N'GenreId', N'Name', N'PictureUrl') AND [object_id] = OBJECT_ID(N'[Authors]'))
        SET IDENTITY_INSERT [Authors] ON;
    EXEC(N'INSERT INTO [Authors] ([Id], [Bio], [DateOfBirth], [DateOfDeath], [GenreId], [Name], [PictureUrl])
    VALUES (''10000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1988-04-05T00:00:00.0000000+02:00'', ''0001-01-01T00:00:00.0000000+00:00'', ''00000000-0000-0000-abcd-000000000000'', N''Ahmed'', N''https://ex.com''),
    (''20000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1918-04-05T00:00:00.0000000+02:00'', ''2018-02-07T00:00:00.0000000+02:00'', ''00000000-0000-0000-abcd-000000000000'', N''Dony'', N''https://ex.com''),
    (''30000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1995-02-14T00:00:00.0000000+02:00'', ''0001-01-01T00:00:00.0000000+00:00'', ''00000000-0000-0000-abcd-000000000001'', N''Mahmoud'', N''https://ex.com''),
    (''40000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1977-07-07T00:00:00.0000000+03:00'', ''0001-01-01T00:00:00.0000000+00:00'', ''00000000-0000-0000-abcd-000000000001'', N''Hassan'', N''https://ex.com''),
    (''50000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1988-07-05T00:00:00.0000000+03:00'', ''0001-01-01T00:00:00.0000000+00:00'', ''00000000-0000-0000-abcd-000000000002'', N''Sara'', N''https://ex.com''),
    (''60000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1898-09-01T00:00:00.0000000+03:00'', ''1948-07-01T00:00:00.0000000+03:00'', ''00000000-0000-0000-abcd-000000000003'', N''Yara'', N''https://ex.com''),
    (''70000000-0000-0000-abcd-000000000000'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''1998-02-02T00:00:00.0000000+02:00'', ''0001-01-01T00:00:00.0000000+00:00'', ''00000000-0000-0000-abcd-000000000003'', N''Lara'', N''https://ex.com'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bio', N'DateOfBirth', N'DateOfDeath', N'GenreId', N'Name', N'PictureUrl') AND [object_id] = OBJECT_ID(N'[Authors]'))
        SET IDENTITY_INSERT [Authors] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AuthorId', N'BookCover', N'BookTitle', N'DateOfPublish', N'Description', N'GenreId', N'NumberOfBookPages', N'Publisher') AND [object_id] = OBJECT_ID(N'[Books]'))
        SET IDENTITY_INSERT [Books] ON;
    EXEC(N'INSERT INTO [Books] ([Id], [AuthorId], [BookCover], [BookTitle], [DateOfPublish], [Description], [GenreId], [NumberOfBookPages], [Publisher])
    VALUES (''00000000-1111-0000-abcd-000000000000'', ''10000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''A Milion To One'', ''2014-04-05T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000000'', 185, N''non''),
    (''00000000-8888-0000-abcd-000000000000'', ''10000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''History Book'', ''1997-02-14T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000002'', 185, N''non''),
    (''00000000-2222-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''Amara the brave'', ''2018-12-05T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000000'', 185, N''non''),
    (''00000000-9999-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''City on the edge'', ''1996-01-09T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000001'', 185, N''non''),
    (''00000000-3333-0000-abcd-000000000000'', ''30000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''The king of drugs'', ''1987-11-15T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000001'', 185, N''non''),
    (''00000000-7777-0000-abcd-000000000000'', ''30000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''Story Book'', ''1997-03-11T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000003'', 185, N''non''),
    (''00000000-4444-0000-abcd-000000000000'', ''40000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''The Martian'', ''1999-10-25T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000002'', 185, N''non''),
    (''00000000-5555-0000-abcd-000000000000'', ''40000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''Tess of the road'', ''1998-05-05T00:00:00.0000000+03:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000002'', 185, N''non''),
    (''00000000-6666-0000-abcd-000000000000'', ''40000000-0000-0000-abcd-000000000000'', N''https://BC.com'', N''A Milion To One'', ''1998-04-07T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', ''00000000-0000-0000-abcd-000000000002'', 185, N''non'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AuthorId', N'BookCover', N'BookTitle', N'DateOfPublish', N'Description', N'GenreId', N'NumberOfBookPages', N'Publisher') AND [object_id] = OBJECT_ID(N'[Books]'))
        SET IDENTITY_INSERT [Books] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'BookId', N'BookRate', N'DownVote', N'Email', N'ReviewDescription', N'ReviewerName', N'UpVote') AND [object_id] = OBJECT_ID(N'[Reviews]'))
        SET IDENTITY_INSERT [Reviews] ON;
    EXEC(N'INSERT INTO [Reviews] ([Id], [BookId], [BookRate], [DownVote], [Email], [ReviewDescription], [ReviewerName], [UpVote])
    VALUES (''00000000-0000-1010-abcd-000000000000'', ''00000000-1111-0000-abcd-000000000000'', 5, 0, N''XMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Xman'', 0),
    (''00000000-0000-8010-abcd-000000000000'', ''00000000-5555-0000-abcd-000000000000'', 4, 0, N''GMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Gman'', 0),
    (''00000000-0000-7010-abcd-000000000000'', ''00000000-4444-0000-abcd-000000000000'', 3, 0, N''FMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Fman'', 0),
    (''00000000-0000-6010-abcd-000000000000'', ''00000000-4444-0000-abcd-000000000000'', 3, 0, N''EMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Eman'', 0),
    (''00000000-0000-1310-abcd-000000000000'', ''00000000-7777-0000-abcd-000000000000'', 2, 0, N''NMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Nman'', 0),
    (''00000000-0000-1210-abcd-000000000000'', ''00000000-7777-0000-abcd-000000000000'', 2, 0, N''VMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Vman'', 0),
    (''00000000-0000-5010-abcd-000000000000'', ''00000000-3333-0000-abcd-000000000000'', 1, 0, N''DMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Dman'', 0),
    (''00000000-0000-9010-abcd-000000000000'', ''00000000-5555-0000-abcd-000000000000'', 2, 0, N''HMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Hman'', 0),
    (''00000000-0000-1810-abcd-000000000000'', ''00000000-9999-0000-abcd-000000000000'', 1, 0, N''IMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Iman'', 0),
    (''00000000-0000-4010-abcd-000000000000'', ''00000000-2222-0000-abcd-000000000000'', 5, 0, N''CMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Cman'', 0),
    (''00000000-0000-3010-abcd-000000000000'', ''00000000-2222-0000-abcd-000000000000'', 4, 0, N''BMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Bman'', 0),
    (''00000000-0000-1610-abcd-000000000000'', ''00000000-8888-0000-abcd-000000000000'', 4, 0, N''KMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Kman'', 0),
    (''00000000-0000-1510-abcd-000000000000'', ''00000000-8888-0000-abcd-000000000000'', 1, 0, N''LMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Lman'', 0),
    (''00000000-0000-1410-abcd-000000000000'', ''00000000-8888-0000-abcd-000000000000'', 5, 0, N''MMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Mman'', 0),
    (''00000000-0000-2010-abcd-000000000000'', ''00000000-1111-0000-abcd-000000000000'', 4, 0, N''AMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Aman'', 0),
    (''00000000-0000-1710-abcd-000000000000'', ''00000000-9999-0000-abcd-000000000000'', 2, 0, N''PMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Pman'', 0),
    (''00000000-0000-1110-abcd-000000000000'', ''00000000-6666-0000-abcd-000000000000'', 2, 0, N''ZMan@abc.com'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', N''Zman'', 0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'BookId', N'BookRate', N'DownVote', N'Email', N'ReviewDescription', N'ReviewerName', N'UpVote') AND [object_id] = OBJECT_ID(N'[Reviews]'))
        SET IDENTITY_INSERT [Reviews] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE INDEX [IX_Authors_GenreId] ON [Authors] ([GenreId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE INDEX [IX_Books_AuthorId] ON [Books] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE INDEX [IX_Books_GenreId] ON [Books] ([GenreId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    CREATE INDEX [IX_Reviews_BookId] ON [Reviews] ([BookId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305004636_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210305004636_init', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306154646_addPictureToGenre')
BEGIN
    ALTER TABLE [Genres] ADD [PicUrl] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306154646_addPictureToGenre')
BEGIN
    EXEC(N'UPDATE [Genres] SET [PicUrl] = N''https://ex.com''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306154646_addPictureToGenre')
BEGIN
    EXEC(N'UPDATE [Genres] SET [PicUrl] = N''https://ex.com''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000001'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306154646_addPictureToGenre')
BEGIN
    EXEC(N'UPDATE [Genres] SET [PicUrl] = N''https://ex.com''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000002'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306154646_addPictureToGenre')
BEGIN
    EXEC(N'UPDATE [Genres] SET [PicUrl] = N''https://ex.com''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000003'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306154646_addPictureToGenre')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210306154646_addPictureToGenre', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Genres]') AND [c].[name] = N'PicUrl');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Genres] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Genres] ALTER COLUMN [PicUrl] nvarchar(max) NOT NULL;
    ALTER TABLE [Genres] ADD DEFAULT N'' FOR [PicUrl];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    CREATE TABLE [BookRates] (
        [BookRateId] uniqueidentifier NOT NULL,
        [FiveStars] int NOT NULL,
        [FourStars] int NOT NULL,
        [ThreeStars] int NOT NULL,
        [TwoStars] int NOT NULL,
        [OneStar] int NOT NULL,
        [TotalRating] int NOT NULL,
        CONSTRAINT [PK_BookRates] PRIMARY KEY ([BookRateId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Khaled Ahmed'', [PictureUrl] = N''https://images.unsplash.com/photo-1485893226355-9a1c32a0c81e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80''
    WHERE [Id] = ''10000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Naguib Mahfouz'', [PictureUrl] = N''https://i.pinimg.com/originals/f4/07/96/f40796f816539dcb76f3c7e4fb750370.jpg''
    WHERE [Id] = ''20000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Hung Men Son'', [PictureUrl] = N''https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MzV8fHBlb3BsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60''
    WHERE [Id] = ''30000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Adham Hamza'', [PictureUrl] = N''https://images.unsplash.com/photo-1485528562718-2ae1c8419ae2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=781&q=80''
    WHERE [Id] = ''40000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Walter Diang'', [PictureUrl] = N''https://images.unsplash.com/photo-1527980965255-d3b416303d12?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80''
    WHERE [Id] = ''50000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Ayman Banon'', [PictureUrl] = N''https://images.unsplash.com/photo-1580309237429-661ea7cd1d53?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80''
    WHERE [Id] = ''60000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Authors] SET [Name] = N''Masute Ozil'', [PictureUrl] = N''https://images.unsplash.com/photo-1542178243-bc20204b769f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80''
    WHERE [Id] = ''70000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://www.designforwriters.com/wp-content/uploads/2017/10/design-for-writers-book-cover-tf-2-a-million-to-one.jpg'', [NumberOfBookPages] = 456, [Publisher] = N''Zindex''
    WHERE [Id] = ''00000000-1111-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://marketplace.canva.com/EAD7WWWtKSQ/1/0/251w/canva-purple-and-red-leaves-illustration-children%27s-book-cover-hNI7HYnNVQQ.jpg'', [NumberOfBookPages] = 285, [Publisher] = N''AI''
    WHERE [Id] = ''00000000-2222-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://d1csarkz8obe9u.cloudfront.net/posterpreviews/action-thriller-book-cover-design-template-3675ae3e3ac7ee095fc793ab61b812cc_screen.jpg?ts=1588152105'', [NumberOfBookPages] = 145
    WHERE [Id] = ''00000000-3333-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://static01.nyt.com/images/2014/02/05/books/05before-and-after-slide-T6H2/05before-and-after-slide-T6H2-superJumbo.jpg?quality=75&auto=webp&disable=upscale'', [DateOfPublish] = ''2010-10-25T00:00:00.0000000+02:00'', [NumberOfBookPages] = 575
    WHERE [Id] = ''00000000-4444-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://images.squarespace-cdn.com/content/v1/5ae2fce87e3c3ae275ea2c9f/1526464175408-W92Q4MSAM40I8YF4HM64/ke17ZwdGBToddI8pDm48kG42nK5MxReh9N1Tgs_dc9t7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1UXysNIcM8ERoy824r28kfN5DdNsbvYnFI46u1WARIoKesh_vZu_IHrh0xbom9DKbTA/tess-cover.jpg?format=1500w'', [Publisher] = N''Alef''
    WHERE [Id] = ''00000000-5555-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://cms-assets.tutsplus.com/uploads/users/1631/posts/32582/image/Soulful%20Poetry%20Book%20Cover%20Template%20copy.jpg'', [BookTitle] = N''Songs with Souls'', [NumberOfBookPages] = 450
    WHERE [Id] = ''00000000-6666-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://assets-2.placeit.net/smart_templates/e639b9513adc63d37ee4f577433b787b/assets/wn5u193mcjesm2ycxacaltq8jdu68kmu.jpg'', [NumberOfBookPages] = 221
    WHERE [Id] = ''00000000-7777-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://i.pinimg.com/originals/1e/c5/df/1ec5df963765d4bcf151467c99d1dae7.jpg'', [BookTitle] = N''Finding Moana'', [Publisher] = N''Book One''
    WHERE [Id] = ''00000000-8888-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Books] SET [BookCover] = N''https://i.pinimg.com/originals/a4/aa/c1/a4aac1f3d86869bcfd2833e8be768014.jpg''
    WHERE [Id] = ''00000000-9999-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Genres] SET [GenreName] = N''Classics'', [PicUrl] = N''https://cdn.shopify.com/s/files/1/0064/5342/8271/products/PCCP5-Penguin_Classics_Cameo_angle_1200_300x.jpg?v=1556052881''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000000'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Genres] SET [PicUrl] = N''https://www.rd.com/wp-content/uploads/2019/12/book-e1576790089347.jpg''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000001'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Genres] SET [GenreName] = N''Action and Adventure'', [PicUrl] = N''https://alisonmortonauthor.com/wp-content/uploads/2014/01/books.jpg''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000002'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    EXEC(N'UPDATE [Genres] SET [GenreName] = N''Comic Book'', [PicUrl] = N''https://www.sun-sentinel.com/resizer/1fuMDdJE7v3kltVnXX07CWZ58Ws=/415x614/top/www.trbimg.com/img-5caf8a09/turbine/fl-1555008005-hc4qu2941s-snap-image''
    WHERE [Id] = ''00000000-0000-0000-abcd-000000000003'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'GenreName', N'PicUrl') AND [object_id] = OBJECT_ID(N'[Genres]'))
        SET IDENTITY_INSERT [Genres] ON;
    EXEC(N'INSERT INTO [Genres] ([Id], [Description], [GenreName], [PicUrl])
    VALUES (''00000000-0000-0000-abcd-000000000005'', N''Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.'', N''Horror'', N''https://images.thestar.com/xN_oIrR10VL8zpaa1-hDq0ELBE8=/1086x1652/smart/filters:cb(1594158289211)/https://www.thestar.com/content/dam/thestar/entertainment/books/2020/07/09/horror-books-to-make-you-lose-your-cool-on-a-hot-summers-night/if_it_bleeds.jpg''),
    (''00000000-0000-0000-abcd-000000000004'', N''Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.'', N''Romance'', N''https://pbs.twimg.com/media/EQuNRJoU0AAvyKD.jpg'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'GenreName', N'PicUrl') AND [object_id] = OBJECT_ID(N'[Genres]'))
        SET IDENTITY_INSERT [Genres] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318064418_editDummyData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210318064418_editDummyData', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    DROP TABLE [BookRates];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    ALTER TABLE [Books] ADD [FiveStarsRate] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    ALTER TABLE [Books] ADD [FourStarsRate] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    ALTER TABLE [Books] ADD [OneStarRate] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    ALTER TABLE [Books] ADD [ThreeStarsRate] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    ALTER TABLE [Books] ADD [TotalRate] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    ALTER TABLE [Books] ADD [TwoStarsRate] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AuthorId', N'BookCover', N'BookTitle', N'DateOfPublish', N'Description', N'FiveStarsRate', N'FourStarsRate', N'GenreId', N'NumberOfBookPages', N'OneStarRate', N'Publisher', N'ThreeStarsRate', N'TotalRate', N'TwoStarsRate') AND [object_id] = OBJECT_ID(N'[Books]'))
        SET IDENTITY_INSERT [Books] ON;
    EXEC(N'INSERT INTO [Books] ([Id], [AuthorId], [BookCover], [BookTitle], [DateOfPublish], [Description], [FiveStarsRate], [FourStarsRate], [GenreId], [NumberOfBookPages], [OneStarRate], [Publisher], [ThreeStarsRate], [TotalRate], [TwoStarsRate])
    VALUES (''00000000-1010-0000-abcd-000000000000'', ''10000000-0000-0000-abcd-000000000000'', N''https://d1csarkz8obe9u.cloudfront.net/posterpreviews/haunted-house-horror-book-cover-design-template-fd3a8016a4128af962549c3c40190270_screen.jpg?ts=1588747771'', N''House Of Secrets'', ''2006-05-09T00:00:00.0000000+03:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000005'', 158, 0, N''non'', 0, 0, 0),
    (''00000000-1100-0000-abcd-000000000000'', ''10000000-0000-0000-abcd-000000000000'', N''https://i.pinimg.com/originals/d1/47/e9/d147e94169caabe9ca52cf7e7f20bb4c.jpg'', N''The Carrow Haunt'', ''1996-01-09T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000005'', 444, 0, N''non'', 0, 0, 0),
    (''00000000-1212-0000-abcd-000000000000'', ''30000000-0000-0000-abcd-000000000000'', N''https://i.pinimg.com/originals/a4/aa/c1/a4aac1f3d86869bcfd2833e8be768014.jpg'', N''Stephen King'', ''2007-11-15T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000005'', 800, 0, N''non'', 0, 0, 0),
    (''00000000-1313-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''https://corviddesign.com/wp-content/uploads/2015/11/isntfunny_web.png'', N''Isn''''t That Funny'', ''2013-07-30T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000005'', 545, 0, N''non'', 0, 0, 0),
    (''00000000-1414-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''hhttps://artfulcover.com/wp-content/uploads/2018/06/Artful-Cover_premade_126524214_Creepy-Kid-Ghost_800x1200.jpg'', N''Creepy Kid Ghost'', ''2015-08-01T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000005'', 652, 0, N''non'', 0, 0, 0),
    (''00000000-1515-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''https://i.pinimg.com/originals/97/26/e8/9726e81b7bba2b8fe0aca6f804b1f44b.jpg'', N''The Black Thunder'', ''2001-01-01T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000002'', 325, 0, N''non'', 0, 0, 0),
    (''00000000-1616-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''https://damonza.com/wp-content/uploads/portfolio/fiction/torrent-15.jpg'', N''Torrent'', ''2010-10-10T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000002'', 475, 0, N''non'', 0, 0, 0),
    (''00000000-1717-0000-abcd-000000000000'', ''20000000-0000-0000-abcd-000000000000'', N''https://damonza.com/wp-content/uploads/portfolio/fiction/torrent-15.jpg'', N''Torrent'', ''2010-10-10T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000002'', 475, 0, N''non'', 0, 0, 0),
    (''00000000-1818-0000-abcd-000000000000'', ''10000000-0000-0000-abcd-000000000000'', N''https://i.pinimg.com/originals/aa/11/6a/aa116a773d6049b0d9d778aae0650062.jpg'', N''The Blue Princes'', ''2019-11-10T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000001'', 405, 0, N''non'', 0, 0, 0),
    (''00000000-1919-0000-abcd-000000000000'', ''10000000-0000-0000-abcd-000000000000'', N''https://www.mythosink.com/wp-content/uploads/2020/01/Screen-Shot-2020-01-20-at-6.00.55-PM.png'', N''Tarnished light'', ''2020-10-11T00:00:00.0000000+02:00'', N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis'', 0, 0, ''00000000-0000-0000-abcd-000000000001'', 507, 0, N''non'', 0, 0, 0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AuthorId', N'BookCover', N'BookTitle', N'DateOfPublish', N'Description', N'FiveStarsRate', N'FourStarsRate', N'GenreId', N'NumberOfBookPages', N'OneStarRate', N'Publisher', N'ThreeStarsRate', N'TotalRate', N'TwoStarsRate') AND [object_id] = OBJECT_ID(N'[Books]'))
        SET IDENTITY_INSERT [Books] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210318172909_setBookRating')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210318172909_setBookRating', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'FiveStarsRate');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Books] DROP COLUMN [FiveStarsRate];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'FourStarsRate');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Books] DROP COLUMN [FourStarsRate];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'OneStarRate');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Books] DROP COLUMN [OneStarRate];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'ThreeStarsRate');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Books] DROP COLUMN [ThreeStarsRate];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'TotalRate');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Books] DROP COLUMN [TotalRate];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'TwoStarsRate');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Books] DROP COLUMN [TwoStarsRate];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    ALTER TABLE [Books] ADD [bookRatingBookRateId] uniqueidentifier NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    CREATE TABLE [bookRatings] (
        [BookRateId] uniqueidentifier NOT NULL,
        [FiveStarsRate] int NOT NULL,
        [FourStarsRate] int NOT NULL,
        [ThreeStarsRate] int NOT NULL,
        [TwoStarsRate] int NOT NULL,
        [OneStarRate] int NOT NULL,
        [TotalRate] int NOT NULL,
        [ReviewsCount] int NOT NULL,
        CONSTRAINT [PK_bookRatings] PRIMARY KEY ([BookRateId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    CREATE INDEX [IX_Books_bookRatingBookRateId] ON [Books] ([bookRatingBookRateId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    ALTER TABLE [Books] ADD CONSTRAINT [FK_Books_bookRatings_bookRatingBookRateId] FOREIGN KEY ([bookRatingBookRateId]) REFERENCES [bookRatings] ([BookRateId]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320130635_addBookRatingEntity')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210320130635_addBookRatingEntity', N'5.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    ALTER TABLE [Books] DROP CONSTRAINT [FK_Books_bookRatings_bookRatingBookRateId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    DROP INDEX [IX_Books_bookRatingBookRateId] ON [Books];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    ALTER TABLE [bookRatings] DROP CONSTRAINT [PK_bookRatings];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'bookRatingBookRateId');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Books] DROP COLUMN [bookRatingBookRateId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    EXEC sp_rename N'[bookRatings]', N'BookRatings';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    ALTER TABLE [BookRatings] ADD [BookId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    ALTER TABLE [BookRatings] ADD CONSTRAINT [PK_BookRatings] PRIMARY KEY ([BookRateId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BookRateId', N'BookId', N'FiveStarsRate', N'FourStarsRate', N'OneStarRate', N'ReviewsCount', N'ThreeStarsRate', N'TotalRate', N'TwoStarsRate') AND [object_id] = OBJECT_ID(N'[BookRatings]'))
        SET IDENTITY_INSERT [BookRatings] ON;
    EXEC(N'INSERT INTO [BookRatings] ([BookRateId], [BookId], [FiveStarsRate], [FourStarsRate], [OneStarRate], [ReviewsCount], [ThreeStarsRate], [TotalRate], [TwoStarsRate])
    VALUES (''11111111-0000-0000-abcd-000000000000'', ''00000000-1111-0000-abcd-000000000000'', 1, 1, 0, 2, 0, 9, 0),
    (''22222222-0000-0000-abcd-000000000000'', ''00000000-6666-0000-abcd-000000000000'', 0, 0, 0, 1, 0, 2, 1),
    (''33333333-0000-0000-abcd-000000000000'', ''00000000-7777-0000-abcd-000000000000'', 0, 0, 0, 2, 0, 4, 2),
    (''44444444-0000-0000-abcd-000000000000'', ''00000000-8888-0000-abcd-000000000000'', 1, 1, 0, 3, 0, 11, 1),
    (''55555555-0000-0000-abcd-000000000000'', ''00000000-9999-0000-abcd-000000000000'', 1, 1, 0, 3, 0, 11, 1),
    (''66666666-0000-0000-abcd-000000000000'', ''00000000-2222-0000-abcd-000000000000'', 1, 1, 0, 2, 0, 9, 0),
    (''77777777-0000-0000-abcd-000000000000'', ''00000000-4444-0000-abcd-000000000000'', 0, 0, 0, 2, 2, 6, 0),
    (''88888888-0000-0000-abcd-000000000000'', ''00000000-5555-0000-abcd-000000000000'', 0, 1, 0, 2, 0, 6, 1)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BookRateId', N'BookId', N'FiveStarsRate', N'FourStarsRate', N'OneStarRate', N'ReviewsCount', N'ThreeStarsRate', N'TotalRate', N'TwoStarsRate') AND [object_id] = OBJECT_ID(N'[BookRatings]'))
        SET IDENTITY_INSERT [BookRatings] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    CREATE UNIQUE INDEX [IX_BookRatings_BookId] ON [BookRatings] ([BookId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    ALTER TABLE [BookRatings] ADD CONSTRAINT [FK_BookRatings_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [Books] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210320153741_editBookRating')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210320153741_editBookRating', N'5.0.3');
END;
GO

COMMIT;
GO

