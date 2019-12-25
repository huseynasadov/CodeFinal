using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class AboutSettingTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSettings_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AboutSettingTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutSettingId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Desc = table.Column<string>(maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSettingTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSettingTranslates_AboutSettings_AboutSettingId",
                        column: x => x.AboutSettingId,
                        principalTable: "AboutSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutSettingTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutSettings",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Photo" },
                values: new object[] { 1, 1, new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(7308), "about/about1.jpg" });

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 35, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(2056), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4025), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4059), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4063), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4071), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4075), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4078), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4082), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4085), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4089), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4092), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4096), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4099), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4103), new DateTime(2019, 12, 25, 15, 31, 27, 37, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(5103), new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7077), new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7101), new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7105), new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7108), new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7112), new DateTime(2019, 12, 25, 15, 31, 27, 36, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 38, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 38, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 38, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 32, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 34, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 34, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.InsertData(
                table: "AboutSettingTranslates",
                columns: new[] { "Id", "AboutSettingId", "Desc", "LanguageId", "Title" },
                values: new object[] { 1, 1, "Adipiscing lacus ut elementum, nec duis, tempor litora turpis dapibus. Imperdiet cursus odio tortor in elementum. Egestas nunc eleifend feugiat lectus laoreet, vel nunc taciti integer cras. Hac pede dis, praesent nibh ac dui mauris sit. Pellentesque mi, facilisi mauris, elit sociis leo sodales accumsan. Iaculis ac fringilla torquent lorem consectetuer, sociosqu phasellus risus urna aliquam, ornare.", 1, "ECommerce For Electronics Store" });

            migrationBuilder.InsertData(
                table: "AboutSettingTranslates",
                columns: new[] { "Id", "AboutSettingId", "Desc", "LanguageId", "Title" },
                values: new object[] { 2, 1, "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı.", 2, "Elektronika Mağazası üçün Kommersiya fəaliyyəti" });

            migrationBuilder.CreateIndex(
                name: "IX_AboutSettings_AdminManagerId",
                table: "AboutSettings",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSettingTranslates_AboutSettingId",
                table: "AboutSettingTranslates",
                column: "AboutSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSettingTranslates_LanguageId",
                table: "AboutSettingTranslates",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutSettingTranslates");

            migrationBuilder.DropTable(
                name: "AboutSettings");

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 919, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(6818), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8852), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8885), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8889), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8893), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8896), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8900), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8905), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8908), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8912), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8917), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8921), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8925), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8928), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8932), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(714), new DateTime(2019, 12, 25, 11, 38, 4, 919, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2104), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2125), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2130), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2134), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2138), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 921, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 916, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 918, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 918, DateTimeKind.Local).AddTicks(1523));
        }
    }
}
