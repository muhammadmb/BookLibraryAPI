using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class editDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PicUrl",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BookRates",
                columns: table => new
                {
                    BookRateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiveStars = table.Column<int>(type: "int", nullable: false),
                    FourStars = table.Column<int>(type: "int", nullable: false),
                    ThreeStars = table.Column<int>(type: "int", nullable: false),
                    TwoStars = table.Column<int>(type: "int", nullable: false),
                    OneStar = table.Column<int>(type: "int", nullable: false),
                    TotalRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRates", x => x.BookRateId);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Khaled Ahmed", "https://images.unsplash.com/photo-1485893226355-9a1c32a0c81e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Naguib Mahfouz", "https://i.pinimg.com/originals/f4/07/96/f40796f816539dcb76f3c7e4fb750370.jpg" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Hung Men Son", "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MzV8fHBlb3BsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Adham Hamza", "https://images.unsplash.com/photo-1485528562718-2ae1c8419ae2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=781&q=80" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Walter Diang", "https://images.unsplash.com/photo-1527980965255-d3b416303d12?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Ayman Banon", "https://images.unsplash.com/photo-1580309237429-661ea7cd1d53?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Masute Ozil", "https://images.unsplash.com/photo-1542178243-bc20204b769f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1111-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages", "Publisher" },
                values: new object[] { "https://www.designforwriters.com/wp-content/uploads/2017/10/design-for-writers-book-cover-tf-2-a-million-to-one.jpg", 456, "Zindex" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-2222-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages", "Publisher" },
                values: new object[] { "https://marketplace.canva.com/EAD7WWWtKSQ/1/0/251w/canva-purple-and-red-leaves-illustration-children%27s-book-cover-hNI7HYnNVQQ.jpg", 285, "AI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-3333-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages" },
                values: new object[] { "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/action-thriller-book-cover-design-template-3675ae3e3ac7ee095fc793ab61b812cc_screen.jpg?ts=1588152105", 145 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-4444-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "DateOfPublish", "NumberOfBookPages" },
                values: new object[] { "https://static01.nyt.com/images/2014/02/05/books/05before-and-after-slide-T6H2/05before-and-after-slide-T6H2-superJumbo.jpg?quality=75&auto=webp&disable=upscale", new DateTimeOffset(new DateTime(2010, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 575 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-5555-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "Publisher" },
                values: new object[] { "https://images.squarespace-cdn.com/content/v1/5ae2fce87e3c3ae275ea2c9f/1526464175408-W92Q4MSAM40I8YF4HM64/ke17ZwdGBToddI8pDm48kG42nK5MxReh9N1Tgs_dc9t7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1UXysNIcM8ERoy824r28kfN5DdNsbvYnFI46u1WARIoKesh_vZu_IHrh0xbom9DKbTA/tess-cover.jpg?format=1500w", "Alef" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-6666-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "BookTitle", "NumberOfBookPages" },
                values: new object[] { "https://cms-assets.tutsplus.com/uploads/users/1631/posts/32582/image/Soulful%20Poetry%20Book%20Cover%20Template%20copy.jpg", "Songs with Souls", 450 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-7777-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages" },
                values: new object[] { "https://assets-2.placeit.net/smart_templates/e639b9513adc63d37ee4f577433b787b/assets/wn5u193mcjesm2ycxacaltq8jdu68kmu.jpg", 221 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-8888-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "BookTitle", "Publisher" },
                values: new object[] { "https://i.pinimg.com/originals/1e/c5/df/1ec5df963765d4bcf151467c99d1dae7.jpg", "Finding Moana", "Book One" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9999-0000-abcd-000000000000"),
                column: "BookCover",
                value: "https://i.pinimg.com/originals/a4/aa/c1/a4aac1f3d86869bcfd2833e8be768014.jpg");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000000"),
                columns: new[] { "GenreName", "PicUrl" },
                values: new object[] { "Classics", "https://cdn.shopify.com/s/files/1/0064/5342/8271/products/PCCP5-Penguin_Classics_Cameo_angle_1200_300x.jpg?v=1556052881" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000001"),
                column: "PicUrl",
                value: "https://www.rd.com/wp-content/uploads/2019/12/book-e1576790089347.jpg");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000002"),
                columns: new[] { "GenreName", "PicUrl" },
                values: new object[] { "Action and Adventure", "https://alisonmortonauthor.com/wp-content/uploads/2014/01/books.jpg" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000003"),
                columns: new[] { "GenreName", "PicUrl" },
                values: new object[] { "Comic Book", "https://www.sun-sentinel.com/resizer/1fuMDdJE7v3kltVnXX07CWZ58Ws=/415x614/top/www.trbimg.com/img-5caf8a09/turbine/fl-1555008005-hc4qu2941s-snap-image" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "GenreName", "PicUrl" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-abcd-000000000005"), "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.", "Horror", "https://images.thestar.com/xN_oIrR10VL8zpaa1-hDq0ELBE8=/1086x1652/smart/filters:cb(1594158289211)/https://www.thestar.com/content/dam/thestar/entertainment/books/2020/07/09/horror-books-to-make-you-lose-your-cool-on-a-hot-summers-night/if_it_bleeds.jpg" },
                    { new Guid("00000000-0000-0000-abcd-000000000004"), "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.", "Romance", "https://pbs.twimg.com/media/EQuNRJoU0AAvyKD.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookRates");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000004"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000005"));

            migrationBuilder.AlterColumn<string>(
                name: "PicUrl",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Ahmed", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Dony", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Mahmoud", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Hassan", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Sara", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Yara", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-abcd-000000000000"),
                columns: new[] { "Name", "PictureUrl" },
                values: new object[] { "Lara", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1111-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages", "Publisher" },
                values: new object[] { "https://BC.com", 185, "non" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-2222-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages", "Publisher" },
                values: new object[] { "https://BC.com", 185, "non" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-3333-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages" },
                values: new object[] { "https://BC.com", 185 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-4444-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "DateOfPublish", "NumberOfBookPages" },
                values: new object[] { "https://BC.com", new DateTimeOffset(new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 185 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-5555-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "Publisher" },
                values: new object[] { "https://BC.com", "non" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-6666-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "BookTitle", "NumberOfBookPages" },
                values: new object[] { "https://BC.com", "A Milion To One", 185 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-7777-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "NumberOfBookPages" },
                values: new object[] { "https://BC.com", 185 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-8888-0000-abcd-000000000000"),
                columns: new[] { "BookCover", "BookTitle", "Publisher" },
                values: new object[] { "https://BC.com", "History Book", "non" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9999-0000-abcd-000000000000"),
                column: "BookCover",
                value: "https://BC.com");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000000"),
                columns: new[] { "GenreName", "PicUrl" },
                values: new object[] { "Art", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000001"),
                column: "PicUrl",
                value: "https://ex.com");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000002"),
                columns: new[] { "GenreName", "PicUrl" },
                values: new object[] { "History", "https://ex.com" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000003"),
                columns: new[] { "GenreName", "PicUrl" },
                values: new object[] { "Poetry", "https://ex.com" });
        }
    }
}
