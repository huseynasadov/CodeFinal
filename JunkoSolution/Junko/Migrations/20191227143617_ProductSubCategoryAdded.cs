using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProductSubCategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductSubCategory");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductSubCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ProductSubCategory",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ProductSubCategoryTranslate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSubCategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategoryTranslate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategoryTranslate_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSubCategoryTranslate_ProductSubCategory_ProductSubCategoryId",
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
                value: new DateTime(2019, 12, 27, 18, 36, 15, 646, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 641, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(4531), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6720), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6753), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6821), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6825), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6829), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6834), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6838), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6842), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6846), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6851), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6855), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6859), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6863), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6867), new DateTime(2019, 12, 27, 18, 36, 15, 643, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(7914), new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9433), new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9455), new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9459), new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9464), new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9467), new DateTime(2019, 12, 27, 18, 36, 15, 642, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 645, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 648, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.InsertData(
                table: "ProductSubCategory",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 19, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8674), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a9a78-evsinema.jpg", true },
                    { 20, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8677), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d73ad-projeksiyon.jpg", true },
                    { 21, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8680), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/712b6-ps4.jpg", true },
                    { 22, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8683), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/8b3c4-unnamed.jpg", true },
                    { 23, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8686), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/47bfc-xbox-logo_318-9975.jpg", true },
                    { 24, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/7e1df-37229008_21039398.jpeg", true },
                    { 25, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8691), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/00858-a4726b678f87bd94ea880eeef0ecdfcb-silhouette-black-white-vacuum-cleaner.png", true },
                    { 26, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8694), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6a0f2-pngtree-vector-hair-dryer-icon-png-image_701315.jpg", true },
                    { 27, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a7af1-electric-iron-icon-simple-style-vector-21484883.jpg", true },
                    { 28, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/560ee-meat-grinder-machine-icon-simple-style-vector-22276672.jpg", true },
                    { 29, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ae188-electric-kettle-household-appliance-icon-vector-8275057.jpg", true },
                    { 30, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8704), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d879f-juicer-icon-simple-style-vector-10155704.jpg", true },
                    { 18, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a6cf0-soundbar.png", true },
                    { 17, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8669), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ec35f-ses_ev.png", true },
                    { 3, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8630), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/3d444-akillisaatler.jpg", true },
                    { 15, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/70f58-monitorkatr.jpg", true },
                    { 14, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8661), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d6ad6-yazicilar.jpg", true },
                    { 13, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/bd8b6-notebook.jpg", true },
                    { 12, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8656), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9b6f3-masaustu.jpg", true },
                    { 11, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8653), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ddf24-notebook.jpg", true },
                    { 10, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/63377-mikrodalga.jpg", true },
                    { 9, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8649), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/bccf0-pilte.png", true },
                    { 8, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a79f3-kitchenaid-logo.jpg", true },
                    { 7, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/531d2-paltaryuyan.png", true },
                    { 6, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/5818a-klima.jpg", true },
                    { 5, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/37bcc-soyuducu.png", true },
                    { 4, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/c6c32-4c725ea90ea12cefddd054328870a61f-online-mobile-second-hand.jpg", true },
                    { 31, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8706), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/11f7a-a-gray-stationary-blender-icon-vector-13417582.jpg", true },
                    { 2, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8476), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/5f28a-tabletler.jpg", true },
                    { 16, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8666), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/900d4-televizyonlar.jpg", true },
                    { 32, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/cea64-toaster-icon-simple-black-style-vector-18839754.jpg", true },
                    { 46, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8791), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/2ed8d-tasinabilirsarj.jpg", true },
                    { 34, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/7b5b8-ekran-koruyucu.jpg", true },
                    { 56, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8816), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/eaf6d-sk50-1.png", true },
                    { 55, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/09a3c-xprinter-thermal-barcode-printer-80mm-xp-350b-.jpg", true },
                    { 54, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/3a824-intermec_pc42d_icon_1.jpg", true },
                    { 53, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8808), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b3747-bar-code.png", true },
                    { 52, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8806), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d9046-81sbl3t77zl._sl1500_.jpg", true },
                    { 51, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/bdd2e-nar.png", true },
                    { 33, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/4f398-90652265-stock-vector-mixer-kitchen-icon-simple-illustration-of-mixer-kitchen-vector-icon-for-web.jpg", true },
                    { 49, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b3323-bakcell.png", true },
                    { 48, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8796), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/c1af5-usb-bellek.jpg", true },
                    { 47, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8794), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/528ea-monopad.png", true },
                    { 50, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8801), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6fb9a-azercell.png", true },
                    { 44, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8786), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/f3ba8-sdcard.png", true },
                    { 45, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8788), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b813a-kulaklikkategori.png", true },
                    { 36, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8719), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/eee1f-003386-glossy-black-icon-media-music-speaker.png", true },
                    { 37, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6d65f-86666-cordless-phone.png", true },
                    { 38, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8769), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/74601-car-flat-icon-01-.jpg", true },
                    { 35, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8716), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9a881-iphonea.png", true },
                    { 40, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8776), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/03ba9-telefonkilif.jpg", true },
                    { 41, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8779), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b1347-business-suitcase-bag-icon.jpg", true },
                    { 42, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8781), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b40b8-network.jpg", true },
                    { 43, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8783), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6d0d5-mouse.jpg", true },
                    { 39, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8773), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/8ebb1-kablo.jpg", true },
                    { 1, 1, new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(6962), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6fe81-ceptelefon.jpg", true }
                });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 644, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 644, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 644, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 638, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 640, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 640, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 646, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 647, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.InsertData(
                table: "ProductSubCategoryTranslate",
                columns: new[] { "Id", "LanguageId", "Name", "ProductSubCategoryId" },
                values: new object[,]
                {
                    { 1, 1, "Mobile Phone", 1 },
                    { 41, 1, "Bags", 41 },
                    { 96, 2, "Telefon Qabları", 40 },
                    { 40, 1, "Phone Cases", 40 },
                    { 95, 2, "Adapterlər", 39 },
                    { 39, 1, "Adapters", 39 },
                    { 94, 2, "Avtomobil aksessuarları", 38 },
                    { 38, 1, "Car accessories", 38 },
                    { 93, 2, "DECT Telefonlar", 37 },
                    { 37, 1, "DECT Phones", 37 },
                    { 112, 2, "Qiymət Oxuyucu", 36 },
                    { 92, 2, "Səs gücləndirici", 36 },
                    { 97, 2, "Çantalar", 41 },
                    { 36, 1, "Amplifier", 36 },
                    { 35, 1, "Apple Accessories", 35 },
                    { 90, 2, "Screen Protector", 34 },
                    { 34, 1, "Screen Protector", 34 },
                    { 89, 2, "Mikserlər", 33 },
                    { 33, 1, "Mixers", 33 },
                    { 88, 2, "Tosterlər", 32 },
                    { 32, 1, "Toasts", 32 },
                    { 87, 2, "Blenderlər", 31 },
                    { 31, 1, "Blenders", 31 },
                    { 86, 2, "Şirəçəkənlər", 30 },
                    { 30, 1, "Juicers", 30 },
                    { 91, 2, "Apple Aksessuarları", 35 },
                    { 85, 2, "Çaydanlar", 29 },
                    { 42, 1, "Modems", 42 },
                    { 43, 1, "Mouse", 43 },
                    { 55, 1, "Check Printer", 55 },
                    { 110, 2, "Barkod Printer", 54 },
                    { 54, 1, "Barcode Printer", 54 },
                    { 109, 2, "Barkod Oxuyucu", 53 },
                    { 53, 1, "Barcode Reader", 53 },
                    { 108, 2, "İRobot", 52 },
                    { 52, 1, "İROBOT", 52 },
                    { 107, 2, "Nar", 51 },
                    { 51, 1, "Nar", 51 },
                    { 106, 2, "Azercell", 50 },
                    { 50, 1, "Azercell", 50 },
                    { 98, 2, "Modemlər", 42 },
                    { 105, 2, "Bakcell", 49 },
                    { 104, 2, "USB Flash", 48 },
                    { 48, 1, "USB Flash", 48 },
                    { 103, 2, "Monopod ", 47 },
                    { 47, 1, "Monopod", 47 },
                    { 102, 2, "Power Bank", 46 },
                    { 46, 1, "Power Bank", 46 },
                    { 101, 2, "Qulaqcıqlar", 45 },
                    { 45, 1, "Headphones", 45 },
                    { 100, 2, "Yaddaş Kartları", 44 },
                    { 44, 1, "Memory Cards", 44 },
                    { 99, 2, "Mouse", 43 },
                    { 49, 1, "Bakcell", 49 },
                    { 29, 1, "Kettles", 29 },
                    { 84, 2, "Ətçəkənlər", 28 },
                    { 28, 1, "Grinders", 28 },
                    { 13, 1, "Monoblok ", 13 },
                    { 68, 2, "Masaüstü kompüter", 12 },
                    { 12, 1, "Desktop computer", 12 },
                    { 67, 2, "Noutbuk", 11 },
                    { 11, 1, "Notebook", 11 },
                    { 66, 2, "Sobalar", 10 },
                    { 10, 1, "Ovens", 10 },
                    { 65, 2, "Plitələr", 9 },
                    { 9, 1, "Plates", 9 },
                    { 64, 2, "KitchenAid", 8 },
                    { 8, 1, "KitchenAid", 8 },
                    { 69, 2, "Monoblok", 13 },
                    { 63, 2, "Paltaryuyan", 7 },
                    { 62, 2, "Kondisioner", 6 },
                    { 6, 1, "Air conditioning", 6 },
                    { 61, 2, "Soyuducu", 5 },
                    { 5, 1, "Refrigerator", 5 },
                    { 60, 2, "İkinci əl mobil telefonlar", 4 },
                    { 4, 1, "Second hand mobile phones", 4 },
                    { 59, 2, "SmartWatch", 3 },
                    { 3, 1, "SmartWatch", 3 },
                    { 58, 2, "Planşetlər", 2 },
                    { 2, 1, "Tablets", 2 },
                    { 57, 2, "Mobil Telefonlar", 1 },
                    { 7, 1, "Washing machine", 7 },
                    { 14, 1, "Printer", 14 },
                    { 70, 2, "Printer", 14 },
                    { 15, 1, "Monitor", 15 },
                    { 83, 2, "Ütülər", 27 },
                    { 27, 1, "Irons", 27 },
                    { 82, 2, "Fenlər ", 26 },
                    { 26, 1, "Subjects", 26 },
                    { 81, 2, "Tozsoranlar", 25 },
                    { 25, 1, "Vacuum cleaners", 25 },
                    { 80, 2, "Oyun Manipulyatorları", 24 },
                    { 24, 1, "Game Manipulators", 24 },
                    { 79, 2, "Microsof Box", 23 },
                    { 23, 1, "Microsof Box ", 23 },
                    { 78, 2, "Oyunlar", 22 },
                    { 22, 1, "Games", 22 },
                    { 77, 2, "PlayStation", 21 },
                    { 21, 1, "PlayStation", 21 },
                    { 76, 2, "Projektor", 20 },
                    { 20, 1, "Projector", 20 },
                    { 75, 2, "DVD player", 19 },
                    { 19, 1, "DVD player", 19 },
                    { 74, 2, "Soundbar", 18 },
                    { 18, 1, "Soundbar", 18 },
                    { 73, 2, "Ev kinoteatrı", 17 },
                    { 17, 1, "Home Cinema", 17 },
                    { 72, 2, "Televizor", 16 },
                    { 16, 1, "TV", 16 },
                    { 71, 2, "Monitor", 15 },
                    { 111, 2, "Çek Printe", 55 },
                    { 56, 1, "Price Reader", 56 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategoryTranslate_LanguageId",
                table: "ProductSubCategoryTranslate",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategoryTranslate_ProductSubCategoryId",
                table: "ProductSubCategoryTranslate",
                column: "ProductSubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSubCategoryTranslate");

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductSubCategory");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ProductSubCategory");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductSubCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(4345));

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

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 17, 14, 5, 932, DateTimeKind.Local).AddTicks(7525));

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
        }
    }
}
