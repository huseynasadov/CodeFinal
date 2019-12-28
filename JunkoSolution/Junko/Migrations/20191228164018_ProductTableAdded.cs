using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProductTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "ProperityTranslates",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProperityTranslates",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<byte>(
                name: "Discount",
                table: "ProductSubCategories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountDate",
                table: "ProductSubCategories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    BrandProductCategoryId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<byte>(nullable: true),
                    DiscountDate = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IsFavory = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    FollowCount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_BrandProductCategories_BrandProductCategoryId",
                        column: x => x.BrandProductCategoryId,
                        principalTable: "BrandProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 336, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 332, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 332, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 332, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 332, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(7611), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9759), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9794), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9799), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9803), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9807), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9813), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9817), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9821), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9825), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9829), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9833), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9837), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9841), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9844), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(1021), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2493), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2516), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2520), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2525), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2529), new DateTime(2019, 12, 28, 20, 40, 16, 333, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 338, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 339, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdminManagerId", "BrandProductCategoryId", "CreatedAt", "Discount", "DiscountDate", "FollowCount", "IsFavory", "ModifiedAt", "Name", "Price", "Slug", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(3608), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro Max 256 GB", 3029m, "iPhone-11-Pro-Max-256-GB", true },
                    { 100, 1, 86, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5457), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox One X 1TB", 1119m, "Xbox-One-X-1TB", true },
                    { 94, 1, 80, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5439), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aiwa JH32TS700S", 479m, "Aiwa-JH32TS700S", true },
                    { 93, 1, 79, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5436), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HD2637/00", 139m, "Philips-HD2637-00", true },
                    { 92, 1, 78, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5432), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HR1627/00", 169m, "Philips-HR1627-00", true },
                    { 91, 1, 77, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5429), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HR1837/00", 279m, "Philips-HR1837-00", true },
                    { 90, 1, 76, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5426), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HD9342/01", 209m, "Philips-HD9342-01", true },
                    { 89, 1, 75, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5423), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HR2711/20", 289m, "Philips-HR2711-20", true },
                    { 88, 1, 74, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5420), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips GC3802/27", 179m, "Philips-GC3802-27", true },
                    { 95, 1, 81, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5442), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awei Bluetooth Headset A990", 50m, "Awei-Bluetooth-Headset-A990", true },
                    { 87, 1, 73, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5417), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips BHD184/00", 179m, "Philips-BHD184-00", true },
                    { 85, 1, 70, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5411), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Epson M 2140", 499m, "Epson-M-2140", true },
                    { 84, 1, 69, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5408), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canon MF 633 Cdw", 859m, "Canon-MF-633-Cdw", true },
                    { 83, 1, 68, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5404), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP USB Flash Drive 16GB", 30m, "HP-USB-Flash-Drive-16GB", true },
                    { 82, 1, 67, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5401), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse HP Gaming M100", 18m, "Mouse-HP-Gaming-M100", true },
                    { 81, 1, 66, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5398), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP F24", 389m, "HP-F24", true },
                    { 80, 1, 65, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5395), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP LaserJet M130 a", 329m, "HP-LaserJet-M130-a", true },
                    { 79, 1, 64, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5393), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP Pavilion All-in-One 27-xa0049ur", 2899m, "HP-Pavilion-All-in-One-27-xa0049ur", true },
                    { 86, 1, 72, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5414), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips FC9735/01", 669m, "Philips-FC9735-01", true },
                    { 96, 1, 82, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5445), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shivaki 43SF90G", 589m, "Shivaki-43SF90G", true },
                    { 97, 1, 83, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5448), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playstation 4 VR Bundle 3 in 1", 1049m, "Playstation-4-VR-Bundle-3-in-1", true },
                    { 98, 1, 84, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5451), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playstation 4 Fifa 2020", 149m, "Playstation-4-Fifa-2020", true },
                    { 116, 1, 103, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5509), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speaker Genius SP-U115", 25m, "Speaker-Genius-SP-U115", true },
                    { 115, 1, 101, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5506), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Braun IS7056BK", 699m, "Braun-IS7056BK", true },
                    { 114, 1, 100, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5503), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VITEK VT-8318", 89m, "VITEK-VT-8318", true },
                    { 113, 1, 99, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5497), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal HT400B30", 79m, "Tefal-HT400B30", true },
                    { 112, 1, 98, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5494), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal Actiflow Pro Set", 199m, "Tefal-Actiflow-Pro-Set", true },
                    { 111, 1, 97, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5491), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal ZE550D38", 259m, "Tefal-ZE550D38", true },
                    { 110, 1, 96, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5489), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal My Tea red", 129m, "Tefal-My-Tea-red", true },
                    { 109, 1, 95, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5484), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal Kiyma Makinesi", 449m, "Tefal-Kiyma-Makinesi", true },
                    { 108, 1, 94, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5481), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal FV9848", 229m, "Tefal-FV9848", true },
                    { 107, 1, 93, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5478), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rowenta CV5090F0", 89m, "Rowenta-CV5090F0", true },
                    { 106, 1, 92, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5476), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic KX-3722", 199m, "Panasonic-KX-3722", true },
                    { 105, 1, 91, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5473), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic MC-CG715K149", 399m, "Panasonic-MC-CG715K149", true },
                    { 104, 1, 90, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5470), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oculus Rift VR Bundle", 1239m, "Oculus-Rift-VR-Bundle", true },
                    { 103, 1, 89, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5467), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse Logitech M187", 10m, "Mouse-Logitech-M187", true },
                    { 102, 1, 88, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5464), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playstation 4 Logitech G29", 849m, "Playstation-4-Logitech-G29", true },
                    { 101, 1, 87, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5460), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox One S/X Controller", 129m, "Xbox-One-S-X-Controller", true },
                    { 99, 1, 85, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5454), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayStation 4 DualShock Joystick", 119m, "PlayStation-4-DualShock-Joystick", true },
                    { 78, 1, 63, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5390), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP Pavilion - 15-cs0056ur", 2289m, "HP-Pavilion-15-cs0056ur", true },
                    { 117, 1, 104, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5512), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speaker Genius SP-U115", 25m, "Speaker-Genius-SP-U115", true },
                    { 77, 1, 62, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5387), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell Inspirion 17 5759", 2249m, "Dell-Inspirion-17-5759", true },
                    { 75, 1, 60, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5379), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASUS Zenbook UX301L", 2359m, "ASUS-Zenbook-UX301L", true },
                    { 53, 1, 35, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5274), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Yoga 510-14IKB Touch", 1771m, "Lenovo-Yoga-510-14IKB-Touch", true },
                    { 52, 1, 34, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5272), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Tab P 10", 829m, "Lenovo-Tab-P-10", true },
                    { 51, 1, 33, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5269), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor 10", 1029m, "Honor-10", true },
                    { 50, 1, 32, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5265), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "uleFone S8 (16 GB) Black", 129m, "uleFone-S8-16-GB-Black", true },
                    { 49, 1, 31, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5260), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ULEFONE S9 Pro", 229m, "ULEFONE-S9-Pro", true },
                    { 48, 1, 30, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5258), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FLY CIRRUS 7", 259m, "FLY-CIRRUS-7", true },
                    { 47, 1, 29, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5254), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOKIA 6.1 2018", 689m, "NOKIA-6-1-2018", true },
                    { 54, 1, 36, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5277), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balafon GPS Watch", 69m, "Balafon-GPS-Watch", true },
                    { 46, 1, 28, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5251), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meizu M6t", 329m, "Meizu-M6t", true },
                    { 44, 1, 26, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5244), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note 5 5D S/P", 10m, "Xiaomi-Note-5-5D-S-P", true },
                    { 43, 1, 25, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5241), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi 8 128 GB Blue", 559m, "Xiaomi-Mi-8-128-GB-Blue", true },
                    { 42, 1, 24, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5238), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Amazfit Stratos", 369m, "Xiaomi-Amazfit-Stratos", true },
                    { 41, 1, 23, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5235), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Black Shark", 1119m, "Xiaomi-Black-Shark", true },
                    { 40, 1, 22, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5230), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Media Tab 3 10.1", 399m, "Huawei-Media-Tab-3-10-1", true },
                    { 39, 1, 21, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5227), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei P 30 Pro", 1999m, "Huawei-P-30-Pro", true },
                    { 38, 1, 20, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5224), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Hi-Fi Level upro", 59m, "Samsung-Hi-Fi-Level-upro", true },
                    { 45, 1, 27, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5248), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Xiaomi 20000 mAh", 79m, "Power-Bank-Xiaomi-20000-mAh", true },
                    { 55, 1, 38, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5280), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG GR-B650GLPL", 1869m, "LG-GR-B650GLPL", true },
                    { 56, 1, 39, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5283), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG F1296TDT24", 1139m, "LG-F1296TDT24", true },
                    { 57, 1, 40, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5286), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG OLED55B8SLB", 3599m, "LG-OLED55B8SLB", true },
                    { 74, 1, 59, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5375), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorenje PS10/21100-W7503/S1", 819m, "Gorenje-PS10-21100-W7503-S1", true },
                    { 73, 1, 57, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5372), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AUX ASW-H30A4/JR1", 2099m, "AUX-ASW-H30A4-JR1", true },
                    { 72, 1, 56, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5370), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gree GWH24AAB-K3NNA1A/O", 1569m, "Gree-GWH24AAB-K3NNA1A-O", true },
                    { 71, 1, 55, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5366), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitsubishi SRC71ZSPR-S", 3199m, "Mitsubishi-SRC71ZSPR-S", true },
                    { 70, 1, 54, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5328), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vestel SD453GR", 999m, "Vestel-SD453GR", true },
                    { 69, 1, 53, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5325), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch MFQ3540", 99m, "Bosch-MFQ3540", true },
                    { 68, 1, 52, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5322), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch TAT6A913", 109m, "Bosch-TAT6A913", true },
                    { 67, 1, 51, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5318), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch MSM67190", 269m, "Bosch-MSM67190", true },
                    { 66, 1, 49, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5315), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch MES4000", 379m, "Bosch-MES4000", true },
                    { 65, 1, 48, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5311), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch TDI902836A", 259m, "Bosch-TDI902836A", true },
                    { 64, 1, 47, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5309), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch BGS5335", 699m, "Bosch-BGS5335", true },
                    { 63, 1, 46, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5306), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOSCH HMG636BS1", 2829m, "BOSCH-HMG636BS1", true },
                    { 62, 1, 45, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5303), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOSCH PKN811FP1E", 1309m, "BOSCH-PKN811FP1E", true },
                    { 61, 1, 44, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5300), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch GSN36AI31U", 1899m, "Bosch-GSN36AI31U", true },
                    { 60, 1, 43, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5297), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zanussi ZRB 36101 XA", 1099m, "Zanussi-ZRB-36101-XA", true },
                    { 59, 1, 42, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5294), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HITACHI R-W720FPUC1X", 2959m, "HITACHI-R-W720FPUC1X", true },
                    { 58, 1, 41, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5289), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTC One X9 Gold Dual SIM ", 399m, "HTC-One-X9-Gold-Dual-SIM ", true },
                    { 76, 1, 61, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5383), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acer Nitro 5 AN515-51-782P", 2299m, "Acer-Nitro-5-AN515-51-782P", true },
                    { 37, 1, 19, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5221), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Note 8 Active Case", 70m, "Samsung-Note-8-Active-Case", true },
                    { 118, 1, 105, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5514), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JBL PARTY BOX 300", 1149m, "JBL-PARTY-BOX-300", true },
                    { 120, 1, 108, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5521), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Remax Bluetooth Headset T6C", 55m, "Remax-Bluetooth-Headset-T6C", true },
                    { 27, 1, 11, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5191), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab S2 VE 8.0", 799m, "Samsung-Galaxy-Tab-S2-VE-8-0", true },
                    { 26, 1, 10, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5188), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10 E", 1449m, "Samsung-Galaxy-S10-E", true },
                    { 25, 1, 10, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5186), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 9", 1499m, "Samsung-Galaxy-Note-9", true },
                    { 24, 1, 10, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5183), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10", 1699m, "Samsung-Galaxy-S10", true },
                    { 23, 1, 10, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5178), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10 Plus", 1899m, "Samsung-Galaxy-S10-Plus", true },
                    { 22, 1, 10, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5175), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 10", 1949m, "Samsung-Galaxy-Note-10", true },
                    { 21, 1, 10, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5173), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 10 plus", 2149m, "Samsung-Galaxy-Note-10-plus", true },
                    { 20, 1, 9, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5170), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X Comma Premium Gift", 99m, "iPhone-X-Comma-Premium-Gift", true },
                    { 19, 1, 8, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5167), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple iPhone USB Original", 25m, "Apple-iPhone-USB-Original", true },
                    { 18, 1, 7, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5164), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone Original Hi-Fi", 59m, "iPhone-Original-Hi-Fi", true },
                    { 17, 1, 6, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5160), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X 5D Baseus Chamilyon", 25m, "iPhone-X-5D-Baseus-Chamilyon", true },
                    { 16, 1, 5, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5109), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple MacBook Pro MR942", 5490m, "Apple-MacBook-Pro-MR942", true },
                    { 119, 1, 107, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5519), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnet USB Remax", 15m, "Magnet-USB-Remax", true },
                    { 15, 1, 4, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5104), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 64 GB Gold", 1759m, "iPhone-XS-Max-64-GB-Gold", true },
                    { 13, 1, 3, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5099), (byte)0, 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Watch Series 4 40mm", 849m, "Apple-Watch-Series-4-40mm", true },
                    { 12, 1, 3, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5096), (byte)0, 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Watch Series 5 44mm", 999m, "Apple-Watch-Series-5-44mm", true },
                    { 11, 1, 2, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5093), (byte)0, 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE IPAD Air 256 GB (2019)", 1649m, "APPLE-IPAD-Air-256-GB-2019", true },
                    { 10, 1, 2, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5090), (byte)0, 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE IPAD PRO 10.5 WI-FI 4G 256 GB", 1799m, "APPLE-IPAD-PRO-10-5-WI-FI-4G-256-GB", true },
                    { 9, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5087), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS  64 GB", 1999m, "iPhone-XS-64-GB", true },
                    { 8, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5084), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS  256 GB", 2189m, "iPhone-XS-256-GB", true },
                    { 7, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5080), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 64 GB", 2199m, "iPhone-XS-Max-64-GB", true },
                    { 6, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5075), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 64 GB Dual", 2379m, "iPhone-XS-Max-64-GB-Dual", true },
                    { 5, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5072), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 256 GB", 2449m, "iPhone-XS-Max-256-GB", true },
                    { 4, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5069), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro 64 GB", 2519m, "iphone-11-pro-64-gb", true },
                    { 3, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5065), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro Max 64 GB", 2759m, "iphone-11-pro-max-64-gb", true },
                    { 2, 1, 1, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5035), (byte)10, 10, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro 256 GB", 2850m, "iphone-11-pro-256-gb", true },
                    { 14, 1, 4, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5101), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 256 Gb black", 1859m, "IPhone-XS-Max-256-Gb-black", true },
                    { 28, 1, 11, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5194), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab A 10.1", 549m, "Samsung-Galaxy-Tab-A-10-1", true },
                    { 36, 1, 18, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5218), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Travel Adater Fast Type C", 25m, "Samsung-Travel-Adater-Fast-Type-C", true },
                    { 30, 1, 12, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5200), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Watch (46 mm)", 599m, "Samsung-Galaxy-Watch-46-mm", true },
                    { 35, 1, 17, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5215), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S8 Plus 3D Black S/P", 20m, "S8-Plus-3D-Black-S-P", true },
                    { 141, 1, 132, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5618), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Çek Printer TSP-143 U", 489m, "Star-Çek-Printer-TSP-143-U", true },
                    { 140, 1, 131, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5615), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACLAS Çek Printer PP7X USB", 269m, "ACLAS-Çek-Printer-PP7X-USB", true },
                    { 139, 1, 130, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5612), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DataLogic Barkod Oxuyucu QW", 129m, "DataLogic-Barkod-Oxuyucu-QW", true },
                    { 138, 1, 129, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5609), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argox Barkod Printer OS 214 Plus", 489m, "Argox-Barkod-Printer-OS-214-Plus", true },
                    { 137, 1, 128, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5606), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argox Barkod Reader Z3100", 99m, "Argox-Barkod-Reader-Z3100", true },
                    { 136, 1, 127, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5604), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Symbol Barkod Reader (LS 2208)", 169m, "Symbol-Barkod-Reader-LS-2208", true },
                    { 135, 1, 126, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5600), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roomba 980", 2400m, "Roomba-980", true },
                    { 134, 1, 122, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5597), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USB Flash Adata 64GB", 59m, "USB-Flash-Adata-64GB", true },
                    { 133, 1, 121, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5594), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Bilitong 10000 Mah", 35m, "Power-Bank-Bilitong-10000-Mah", true },
                    { 29, 1, 11, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5197), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab A/8.0 LTE", 369m, "Samsung-Galaxy-Tab-A-8-0-LTE", true },
                    { 132, 1, 120, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5591), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Aspor 6000 Mah", 25m, "Power-Bank-Aspor-6000-Mah", true },
                    { 130, 1, 118, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5585), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Proda 10000 Mah", 65m, "Power-Bank-Proda-10000-Mah", true },
                    { 129, 1, 117, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5582), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman Bluetooth Headset X2S", 27m, "Roman-Bluetooth-Headset-X2S", true },
                    { 128, 1, 116, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5580), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bluetooth Jabra Storm", 45m, "Bluetooth-Jabra-Storm", true },
                    { 127, 1, 115, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5576), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beats S460 red", 35m, "Beats-S460-red", true },
                    { 126, 1, 114, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5573), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USB Dual Driver Sandisk 32GB", 40m, "USB-Dual-Driver-Sandisk-32GB", true },
                    { 125, 1, 113, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5569), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SanDisk Micro 128GB 10 Class Ultra", 99m, "SanDisk-Micro-128GB-10-Class-Ultra", true },
                    { 124, 1, 112, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5533), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse A4Tech R7 Bloody", 89m, "Mouse-A4Tech-R7-Bloody", true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdminManagerId", "BrandProductCategoryId", "CreatedAt", "Discount", "DiscountDate", "FollowCount", "IsFavory", "ModifiedAt", "Name", "Price", "Slug", "Status" },
                values: new object[,]
                {
                    { 123, 1, 111, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5530), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X Baseus Weaving case", 18m, "iPhone-X-Baseus-Weaving-case", true },
                    { 122, 1, 110, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5527), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wireless Charger Rock-W3", 75m, "Wireless-Charger-Rock-W3", true },
                    { 121, 1, 109, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5524), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Remax 2600 Mah", 12m, "Power-Bank-Remax-2600-Mah", true },
                    { 131, 1, 119, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5588), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank WK 10000 Mah", 45m, "Power-Bank-WK-10000-Mah", true },
                    { 33, 1, 15, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5210), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung WW70K62E00SDLP", 1199m, "Samsung-WW70K62E00SDLP", true },
                    { 34, 1, 16, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5213), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung UE65RU7300UXRU", 2669m, "Samsung-UE65RU7300UXRU", true },
                    { 31, 1, 13, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5203), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S8 Plus Black", 699m, "Samsung-Galaxy-S8-Plus-Black", true },
                    { 32, 1, 14, new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5206), (byte)10, 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung RS57K4000SA/WT", 2369m, "Samsung-RS57K4000SA-WT", true }
                });

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 340, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 341, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 334, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 335, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 329, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 331, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 331, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 337, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.InsertData(
                table: "ProductTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "ProductId" },
                values: new object[,]
                {
                    { 1, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 1 },
                    { 12, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 12 },
                    { 32, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 12 },
                    { 13, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 13 },
                    { 33, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 13 },
                    { 14, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 14 },
                    { 34, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 14 },
                    { 15, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 15 },
                    { 31, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 11 },
                    { 35, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 15 },
                    { 36, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 16 },
                    { 17, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 17 },
                    { 37, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 17 },
                    { 18, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 18 },
                    { 38, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 18 },
                    { 19, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 19 },
                    { 39, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 19 },
                    { 16, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 16 },
                    { 11, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 11 },
                    { 30, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 10 },
                    { 10, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 10 },
                    { 21, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 1 },
                    { 2, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 2 },
                    { 22, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 2 },
                    { 3, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 3 },
                    { 23, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 3 },
                    { 4, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 4 },
                    { 24, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 4 },
                    { 5, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 5 },
                    { 25, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 5 },
                    { 6, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 6 },
                    { 26, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 6 },
                    { 7, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 7 },
                    { 27, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 7 },
                    { 8, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 8 },
                    { 28, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 8 },
                    { 9, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 9 },
                    { 29, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 9 },
                    { 20, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 20 },
                    { 40, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdminManagerId",
                table: "Products",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandProductCategoryId",
                table: "Products",
                column: "BrandProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslates_LanguageId",
                table: "ProductTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslates_ProductId",
                table: "ProductTranslates",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTranslates");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "ProductSubCategories");

            migrationBuilder.DropColumn(
                name: "DiscountDate",
                table: "ProductSubCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "ProperityTranslates",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProperityTranslates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

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

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 12, 27, 18, 671, DateTimeKind.Local).AddTicks(6737));

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
        }
    }
}
