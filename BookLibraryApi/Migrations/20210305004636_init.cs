using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibraryApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateOfDeath = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfPublish = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    NumberOfBookPages = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDescription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    BookRate = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpVote = table.Column<int>(type: "int", nullable: false),
                    DownVote = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-abcd-000000000000"), "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.", "Art" },
                    { new Guid("00000000-0000-0000-abcd-000000000001"), "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.", "Fantasy" },
                    { new Guid("00000000-0000-0000-abcd-000000000002"), "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.", "History" },
                    { new Guid("00000000-0000-0000-abcd-000000000003"), "Suspendisse id accumsan lacus. Phasellus condimentum volutpat libero id finibus.", "Poetry" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "DateOfBirth", "DateOfDeath", "GenreId", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1988, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000000"), "Ahmed", "https://ex.com" },
                    { new Guid("20000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1918, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000000"), "Dony", "https://ex.com" },
                    { new Guid("30000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1995, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000001"), "Mahmoud", "https://ex.com" },
                    { new Guid("40000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000001"), "Hassan", "https://ex.com" },
                    { new Guid("50000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1988, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000002"), "Sara", "https://ex.com" },
                    { new Guid("60000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1898, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1948, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000003"), "Yara", "https://ex.com" },
                    { new Guid("70000000-0000-0000-abcd-000000000000"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new DateTimeOffset(new DateTime(1998, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-abcd-000000000003"), "Lara", "https://ex.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookCover", "BookTitle", "DateOfPublish", "Description", "GenreId", "NumberOfBookPages", "Publisher" },
                values: new object[,]
                {
                    { new Guid("00000000-1111-0000-abcd-000000000000"), new Guid("10000000-0000-0000-abcd-000000000000"), "https://BC.com", "A Milion To One", new DateTimeOffset(new DateTime(2014, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000000"), 185, "non" },
                    { new Guid("00000000-8888-0000-abcd-000000000000"), new Guid("10000000-0000-0000-abcd-000000000000"), "https://BC.com", "History Book", new DateTimeOffset(new DateTime(1997, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000002"), 185, "non" },
                    { new Guid("00000000-2222-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "https://BC.com", "Amara the brave", new DateTimeOffset(new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000000"), 185, "non" },
                    { new Guid("00000000-9999-0000-abcd-000000000000"), new Guid("20000000-0000-0000-abcd-000000000000"), "https://BC.com", "City on the edge", new DateTimeOffset(new DateTime(1996, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000001"), 185, "non" },
                    { new Guid("00000000-3333-0000-abcd-000000000000"), new Guid("30000000-0000-0000-abcd-000000000000"), "https://BC.com", "The king of drugs", new DateTimeOffset(new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000001"), 185, "non" },
                    { new Guid("00000000-7777-0000-abcd-000000000000"), new Guid("30000000-0000-0000-abcd-000000000000"), "https://BC.com", "Story Book", new DateTimeOffset(new DateTime(1997, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000003"), 185, "non" },
                    { new Guid("00000000-4444-0000-abcd-000000000000"), new Guid("40000000-0000-0000-abcd-000000000000"), "https://BC.com", "The Martian", new DateTimeOffset(new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000002"), 185, "non" },
                    { new Guid("00000000-5555-0000-abcd-000000000000"), new Guid("40000000-0000-0000-abcd-000000000000"), "https://BC.com", "Tess of the road", new DateTimeOffset(new DateTime(1998, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000002"), 185, "non" },
                    { new Guid("00000000-6666-0000-abcd-000000000000"), new Guid("40000000-0000-0000-abcd-000000000000"), "https://BC.com", "A Milion To One", new DateTimeOffset(new DateTime(1998, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", new Guid("00000000-0000-0000-abcd-000000000002"), 185, "non" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "BookRate", "DownVote", "Email", "ReviewDescription", "ReviewerName", "UpVote" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-1010-abcd-000000000000"), new Guid("00000000-1111-0000-abcd-000000000000"), 5, 0, "XMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Xman", 0 },
                    { new Guid("00000000-0000-8010-abcd-000000000000"), new Guid("00000000-5555-0000-abcd-000000000000"), 4, 0, "GMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Gman", 0 },
                    { new Guid("00000000-0000-7010-abcd-000000000000"), new Guid("00000000-4444-0000-abcd-000000000000"), 3, 0, "FMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Fman", 0 },
                    { new Guid("00000000-0000-6010-abcd-000000000000"), new Guid("00000000-4444-0000-abcd-000000000000"), 3, 0, "EMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Eman", 0 },
                    { new Guid("00000000-0000-1310-abcd-000000000000"), new Guid("00000000-7777-0000-abcd-000000000000"), 2, 0, "NMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Nman", 0 },
                    { new Guid("00000000-0000-1210-abcd-000000000000"), new Guid("00000000-7777-0000-abcd-000000000000"), 2, 0, "VMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Vman", 0 },
                    { new Guid("00000000-0000-5010-abcd-000000000000"), new Guid("00000000-3333-0000-abcd-000000000000"), 1, 0, "DMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Dman", 0 },
                    { new Guid("00000000-0000-9010-abcd-000000000000"), new Guid("00000000-5555-0000-abcd-000000000000"), 2, 0, "HMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Hman", 0 },
                    { new Guid("00000000-0000-1810-abcd-000000000000"), new Guid("00000000-9999-0000-abcd-000000000000"), 1, 0, "IMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Iman", 0 },
                    { new Guid("00000000-0000-4010-abcd-000000000000"), new Guid("00000000-2222-0000-abcd-000000000000"), 5, 0, "CMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Cman", 0 },
                    { new Guid("00000000-0000-3010-abcd-000000000000"), new Guid("00000000-2222-0000-abcd-000000000000"), 4, 0, "BMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Bman", 0 },
                    { new Guid("00000000-0000-1610-abcd-000000000000"), new Guid("00000000-8888-0000-abcd-000000000000"), 4, 0, "KMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Kman", 0 },
                    { new Guid("00000000-0000-1510-abcd-000000000000"), new Guid("00000000-8888-0000-abcd-000000000000"), 1, 0, "LMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Lman", 0 },
                    { new Guid("00000000-0000-1410-abcd-000000000000"), new Guid("00000000-8888-0000-abcd-000000000000"), 5, 0, "MMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Mman", 0 },
                    { new Guid("00000000-0000-2010-abcd-000000000000"), new Guid("00000000-1111-0000-abcd-000000000000"), 4, 0, "AMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Aman", 0 },
                    { new Guid("00000000-0000-1710-abcd-000000000000"), new Guid("00000000-9999-0000-abcd-000000000000"), 2, 0, "PMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Pman", 0 },
                    { new Guid("00000000-0000-1110-abcd-000000000000"), new Guid("00000000-6666-0000-abcd-000000000000"), 2, 0, "ZMan@abc.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed faucibus quis nibh non sagittis", "Zman", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_GenreId",
                table: "Authors",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
