using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Band = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TrackList = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Popularity = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "albums",
                columns: new[] { "Id", "Band", "Created", "Duration", "Name", "Popularity", "ReleaseDate", "TrackList" },
                values: new object[,]
                {
                    { 1, "The Beatles", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "47:23", "Abbey Road", 3, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty." },
                    { 2, "Pink Floyd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42:49", "The Dark Side of the Moon", 4, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse." },
                    { 3, "Papa Dance", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "57:03", "Nasza Ziemia Eden", 2, new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galaktyczny zwiad, Nasz Disneyland, Temat na clip, It's a simple song, Zły omen, Czas szaleństwa, Nietykalni, Ciało i talent..., Skajlajt, Twój ziemski Eden, The End" },
                    { 4, "Lady Pank", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41:27", "Zawsze Tam, Gdzie Ty", 3, new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dopóki da czas, Przerwa w trasie, Co mnie to obchodzi, Jak igła, Nie omijaj mnie, Niedokończona ulica, Nie wpychaj mnie w to dno, Zawsze tam gdzie ty, Zapłacę każdą cenę, Wiara we wroga" },
                    { 5, "The Police", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "44:18", "Synchronicity", 4, new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synchronicity I, Walking in Your Footsteps, O My God, Mother, Miss Gradenko, Synchronicity II, Every Breath You Take, King of Pain, Wrapped Around Your Finger, Tea in the Sahara" },
                    { 6, "Michael Jackson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42:19", "Thriller", 4, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life" },
                    { 7, "Michael Jackson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42:19", "Thriller", 4, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albums");
        }
    }
}
