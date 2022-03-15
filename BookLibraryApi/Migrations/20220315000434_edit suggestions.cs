using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class editsuggestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suggesstions");

            migrationBuilder.CreateTable(
                name: "Suggestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfPublish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    NumberOfBookPages = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(186), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(2045), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(2050), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1010-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5362), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1100-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1111-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1212-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1313-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1414-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1515-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5397), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1616-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1717-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1818-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5419), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1919-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-2222-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5253), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-3333-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-4444-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-5555-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-6666-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-7777-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-8888-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9999-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 172, DateTimeKind.Unspecified).AddTicks(6041), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000001"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 174, DateTimeKind.Unspecified).AddTicks(2040), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000002"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 174, DateTimeKind.Unspecified).AddTicks(2075), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000003"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 174, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000004"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 174, DateTimeKind.Unspecified).AddTicks(2085), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000005"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 174, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1110-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1210-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1310-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7665), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1410-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1510-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7673), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1610-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1710-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1810-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-2010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-3010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-4010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7591), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-5010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7632), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-6010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-7010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-8010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-9010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 3, 15, 2, 4, 34, 175, DateTimeKind.Unspecified).AddTicks(7653), new TimeSpan(0, 2, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suggestions");

            migrationBuilder.CreateTable(
                name: "Suggesstions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfPublish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NumberOfBookPages = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggesstions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(8761), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(9009), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(9021), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(9029), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(9034), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1010-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1100-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1111-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 746, DateTimeKind.Unspecified).AddTicks(9531), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1212-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1313-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2459), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1414-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1515-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1616-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2477), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1717-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2483), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1818-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2489), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1919-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2494), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-2222-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-3333-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-4444-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-5555-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2401), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-6666-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2409), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-7777-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-8888-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9999-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(2433), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 743, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000001"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 745, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000002"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 745, DateTimeKind.Unspecified).AddTicks(9476), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000003"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 745, DateTimeKind.Unspecified).AddTicks(9481), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000004"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 745, DateTimeKind.Unspecified).AddTicks(9484), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000005"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 745, DateTimeKind.Unspecified).AddTicks(9487), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1110-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4286), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1210-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1310-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4293), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1410-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4296), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1510-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1610-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4304), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1710-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1810-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4312), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-2010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-3010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-4010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4259), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-5010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4263), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-6010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-7010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-8010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-9010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 14, 30, 747, DateTimeKind.Unspecified).AddTicks(4283), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
