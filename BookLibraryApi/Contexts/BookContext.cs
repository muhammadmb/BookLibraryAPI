using BookLibraryApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookLibraryApi.Contexts
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Books)
                .WithOne(b => b.Genre)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Authors)
                .WithOne(a => a.Genre)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Reviews)
                .WithOne(r => r.Book);

            // Dunny data just for development

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    GenreName = "Art"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    GenreName = "Fantasy"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    GenreName = "History"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000003"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    GenreName = "Poetry"
                }
                );

            modelBuilder.Entity<Author>().HasData(

                new Author
                {
                    Id = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    Name = "Ahmed",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1988, 4, 5),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    PictureUrl = "https://ex.com"
                },

                new Author
                {
                    Id = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    Name = "Dony",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1918, 4, 5),
                    DateOfDeath = new DateTime(2018, 2, 7),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    PictureUrl = "https://ex.com"
                },

                new Author
                {
                    Id = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    Name = "Mahmoud",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1995, 2, 14),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    PictureUrl = "https://ex.com"
                },
                
                new Author
                {
                    Id = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    Name = "Hassan",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1977, 7, 7),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    PictureUrl = "https://ex.com"
                },

                new Author
                {
                    Id = Guid.Parse("50000000-0000-0000-abcd-000000000000"),
                    Name = "Sara",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1988, 7, 5),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                    PictureUrl = "https://ex.com"
                },

                new Author
                {
                    Id = Guid.Parse("60000000-0000-0000-abcd-000000000000"),
                    Name = "Yara",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1898, 9, 1),
                    DateOfDeath = new DateTime(1948, 7, 1),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000003"),
                    PictureUrl = "https://ex.com"
                },

                new Author
                {
                    Id = Guid.Parse("70000000-0000-0000-abcd-000000000000"),
                    Name = "Lara",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1998, 2, 2),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000003"),
                    PictureUrl = "https://ex.com"
                }
                );

            modelBuilder.Entity<Book>().HasData(
                
                new Book
                {
                    Id = Guid.Parse("00000000-1111-0000-abcd-000000000000"),
                    BookTitle = "A Milion To One",
                    BookCover= "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2014, 4, 5),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-2222-0000-abcd-000000000000"),
                    BookTitle = "Amara the brave",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2018, 12, 5),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-3333-0000-abcd-000000000000"),
                    BookTitle = "The king of drugs",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1987, 11, 15),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-4444-0000-abcd-000000000000"),
                    BookTitle = "The Martian",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1999, 10, 25),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-5555-0000-abcd-000000000000"),
                    BookTitle = "Tess of the road",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1998, 5, 5),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-6666-0000-abcd-000000000000"),
                    BookTitle = "A Milion To One",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1998, 4, 7),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-7777-0000-abcd-000000000000"),
                    BookTitle = "Story Book",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1997, 3, 11),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000003")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-8888-0000-abcd-000000000000"),
                    BookTitle = "History Book",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1997, 2, 14),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-9999-0000-abcd-000000000000"),
                    BookTitle = "City on the edge",
                    BookCover = "https://BC.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1996, 1, 9),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001")
                }
                );
            modelBuilder.Entity<Review>().HasData(
                
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-1111-0000-abcd-000000000000"),
                    ReviewerName="Xman",
                    BookRate=5,
                    Email="XMan@abc.com",
                    ReviewDescription= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-2010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-1111-0000-abcd-000000000000"),
                    ReviewerName = "Aman",
                    BookRate = 4,
                    Email = "AMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-3010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-2222-0000-abcd-000000000000"),
                    ReviewerName = "Bman",
                    BookRate = 4,
                    Email = "BMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-4010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-2222-0000-abcd-000000000000"),
                    ReviewerName = "Cman",
                    BookRate = 5,
                    Email = "CMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-5010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-3333-0000-abcd-000000000000"),
                    ReviewerName = "Dman",
                    BookRate = 1,
                    Email = "DMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-6010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-4444-0000-abcd-000000000000"),
                    ReviewerName = "Eman",
                    BookRate = 3,
                    Email = "EMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-7010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-4444-0000-abcd-000000000000"),
                    ReviewerName = "Fman",
                    BookRate = 3,
                    Email = "FMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-8010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-5555-0000-abcd-000000000000"),
                    ReviewerName = "Gman",
                    BookRate = 4,
                    Email = "GMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-9010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-5555-0000-abcd-000000000000"),
                    ReviewerName = "Hman",
                    BookRate = 2,
                    Email = "HMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1110-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-6666-0000-abcd-000000000000"),
                    ReviewerName = "Zman",
                    BookRate = 2,
                    Email = "ZMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1210-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-7777-0000-abcd-000000000000"),
                    ReviewerName = "Vman",
                    BookRate = 2,
                    Email = "VMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1310-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-7777-0000-abcd-000000000000"),
                    ReviewerName = "Nman",
                    BookRate = 2,
                    Email = "NMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1410-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-8888-0000-abcd-000000000000"),
                    ReviewerName = "Mman",
                    BookRate = 5,
                    Email = "MMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1510-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-8888-0000-abcd-000000000000"),
                    ReviewerName = "Lman",
                    BookRate = 1,
                    Email = "LMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1610-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-8888-0000-abcd-000000000000"),
                    ReviewerName = "Kman",
                    BookRate = 4,
                    Email = "KMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1710-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-9999-0000-abcd-000000000000"),
                    ReviewerName = "Pman",
                    BookRate = 2,
                    Email = "PMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                },
                new Review
                {
                    Id = Guid.Parse("00000000-0000-1810-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-9999-0000-abcd-000000000000"),
                    ReviewerName = "Iman",
                    BookRate = 1,
                    Email = "IMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
                }
                );

        }
    }
}
