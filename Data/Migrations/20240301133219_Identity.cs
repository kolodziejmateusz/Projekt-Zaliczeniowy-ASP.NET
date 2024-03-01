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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cb2c6fe-19bc-4559-998b-99bd3a8f7af3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14e8deee-c0e8-49fd-8243-f88d96507686", "9d13ff6b-0a10-4eb4-bd98-c547af7d6bc3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14e8deee-c0e8-49fd-8243-f88d96507686");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d13ff6b-0a10-4eb4-bd98-c547af7d6bc3");

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
                    { "b982e513-614c-40ad-a678-f1ef0a1e3878", "b982e513-614c-40ad-a678-f1ef0a1e3878", "user", "USER" },
                    { "f965f8f7-1ba1-4d91-b858-a6ce0ebf8427", "f965f8f7-1ba1-4d91-b858-a6ce0ebf8427", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4df0409c-175e-42f6-bab8-511559bb294e", 0, "d6a35ba4-00cb-4e35-9aad-dbe294749799", "jan@wsei.edu.pl", true, false, null, "JAN@WSEI.EDU.PL", "JAN", "AQAAAAIAAYagAAAAEBWjy5OcaKbp+JKhg/BlCIIA/RSEjZz8KFKmtbVazRFb8o3r9xI4JrXFEGF3CJF5Gw==", null, false, "6799b897-1a08-4855-880a-a38fe2916d74", false, "jan" },
                    { "f49ef2d9-a305-4279-8dc2-bc6204fb5823", 0, "d9d475e9-3470-4627-9aa1-12e5b48ea8e4", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAELTm3abnv+DM6ooTkaH1pM4VR78kC2oyr65fK55/nWWiiO+hUBqxbl1H2YJLSWDruw==", null, false, "bb906c65-11d9-42b4-b3e6-7bcacee9e0d1", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b982e513-614c-40ad-a678-f1ef0a1e3878", "4df0409c-175e-42f6-bab8-511559bb294e" },
                    { "f965f8f7-1ba1-4d91-b858-a6ce0ebf8427", "f49ef2d9-a305-4279-8dc2-bc6204fb5823" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b982e513-614c-40ad-a678-f1ef0a1e3878", "4df0409c-175e-42f6-bab8-511559bb294e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f965f8f7-1ba1-4d91-b858-a6ce0ebf8427", "f49ef2d9-a305-4279-8dc2-bc6204fb5823" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b982e513-614c-40ad-a678-f1ef0a1e3878");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f965f8f7-1ba1-4d91-b858-a6ce0ebf8427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4df0409c-175e-42f6-bab8-511559bb294e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f49ef2d9-a305-4279-8dc2-bc6204fb5823");

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
                    { "14e8deee-c0e8-49fd-8243-f88d96507686", "14e8deee-c0e8-49fd-8243-f88d96507686", "admin", "ADMIN" },
                    { "7cb2c6fe-19bc-4559-998b-99bd3a8f7af3", "7cb2c6fe-19bc-4559-998b-99bd3a8f7af3", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9d13ff6b-0a10-4eb4-bd98-c547af7d6bc3", 0, "9ad78fc1-2262-492b-9fb3-5c43cd688e1b", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAEPtNf+P9RbM26morzFy8bnaRGB6tGC/Pu4P71XqKSeBSqk/r3RBApmVtlDtNmfwBTQ==", null, false, "e7300835-05fd-484d-acf0-8d2881596749", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "14e8deee-c0e8-49fd-8243-f88d96507686", "9d13ff6b-0a10-4eb4-bd98-c547af7d6bc3" });
        }
    }
}
