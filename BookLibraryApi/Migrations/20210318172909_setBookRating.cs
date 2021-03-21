using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class setBookRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookRates");

            migrationBuilder.AddColumn<int>(
                name: "FiveStarsRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FourStarsRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OneStarRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThreeStarsRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TwoStarsRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookCover", "BookTitle", "DateOfPublish", "Description", "FiveStarsRate", "FourStarsRate", "GenreId", "NumberOfBookPages", "OneStarRate", "Publisher", "ThreeStarsRate", "TotalRate", "TwoStarsRate" },
                values: new object[,]
                {
                    { new Guid("00000000-1010-0000-abcd-000000000000"), new Guid("10000000-0000-0000-abcd-000000000000"), "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/haunted-house-horror-book-cover-design-template-fd3a8016a4128af962549c3c40190270_screen.jpg?ts=1588747771", "House Of Secrets", new DateTimeOffset(new DateTime(2006, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000005"), 158, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1100-0000-abcd-000000000000"), new Guid("10000000-0000-0000-abcd-000000000000"), "https://i.pinimg.com/originals/d1/47/e9/d147e94169caabe9ca52cf7e7f20bb4c.jpg", "The Carrow Haunt", new DateTimeOffset(new DateTime(1996, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000005"), 444, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1212-0000-abcd-000000000000"), new Guid("30000000-0000-0000-abcd-000000000000"), "https://i.pinimg.com/originals/a4/aa/c1/a4aac1f3d86869bcfd2833e8be768014.jpg", "Stephen King", new DateTimeOffset(new DateTime(2007, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000005"), 800, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1313-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "https://corviddesign.com/wp-content/uploads/2015/11/isntfunny_web.png", "Isn't That Funny", new DateTimeOffset(new DateTime(2013, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000005"), 545, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1414-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "hhttps://artfulcover.com/wp-content/uploads/2018/06/Artful-Cover_premade_126524214_Creepy-Kid-Ghost_800x1200.jpg", "Creepy Kid Ghost", new DateTimeOffset(new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000005"), 652, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1515-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "https://i.pinimg.com/originals/97/26/e8/9726e81b7bba2b8fe0aca6f804b1f44b.jpg", "The Black Thunder", new DateTimeOffset(new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000002"), 325, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1616-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "https://damonza.com/wp-content/uploads/portfolio/fiction/torrent-15.jpg", "Torrent", new DateTimeOffset(new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000002"), 475, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1717-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "https://damonza.com/wp-content/uploads/portfolio/fiction/torrent-15.jpg", "Torrent", new DateTimeOffset(new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000002"), 475, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1818-0000-abcd-000000000000"), new Guid("10000000-0000-0000-abcd-000000000000"), "https://i.pinimg.com/originals/aa/11/6a/aa116a773d6049b0d9d778aae0650062.jpg", "The Blue Princes", new DateTimeOffset(new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000001"), 405, 0, "non", 0, 0, 0 },
                    { new Guid("00000000-1919-0000-abcd-000000000000"), new Guid("10000000-0000-0000-abcd-000000000000"), "https://www.mythosink.com/wp-content/uploads/2020/01/Screen-Shot-2020-01-20-at-6.00.55-PM.png", "Tarnished light", new DateTimeOffset(new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", 0, 0, new Guid("00000000-0000-0000-abcd-000000000001"), 507, 0, "non", 0, 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1010-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1100-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1212-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1313-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1414-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1515-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1616-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1717-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1818-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1919-0000-abcd-000000000000"));

            migrationBuilder.DropColumn(
                name: "FiveStarsRate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FourStarsRate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "OneStarRate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ThreeStarsRate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TotalRate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TwoStarsRate",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookRates",
                columns: table => new
                {
                    BookRateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiveStars = table.Column<int>(type: "int", nullable: false),
                    FourStars = table.Column<int>(type: "int", nullable: false),
                    OneStar = table.Column<int>(type: "int", nullable: false),
                    ThreeStars = table.Column<int>(type: "int", nullable: false),
                    TotalRating = table.Column<int>(type: "int", nullable: false),
                    TwoStars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRates", x => x.BookRateId);
                });
        }
    }
}
