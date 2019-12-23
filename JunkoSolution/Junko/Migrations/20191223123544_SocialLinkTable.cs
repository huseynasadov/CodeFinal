using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class SocialLinkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 35, 44, 53, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 35, 44, 55, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 35, 44, 55, DateTimeKind.Local).AddTicks(748));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 11, 44, 733, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 11, 44, 735, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 11, 44, 735, DateTimeKind.Local).AddTicks(2621));
        }
    }
}
