using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class BrandproductCategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "ProductSubCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BrandProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(nullable: false),
                    ProductSubCategoryId = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandProductCategories_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandProductCategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BrandProductCategories_ProductSubCategory_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 132, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 132, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 132, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 132, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(7720), new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(18), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(53), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(58), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(63), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(67), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(71), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(74), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(78), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(82), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(86), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(91), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(95), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(100), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(104), new DateTime(2019, 12, 27, 20, 8, 23, 134, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.InsertData(
                table: "BrandProductCategories",
                columns: new[] { "Id", "BrandId", "ProductCategoryId", "ProductSubCategoryId" },
                values: new object[,]
                {
                    { 94, 38, null, 27 },
                    { 95, 38, null, 28 },
                    { 96, 38, null, 29 },
                    { 97, 38, null, 30 },
                    { 98, 38, null, 31 },
                    { 103, 42, null, 36 },
                    { 100, 39, null, 27 },
                    { 101, 40, null, 27 },
                    { 102, 41, null, 36 },
                    { 93, 37, null, 26 },
                    { 99, 38, null, 33 },
                    { 92, 36, null, 37 },
                    { 82, 31, null, 16 },
                    { 90, 35, null, 24 },
                    { 89, 34, null, 43 },
                    { 88, 34, null, 24 },
                    { 87, 33, null, 24 },
                    { 86, 33, null, 23 },
                    { 85, 32, null, 24 },
                    { 84, 32, null, 22 },
                    { 83, 32, null, 21 },
                    { 104, 42, null, 43 },
                    { 81, 30, null, 45 },
                    { 80, 30, null, 16 },
                    { 91, 36, null, 25 },
                    { 105, 43, null, 36 },
                    { 115, 50, null, 45 },
                    { 107, 45, null, 39 },
                    { 132, 66, null, 55 },
                    { 131, 65, null, 55 },
                    { 130, 64, null, 53 },
                    { 129, 63, null, 54 },
                    { 128, 63, null, 53 },
                    { 127, 62, null, 53 },
                    { 126, 61, null, 52 },
                    { 125, 60, null, 51 },
                    { 124, 59, null, 50 },
                    { 123, 58, null, 49 },
                    { 122, 57, null, 48 },
                    { 121, 56, null, 46 },
                    { 120, 55, null, 46 },
                    { 119, 54, null, 46 },
                    { 118, 53, null, 46 },
                    { 117, 52, null, 45 },
                    { 116, 51, null, 45 },
                    { 79, 29, null, 32 },
                    { 114, 49, null, 48 },
                    { 113, 49, null, 44 },
                    { 112, 48, null, 43 },
                    { 111, 47, null, 40 },
                    { 110, 46, null, 39 },
                    { 109, 45, null, 46 },
                    { 108, 45, null, 45 },
                    { 106, 44, null, 37 },
                    { 78, 29, null, 31 },
                    { 1, 1, null, 1 },
                    { 76, 29, null, 29 },
                    { 22, 3, null, 2 },
                    { 23, 4, null, 1 },
                    { 24, 4, null, 3 },
                    { 25, 4, null, 4 },
                    { 26, 4, null, 34 },
                    { 27, 4, null, 46 },
                    { 28, 5, null, 1 },
                    { 29, 6, null, 1 },
                    { 30, 7, null, 1 },
                    { 31, 8, null, 1 },
                    { 32, 8, null, 4 },
                    { 33, 9, null, 1 },
                    { 34, 10, null, 2 },
                    { 35, 10, null, 11 },
                    { 36, 11, null, 3 },
                    { 21, 3, null, 1 },
                    { 37, 12, null, 4 },
                    { 3, 1, null, 3 },
                    { 5, 1, null, 11 },
                    { 19, 2, null, 40 },
                    { 18, 2, null, 39 },
                    { 17, 2, null, 34 },
                    { 16, 2, null, 16 },
                    { 15, 2, null, 7 },
                    { 14, 2, null, 5 },
                    { 13, 2, null, 4 },
                    { 12, 2, null, 3 },
                    { 11, 2, null, 2 },
                    { 10, 2, null, 1 },
                    { 20, 2, null, 45 },
                    { 9, 1, null, 40 },
                    { 8, 1, null, 39 },
                    { 7, 1, null, 35 },
                    { 6, 1, null, 34 },
                    { 4, 1, null, 4 },
                    { 38, 12, null, 5 },
                    { 2, 1, null, 2 },
                    { 40, 12, null, 16 },
                    { 61, 24, null, 11 },
                    { 62, 25, null, 11 },
                    { 63, 26, null, 11 },
                    { 64, 26, null, 13 },
                    { 39, 12, null, 7 },
                    { 65, 26, null, 14 },
                    { 66, 26, null, 15 },
                    { 60, 23, null, 11 },
                    { 67, 26, null, 43 },
                    { 69, 27, null, 14 },
                    { 70, 28, null, 14 },
                    { 71, 29, null, 16 },
                    { 72, 29, null, 25 },
                    { 73, 29, null, 26 },
                    { 74, 29, null, 27 },
                    { 75, 29, null, 28 },
                    { 68, 26, null, 48 },
                    { 59, 22, null, 7 },
                    { 77, 29, null, 30 },
                    { 46, 16, null, 10 },
                    { 51, 16, null, 31 },
                    { 49, 16, null, 30 },
                    { 48, 16, null, 27 },
                    { 47, 16, null, 25 },
                    { 58, 21, null, 7 },
                    { 45, 16, null, 9 },
                    { 52, 16, null, 32 },
                    { 44, 16, null, 5 },
                    { 42, 14, null, 5 },
                    { 41, 13, null, 4 },
                    { 54, 17, null, 5 },
                    { 55, 18, null, 6 },
                    { 56, 19, null, 6 },
                    { 57, 20, null, 6 },
                    { 43, 15, null, 5 },
                    { 53, 16, null, 33 }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(686), new DateTime(2019, 12, 27, 20, 8, 23, 132, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2197), new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2223), new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2227), new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2231), new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2235), new DateTime(2019, 12, 27, 20, 8, 23, 133, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 137, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 138, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 135, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 136, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 139, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(381), 1 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1730), 1 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1811), 1 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1815), 1 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1818), 2 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1820), 2 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1822), 2 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1824), 2 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1827), 2 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1829), 2 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1831), 3 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1833), 3 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1835), 3 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1838), 3 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1840), 3 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1842), 4 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1844), 4 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1846), 4 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1849), 4 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1852), 4 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1854), 5 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1857), 5 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1859), 5 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1862), 5 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1864), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1866), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1868), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1870), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1872), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1875), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1877), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1879), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1881), 6 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1883), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1886), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1888), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1891), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1894), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1896), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1898), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1901), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1903), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1905), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1907), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1909), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1912), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1914), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1916), 7 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1918), 8 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1920), 8 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1922), 8 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1924), 9 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1926), 10 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1930), 10 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1932), 10 });

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ProductCategoryId" },
                values: new object[] { new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1982), 10 });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 135, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 135, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 135, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 129, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 130, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 131, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 137, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 137, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                table: "ProductSubCategory",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandProductCategories_BrandId",
                table: "BrandProductCategories",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandProductCategories_ProductCategoryId",
                table: "BrandProductCategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandProductCategories_ProductSubCategoryId",
                table: "BrandProductCategories",
                column: "ProductSubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_ProductCategories_ProductCategoryId",
                table: "ProductSubCategory",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_ProductCategories_ProductCategoryId",
                table: "ProductSubCategory");

            migrationBuilder.DropTable(
                name: "BrandProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                table: "ProductSubCategory");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "ProductSubCategory");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 696, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(2824), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4776), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4808), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4812), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4815), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4818), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4822), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4825), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4829), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4832), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4836), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4841), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4844), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4848), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4851), new DateTime(2019, 12, 27, 18, 41, 40, 698, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(6686), new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8026), new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8047), new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8051), new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8054), new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8057), new DateTime(2019, 12, 27, 18, 41, 40, 697, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 702, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 700, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 703, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 704, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 699, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 699, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 699, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 693, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 695, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 695, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 701, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 41, 40, 701, DateTimeKind.Local).AddTicks(5318));
        }
    }
}
