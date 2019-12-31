using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class HomeHeaderTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DiscountDate",
                table: "Products",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "HomeHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeHeaders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeHeaderTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeHeaderId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeHeaderTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeHeaderTranslates_HomeHeaders_HomeHeaderId",
                        column: x => x.HomeHeaderId,
                        principalTable: "HomeHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeHeaderTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 30, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 26, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 26, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 26, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 26, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(6003), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8014), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8047), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8051), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8055), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8058), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8062), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8065), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8068), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8072), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8075), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8128), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8133), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8136), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8140), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 26, DateTimeKind.Local).AddTicks(9540), new DateTime(2019, 12, 31, 14, 46, 3, 26, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1055), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1077), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1081), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1085), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1089), new DateTime(2019, 12, 31, 14, 46, 3, 27, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 31, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 32, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.InsertData(
                table: "HomeHeaders",
                columns: new[] { "Id", "ModifiedAt", "Order", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(6579), 1, 32 },
                    { 2, new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(7313), 2, 1 },
                    { 3, new DateTime(2019, 12, 31, 14, 46, 3, 38, DateTimeKind.Local).AddTicks(7330), 3, 33 }
                });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 33, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5685), "product/6b44f-samsung-galaxy-note10-plus-aura-black.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 37, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 34, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(4394), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6665), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6701), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6706), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6710), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6714), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6719), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6722), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6726), 10, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6729), 0, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6732), 0, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6735), 0, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6742), 0, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6745), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6748), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6751), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6755), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6758), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6763), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6767), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6770), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6773), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6821), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6825), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6829), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6833), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6836), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6839), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6842), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6845), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6848), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6854), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6858), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6861), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6865), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6869), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6872), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6877), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6881), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6884), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6887), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6890), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6893), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6896), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6901), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6904), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6907), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6912), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6916), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6919), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6924), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6927), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6931), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6934), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6938), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6941), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6946), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6950), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6953), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6956), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6962), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6965), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6968), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6973), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6976), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6979), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6982), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(6985), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7021), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7027), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7030), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7033), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7036), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7039), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7042), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7044), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7048), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7051), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7054), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7057), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7060), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7064), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7068), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7071), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7074), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7077), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7080), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7083), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7087), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7090), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7094), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7097), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7101), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7104), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7108), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7112), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7115), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7118), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7121), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7124), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7127), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7131), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7134), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7137), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7140), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7143), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7146), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7149), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7153), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7155), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7158), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7161), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7164), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7167), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7171), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7242), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7246), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7249), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7252), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7255), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7260), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7264), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7267), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7270), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7273), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7276), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7279), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7285), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7288), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7291), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7294), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7297), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7300), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7304), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7308), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7311), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7314), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7317), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7320), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7323), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 14, 46, 3, 36, DateTimeKind.Local).AddTicks(7328), 5, 1m });

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 35, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 28, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 29, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 22, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 24, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 24, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 31, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 14, 46, 3, 31, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.InsertData(
                table: "HomeHeaderTranslates",
                columns: new[] { "Id", "HomeHeaderId", "LanguageId", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "best skin" },
                    { 4, 1, 2, "Ən yaxşı Görünüş" },
                    { 2, 2, 1, "dual front" },
                    { 5, 2, 2, "2 kameralı" },
                    { 3, 3, 1, "Hurry Up!" },
                    { 6, 3, 2, "Tələsin!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeHeaders_ProductId",
                table: "HomeHeaders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeHeaderTranslates_HomeHeaderId",
                table: "HomeHeaderTranslates",
                column: "HomeHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeHeaderTranslates_LanguageId",
                table: "HomeHeaderTranslates",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeHeaderTranslates");

            migrationBuilder.DropTable(
                name: "HomeHeaders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DiscountDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 804, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(334), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2319), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2347), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2351), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2355), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2359), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2362), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2367), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2371), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2375), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2379), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2384), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2387), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2391), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2396), new DateTime(2019, 12, 31, 10, 3, 42, 806, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(3884), new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5265), new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5287), new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5290), new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5295), new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5299), new DateTime(2019, 12, 31, 10, 3, 42, 805, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 816, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 816, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 816, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 816, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 816, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 810, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 807, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 808, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 811, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8849), "product/6b44f-samsung-galaxy-note10-plus-aura-black.jpg.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 815, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 812, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(7443), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(6545), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9019), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(8984), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9045), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9042), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9051), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9049), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9056), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9053), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9061), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9059), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9066), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9064), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9071), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9069), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9078), new DateTime(2020, 1, 10, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9076), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9084), new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9082), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9089), new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9087), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9093), new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9091), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9098), new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9096), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9103), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9100), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9107), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9106), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9112), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9110), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9119), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9116), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9124), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9122), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9129), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9127), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9134), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9133), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9139), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9137), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9142), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9152), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9150), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9156), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9154), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9162), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9160), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9166), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9171), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9178), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9176), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9182), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9180), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9188), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9185), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9192), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9190), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9197), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9195), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9204), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9202), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9209), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9207), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9213), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9211), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9218), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9216), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9223), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9221), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9228), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9226), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9233), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9231), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9238), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9236), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9244), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9242), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9250), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9248), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9254), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9252), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9259), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9257), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9264), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9262), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9269), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9266), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9273), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9271), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9278), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9276), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9284), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9282), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9289), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9288), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9336), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9333), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9341), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9339), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9346), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9344), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9351), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9349), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9356), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9354), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9360), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9358), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9367), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9365), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9372), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9370), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9377), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9375), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9381), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9379), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9386), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9384), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9391), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9389), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9396), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9394), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9401), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9399), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9408), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9406), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9413), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9411), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9418), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9416), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9423), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9421), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9427), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9425), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9433), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9431), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9439), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9437), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9444), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9441), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9451), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9448), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9456), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9454), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9461), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9459), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9466), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9464), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9472), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9469), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9477), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9475), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9482), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9480), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9488), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9485), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9494), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9492), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9499), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9497), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9503), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9501), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9508), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9506), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9513), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9511), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9518), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9516), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9523), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9521), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9529), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9526), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9534), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9532), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9539), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9538), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9544), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9542), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9549), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9547), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9553), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9552), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9559), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9557), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9564), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9562), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9570), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9568), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9576), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9574), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9581), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9579), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9623), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9620), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9628), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9626), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9632), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9631), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9638), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9635), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9642), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9641), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9648), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9646), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9653), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9652), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9658), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9656), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9663), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9661), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9668), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9666), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9672), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9670), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9677), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9675), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9682), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9680), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9688), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9685), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9693), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9691), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9698), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9696), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9703), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9701), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9708), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9706), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9712), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9710), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9717), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9715), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9722), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9720), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9727), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9726), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9732), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9730), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9737), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9735), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9742), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9740), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9746), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9744), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9751), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9749), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9756), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9754), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9761), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9759), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9766), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9764), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9771), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9769), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9776), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9774), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9780), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9779), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9785), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9783), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9790), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9788), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9794), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9792), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9799), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9797), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9804), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9802), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9809), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9807), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9814), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9812), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9818), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9816), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9823), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9821), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "DiscountDate", "FollowCount" },
                values: new object[] { new DateTime(2019, 12, 31, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9828), new DateTime(2020, 1, 5, 10, 3, 42, 814, DateTimeKind.Local).AddTicks(9826), null });

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 813, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 807, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 807, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 807, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 801, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 803, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 803, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 809, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 10, 3, 42, 809, DateTimeKind.Local).AddTicks(4831));
        }
    }
}
