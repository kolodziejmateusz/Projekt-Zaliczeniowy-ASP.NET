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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "recordlabel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Regon = table.Column<string>(type: "TEXT", nullable: false),
                    Nip = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: true),
                    Address_HouseNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Address_ApartmentNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Address_City = table.Column<string>(type: "TEXT", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Address_State = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Country = table.Column<string>(type: "TEXT", nullable: true),
                    Website = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recordlabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordLabelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_albums_recordlabel_RecordLabelId",
                        column: x => x.RecordLabelId,
                        principalTable: "recordlabel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "489d113a-b839-4729-b8ab-1c1aea8fc9c8", "489d113a-b839-4729-b8ab-1c1aea8fc9c8", "admin", "ADMIN" },
                    { "bb537f39-c91d-4edb-9ded-8be696856100", "bb537f39-c91d-4edb-9ded-8be696856100", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e022311-9842-4486-9cf7-62b46590bfbb", 0, "4342d4f5-92ec-4ac3-8eeb-0742e228c19a", "jan@wsei.edu.pl", true, false, null, "JAN@WSEI.EDU.PL", "JAN@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEFdVh5PNVw0MLlgZodhwN1iSqmzDS1XfKfEikazbk3vaEBOAESn4kd3wCdSs/boFyA==", null, false, "15af79ae-6fc8-4980-9901-bb043bcd47c3", false, "jan@wsei.edu.pl" },
                    { "bb889c26-e9c5-4202-89b1-43cb7b051070", 0, "6fc0ece3-21ab-45bd-b4b1-247f00f6f5f4", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEBsHCc2wnDI8HmexsgF2ZFaiYUAE/Glldw+aY4fpN8izoYY7etLioiKbVl2kbsq+RQ==", null, false, "41e7173c-7535-4653-b7f0-3e248a11ee1b", false, "adam@wsei.edu.pl" }
                });

            migrationBuilder.InsertData(
                table: "recordlabel",
                columns: new[] { "Id", "Address_ApartmentNumber", "Address_City", "Address_Country", "Address_HouseNumber", "Address_PostalCode", "Address_State", "Address_Street", "Name", "Nip", "Regon", "Website" },
                values: new object[,]
                {
                    { 1, null, "Warszawa", "Poland", "27A", "00-639", "mazowieckie", "Marszałkowska", "Starlight Records", "987654321", "123456789", "www.starlightrecords.com" },
                    { 2, null, "Gdańsk", "Poland", "45/6", "80-831", "pomorskie", "Długa", "Echo Harmony Music", "876543219", "234567891", "www.echoharmonymusic.com" },
                    { 3, null, "Wrocław", "Poland", "13", "50-101", "dolnośląskie", "Rynek", "Neon Beat Productions", "765432198", "345678912", "www.neonbeatpro.com" },
                    { 4, null, "Kraków", "Poland", "39", "31-019", "małopolskie", "Floriańska", "Oceanwave Audio", "654321987", "456789123", "www.oceanwaveaudio.com" },
                    { 5, null, "Poznań", "Poland", "80/82", "61-809", "wielkopolskie", "Święty Marcin", "RetroSound Studios", "543219876", "567891234", "www.retrosoundstudios.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb537f39-c91d-4edb-9ded-8be696856100", "1e022311-9842-4486-9cf7-62b46590bfbb" },
                    { "489d113a-b839-4729-b8ab-1c1aea8fc9c8", "bb889c26-e9c5-4202-89b1-43cb7b051070" }
                });

            migrationBuilder.InsertData(
                table: "albums",
                columns: new[] { "Id", "Band", "Created", "Duration", "Name", "Popularity", "RecordLabelId", "ReleaseDate", "TrackList" },
                values: new object[,]
                {
                    { 1, "The Beatles", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "47:23", "Abbey Road", 3, 1, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty." },
                    { 2, "Pink Floyd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42:49", "The Dark Side of the Moon", 4, 3, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse." },
                    { 3, "Papa Dance", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "57:03", "Nasza Ziemia Eden", 2, 2, new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galaktyczny zwiad, Nasz Disneyland, Temat na clip, It's a simple song, Zły omen, Czas szaleństwa, Nietykalni, Ciało i talent..., Skajlajt, Twój ziemski Eden, The End" },
                    { 4, "Lady Pank", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41:27", "Zawsze Tam, Gdzie Ty", 3, 3, new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dopóki da czas, Przerwa w trasie, Co mnie to obchodzi, Jak igła, Nie omijaj mnie, Niedokończona ulica, Nie wpychaj mnie w to dno, Zawsze tam gdzie ty, Zapłacę każdą cenę, Wiara we wroga" },
                    { 5, "The Police", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "44:18", "Synchronicity", 4, 4, new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Synchronicity I, Walking in Your Footsteps, O My God, Mother, Miss Gradenko, Synchronicity II, Every Breath You Take, King of Pain, Wrapped Around Your Finger, Tea in the Sahara" },
                    { 6, "Michael Jackson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42:19", "Thriller", 4, 5, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life" },
                    { 7, "AC/DC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42:11", "Back in Black", 4, 3, new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hells Bells, Shoot to Thrill, What Do You Do for Money Honey, Givin the Dog a Bone, Let Me Put My Love Into You, Back in Black, You Shook Me All Night Long, Have a Drink on Me, Shake a Leg, Rock and Roll Ain't Noise Pollution" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_albums_RecordLabelId",
                table: "albums",
                column: "RecordLabelId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "recordlabel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
