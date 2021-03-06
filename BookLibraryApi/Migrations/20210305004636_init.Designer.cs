﻿// <auto-generated />
using System;
using BookLibraryApi.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookLibraryApi.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20210305004636_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookLibraryApi.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateOfDeath")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1988, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000000"),
                            Name = "Ahmed",
                            PictureUrl = "https://ex.com"
                        },
                        new
                        {
                            Id = new Guid("20000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1918, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(2018, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000000"),
                            Name = "Dony",
                            PictureUrl = "https://ex.com"
                        },
                        new
                        {
                            Id = new Guid("30000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1995, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000001"),
                            Name = "Mahmoud",
                            PictureUrl = "https://ex.com"
                        },
                        new
                        {
                            Id = new Guid("40000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000001"),
                            Name = "Hassan",
                            PictureUrl = "https://ex.com"
                        },
                        new
                        {
                            Id = new Guid("50000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1988, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000002"),
                            Name = "Sara",
                            PictureUrl = "https://ex.com"
                        },
                        new
                        {
                            Id = new Guid("60000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1898, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(1948, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000003"),
                            Name = "Yara",
                            PictureUrl = "https://ex.com"
                        },
                        new
                        {
                            Id = new Guid("70000000-0000-0000-abcd-000000000000"),
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            DateOfBirth = new DateTimeOffset(new DateTime(1998, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DateOfDeath = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000003"),
                            Name = "Lara",
                            PictureUrl = "https://ex.com"
                        });
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BookCover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DateOfPublish")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfBookPages")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-1111-0000-abcd-000000000000"),
                            AuthorId = new Guid("10000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "A Milion To One",
                            DateOfPublish = new DateTimeOffset(new DateTime(2014, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000000"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-2222-0000-abcd-000000000000"),
                            AuthorId = new Guid("20000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "Amara the brave",
                            DateOfPublish = new DateTimeOffset(new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000000"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-3333-0000-abcd-000000000000"),
                            AuthorId = new Guid("30000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "The king of drugs",
                            DateOfPublish = new DateTimeOffset(new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000001"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-4444-0000-abcd-000000000000"),
                            AuthorId = new Guid("40000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "The Martian",
                            DateOfPublish = new DateTimeOffset(new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000002"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-5555-0000-abcd-000000000000"),
                            AuthorId = new Guid("40000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "Tess of the road",
                            DateOfPublish = new DateTimeOffset(new DateTime(1998, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000002"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-6666-0000-abcd-000000000000"),
                            AuthorId = new Guid("40000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "A Milion To One",
                            DateOfPublish = new DateTimeOffset(new DateTime(1998, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000002"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-7777-0000-abcd-000000000000"),
                            AuthorId = new Guid("30000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "Story Book",
                            DateOfPublish = new DateTimeOffset(new DateTime(1997, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000003"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-8888-0000-abcd-000000000000"),
                            AuthorId = new Guid("10000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "History Book",
                            DateOfPublish = new DateTimeOffset(new DateTime(1997, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000002"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        },
                        new
                        {
                            Id = new Guid("00000000-9999-0000-abcd-000000000000"),
                            AuthorId = new Guid("20000000-0000-0000-abcd-000000000000"),
                            BookCover = "https://BC.com",
                            BookTitle = "City on the edge",
                            DateOfPublish = new DateTimeOffset(new DateTime(1996, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            GenreId = new Guid("00000000-0000-0000-abcd-000000000001"),
                            NumberOfBookPages = 185,
                            Publisher = "non"
                        });
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-abcd-000000000000"),
                            Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                            GenreName = "Art"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-abcd-000000000001"),
                            Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-abcd-000000000002"),
                            Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                            GenreName = "History"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-abcd-000000000003"),
                            Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                            GenreName = "Poetry"
                        });
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BookRate")
                        .HasColumnType("int");

                    b.Property<int>("DownVote")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewDescription")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpVote")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-1010-abcd-000000000000"),
                            BookId = new Guid("00000000-1111-0000-abcd-000000000000"),
                            BookRate = 5,
                            DownVote = 0,
                            Email = "XMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Xman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-2010-abcd-000000000000"),
                            BookId = new Guid("00000000-1111-0000-abcd-000000000000"),
                            BookRate = 4,
                            DownVote = 0,
                            Email = "AMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Aman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-3010-abcd-000000000000"),
                            BookId = new Guid("00000000-2222-0000-abcd-000000000000"),
                            BookRate = 4,
                            DownVote = 0,
                            Email = "BMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Bman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-4010-abcd-000000000000"),
                            BookId = new Guid("00000000-2222-0000-abcd-000000000000"),
                            BookRate = 5,
                            DownVote = 0,
                            Email = "CMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Cman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-5010-abcd-000000000000"),
                            BookId = new Guid("00000000-3333-0000-abcd-000000000000"),
                            BookRate = 1,
                            DownVote = 0,
                            Email = "DMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Dman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-6010-abcd-000000000000"),
                            BookId = new Guid("00000000-4444-0000-abcd-000000000000"),
                            BookRate = 3,
                            DownVote = 0,
                            Email = "EMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Eman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-7010-abcd-000000000000"),
                            BookId = new Guid("00000000-4444-0000-abcd-000000000000"),
                            BookRate = 3,
                            DownVote = 0,
                            Email = "FMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Fman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-8010-abcd-000000000000"),
                            BookId = new Guid("00000000-5555-0000-abcd-000000000000"),
                            BookRate = 4,
                            DownVote = 0,
                            Email = "GMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Gman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-9010-abcd-000000000000"),
                            BookId = new Guid("00000000-5555-0000-abcd-000000000000"),
                            BookRate = 2,
                            DownVote = 0,
                            Email = "HMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Hman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1110-abcd-000000000000"),
                            BookId = new Guid("00000000-6666-0000-abcd-000000000000"),
                            BookRate = 2,
                            DownVote = 0,
                            Email = "ZMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Zman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1210-abcd-000000000000"),
                            BookId = new Guid("00000000-7777-0000-abcd-000000000000"),
                            BookRate = 2,
                            DownVote = 0,
                            Email = "VMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Vman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1310-abcd-000000000000"),
                            BookId = new Guid("00000000-7777-0000-abcd-000000000000"),
                            BookRate = 2,
                            DownVote = 0,
                            Email = "NMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Nman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1410-abcd-000000000000"),
                            BookId = new Guid("00000000-8888-0000-abcd-000000000000"),
                            BookRate = 5,
                            DownVote = 0,
                            Email = "MMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Mman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1510-abcd-000000000000"),
                            BookId = new Guid("00000000-8888-0000-abcd-000000000000"),
                            BookRate = 1,
                            DownVote = 0,
                            Email = "LMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Lman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1610-abcd-000000000000"),
                            BookId = new Guid("00000000-8888-0000-abcd-000000000000"),
                            BookRate = 4,
                            DownVote = 0,
                            Email = "KMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Kman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1710-abcd-000000000000"),
                            BookId = new Guid("00000000-9999-0000-abcd-000000000000"),
                            BookRate = 2,
                            DownVote = 0,
                            Email = "PMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Pman",
                            UpVote = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-1810-abcd-000000000000"),
                            BookId = new Guid("00000000-9999-0000-abcd-000000000000"),
                            BookRate = 1,
                            DownVote = 0,
                            Email = "IMan@abc.com",
                            ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                            ReviewerName = "Iman",
                            UpVote = 0
                        });
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Author", b =>
                {
                    b.HasOne("BookLibraryApi.Entities.Genre", "Genre")
                        .WithMany("Authors")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Book", b =>
                {
                    b.HasOne("BookLibraryApi.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibraryApi.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Review", b =>
                {
                    b.HasOne("BookLibraryApi.Entities.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookLibraryApi.Entities.Genre", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
