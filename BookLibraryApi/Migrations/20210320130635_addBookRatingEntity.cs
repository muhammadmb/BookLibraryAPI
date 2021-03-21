using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class addBookRatingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "bookRatingBookRateId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "bookRatings",
                columns: table => new
                {
                    BookRateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiveStarsRate = table.Column<int>(type: "int", nullable: false),
                    FourStarsRate = table.Column<int>(type: "int", nullable: false),
                    ThreeStarsRate = table.Column<int>(type: "int", nullable: false),
                    TwoStarsRate = table.Column<int>(type: "int", nullable: false),
                    OneStarRate = table.Column<int>(type: "int", nullable: false),
                    TotalRate = table.Column<int>(type: "int", nullable: false),
                    ReviewsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookRatings", x => x.BookRateId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_bookRatings_bookRatingBookRateId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "bookRatings");

            migrationBuilder.DropIndex(
                name: "IX_Books_bookRatingBookRateId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "bookRatingBookRateId",
                table: "Books");

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
        }
    }
}
