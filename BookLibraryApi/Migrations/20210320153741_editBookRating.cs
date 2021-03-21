using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class editBookRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_bookRatings_bookRatingBookRateId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_bookRatingBookRateId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookRatings",
                table: "bookRatings");

            migrationBuilder.DropColumn(
                name: "bookRatingBookRateId",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "bookRatings",
                newName: "BookRatings");

            migrationBuilder.AddColumn<Guid>(
                name: "BookId",
                table: "BookRatings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRatings",
                table: "BookRatings",
                column: "BookRateId");

            migrationBuilder.InsertData(
                table: "BookRatings",
                columns: new[] { "BookRateId", "BookId", "FiveStarsRate", "FourStarsRate", "OneStarRate", "ReviewsCount", "ThreeStarsRate", "TotalRate", "TwoStarsRate" },
                values: new object[,]
                {
                    { new Guid("11111111-0000-0000-abcd-000000000000"), new Guid("00000000-1111-0000-abcd-000000000000"), 1, 1, 0, 2, 0, 9, 0 },
                    { new Guid("22222222-0000-0000-abcd-000000000000"), new Guid("00000000-6666-0000-abcd-000000000000"), 0, 0, 0, 1, 0, 2, 1 },
                    { new Guid("33333333-0000-0000-abcd-000000000000"), new Guid("00000000-7777-0000-abcd-000000000000"), 0, 0, 0, 2, 0, 4, 2 },
                    { new Guid("44444444-0000-0000-abcd-000000000000"), new Guid("00000000-8888-0000-abcd-000000000000"), 1, 1, 0, 3, 0, 11, 1 },
                    { new Guid("55555555-0000-0000-abcd-000000000000"), new Guid("00000000-9999-0000-abcd-000000000000"), 1, 1, 0, 3, 0, 11, 1 },
                    { new Guid("66666666-0000-0000-abcd-000000000000"), new Guid("00000000-2222-0000-abcd-000000000000"), 1, 1, 0, 2, 0, 9, 0 },
                    { new Guid("77777777-0000-0000-abcd-000000000000"), new Guid("00000000-4444-0000-abcd-000000000000"), 0, 0, 0, 2, 2, 6, 0 },
                    { new Guid("88888888-0000-0000-abcd-000000000000"), new Guid("00000000-5555-0000-abcd-000000000000"), 0, 1, 0, 2, 0, 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookRatings_BookId",
                table: "BookRatings",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookRatings_Books_BookId",
                table: "BookRatings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRatings_Books_BookId",
                table: "BookRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRatings",
                table: "BookRatings");

            migrationBuilder.DropIndex(
                name: "IX_BookRatings_BookId",
                table: "BookRatings");

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("11111111-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("22222222-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("33333333-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("44444444-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("55555555-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("66666666-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("77777777-0000-0000-abcd-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRateId",
                keyValue: new Guid("88888888-0000-0000-abcd-000000000000"));

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookRatings");

            migrationBuilder.RenameTable(
                name: "BookRatings",
                newName: "bookRatings");

            migrationBuilder.AddColumn<Guid>(
                name: "bookRatingBookRateId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookRatings",
                table: "bookRatings",
                column: "BookRateId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_bookRatingBookRateId",
                table: "Books",
                column: "bookRatingBookRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_bookRatings_bookRatingBookRateId",
                table: "Books",
                column: "bookRatingBookRateId",
                principalTable: "bookRatings",
                principalColumn: "BookRateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
