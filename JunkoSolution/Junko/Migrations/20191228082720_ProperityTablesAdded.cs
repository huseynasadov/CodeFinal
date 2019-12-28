using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProperityTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandProductCategories_ProductCategories_ProductCategoryId",
                table: "BrandProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BrandProductCategories_ProductSubCategory_ProductSubCategoryId",
                table: "BrandProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_AdminManagers_AdminManagerId",
                table: "ProductSubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_ProductCategories_ProductCategoryId",
                table: "ProductSubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategoryTranslate_Languages_LanguageId",
                table: "ProductSubCategoryTranslate");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategoryTranslate_ProductSubCategory_ProductSubCategoryId",
                table: "ProductSubCategoryTranslate");

            migrationBuilder.DropIndex(
                name: "IX_BrandProductCategories_ProductCategoryId",
                table: "BrandProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategoryTranslate",
                table: "ProductSubCategoryTranslate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "BrandProductCategories");

            migrationBuilder.RenameTable(
                name: "ProductSubCategoryTranslate",
                newName: "ProductSubCategoryTranslates");

            migrationBuilder.RenameTable(
                name: "ProductSubCategory",
                newName: "ProductSubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategoryTranslate_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                newName: "IX_ProductSubCategoryTranslates_ProductSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategoryTranslate_LanguageId",
                table: "ProductSubCategoryTranslates",
                newName: "IX_ProductSubCategoryTranslates_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                table: "ProductSubCategories",
                newName: "IX_ProductSubCategories_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategory_AdminManagerId",
                table: "ProductSubCategories",
                newName: "IX_ProductSubCategories_AdminManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategoryTranslates",
                table: "ProductSubCategoryTranslates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategories",
                table: "ProductSubCategories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Properities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properities_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProperityCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProperityId = table.Column<int>(nullable: false),
                    ProductSubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProperityCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProperityCategories_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProperityCategories_Properities_ProperityId",
                        column: x => x.ProperityId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProperityTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProperityId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Slug = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProperityTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProperityTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProperityTranslates_Properities_ProperityId",
                        column: x => x.ProperityId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 667, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 663, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 663, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 663, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 663, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(7158), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9148), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9177), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9181), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9184), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9188), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9192), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9196), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9199), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9203), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9206), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9210), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9213), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9217), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9220), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(681), new DateTime(2019, 12, 28, 12, 27, 18, 663, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2044), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2063), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2067), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2071), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2074), new DateTime(2019, 12, 28, 12, 27, 18, 664, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 669, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 670, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.InsertData(
                table: "Properities",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Status" },
                values: new object[,]
                {
                    { 30, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6688), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 27, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6681), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 26, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 25, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6677), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 24, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6675), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 23, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6673), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 22, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6671), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 21, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6669), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 20, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6666), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 19, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 18, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6662), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 17, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6659), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 16, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6656), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 28, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 15, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6653), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 13, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6648), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 11, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6637), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6634), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6632), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6630), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6583), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 14, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6650), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 29, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6686), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(5212), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 46, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6723), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 52, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 51, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 50, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 49, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 48, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 47, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 31, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6690), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 45, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 44, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 43, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6716), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 42, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 41, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 40, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 39, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6708), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 38, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6706), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 37, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6704), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 36, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 35, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 34, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 33, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6694), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 32, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 53, 1, new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 665, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 666, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 660, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 662, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 662, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 667, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 668, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.InsertData(
                table: "ProperityCategories",
                columns: new[] { "Id", "ProductSubCategoryId", "ProperityId" },
                values: new object[,]
                {
                    { 48, 5, 21 },
                    { 55, 7, 26 },
                    { 80, 25, 25 },
                    { 54, 7, 25 },
                    { 52, 6, 24 },
                    { 51, 6, 23 },
                    { 49, 5, 22 },
                    { 100, 54, 53 },
                    { 47, 5, 20 },
                    { 46, 5, 19 },
                    { 96, 53, 18 },
                    { 45, 5, 18 },
                    { 93, 53, 17 },
                    { 92, 52, 17 },
                    { 50, 6, 17 },
                    { 44, 5, 17 },
                    { 71, 16, 16 },
                    { 26, 3, 16 },
                    { 17, 2, 16 },
                    { 42, 4, 15 },
                    { 15, 1, 15 },
                    { 41, 4, 14 },
                    { 14, 1, 14 },
                    { 40, 4, 13 },
                    { 13, 1, 13 },
                    { 39, 4, 12 },
                    { 23, 2, 12 },
                    { 12, 1, 12 },
                    { 56, 7, 27 },
                    { 57, 7, 28 },
                    { 58, 7, 29 },
                    { 59, 7, 30 },
                    { 102, 55, 52 },
                    { 99, 54, 52 },
                    { 101, 55, 51 },
                    { 98, 54, 51 },
                    { 97, 53, 50 },
                    { 91, 27, 49 },
                    { 90, 27, 48 },
                    { 88, 26, 47 },
                    { 87, 26, 46 },
                    { 86, 26, 45 },
                    { 84, 25, 44 },
                    { 83, 25, 43 },
                    { 82, 25, 42 },
                    { 38, 4, 11 },
                    { 89, 27, 41 },
                    { 81, 25, 41 },
                    { 78, 16, 40 },
                    { 77, 16, 39 },
                    { 76, 16, 38 },
                    { 75, 16, 37 },
                    { 74, 16, 36 },
                    { 73, 16, 35 },
                    { 72, 16, 34 },
                    { 70, 15, 33 },
                    { 69, 13, 32 },
                    { 64, 11, 32 },
                    { 68, 13, 31 },
                    { 63, 11, 31 },
                    { 85, 26, 41 },
                    { 11, 1, 11 },
                    { 103, 55, 53 },
                    { 5, 1, 5 },
                    { 53, 7, 1 },
                    { 79, 16, 1 },
                    { 66, 13, 7 },
                    { 61, 11, 7 },
                    { 34, 4, 7 },
                    { 94, 53, 1 },
                    { 21, 2, 7 },
                    { 2, 1, 2 },
                    { 33, 4, 6 },
                    { 25, 3, 2 },
                    { 8, 1, 8 },
                    { 6, 1, 6 },
                    { 95, 53, 2 },
                    { 65, 13, 5 },
                    { 60, 11, 5 },
                    { 3, 1, 3 },
                    { 32, 4, 5 },
                    { 20, 2, 5 },
                    { 18, 2, 3 },
                    { 30, 4, 3 },
                    { 31, 4, 4 },
                    { 19, 2, 4 },
                    { 29, 4, 2 },
                    { 35, 4, 8 },
                    { 7, 1, 7 },
                    { 4, 1, 4 },
                    { 22, 2, 10 },
                    { 1, 1, 1 },
                    { 37, 4, 10 },
                    { 9, 1, 9 },
                    { 28, 4, 1 },
                    { 10, 1, 10 },
                    { 27, 3, 9 },
                    { 43, 5, 1 },
                    { 67, 13, 8 },
                    { 24, 3, 1 },
                    { 16, 2, 1 },
                    { 62, 11, 8 },
                    { 36, 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProperityTranslates",
                columns: new[] { "Id", "LanguageId", "Name", "ProperityId", "Slug" },
                values: new object[,]
                {
                    { 93, 1, "Supported formats", 40, "Supported-formats" },
                    { 56, 1, "SIM", 3, "SIM" },
                    { 105, 1, "Speed", 52, "speed" },
                    { 40, 2, "Dəstəklənən formatlar", 40, "Dəstəklənən-formatlar" },
                    { 54, 1, "Dimensions", 1, "Dimensions" },
                    { 92, 1, "3D", 39, "3D" },
                    { 91, 1, "Wi-Fi", 38, "Wi-Fi" },
                    { 52, 2, "Sürəti", 52, "Sürəti" },
                    { 38, 2, "Wi-Fi", 38, "Wi-Fi" },
                    { 90, 1, "Supported speeches", 37, "Supported-speeches" },
                    { 37, 2, "Dəstəklənən çıxışlar", 37, "Dəstəklənən-çıxışlar" },
                    { 4, 2, "Əməliyyat sistemi", 4, "emeliyyat-sistemi" },
                    { 53, 2, "Keyfiyyəti", 53, "Keyfiyyəti" },
                    { 89, 1, "Digital Tuner", 36, "Digital-Tuner" },
                    { 36, 2, "Rəqəmsal Tuner", 36, "Rəqəmsal-Tuner" },
                    { 106, 1, "Quality", 53, "Quality" },
                    { 57, 1, "Operating system", 4, "Operating-system" },
                    { 39, 2, "3D", 39, "3D" },
                    { 41, 2, "Gücü", 41, "Gücü" },
                    { 42, 2, "Sovurma Gücü", 42, "Sovurma-Gücü" },
                    { 3, 2, "SİM", 3, "SİM" },
                    { 101, 1, "Steam Power", 48, "Steam-Power" },
                    { 48, 2, "Buxar Gücü", 48, "Buxar-Gücü" },
                    { 50, 2, "Məsafəsi", 50, "Məsafəsi" },
                    { 100, 1, "Headlines", 47, "Headlines" },
                    { 47, 2, "Başlıqlar", 47, "Başlıqlar" },
                    { 103, 1, "Distance", 50, "Distance" },
                    { 99, 1, "Number of temperature modes", 46, "Number-of-temperature-modes" },
                    { 46, 2, "Temperatur rejimlərinin sayı", 46, "Temperatur-rejimlərinin-sayı" },
                    { 2, 2, "Çəkisi", 2, "cekisi" },
                    { 88, 1, "Speed", 35, "Speed" },
                    { 98, 1, "Number of speeds", 45, "Number-of-speeds" },
                    { 45, 2, "Sürət sayı", 45, "Sürət-sayı" },
                    { 55, 1, "Weight", 2, "Weight" },
                    { 97, 1, "Dust container type", 44, "Dust-container-type" },
                    { 44, 2, "Toz qabının növü", 44, "Toz-qabının-növü" },
                    { 51, 2, "Genişliyi", 51, "Genişliyi" },
                    { 96, 1, "Length of wire", 43, "Length-of-wire" },
                    { 43, 2, "Naqilin Uzunluğu", 43, "Naqilin-Uzunluğu" },
                    { 104, 1, "Width", 51, "Width" },
                    { 95, 1, "Cooling Power", 42, "Cooling-Power" },
                    { 49, 2, "Su tutumu", 49, "Su-tutumu" },
                    { 94, 1, "Power", 41, "Power" },
                    { 102, 1, "Water capacity", 49, "Water-capacity" },
                    { 11, 2, "Video", 11, "video" },
                    { 87, 1, "Screen type", 34, "Screen-type" },
                    { 22, 2, "Xüsusiyyətləri", 22, "xususiyetleri" },
                    { 74, 1, "Freezing chamber volume", 21, "Freezing-chamber-volume" },
                    { 21, 2, "Dondurma kamerasının həcmi", 21, "dondurma-kamerasinin-hecmi" },
                    { 73, 1, "The volume of the refrigerator compartment", 20, "The-volume-of-the-refrigerator-compartment" },
                    { 20, 2, "Soyuducu hissənin həcmi", 20, "soyuducu-hissenin-hecmi" },
                    { 72, 1, "Energy class", 19, "Energy-class" },
                    { 19, 2, "Enerji sinifi", 19, "enerji-sinfi" },
                    { 71, 1, "Total volume", 18, "Total-volume" },
                    { 18, 2, "Ümumi həcmi", 18, "umumi-hecmi" },
                    { 8, 2, "RAM", 8, "RAM" },
                    { 61, 1, "RAM", 8, "ram" },
                    { 70, 1, "Type", 17, "Type" },
                    { 17, 2, "Növü", 17, "novu" },
                    { 9, 2, "Yaddaş kartı", 9, "Yaddas-karti" },
                    { 69, 1, "Screen size", 16, "Screen-size" },
                    { 16, 2, "Ekran ölçüsü", 16, "ekran-olcusu" },
                    { 62, 1, "Memory card", 9, "Memory-card" },
                    { 68, 1, "Battery volume", 15, "Battery-volume" },
                    { 15, 2, "Batareya həcmi", 15, "Batareya-həcmi" },
                    { 67, 1, "Bluetooth", 14, "Bluetooth" },
                    { 14, 2, "Bluetooth", 14, "Bluetooth" },
                    { 10, 2, "Əsas kamera", 10, "esas-kamera" },
                    { 63, 1, "The main camera", 10, "The-main-camera" },
                    { 66, 1, "WLAN", 13, "WLAN" },
                    { 13, 2, "WLAN", 13, "WLAN" },
                    { 65, 1, "Front camera", 12, "Front-camera" },
                    { 12, 2, "Ön kamera", 12, "on-kamera" },
                    { 75, 1, "Features", 22, "Features" },
                    { 35, 2, "Tezlik", 35, "Tezlik" },
                    { 60, 1, "Internal memory", 7, "Internal-memory" },
                    { 76, 1, "Refrigerant liquid", 23, "Refrigerant-liquid" },
                    { 34, 2, "Ekran növü", 34, "Ekran-növü" },
                    { 86, 1, "Graphic memory", 33, "Graphic-memory" },
                    { 33, 2, "Qrafik yaddaş", 33, "Qrafik-yaddaş" },
                    { 5, 2, "Prosessor", 5, "Prosessor" },
                    { 85, 1, "Network", 32, "Network" },
                    { 32, 2, "Şəbəkə", 32, "Şəbəkə" },
                    { 58, 1, "Processor", 5, "Processor" },
                    { 64, 1, "Video", 11, "video" },
                    { 84, 1, "Ports", 31, "Ports" },
                    { 31, 2, "Portlar", 31, "Portlar" },
                    { 83, 1, "Ceramic heater", 30, "Ceramic-heater" },
                    { 30, 2, "Keramik qızdırıcı", 30, "Keramik-qızdırıcı" },
                    { 82, 1, "Child lock", 29, "Child-lock" },
                    { 29, 2, "Uşaq kilidi", 29, "Uşaq-kilidi" },
                    { 81, 1, "Applications", 28, "Applications" },
                    { 28, 2, "Proqramlar", 28, "Proqramlar" },
                    { 80, 1, "Energy class", 27, "Energy-class" },
                    { 27, 2, "Enerji sinifi", 27, "Enerji-sinifi" },
                    { 6, 2, "Nüvə", 6, "nuve" },
                    { 79, 1, "Compression rate", 26, "Compression-rate" },
                    { 26, 2, "Sıxma sürəti", 26, "Sıxma-sureti" },
                    { 59, 1, "Nuclear", 6, "Nuclear" },
                    { 78, 1, "Capacity", 25, "Capacity" },
                    { 25, 2, "Tutum", 25, "tutum" },
                    { 77, 1, "Influence area", 24, "Influence-area" },
                    { 24, 2, "Təsir sahəsi", 24, "tesir-sahesi" },
                    { 7, 2, "Daxili yaddaş", 7, "daxili-yaddas" },
                    { 23, 2, "Soyuducu maye", 23, "Soyuducu-maye" },
                    { 1, 2, "Ölçüləri", 1, "olculeri" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properities_AdminManagerId",
                table: "Properities",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityCategories_ProductSubCategoryId",
                table: "ProperityCategories",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityCategories_ProperityId",
                table: "ProperityCategories",
                column: "ProperityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityTranslates_LanguageId",
                table: "ProperityTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityTranslates_ProperityId",
                table: "ProperityTranslates",
                column: "ProperityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandProductCategories_ProductSubCategories_ProductSubCategoryId",
                table: "BrandProductCategories",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_AdminManagers_AdminManagerId",
                table: "ProductSubCategories",
                column: "AdminManagerId",
                principalTable: "AdminManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategoryTranslates_Languages_LanguageId",
                table: "ProductSubCategoryTranslates",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandProductCategories_ProductSubCategories_ProductSubCategoryId",
                table: "BrandProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategories_AdminManagers_AdminManagerId",
                table: "ProductSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                table: "ProductSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategoryTranslates_Languages_LanguageId",
                table: "ProductSubCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates");

            migrationBuilder.DropTable(
                name: "ProperityCategories");

            migrationBuilder.DropTable(
                name: "ProperityTranslates");

            migrationBuilder.DropTable(
                name: "Properities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategoryTranslates",
                table: "ProductSubCategoryTranslates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategories",
                table: "ProductSubCategories");

            migrationBuilder.RenameTable(
                name: "ProductSubCategoryTranslates",
                newName: "ProductSubCategoryTranslate");

            migrationBuilder.RenameTable(
                name: "ProductSubCategories",
                newName: "ProductSubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategoryTranslates_ProductSubCategoryId",
                table: "ProductSubCategoryTranslate",
                newName: "IX_ProductSubCategoryTranslate_ProductSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategoryTranslates_LanguageId",
                table: "ProductSubCategoryTranslate",
                newName: "IX_ProductSubCategoryTranslate_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategory",
                newName: "IX_ProductSubCategory_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategories_AdminManagerId",
                table: "ProductSubCategory",
                newName: "IX_ProductSubCategory_AdminManagerId");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "BrandProductCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategoryTranslate",
                table: "ProductSubCategoryTranslate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory",
                column: "Id");

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
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 20, 8, 23, 140, DateTimeKind.Local).AddTicks(1982));

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
                name: "IX_BrandProductCategories_ProductCategoryId",
                table: "BrandProductCategories",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandProductCategories_ProductCategories_ProductCategoryId",
                table: "BrandProductCategories",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandProductCategories_ProductSubCategory_ProductSubCategoryId",
                table: "BrandProductCategories",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_AdminManagers_AdminManagerId",
                table: "ProductSubCategory",
                column: "AdminManagerId",
                principalTable: "AdminManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_ProductCategories_ProductCategoryId",
                table: "ProductSubCategory",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategoryTranslate_Languages_LanguageId",
                table: "ProductSubCategoryTranslate",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategoryTranslate_ProductSubCategory_ProductSubCategoryId",
                table: "ProductSubCategoryTranslate",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
