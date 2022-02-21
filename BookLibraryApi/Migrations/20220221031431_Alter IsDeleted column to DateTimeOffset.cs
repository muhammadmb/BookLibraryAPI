using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class AlterIsDeletedcolumntoDateTimeOffset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "Suggesstions",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "Reviews",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "Genres",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "Feedbacks",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "Books",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "Authors",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Suggesstions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(9132), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(9137), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1010-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2705), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1100-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1111-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 879, DateTimeKind.Unspecified).AddTicks(9737), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1212-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1313-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2732), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1414-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2738), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1515-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2744), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1616-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2750), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1717-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1818-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2764), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-1919-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2770), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-2222-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-3333-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-4444-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-5555-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2647), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-6666-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-7777-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2662), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-8888-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00000000-9999-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(2676), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 876, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000001"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 878, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000002"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 878, DateTimeKind.Unspecified).AddTicks(7059), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000003"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 878, DateTimeKind.Unspecified).AddTicks(7064), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000004"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 878, DateTimeKind.Unspecified).AddTicks(7068), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000005"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 878, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1110-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1210-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1310-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5361), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1410-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1510-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5369), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1610-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5372), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1710-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5376), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-1810-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5379), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-2010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-3010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-4010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-5010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-6010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5338), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-7010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-8010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-9010-abcd-000000000000"),
                column: "AddedDate",
                value: new DateTimeOffset(new DateTime(2022, 2, 21, 5, 9, 26, 880, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
