using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54693bf1-a310-4953-b350-c2dbb0ebaf08", "54693bf1-a310-4953-b350-c2dbb0ebaf08", "user", "USER" },
                    { "9fc8731d-26d3-409f-9043-b69a39e5cfa8", "9fc8731d-26d3-409f-9043-b69a39e5cfa8", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d2f89a08-2f9a-4b80-a602-7f7eac81ef50", 0, "4e67d393-a522-44ac-8408-fff4a2554167", "jan@wsei.edu.pl", true, false, null, "JAN@WSEI.EDU.PL", "JAN", "AQAAAAIAAYagAAAAEEN2O+rLl1OuTwrUuKtjce+fESn4jYV0xU+P42PnnTtKiTYlQHIwjp1+B8BKuFDmWw==", null, false, "a0e0c4fe-8790-49d8-b49f-fbb3c20215da", false, "jan" },
                    { "d40e4c84-1cb2-4819-96f0-c363acaff7ec", 0, "c8a8f4ef-015c-4dd0-b840-2dcda5091421", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAEHMzC5cDa87JFUgIzHPzMz//+x/lm8c7jumrnF68+OAKQLmpiLvEUBLyx3fcKwqZ5w==", null, false, "4a16aacb-20aa-41fe-b001-55af4c0a0f98", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "54693bf1-a310-4953-b350-c2dbb0ebaf08", "d2f89a08-2f9a-4b80-a602-7f7eac81ef50" },
                    { "9fc8731d-26d3-409f-9043-b69a39e5cfa8", "d40e4c84-1cb2-4819-96f0-c363acaff7ec" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54693bf1-a310-4953-b350-c2dbb0ebaf08", "d2f89a08-2f9a-4b80-a602-7f7eac81ef50" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9fc8731d-26d3-409f-9043-b69a39e5cfa8", "d40e4c84-1cb2-4819-96f0-c363acaff7ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54693bf1-a310-4953-b350-c2dbb0ebaf08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fc8731d-26d3-409f-9043-b69a39e5cfa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2f89a08-2f9a-4b80-a602-7f7eac81ef50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40e4c84-1cb2-4819-96f0-c363acaff7ec");

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
    }
}
