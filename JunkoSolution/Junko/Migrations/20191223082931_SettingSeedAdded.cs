using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class SettingSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageCode", "Name" },
                values: new object[] { 1, "en-US", "English" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageCode", "Name" },
                values: new object[] { 2, "az-Latn-AZ", "Azerbaijan" });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Email", "Location", "Logo", "ModifiedAt", "Phone", "PhotoLogo" },
                values: new object[] { 1, "Junko@mail.com", "Code Academy", "Junko", new DateTime(2019, 12, 23, 12, 29, 30, 760, DateTimeKind.Local).AddTicks(3779), "+994 50 787 01 81", "logo/logo.png" });

            migrationBuilder.InsertData(
                table: "SettingTranslates",
                columns: new[] { "Id", "Address", "FAQContent", "FAQTitle", "LanguageId", "ModifiedAt", "SettingId" },
                values: new object[] { 1, " Nizami street 203B, AF Business House", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec id erat sagittis, faucibus metus malesuada, eleifend turpis. Mauris semper augue id nisl aliquet, a porta lectus mattis. Nulla at tortor augue. In eget enim diam. Donec gravida tortor sem, ac fermentum nibh rutrum sit amet. Nulla convallis mauris vitae congue consequat. Donec interdum nunc purus, vitae vulputate arcu fringilla quis. Vivamus iaculis euismod dui.", "Below are frequently asked questions, you may find the answer for yourself", 1, new DateTime(2019, 12, 23, 12, 29, 30, 762, DateTimeKind.Local).AddTicks(1723), 1 });

            migrationBuilder.InsertData(
                table: "SettingTranslates",
                columns: new[] { "Id", "Address", "FAQContent", "FAQTitle", "LanguageId", "ModifiedAt", "SettingId" },
                values: new object[] { 2, " Nizami küç. 203B, AF Business House, 2-ci mərtəbə", "", "Aşağıda tez-tez verilən suallarla özünüz üçün cavab tapa bilərsiniz", 2, new DateTime(2019, 12, 23, 12, 29, 30, 762, DateTimeKind.Local).AddTicks(1840), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
