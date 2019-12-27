using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProductCategoryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Slug = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Photo = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Slug = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslates_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 930, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 926, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 926, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 926, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 926, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(5012), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7123), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7152), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7156), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7160), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7163), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7167), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7171), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7175), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7178), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7182), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7186), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7190), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7194), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7198), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Name", "Slug", "Status" },
                values: new object[,]
                {
                    { 53, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proda ", "Proda ", true },
                    { 52, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4312), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman ", "Roman ", true },
                    { 51, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jabra ", "Jabra ", true },
                    { 50, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4307), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beats ", "Beats ", true },
                    { 46, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4298), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock ", "Rock ", true },
                    { 48, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4303), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4Tech ", "A4Tech ", true },
                    { 47, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4300), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baseus ", "Baseus ", true },
                    { 54, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WK ", "WK ", true },
                    { 49, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SanDisk ", "SanDisk ", true },
                    { 55, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4319), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspor ", "Aspor ", true },
                    { 65, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4343), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACLAS ", "ACLAS ", true },
                    { 57, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adata ", "Adata ", true },
                    { 58, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4326), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BAKCELL ", "bakcell ", true },
                    { 59, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZERCELL ", "AZERCELL ", true },
                    { 60, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4330), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NAR ", "NAR ", true },
                    { 61, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4333), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İROBOT ", "İROBOT ", true },
                    { 62, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4336), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Symbol ", "Symbol ", true },
                    { 64, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Datalogic ", "Datalogic ", true },
                    { 45, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4295), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Remax ", "Remax ", true },
                    { 66, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4345), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star ", "Star ", true },
                    { 56, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4321), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilitong ", "Bilitong ", true },
                    { 44, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4293), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gigaset ", "Gigaset ", true },
                    { 63, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4338), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argox ", "Argox ", true },
                    { 42, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4289), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genius ", "Genius ", true },
                    { 19, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4151), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gree", "Gree", true },
                    { 18, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitsubishi", "Mitsubishi", true },
                    { 17, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vestel", "Vestel", true },
                    { 16, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4144), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch", "Bosch", true },
                    { 15, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4142), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zanussi", "Zanussi", true },
                    { 14, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4140), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hitachi", "Hitachi", true },
                    { 13, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4137), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTC", "HTC", true },
                    { 12, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4135), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG", "LG", true },
                    { 43, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4291), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JBL ", "JBL ", true },
                    { 11, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4133), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balafon", "Balafon", true },
                    { 9, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4128), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor", "Honor", true },
                    { 8, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4125), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UleFone", "UleFone", true },
                    { 7, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4123), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FLY", "FLY", true },
                    { 6, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4121), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nokia", "Nokia", true },
                    { 5, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4119), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meizu", "Meizu", true },
                    { 4, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4116), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi", "Xiaomi", true },
                    { 3, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4113), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei", "Huawei", true },
                    { 2, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4069), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung", "Samsung", true },
                    { 10, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4130), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo", "Lenovo", true },
                    { 20, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4154), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AUX", "AUX", true },
                    { 1, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(1400), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "apple", true },
                    { 22, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4158), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorenje", "Gorenje", true },
                    { 21, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4156), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İndesit", "İndesit", true },
                    { 24, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4164), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acer", "Acer", true },
                    { 23, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4162), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asus", "Asus", true },
                    { 25, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell", "Dell", true },
                    { 26, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4169), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP", "HP", true },
                    { 27, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canon", "Canon", true },
                    { 29, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4258), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips ", "Philips ", true },
                    { 30, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4260), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aiwa ", "Aiwa ", true },
                    { 31, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4263), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shivaki ", "Shivaki ", true },
                    { 28, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4256), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Epson ", "Epson ", true },
                    { 33, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4268), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox ", "Xbox ", true },
                    { 41, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F&D ", "F&D ", true },
                    { 32, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4265), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony ", "Sony ", true },
                    { 39, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4282), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitek ", "Vitek ", true },
                    { 38, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal ", "Tefal ", true },
                    { 40, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4284), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Braun ", "Braun ", true },
                    { 36, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic ", "Panasonic ", true },
                    { 35, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4272), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oculus ", "Oculus ", true },
                    { 34, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4270), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logitech ", "Logitech ", true },
                    { 37, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4277), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rowenta ", "Rowenta ", true }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 926, DateTimeKind.Local).AddTicks(8600), new DateTime(2019, 12, 27, 17, 14, 5, 926, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(168), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(190), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(194), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(197), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(201), new DateTime(2019, 12, 27, 17, 14, 5, 927, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 931, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 929, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 10, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7525), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "581ea-barcode_scanner.png", true },
                    { 7, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7519), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/90694-dasinabilen.png", true },
                    { 8, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7521), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0427b-simcart.png", true },
                    { 9, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6e7e5-icon.png", true },
                    { 4, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7512), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ee515-televior.png", true },
                    { 5, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7515), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9c45c-game-blue-.png", true },
                    { 2, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7472), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/73913-meiset-esyalari.png", true },
                    { 1, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(5358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/e7132-telefon.png", true },
                    { 6, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9ca97-kicik-meiset-esyalari.png", true },
                    { 3, 1, new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7509), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/44444-ofis-mehsullari.png", true }
                });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 928, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 928, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 928, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 923, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 924, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 925, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 930, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 930, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.InsertData(
                table: "ProductCategoryTranslates",
                columns: new[] { "Id", "LanguageId", "Name", "ProductCategoryId", "Slug" },
                values: new object[,]
                {
                    { 1, 1, "Telephone and tablets", 1, "Telephones-and-tablets" },
                    { 19, 2, "İROBOT", 9, "İROBOT" },
                    { 9, 1, "İROBOT", 9, "İROBOT" },
                    { 18, 2, "Nömrələr", 8, "Nomreler" },
                    { 8, 1, "Numbers", 8, "Numbers" },
                    { 17, 2, "Aksessuarlar", 7, "Aksessuarlar" },
                    { 7, 1, "Accessories", 7, "Accessories" },
                    { 16, 2, "Kiçik ev əşyaları", 6, "kicik-ev-esyalari" },
                    { 6, 1, "Small household items", 6, "Small-household-items" },
                    { 15, 2, "Oyun konsolları", 5, "oyun-konsollari" },
                    { 5, 1, "Game consoles", 5, "Game-consoles" },
                    { 14, 2, "TV və Audio sistemlər", 4, "tv-ve-audio-sistemler" },
                    { 4, 1, "TV and Audio Systems", 4, "TV-and-Audio-Systems" },
                    { 13, 2, "Kompüterlər və ofis avadanlıqları", 3, "koputer-ve-ofis-avadanliqlari" },
                    { 3, 1, "Computers and office equipment", 3, "Computers-and-office-equipment" },
                    { 12, 2, "Məişət əşyaları", 2, "meiset-esyalari" },
                    { 2, 1, "Household Items", 2, "Household-Items" },
                    { 11, 2, "Telefon və planşetlər", 1, "telefon-ve-plansetler" },
                    { 10, 1, "Office Equipment", 10, "Office-Equipment" },
                    { 20, 2, "Ofis Avadanlıqları", 10, "Ofis Avadanlıqları" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_AdminManagerId",
                table: "Brands",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_AdminManagerId",
                table: "ProductCategories",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslates_LanguageId",
                table: "ProductCategoryTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslates_ProductCategoryId",
                table: "ProductCategoryTranslates",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_AdminManagerId",
                table: "ProductSubCategory",
                column: "AdminManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductCategoryTranslates");

            migrationBuilder.DropTable(
                name: "ProductSubCategory");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 498, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(1749), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3936), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3968), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3972), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4047), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4051), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4055), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4058), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4062), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4065), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4069), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4073), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4077), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4080), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4084), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(5729), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7108), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7132), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7135), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7139), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7142), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 501, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 501, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 501, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 495, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 497, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 497, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 503, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 503, DateTimeKind.Local).AddTicks(5754));
        }
    }
}
