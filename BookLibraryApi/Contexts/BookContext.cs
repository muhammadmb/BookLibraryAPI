using BookLibraryApi.Entities;
using BookLibraryApi.Models.AuthenticationModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookLibraryApi.Contexts
{
    public class BookContext : IdentityDbContext<ApplicationUser>
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<BookRating> BookRatings { get; set; }

        public DbSet<RefreshTokens> RefreshTokens { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Suggestion> Suggestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Books)
                .WithOne(b => b.Genre)
                .HasForeignKey(b => b.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Authors)
                .WithOne(a => a.Genre)
                .HasForeignKey(a => a.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Reviews)
                .WithOne(r => r.Book);

            modelBuilder.Entity<Book>()
                .HasOne<BookRating>(b => b.BookRating)
                .WithOne(r => r.Book)
                .HasForeignKey<BookRating>(r => r.BookId);

            modelBuilder.Entity<ApplicationUser>().HasQueryFilter(a => a.IsDeleted == null);
            modelBuilder.Entity<Author>().HasQueryFilter(a => a.IsDeleted == null);
            modelBuilder.Entity<Genre>().HasQueryFilter(g => g.IsDeleted == null);
            modelBuilder.Entity<Book>().HasQueryFilter(b => b.IsDeleted == null);
            modelBuilder.Entity<Review>().HasQueryFilter(r => r.IsDeleted == null);
            modelBuilder.Entity<Feedback>().HasQueryFilter(f => f.IsDeleted == null);
            modelBuilder.Entity<Suggestion>().HasQueryFilter(s => s.IsDeleted == null);

            // data just for development

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    PicUrl = "https://cdn.shopify.com/s/files/1/0064/5342/8271/products/PCCP5-Penguin_Classics_Cameo_angle_1200_300x.jpg?v=1556052881",
                    GenreName = "Classics"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    PicUrl = "https://www.rd.com/wp-content/uploads/2019/12/book-e1576790089347.jpg",
                    GenreName = "Fantasy"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    PicUrl = "https://alisonmortonauthor.com/wp-content/uploads/2014/01/books.jpg",
                    GenreName = "Action and Adventure"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000003"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    PicUrl = "https://www.sun-sentinel.com/resizer/1fuMDdJE7v3kltVnXX07CWZ58Ws=/415x614/top/www.trbimg.com/img-5caf8a09/turbine/fl-1555008005-hc4qu2941s-snap-image",
                    GenreName = "Comic Book"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000004"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    PicUrl = "https://pbs.twimg.com/media/EQuNRJoU0AAvyKD.jpg",
                    GenreName = "Romance"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000005"),
                    Description = "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.",
                    PicUrl = "https://images.thestar.com/xN_oIrR10VL8zpaa1-hDq0ELBE8=/1086x1652/smart/filters:cb(1594158289211)/https://www.thestar.com/content/dam/thestar/entertainment/books/2020/07/09/horror-books-to-make-you-lose-your-cool-on-a-hot-summers-night/if_it_bleeds.jpg",
                    GenreName = "Horror"
                }
                );

            modelBuilder.Entity<Author>().HasData(

                new Author
                {
                    Id = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    Name = "Khaled Ahmed",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1988, 4, 5),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    PictureUrl = "https://images.unsplash.com/photo-1485893226355-9a1c32a0c81e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80"
                },

                new Author
                {
                    Id = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    Name = "Naguib Mahfouz",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1918, 4, 5),
                    DateOfDeath = new DateTime(2018, 2, 7),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    PictureUrl = "https://i.pinimg.com/originals/f4/07/96/f40796f816539dcb76f3c7e4fb750370.jpg"
                },

                new Author
                {
                    Id = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    Name = "Hung Men Son",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1995, 2, 14),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    PictureUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MzV8fHBlb3BsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                },

                new Author
                {
                    Id = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    Name = "Adham Hamza",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1977, 7, 7),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    PictureUrl = "https://images.unsplash.com/photo-1485528562718-2ae1c8419ae2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=781&q=80"
                },

                new Author
                {
                    Id = Guid.Parse("50000000-0000-0000-abcd-000000000000"),
                    Name = "Walter Diang",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1988, 7, 5),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                    PictureUrl = "https://images.unsplash.com/photo-1527980965255-d3b416303d12?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80"
                },

                new Author
                {
                    Id = Guid.Parse("60000000-0000-0000-abcd-000000000000"),
                    Name = "Ayman Banon",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1898, 9, 1),
                    DateOfDeath = new DateTime(1948, 7, 1),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000003"),
                    PictureUrl = "https://images.unsplash.com/photo-1580309237429-661ea7cd1d53?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80"
                },

                new Author
                {
                    Id = Guid.Parse("70000000-0000-0000-abcd-000000000000"),
                    Name = "Masute Ozil",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfBirth = new DateTime(1998, 2, 2),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000003"),
                    PictureUrl = "https://images.unsplash.com/photo-1542178243-bc20204b769f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80"
                }
                );

            modelBuilder.Entity<Book>().HasData(

                new Book
                {
                    Id = Guid.Parse("00000000-1111-0000-abcd-000000000000"),
                    BookTitle = "A Milion To One",
                    BookCover = "https://www.designforwriters.com/wp-content/uploads/2017/10/design-for-writers-book-cover-tf-2-a-million-to-one.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2014, 4, 5),
                    NumberOfBookPages = 456,
                    Publisher = "Zindex",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-2222-0000-abcd-000000000000"),
                    BookTitle = "Amara the brave",
                    BookCover = "https://marketplace.canva.com/EAD7WWWtKSQ/1/0/251w/canva-purple-and-red-leaves-illustration-children%27s-book-cover-hNI7HYnNVQQ.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2018, 12, 5),
                    NumberOfBookPages = 285,
                    Publisher = "AI",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000000")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-3333-0000-abcd-000000000000"),
                    BookTitle = "The king of drugs",
                    BookCover = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/action-thriller-book-cover-design-template-3675ae3e3ac7ee095fc793ab61b812cc_screen.jpg?ts=1588152105",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1987, 11, 15),
                    NumberOfBookPages = 145,
                    Publisher = "non",
                    AuthorId = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-4444-0000-abcd-000000000000"),
                    BookTitle = "The Martian",
                    BookCover = "https://static01.nyt.com/images/2014/02/05/books/05before-and-after-slide-T6H2/05before-and-after-slide-T6H2-superJumbo.jpg?quality=75&auto=webp&disable=upscale",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2010, 10, 25),
                    NumberOfBookPages = 575,
                    Publisher = "non",
                    AuthorId = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-5555-0000-abcd-000000000000"),
                    BookTitle = "Tess of the road",
                    BookCover = "https://images.squarespace-cdn.com/content/v1/5ae2fce87e3c3ae275ea2c9f/1526464175408-W92Q4MSAM40I8YF4HM64/ke17ZwdGBToddI8pDm48kG42nK5MxReh9N1Tgs_dc9t7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1UXysNIcM8ERoy824r28kfN5DdNsbvYnFI46u1WARIoKesh_vZu_IHrh0xbom9DKbTA/tess-cover.jpg?format=1500w",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1998, 5, 5),
                    NumberOfBookPages = 185,
                    Publisher = "Alef",
                    AuthorId = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-6666-0000-abcd-000000000000"),
                    BookTitle = "Songs with Souls",
                    BookCover = "https://cms-assets.tutsplus.com/uploads/users/1631/posts/32582/image/Soulful%20Poetry%20Book%20Cover%20Template%20copy.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1998, 4, 7),
                    NumberOfBookPages = 450,
                    Publisher = "non",
                    AuthorId = Guid.Parse("40000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-7777-0000-abcd-000000000000"),
                    BookTitle = "Story Book",
                    BookCover = "https://assets-2.placeit.net/smart_templates/e639b9513adc63d37ee4f577433b787b/assets/wn5u193mcjesm2ycxacaltq8jdu68kmu.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1997, 3, 11),
                    NumberOfBookPages = 221,
                    Publisher = "non",
                    AuthorId = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000003")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-8888-0000-abcd-000000000000"),
                    BookTitle = "Finding Moana",
                    BookCover = "https://i.pinimg.com/originals/1e/c5/df/1ec5df963765d4bcf151467c99d1dae7.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1997, 2, 14),
                    NumberOfBookPages = 185,
                    Publisher = "Book One",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-9999-0000-abcd-000000000000"),
                    BookTitle = "City on the edge",
                    BookCover = "https://i.pinimg.com/originals/a4/aa/c1/a4aac1f3d86869bcfd2833e8be768014.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1996, 1, 9),
                    NumberOfBookPages = 185,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1010-0000-abcd-000000000000"),
                    BookTitle = "House Of Secrets",
                    BookCover = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/haunted-house-horror-book-cover-design-template-fd3a8016a4128af962549c3c40190270_screen.jpg?ts=1588747771",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2006, 5, 9),
                    NumberOfBookPages = 158,
                    Publisher = "non",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000005")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1100-0000-abcd-000000000000"),
                    BookTitle = "The Carrow Haunt",
                    BookCover = "https://i.pinimg.com/originals/d1/47/e9/d147e94169caabe9ca52cf7e7f20bb4c.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(1996, 1, 9),
                    NumberOfBookPages = 444,
                    Publisher = "non",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000005")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1212-0000-abcd-000000000000"),
                    BookTitle = "Stephen King",
                    BookCover = "https://i.pinimg.com/originals/a4/aa/c1/a4aac1f3d86869bcfd2833e8be768014.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2007, 11, 15),
                    NumberOfBookPages = 800,
                    Publisher = "non",
                    AuthorId = Guid.Parse("30000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000005")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1313-0000-abcd-000000000000"),
                    BookTitle = "Isn't That Funny",
                    BookCover = "https://corviddesign.com/wp-content/uploads/2015/11/isntfunny_web.png",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2013, 7, 30),
                    NumberOfBookPages = 545,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000005")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1414-0000-abcd-000000000000"),
                    BookTitle = "Creepy Kid Ghost",
                    BookCover = "hhttps://artfulcover.com/wp-content/uploads/2018/06/Artful-Cover_premade_126524214_Creepy-Kid-Ghost_800x1200.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2015, 8, 1),
                    NumberOfBookPages = 652,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000005")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1515-0000-abcd-000000000000"),
                    BookTitle = "The Black Thunder",
                    BookCover = "https://i.pinimg.com/originals/97/26/e8/9726e81b7bba2b8fe0aca6f804b1f44b.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2001, 1, 1),
                    NumberOfBookPages = 325,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1616-0000-abcd-000000000000"),
                    BookTitle = "Torrent",
                    BookCover = "https://damonza.com/wp-content/uploads/portfolio/fiction/torrent-15.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2010, 10, 10),
                    NumberOfBookPages = 475,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                }
                ,
                new Book
                {
                    Id = Guid.Parse("00000000-1717-0000-abcd-000000000000"),
                    BookTitle = "Torrent",
                    BookCover = "https://damonza.com/wp-content/uploads/portfolio/fiction/torrent-15.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2010, 10, 10),
                    NumberOfBookPages = 475,
                    Publisher = "non",
                    AuthorId = Guid.Parse("20000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000002")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1818-0000-abcd-000000000000"),
                    BookTitle = "The Blue Princes",
                    BookCover = "https://i.pinimg.com/originals/aa/11/6a/aa116a773d6049b0d9d778aae0650062.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2019, 11, 10),
                    NumberOfBookPages = 405,
                    Publisher = "non",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001")
                },
                new Book
                {
                    Id = Guid.Parse("00000000-1919-0000-abcd-000000000000"),
                    BookTitle = "Tarnished light",
                    BookCover = "https://www.mythosink.com/wp-content/uploads/2020/01/Screen-Shot-2020-01-20-at-6.00.55-PM.png",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis",
                    DateOfPublish = new DateTime(2020, 10, 11),
                    NumberOfBookPages = 507,
                    Publisher = "non",
                    AuthorId = Guid.Parse("10000000-0000-0000-abcd-000000000000"),
                    GenreId = Guid.Parse("00000000-0000-0000-abcd-000000000001")
                }
                );
            modelBuilder.Entity<Review>().HasData(

                new Review
                {
                    Id = Guid.Parse("00000000-0000-1010-abcd-000000000000"),
                    BookId = Guid.Parse("00000000-1111-0000-abcd-000000000000"),
                    ReviewerName = "Xman",
                    BookRate = 5,
                    Email = "XMan@abc.com",
                    ReviewDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis"
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

            modelBuilder.Entity<BookRating>().HasData
                (
                    new BookRating
                    {
                        BookRateId = Guid.Parse("11111111-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-1111-0000-abcd-000000000000"),
                        FiveStarsRate = 1,
                        FourStarsRate = 1,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 0,
                        OneStarRate = 0,
                        TotalRate = 9,
                        ReviewsCount = 2
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("22222222-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-6666-0000-abcd-000000000000"),
                        FiveStarsRate = 0,
                        FourStarsRate = 0,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 1,
                        OneStarRate = 0,
                        TotalRate = 2,
                        ReviewsCount = 1
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("33333333-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-7777-0000-abcd-000000000000"),
                        FiveStarsRate = 0,
                        FourStarsRate = 0,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 2,
                        OneStarRate = 0,
                        TotalRate = 4,
                        ReviewsCount = 2
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("44444444-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-8888-0000-abcd-000000000000"),
                        FiveStarsRate = 1,
                        FourStarsRate = 1,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 1,
                        OneStarRate = 0,
                        TotalRate = 11,
                        ReviewsCount = 3
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("55555555-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-9999-0000-abcd-000000000000"),
                        FiveStarsRate = 1,
                        FourStarsRate = 1,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 1,
                        OneStarRate = 0,
                        TotalRate = 11,
                        ReviewsCount = 3
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("66666666-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-2222-0000-abcd-000000000000"),
                        FiveStarsRate = 1,
                        FourStarsRate = 1,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 0,
                        OneStarRate = 0,
                        TotalRate = 9,
                        ReviewsCount = 2
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("77777777-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-4444-0000-abcd-000000000000"),
                        FiveStarsRate = 0,
                        FourStarsRate = 0,
                        ThreeStarsRate = 2,
                        TwoStarsRate = 0,
                        OneStarRate = 0,
                        TotalRate = 6,
                        ReviewsCount = 2
                    },
                    new BookRating
                    {
                        BookRateId = Guid.Parse("88888888-0000-0000-abcd-000000000000"),
                        BookId = Guid.Parse("00000000-5555-0000-abcd-000000000000"),
                        FiveStarsRate = 0,
                        FourStarsRate = 1,
                        ThreeStarsRate = 0,
                        TwoStarsRate = 1,
                        OneStarRate = 0,
                        TotalRate = 6,
                        ReviewsCount = 2
                    }
                );

        }
    }
}
