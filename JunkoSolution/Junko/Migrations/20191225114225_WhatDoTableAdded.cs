using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class WhatDoTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WhatDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(maxLength: 300, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: true),
                    WhatDoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatDos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatDos_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WhatDos_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WhatDos_WhatDos_WhatDoId",
                        column: x => x.WhatDoId,
                        principalTable: "WhatDos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WhatDosTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhatDoId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Desc = table.Column<string>(maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatDosTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatDosTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WhatDosTranslates_WhatDos_WhatDoId",
                        column: x => x.WhatDoId,
                        principalTable: "WhatDos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 424, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 420, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(5265), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7431), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7465), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7470), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7474), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7478), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7482), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7486), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7490), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7494), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7497), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7501), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7505), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7509), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7513), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 420, DateTimeKind.Local).AddTicks(8715), new DateTime(2019, 12, 25, 15, 42, 24, 420, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(221), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(244), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(248), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(253), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(257), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 422, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 422, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 422, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 417, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 418, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 418, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.InsertData(
                table: "WhatDos",
                columns: new[] { "Id", "AdminManagerId", "LanguageId", "ModifiedAt", "Photo", "Status", "WhatDoId" },
                values: new object[,]
                {
                    { 2, 1, null, new DateTime(2019, 12, 25, 15, 42, 24, 424, DateTimeKind.Local).AddTicks(9771), "about/about3.jpg", true, null },
                    { 1, 1, null, new DateTime(2019, 12, 25, 15, 42, 24, 424, DateTimeKind.Local).AddTicks(8503), "about/about2.jpg", true, null }
                });

            migrationBuilder.InsertData(
                table: "WhatDosTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "Title", "WhatDoId" },
                values: new object[,]
                {
                    { 1, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ‘Content here, content here’, making it look like readable English.", 1, "What Do We Do?", 1 },
                    { 3, "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı.", 2, "Fəaliyyətimiz Nədir?", 1 },
                    { 2, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ‘Content here, content here’, making it look like readable English.", 1, "History Of Us", 2 },
                    { 4, "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı.", 2, "Tariximiz", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WhatDos_AdminManagerId",
                table: "WhatDos",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDos_LanguageId",
                table: "WhatDos",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDos_WhatDoId",
                table: "WhatDos",
                column: "WhatDoId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDosTranslates_LanguageId",
                table: "WhatDosTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDosTranslates_WhatDoId",
                table: "WhatDosTranslates",
                column: "WhatDoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhatDosTranslates");

            migrationBuilder.DropTable(
                name: "WhatDos");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 31, 27, 39, DateTimeKind.Local).AddTicks(7308));

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
        }
    }
}
