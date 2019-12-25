using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class FAQTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faqs_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FaqTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaqId = table.Column<int>(nullable: false),
                    LanguageeId = table.Column<int>(nullable: false),
                    Question = table.Column<string>(maxLength: 100, nullable: false),
                    Answer = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaqTranslates_Faqs_FaqId",
                        column: x => x.FaqId,
                        principalTable: "Faqs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaqTranslates_Languages_LanguageeId",
                        column: x => x.LanguageeId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 930, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 925, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(3039), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5278), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5310), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5315), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5320), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5324), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5328), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5332), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5335), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5339), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5343), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5348), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5353), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5357), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5361), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(5594), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7225), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7426), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7431), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7435), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7440), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Order", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 25, 17, 9, 15, 931, DateTimeKind.Local).AddTicks(9385), 1, true },
                    { 5, 1, new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1049), 5, true },
                    { 4, 1, new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1045), 4, true },
                    { 3, 1, new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1038), 3, true },
                    { 2, 1, new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1006), 2, true },
                    { 7, 1, new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1056), 7, true },
                    { 6, 1, new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1052), 6, true }
                });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 928, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 928, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 928, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 921, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 924, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 924, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 931, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 931, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.InsertData(
                table: "FaqTranslates",
                columns: new[] { "Id", "Answer", "FaqId", "LanguageeId", "Question" },
                values: new object[,]
                {
                    { 1, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 1, 1, "Donec mattis finibus elit ut tristique?" },
                    { 8, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 1, 2, "Saytda hansı ödəmə vasitələri var?" },
                    { 2, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 2, 1, "mattis finibus elit ut tristique?" },
                    { 9, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 2, 2, "Çatdırılma necə həyata keçir?" },
                    { 3, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 3, 1, "finibus elit ut tristique?" },
                    { 10, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 3, 2, "Vakansiyalar ne vaxt olacaq?" },
                    { 4, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 4, 1, "elit mattis finibus elit ut tristique?" },
                    { 11, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 4, 2, "Mobil tetbiqi də hazırlanırmı?" },
                    { 5, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 5, 1, "ut Donec mattis finibus elit ut tristique?" },
                    { 12, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 5, 2, "Digərlərindən fərqi nədir?" },
                    { 6, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 6, 1, "Trist mattis finibus elit ut tristique?" },
                    { 13, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 6, 2, "Nə üstünlüklər verilir?" },
                    { 7, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 7, 1, "Donec tristique?" },
                    { 14, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 7, 2, "ikinci əl satılırmı?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_AdminManagerId",
                table: "Faqs",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_FaqTranslates_FaqId",
                table: "FaqTranslates",
                column: "FaqId");

            migrationBuilder.CreateIndex(
                name: "IX_FaqTranslates_LanguageeId",
                table: "FaqTranslates",
                column: "LanguageeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaqTranslates");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 364, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(1802), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(3981), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4018), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4023), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4027), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4032), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4035), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4039), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4043), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4047), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4051), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4055), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4059), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4063), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(5271), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6790), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6817), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6821), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6825), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6828), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 367, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 367, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 367, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 361, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 363, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 363, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 369, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 369, DateTimeKind.Local).AddTicks(6398));
        }
    }
}
