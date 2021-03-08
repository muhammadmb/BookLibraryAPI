using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class addPictureToGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicUrl",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000000"),
                column: "PicUrl",
                value: "https://ex.com");

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
                column: "PicUrl",
                value: "https://ex.com");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-abcd-000000000003"),
                column: "PicUrl",
                value: "https://ex.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicUrl",
                table: "Genres");
        }
    }
}
