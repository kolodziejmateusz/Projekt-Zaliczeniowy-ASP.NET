using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a84be82d-9cc0-4d5d-9c19-01e72108061a", "17bf772f-1a7d-4788-a2a9-5ed97f36f705" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96fcd6e3-91c0-4745-adb8-0d276b245ee7", "b6bda1e1-547d-4a22-9594-def408a2b578" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96fcd6e3-91c0-4745-adb8-0d276b245ee7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a84be82d-9cc0-4d5d-9c19-01e72108061a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17bf772f-1a7d-4788-a2a9-5ed97f36f705");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6bda1e1-547d-4a22-9594-def408a2b578");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "recordlabel",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9fdd4a82-b814-4005-a77e-9a77003ab681", "9fdd4a82-b814-4005-a77e-9a77003ab681", "user", "USER" },
                    { "c1c4d84f-0494-45e6-8c66-99a5034df6b5", "c1c4d84f-0494-45e6-8c66-99a5034df6b5", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6461dc48-f9f5-4fc6-b338-d07cbc9c9846", 0, "d9814211-af85-4354-b503-7ef6034bace3", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEBcyv97JuDnm1esnxhdEGx8RtLiHTAn/a9TNCaujfqBLu2kVALnol9Sh0rHVfXNCcw==", null, false, "7d0e2045-b08a-40ec-8e88-33f2097555d7", false, "adam@wsei.edu.pl" },
                    { "b2140c6d-532b-4a72-a2f0-909c75212e34", 0, "b6474c43-8e82-4711-8efa-9ed71311ac2b", "jan@wsei.edu.pl", true, false, null, "JAN@WSEI.EDU.PL", "JAN@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEPV+oDX0+SXWqp5AJECZV7PSeYF0aQEOhndt1xMp2bjI9eu8pyCmr8yyGTJtxiv1Yw==", null, false, "ec6cb6a4-040c-4e7f-a84e-e493bca25b1f", false, "jan@wsei.edu.pl" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c1c4d84f-0494-45e6-8c66-99a5034df6b5", "6461dc48-f9f5-4fc6-b338-d07cbc9c9846" },
                    { "9fdd4a82-b814-4005-a77e-9a77003ab681", "b2140c6d-532b-4a72-a2f0-909c75212e34" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1c4d84f-0494-45e6-8c66-99a5034df6b5", "6461dc48-f9f5-4fc6-b338-d07cbc9c9846" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9fdd4a82-b814-4005-a77e-9a77003ab681", "b2140c6d-532b-4a72-a2f0-909c75212e34" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fdd4a82-b814-4005-a77e-9a77003ab681");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1c4d84f-0494-45e6-8c66-99a5034df6b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6461dc48-f9f5-4fc6-b338-d07cbc9c9846");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2140c6d-532b-4a72-a2f0-909c75212e34");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "recordlabel",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96fcd6e3-91c0-4745-adb8-0d276b245ee7", "96fcd6e3-91c0-4745-adb8-0d276b245ee7", "user", "USER" },
                    { "a84be82d-9cc0-4d5d-9c19-01e72108061a", "a84be82d-9cc0-4d5d-9c19-01e72108061a", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17bf772f-1a7d-4788-a2a9-5ed97f36f705", 0, "507a0277-0de4-40de-8cd2-c19f4aed80f3", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAEKBoM8K+SOOZxfWHcFElVXbdHs4E+Pc6NfsWovm+wgo7ZiKrFuu2gyNSN13Af1su9Q==", null, false, "d0f74fb0-48c7-4c59-81d8-5c2891024268", false, "adam@wsei.edu.pl" },
                    { "b6bda1e1-547d-4a22-9594-def408a2b578", 0, "3a5cef33-a1df-4753-9a98-077323c7824e", "jan@wsei.edu.pl", true, false, null, "JAN@WSEI.EDU.PL", "JAN", "AQAAAAIAAYagAAAAEI4ki2PvfodYaWCaD1gDfvqm353bc28wrAH82W9isurUJy1gY8SezWAlIHgVmUC09w==", null, false, "266ce793-5b22-4368-afe1-31acf89291dd", false, "jan@wsei.edu.pl" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a84be82d-9cc0-4d5d-9c19-01e72108061a", "17bf772f-1a7d-4788-a2a9-5ed97f36f705" },
                    { "96fcd6e3-91c0-4745-adb8-0d276b245ee7", "b6bda1e1-547d-4a22-9594-def408a2b578" }
                });
        }
    }
}
