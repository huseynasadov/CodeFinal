using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProductPhotosTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPhotos_Products_ProductId",
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
                value: new DateTime(2019, 12, 29, 16, 8, 50, 645, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 640, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(2831), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(4980), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5013), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5018), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5023), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5027), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5034), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5038), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5042), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5046), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5051), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5054), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5059), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5062), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5066), new DateTime(2019, 12, 29, 16, 8, 50, 642, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(6348), new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7808), new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7829), new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7834), new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7838), new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7842), new DateTime(2019, 12, 29, 16, 8, 50, 641, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 646, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 644, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 647, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "Id", "CreatedAt", "Photo", "ProductId", "Status" },
                values: new object[,]
                {
                    { 177, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1584), "product/37d24-2d497ee1-b6d9-42a2-a22f-423c8bc91fd1.jpg", 122, true },
                    { 176, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1581), "product/c43ec-Remax-Power-Box-Mini-2600-mAh-9292-900x900.jpg", 121, true },
                    { 175, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1579), "product/ba53e-advertising-s1.jpg", 120, true },
                    { 174, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1577), "product/aa500-390-500x554.jpg", 119, true },
                    { 173, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1575), "product/04e4d-jbl-partybox-300-wireless-party-speaker.jpg", 118, true },
                    { 172, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1572), "product/4fcdc-traveler_9000r_2_02.jpg", 117, true },
                    { 171, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1569), "product/5a790-item_XL_8323336_7940917.jpg", 116, true },
                    { 170, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1566), "product/4711a-braun_is_7056_bk_d.jpg", 115, true },
                    { 162, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1549), "product/0a059-6863_1830007152.1200X1200_700x700.jpg", 108, true },
                    { 168, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1562), "product/26502-vitek-vt-1209-vt_images_1425588609.jpg", 114, true },
                    { 167, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1560), "product/c9d5c-a4e391610eb4e3f191e20f0745afd9d8.jpg", 113, true },
                    { 166, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1557), "product/c43dd-5077_1510001396.1200X1200_700x700--1-.jpg", 112, true },
                    { 165, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1555), "product/a3c2a-1b-sokovyzhimalka-tefal-ze550d38.jpg", 111, true },
                    { 164, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1553), "product/b28f2-mytea_red-1.jpg", 110, true },
                    { 163, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1551), "product/a8978-1--1-.jpg", 109, true },
                    { 178, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1586), "product/dd5ab-item_XL_27390553_67835296.jpg", 123, true },
                    { 161, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1547), "product/b86db-rowenta_cv_5090_images_8899783856.jpg", 107, true },
                    { 169, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1564), "product/de5c3-IS7056BK-1000x1000.jpg", 115, true },
                    { 179, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1588), "product/35a78-A4TECH-Bloody-R7-R70-Wireless-Gaming-Mouse-World-s-Fastest-Key.jpg", 124, true },
                    { 188, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1607), "product/a5b90-bilitong-10000mah-power-bank--500x500.jpg", 133, true },
                    { 181, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1592), "product/812e6-sandisk-ultra-dual-usb-m3-0-micro.jpg", 126, true },
                    { 160, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1544), "product/f061c-KX-TG3722.jpg", 106, true },
                    { 198, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1629), "product/555b5-sraseq.jpg", 141, true },
                    { 197, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1627), "product/3d33b-staer.jpg", 141, true },
                    { 196, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1625), "product/a6474-aclas-pp7x-usb-x.jpg", 140, true },
                    { 195, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1623), "product/07461-datalogic-quickscan-lite-qw210.jpg", 139, true },
                    { 194, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1621), "product/8abd1-zebra-gc-420t-barkod-yazici-barkod-yazici-38130_500.jpg", 138, true },
                    { 193, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1619), "product/40167-argox-as-8000-ccd-kablolu-barkod-okuyucu.jpg", 137, true },
                    { 192, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1617), "product/40167-argox-as-8000-ccd-kablolu-barkod-okuyucu.jpg", 136, true },
                    { 191, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1614), "product/180f3-886.jpg", 135, true },
                    { 190, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1612), "product/19a63-b4e306f7-2672-49a3-92ae-674701322bd7.png", 135, true },
                    { 189, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1610), "product/655d4-Brand-new-Fashion.jpg", 134, true },
                    { 187, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1605), "product/a9db2-ZUVA0014.png", 132, true },
                    { 186, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1603), "product/8962a-image-244538.jpg", 131, true },
                    { 185, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1601), "product/90df9-241531185.jpg", 130, true },
                    { 184, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1599), "product/6d56b-ORIG-Roman-X3s-1428x1228.jpg", 129, true },
                    { 183, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1597), "product/05d53-item_XL_11469506_16186303.jpg", 128, true },
                    { 182, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1594), "product/e4a4e-Beats_Solo_HD_Bluetooth_S_460_Red.jpg", 127, true },
                    { 180, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1590), "product/9b4a9-0042341_memorijskakartica-sandisk.jpg", 125, true },
                    { 159, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1542), "product/58f92-97af2475ef574516a0c7c42f5f22ff28.jpeg", 105, true },
                    { 1, new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(9624), "product/856a5-iphone-11-pro-select-2019-family.jpg", 1, true },
                    { 157, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1538), "product/50380-s0657161_sc7.jpg", 103, true },
                    { 62, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1285), "product/d2605-travel_adapter_samsung_fast.jpg", 36, true },
                    { 117, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1411), "product/64bbe-98-1-vestel-sd450g-a-46970778995.jpg", 70, true },
                    { 63, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1287), "product/db145-samsung-ep-ta20iweugin-travel-adapter_1487920932.jpeg", 36, true },
                    { 64, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1289), "product/c3658-galaxy-note8-acc_standing.jpg", 37, true },
                    { 65, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1291), "product/916ef-coque-etui-housse-pour-samsung.jpg", 37, true },
                    { 66, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1293), "product/02457-Pdpdefault-eo-bg935cbegus-600x600-C1-052016.jpg", 38, true },
                    { 67, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1296), "product/3e6c7-p30proaurorahero.jpg.4e68899253.999x600x550.jpg", 39, true },
                    { 68, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1298), "product/4e434-51zDfRUUhHL._SX425_.jpg", 39, true },
                    { 69, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1300), "product/a7331-41AdlRlQzRL._SY355_.jpg", 40, true },
                    { 70, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1303), "product/b56fb-csm_4_zu_3_Huawei_MediaPad_T3_10_57ec177426.jpg", 40, true },
                    { 71, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1305), "product/ce7aa-xiaomi-black-shark-8gb128gb-black-global.jpg", 41, true },
                    { 72, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1307), "product/619ed-xiaomi-black-shark-6gb-64gb-dual-sim-black.jpg", 41, true },
                    { 73, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1309), "product/258ac-1000.1000_1f9e58da626e43e9b33aafea1b061d2c.jpg", 42, true },
                    { 74, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1311), "product/5ca3c-49848484.jpg", 42, true },
                    { 75, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1313), "product/cb256-888888.jpg", 43, true },
                    { 61, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1283), "product/d17fe-SAMS8LCDSCPR83B-1000__17859.1491533735.500.750.jpg", 35, true },
                    { 60, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1280), "product/5255b-0000260_3d-curved-edge-full.jpeg", 35, true },
                    { 59, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1277), "product/a8df2-1129201_v01_b.jpg", 34, true },
                    { 58, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1274), "product/0b362-Samsung-WW70K62E00SDLP2.jpg", 33, true },
                    { 42, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1239), "product/a0e2e-s10_2-1.jpg", 24, true },
                    { 43, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1241), "product/91e94-81vB-Irbk9L._SL1500_.jpg", 25, true },
                    { 44, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1243), "product/9c9a0-samsng_note_9.jpg", 25, true },
                    { 45, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1245), "product/d9d15-190202-samsung-galaxy-s10e-01.jpg", 26, true },
                    { 46, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1247), "product/6afdd-samsung-galaxy-s10e-white.jpg", 26, true },
                    { 47, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1250), "product/06a0b-Samsung-Galaxy-Tab-S2-VE.png", 27, true },
                    { 48, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1252), "product/52832-Samsung-Galaxy-Tab-A-10.png", 27, true },
                    { 76, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1316), "product/ef431-707d6-Global-Version.jpg", 43, true },
                    { 49, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1254), "product/52832-Samsung-Galaxy-Tab-A-10.png", 28, true },
                    { 51, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1258), "product/3193f-Samsung-Galaxy-Tab-A7.0-2.png", 29, true },
                    { 52, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1260), "product/06a0b-Samsung-Galaxy-Tab-S2-VE.png", 29, true },
                    { 116, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1408), "product/32213-61Jz8-WoS2L._SX425_.jpg", 69, true },
                    { 54, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1265), "product/21cb8-Samsung-Galaxy-S8-Plus-1.png", 31, true },
                    { 55, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1267), "product/04759-Samsung-RS57K4000SAWT.jpg", 32, true },
                    { 56, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1270), "product/f2e47-Samsung-RS57K4000SAWT2.jpg", 32, true },
                    { 57, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1272), "product/2f980-Samsung-WW70K62E00SDLP.jpg", 33, true },
                    { 50, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1256), "product/06a0b-Samsung-Galaxy-Tab-S2-VE.png", 28, true },
                    { 77, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1319), "product/872a6-MAKAVO-For-Xiaomi-Redmi-Note-5-Pro.jpg", 44, true },
                    { 78, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1322), "product/be99b-gs100.jpg", 44, true },
                    { 79, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1324), "product/55d3e-vneshnij-akkumulyator-xiaomi.jpg", 45, true },
                    { 100, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1372), "product/26bcf-lg_oled_tv_55b8slb1-1.jpg", 57, true },
                    { 101, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1375), "product/2767d-lg_oled_tv_55b8slb3.jpg", 57, true },
                    { 102, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1377), "product/b9145-x9.jpg", 58, true },
                    { 103, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1379), "product/58251-soyuducu-hitachi-r-w720puc1-gbk-new-630x552.jpg", 59, true },
                    { 104, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1381), "product/5d3dc-hitachi-r-w720fpuc1x-gbk_images_1490044930-630x552.jpg", 59, true },
                    { 105, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1383), "product/7a81a-Zanussi-ZRB-36101-XA.jpg", 60, true },
                    { 106, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1385), "product/295ac-Zanussi-ZRB-36101XA.jpg", 60, true },
                    { 99, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1370), "product/a7437-medium04_F12B8QD5_FrontOpen_Silver.jpg", 56, true },
                    { 107, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1387), "product/84b16-mcsa02343948-i2025-1745639-gsn36ai31u-cmyk-def.jpg", 61, true },
                    { 109, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1392), "product/6869e-mcsa01734543-pkn811fp1e-electrichob-bosch-stp-def.jpg", 62, true },
                    { 110, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1394), "product/397bd-mcsa00766690-411043-hmg636bs1-def.jpg", 63, true },
                    { 111, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1396), "product/22142-11.jpg", 64, true },
                    { 112, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1398), "product/ef50c-1720017047_w640_h640_utyug-bosch-tdi902836a.jpg", 65, true },
                    { 113, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1400), "product/4391f-juicer-bosch-mes4000-silver.jpg", 66, true },
                    { 114, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1402), "product/b111c-MCSA00726979_E4593_MSM67190_378570_korr_def.jpg", 67, true },
                    { 115, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1406), "product/193d2-MCSA01619347_G1895_TAT6A913_1070026_def.jpg", 68, true },
                    { 108, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1389), "product/dfb76-mcsa02343828-i2015-1745524-gsn36ai31u-pga2-cmyk-def.jpg", 61, true },
                    { 41, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1236), "product/78896-Samsung-Galaxy-S10-128GB.jpg", 24, true },
                    { 98, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1368), "product/53aaf-mega-medium.jpg", 56, true },
                    { 96, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1363), "product/a3dff-refrigerators-gr-b650glpl-750x480.jpg", 55, true },
                    { 80, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1326), "product/14fe3-1.jpg", 45, true },
                    { 81, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1328), "product/45f67-Meizu_M6T_L_1.jpg", 46, true },
                    { 82, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1331), "product/4a4c1-2c4839a6cc370f5269233bffec6369e9-254x300.jpg", 46, true },
                    { 83, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1333), "product/59f3a-61eGeaQ45VL._SX569_.jpg", 47, true },
                    { 84, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1335), "product/ef41b-1519637855_635_nokia_6_android_one.jpg", 47, true },
                    { 85, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1338), "product/31c63-FLY-NIMBUS-9.png", 48, true },
                    { 86, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1340), "product/c0960-37a4c0b68c456c44742f59a38127b45f_300x300.jpg", 48, true },
                    { 97, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1365), "product/4db1f-copy-large02.jpg", 55, true },
                    { 87, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1342), "product/4c564-s9pro.png", 49, true },
                    { 89, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1346), "product/3064e-s8.jpg", 50, true },
                    { 90, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1348), "product/8e3c3-428_428_1523443560490.jpg", 51, true },
                    { 91, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1350), "product/c2606-lenovo-tab-p10.jpg", 52, true },
                    { 92, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1353), "product/80a1d-Lenovo-Tab-M10-Tablet-600x507.jpg", 52, true },
                    { 93, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1355), "product/55fe3-4zu3_Lenovo_Yoga_510_Teaser.jpg", 53, true },
                    { 94, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1357), "product/a2f82-copy_lenovo_80vb005fra_587e1b47dadc1_images_1837230040.jpg", 53, true },
                    { 95, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1360), "product/47220-68526_Gps-tracker-kid-safe-smart-watch.jpg", 54, true },
                    { 88, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1344), "product/0dbb1-989.png", 49, true },
                    { 40, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1234), "product/41928-61YVqHdFRxL._SL1322_.jpg", 23, true },
                    { 53, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1263), "product/d891c-samsung_sm_r800nzsaxar_galileo_smartwatch_silver_1429263.jpg", 30, true },
                    { 38, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1228), "product/6b44f-samsung-galaxy-note10-plus-aura-black.jpg.jpg", 22, true },
                    { 129, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1436), "product/96ef6-monoblok-hp-pavilion-27-xa0046ur-aio-5kp15ea-belyj-27.jpg", 79, true },
                    { 128, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1434), "product/bda07-c06179404.png", 79, true },
                    { 127, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1432), "product/8b7e0-1157594-1024x768.jpg", 78, true },
                    { 126, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1430), "product/26989-Dell-Inspirion-17-57592.jpg", 77, true },
                    { 125, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1428), "product/cff28-Dell-Inspirion-17-5759.jpeg", 77, true },
                    { 124, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1425), "product/60264-large_9212_acer-nitro-5-an515-51-nh-q2rer-001-black-1304615-1.jpg", 76, true },
                    { 123, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1423), "product/a15f4-ASUS-Zenbook-UX301L.jpg", 75, true },
                    { 122, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1421), "product/411e1-ASUS-Zenbook-UX301L.png", 75, true },
                    { 121, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1419), "product/57572-8845618053150.jpg", 74, true },
                    { 120, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1417), "product/311b2-5b111ad12a7ff.jpg", 73, true },
                    { 130, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1438), "product/3cefb-14265876.jpg", 80, true },
                    { 119, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1415), "product/e18c1-31bb1-p1cegsbak5at11i9f1d6t1c61ui16.jpg", 72, true },
                    { 2, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1072), "product/a6bc8-iPhone-11-Pro-Max-256GB-Gold-1.png", 1, true },
                    { 3, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1101), "product/48d85-221132_pjpeg.jpg", 2, true },
                    { 4, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1104), "product/a6bc8-iPhone-11-Pro-Max-256GB-Gold-1.png", 2, true },
                    { 5, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1107), "product/7920f-iPhone-XI.jpeg", 3, true },
                    { 6, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1109), "product/48d85-221132_pjpeg.jpg", 3, true },
                    { 7, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1111), "product/48d85-221132_pjpeg.jpg", 4, true },
                    { 8, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1113), "product/7920f-iPhone-XI.jpeg", 4, true },
                    { 9, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1116), "product/a0915-3ff7e-1.jpg", 5, true },
                    { 10, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1118), "product/7adc3-6e4b1-Apple-IPHONE-XS-MAX-64-GB-grey.jpg", 5, true },
                    { 11, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1120), "product/be5f7-l_10185950_001.jpg", 6, true },
                    { 118, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1413), "product/ce317-srk-zspr-s-3.jpg", 71, true },
                    { 131, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1440), "product/bda07-c06179404.png", 81, true },
                    { 132, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1442), "product/96ef6-monoblok-hp-pavilion-27-xa0046ur-aio-5kp15ea-belyj-27.jpg", 81, true },
                    { 133, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1446), "product/eb436-item_XL_24487273_36024943.jpg", 82, true },
                    { 156, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1535), "product/7b8ae-61tmThxXwCL._SX425_.jpg", 102, true },
                    { 155, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1533), "product/745d0-9558d591a8eff0d270ad94a5c1896826.jpg", 101, true },
                    { 154, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1531), "product/cc70a-Xbox-One-X-600x400.jpg", 100, true },
                    { 153, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1528), "product/product11.jpg", 99, true },
                    { 152, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1526), "product/product12.jpg", 99, true },
                    { 151, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1522), "product/2e9b2-fifa2020.jpeg", 98, true },
                    { 150, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1483), "product/de456-PS-VR-1.jpg", 97, true },
                    { 149, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1481), "product/2d5ed-sony_3001560_playstation_vr_ps4_1245989.jpg", 97, true },
                    { 148, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1479), "product/1b89a-shivaki_32sh90g_2019-02-12_13-52-21.jpg", 96, true },
                    { 147, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1477), "product/a96ad-bluetooth_stereo_garnitura_awei_a990_bl_black_46.jpg", 95, true },
                    { 146, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1475), "product/d29c5-1-aiwa-jh32bt700s.jpg", 94, true },
                    { 145, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1473), "product/5a045-p1cv07udbb3p41ggd1omi3oa19kf4.jpg", 93, true },
                    { 144, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1471), "product/234fd-philips_hr1627_00_images_8734980833.jpg", 92, true },
                    { 143, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1469), "product/e0788-1cyyBR9sQRE74UHjZ3DSQ.jpg", 91, true },
                    { 142, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1466), "product/d74d6-20038860b.jpg", 90, true },
                    { 141, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1464), "product/1d986-7127109_images_1457230048.jpg", 89, true },
                    { 140, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1462), "product/87640-GC3802_27-IMS-ru_RU.jpg", 88, true },
                    { 139, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1460), "product/e48ec-6.jpg", 87, true },
                    { 138, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1458), "product/6f999-2.jpg", 86, true },
                    { 137, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1456), "product/acd36-155135057906695c77bb331062c240.jpeg", 85, true },
                    { 136, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1454), "product/54de5-Canon-i-SENSYS-MF633-Left-Large.jpg", 84, true },
                    { 135, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1452), "product/31ee5-1475c009aa-1_1_1.jpg", 84, true },
                    { 134, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1449), "product/eda36-HP-V220W-USB2.0.jpg", 83, true },
                    { 12, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1122), "product/f2ddd-l_10185951_001.jpg", 6, true },
                    { 39, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1230), "product/ad082-61jE22Q4J2L._SX425_.jpg", 23, true },
                    { 13, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1124), "product/f2ddd-l_10185951_001.jpg", 7, true },
                    { 15, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1129), "product/be5f7-l_10185950_001.jpg", 8, true },
                    { 18, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1135), "product/be5f7-l_10185950_001.jpg", 9, true },
                    { 19, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1137), "product/17122--------------iPad-6------------------------.jpg", 10, true },
                    { 20, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1140), "product/17122--------------iPad-6------------------------.jpg", 11, true },
                    { 21, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1143), "product/8dcf6-bb582ec8128fd58df69520834e1ab7ae.jpg", 12, true },
                    { 22, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1145), "product/00d79-MTPK2_VW_34FR-watch-44-alum-silver-nc-5s_VW_34FR_WF_CO.jpg", 12, true },
                    { 23, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1194), "product/50de3-44-alu-gold-sport-pink-sand-nc-s4-gallery1_GEO_GB.jpg", 13, true },
                    { 24, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1197), "product/00d79-MTPK2_VW_34FR-watch-44-alum-silver-nc-5s_VW_34FR_WF_CO.jpg", 13, true },
                    { 25, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1199), "product/a0915-3ff7e-1.jpg", 14, true },
                    { 26, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1201), "product/7adc3-6e4b1-Apple-IPHONE-XS-MAX-64-GB-grey.jpg", 14, true },
                    { 17, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1133), "product/f2ddd-l_10185951_001.jpg", 9, true },
                    { 27, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1204), "product/be5f7-l_10185950_001.jpg", 15, true },
                    { 29, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1208), "product/010bd-ddsadasdsadasdasdad.jpg", 16, true },
                    { 30, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1210), "product/8e3a1-apple-macbook-pro-15-retina.png", 16, true },
                    { 31, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1213), "product/0c1aa-Baseus-Full-Coverage-Screen-Protector.jpg", 17, true },
                    { 32, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1215), "product/43f8a-s-l1000.jpg", 18, true },
                    { 33, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1217), "product/73fd6-Wholesale-for-iPhone-8-Pin-Lightning.jpg", 19, true },
                    { 34, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1220), "product/1dfb4-2en_2.jpg", 20, true },
                    { 35, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1222), "product/6b44f-samsung-galaxy-note10-plus-aura-black.jpg", 21, true },
                    { 36, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1224), "product/90ecf-samsung-galaxy-note10-plus-aura-white.jpg", 21, true },
                    { 37, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1226), "product/9de81-samsung-galaxy-note10-aura-white.jpg", 22, true },
                    { 28, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1206), "product/f2ddd-l_10185951_001.jpg", 15, true },
                    { 14, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1127), "product/be5f7-l_10185950_001.jpg", 7, true },
                    { 158, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1540), "product/a31df-447a2b44-b89c-4b43-ab24-71789d6585cb.jpeg", 104, true },
                    { 16, new DateTime(2019, 12, 29, 16, 8, 50, 652, DateTimeKind.Local).AddTicks(1131), "product/f2ddd-l_10185951_001.jpg", 8, true }
                });

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 648, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 651, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 649, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 643, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 643, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 643, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 637, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 639, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 639, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 645, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 29, 16, 8, 50, 645, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.CreateIndex(
                name: "IX_ProductPhotos_ProductId",
                table: "ProductPhotos",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPhotos");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 28, 20, 40, 16, 342, DateTimeKind.Local).AddTicks(5618));

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
        }
    }
}
