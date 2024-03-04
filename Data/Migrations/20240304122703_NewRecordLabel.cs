using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NewRecordLabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb537f39-c91d-4edb-9ded-8be696856100", "1e022311-9842-4486-9cf7-62b46590bfbb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "489d113a-b839-4729-b8ab-1c1aea8fc9c8", "bb889c26-e9c5-4202-89b1-43cb7b051070" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "489d113a-b839-4729-b8ab-1c1aea8fc9c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb537f39-c91d-4edb-9ded-8be696856100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e022311-9842-4486-9cf7-62b46590bfbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb889c26-e9c5-4202-89b1-43cb7b051070");

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
                    { "4556ff26-3c24-49ea-a5e3-6c65524c8140", "4556ff26-3c24-49ea-a5e3-6c65524c8140", "admin", "ADMIN" },
                    { "f146f123-4c28-434b-ba42-46acdf4ccca4", "f146f123-4c28-434b-ba42-46acdf4ccca4", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "47a364c9-1326-4d6c-8588-ecddc5561b75", 0, "345ccb41-788a-427a-a396-c45bb020d304", "jan@wsei.edu.pl", true, false, null, "JAN@WSEI.EDU.PL", "JAN@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEHk0bIFfTiWiEVnKP3o0iDPIwH+PU4bd3wfju3rZ22xh7JjHfcja2IKeziLSUeIgog==", null, false, "736e24a9-03e2-44f8-9f4e-9bb0804d3c53", false, "jan@wsei.edu.pl" },
                    { "97ca4a85-a0cc-4479-bb62-db3a16b85d9d", 0, "7d641d9c-87f6-4ea6-9906-48190ff05691", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEAN7Sryt5eCChe1iGWNdEC130gdUhhQOqY/W2YmG6fYSUr7BEddV+W2U0MScl8kF1A==", null, false, "79279af2-e68f-4634-9d1e-c65f4d1204cd", false, "adam@wsei.edu.pl" }
                });

            migrationBuilder.InsertData(
                table: "recordlabel",
                columns: new[] { "Id", "Address_ApartmentNumber", "Address_City", "Address_Country", "Address_HouseNumber", "Address_PostalCode", "Address_State", "Address_Street", "Name", "Nip", "Regon", "Website" },
                values: new object[,]
                {
                    { 6, null, "Warszawa", "Poland", "27A", "00-639", "mazowieckie", "Marszałkowska", "Aurora Melodies", "432198765", "678912345", "www.auroramelodies.com" },
                    { 7, null, "Gdańsk", "Poland", "45/6", "80-831", "pomorskie", "Długa", "Bluewave Studio", "321987654", "789123456", "www.bluewavestudio.com" },
                    { 8, null, "Wrocław", "Poland", "13", "50-101", "dolnośląskie", "Rynek", "Cosmic Tunes", "219876543", "891234567", "www.cosmictunes.com" },
                    { 9, null, "Kraków", "Poland", "39", "31-019", "małopolskie", "Floriańska", "Dreamscape Audio", "198765432", "912345678", "www.dreamscapeaudio.com" },
                    { 10, null, "Poznań", "Poland", "80/82", "61-809", "wielkopolskie", "Święty Marcin", "Eclipse Records", "987654320", "123456780", "www.eclipserecords.com" },
                    { 11, null, "Warszawa", "Poland", "27A", "00-639", "mazowieckie", "Marszałkowska", "Fusion Beats", "876543210", "234567890", "www.fusionbeats.com" },
                    { 12, null, "Gdańsk", "Poland", "45/6", "80-831", "pomorskie", "Długa", "Galaxy Grooves", "765432109", "345678901", "www.galaxygrooves.com" },
                    { 13, null, "Wrocław", "Poland", "13", "50-101", "dolnośląskie", "Rynek", "Harmony Hub", "654321098", "456789012", "www.harmonyhub.com" },
                    { 14, null, "Kraków", "Poland", "39", "31-019", "małopolskie", "Floriańska", "Infinity Sounds", "543210987", "567890123", "www.infinitysounds.com" },
                    { 15, null, "Poznań", "Poland", "80/82", "61-809", "wielkopolskie", "Święty Marcin", "Jazz Journey", "432109876", "678901234", "www.jazzjourney.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f146f123-4c28-434b-ba42-46acdf4ccca4", "47a364c9-1326-4d6c-8588-ecddc5561b75" },
                    { "4556ff26-3c24-49ea-a5e3-6c65524c8140", "97ca4a85-a0cc-4479-bb62-db3a16b85d9d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f146f123-4c28-434b-ba42-46acdf4ccca4", "47a364c9-1326-4d6c-8588-ecddc5561b75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4556ff26-3c24-49ea-a5e3-6c65524c8140", "97ca4a85-a0cc-4479-bb62-db3a16b85d9d" });

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "recordlabel",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4556ff26-3c24-49ea-a5e3-6c65524c8140");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f146f123-4c28-434b-ba42-46acdf4ccca4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47a364c9-1326-4d6c-8588-ecddc5561b75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97ca4a85-a0cc-4479-bb62-db3a16b85d9d");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb537f39-c91d-4edb-9ded-8be696856100", "1e022311-9842-4486-9cf7-62b46590bfbb" },
                    { "489d113a-b839-4729-b8ab-1c1aea8fc9c8", "bb889c26-e9c5-4202-89b1-43cb7b051070" }
                });
        }
    }
}
