using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class UserLoginadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 798, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 793, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(9226), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1443), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1479), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1484), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1489), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1494), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1498), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1502), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1507), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1605), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1610), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1614), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1618), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1622), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1626), new DateTime(2020, 1, 7, 17, 24, 6, 795, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(2195), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3716), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3740), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3744), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3748), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3752), new DateTime(2020, 1, 7, 17, 24, 6, 794, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 807, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 807, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 807, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 807, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 807, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 809, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 797, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 808, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 800, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 806, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 801, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 804, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 802, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 803, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 805, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 796, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 796, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 796, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 651, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 792, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 792, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 791, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 17, 24, 6, 799, DateTimeKind.Local).AddTicks(1713));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 375, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 370, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(9611), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1781), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1817), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1821), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1826), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1831), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1835), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1839), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1843), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1847), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1851), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1855), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1859), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1863), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1867), new DateTime(2020, 1, 7, 16, 55, 22, 372, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(2876), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4560), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4582), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4589), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4594), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4597), new DateTime(2020, 1, 7, 16, 55, 22, 371, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 384, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 384, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 384, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 384, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 384, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 384, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 374, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 385, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 377, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 383, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 378, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 381, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 379, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 382, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 373, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 373, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 373, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 364, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 369, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 369, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 368, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 375, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 7, 16, 55, 22, 376, DateTimeKind.Local).AddTicks(1046));
        }
    }
}
