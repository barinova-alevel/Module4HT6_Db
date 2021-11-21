using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_Id",
                        column: x => x.Id,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    ArtistSongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.ArtistSongId);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "DateOfBirth", "Email", "Insta", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 7, 20, 18, 30, 25, 0, DateTimeKind.Unspecified), "mail1@mail.fi", "https://metanit.com/sharp/tutorial/19.1.php", "Ed Sheeran", "+3638778677" },
                    { 2, new DateTime(1980, 6, 20, 18, 30, 25, 0, DateTimeKind.Unspecified), "mail1@mail.no", "https://insta123", "Doja Cat", "+3638778655" },
                    { 3, new DateTime(1990, 5, 20, 18, 30, 25, 0, DateTimeKind.Unspecified), "mail1@mail.dk", "https://insta124", "Ariana Grande", "12345" },
                    { 4, new DateTime(2000, 4, 20, 18, 30, 25, 0, DateTimeKind.Unspecified), "mail1@mail.de", "https://insta125", "Shivers", "+3638778111" },
                    { 5, new DateTime(2010, 3, 20, 18, 30, 25, 0, DateTimeKind.Unspecified), null, null, "Olivia Rodrigo", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Dance-pop" },
                    { 2, "Pop" },
                    { 3, "Soul" },
                    { 4, "R&B" },
                    { 5, "Pop-punk" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 2.5m, 0, new DateTime(2015, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "Butter" },
                    { 2, 2.3m, 0, new DateTime(1976, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "Leave the door open" },
                    { 3, 2.0m, 0, new DateTime(2001, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "Kiss me more" },
                    { 4, 1.5m, 0, new DateTime(2014, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "Save your tears" },
                    { 5, 1.8m, 0, new DateTime(2020, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "good 4 u" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistSongId", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 3, 2 },
                    { 5, 4, 3 },
                    { 2, 1, 4 },
                    { 3, 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_ArtistId",
                table: "ArtistSong",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongId",
                table: "ArtistSong",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
