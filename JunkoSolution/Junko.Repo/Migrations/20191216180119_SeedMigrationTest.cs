using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Repo.Migrations
{
    public partial class SeedMigrationTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Address", "Email", "Location", "Logo", "ModifiedAt", "PhotoLogo" },
                values: new object[] { 1, null, null, null, "Junko", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
