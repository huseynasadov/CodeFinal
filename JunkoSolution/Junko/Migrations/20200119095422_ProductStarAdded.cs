using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProductStarAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StarCount",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 5, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 5, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 5, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 5, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 7, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(7576), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9688), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9720), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9725), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9729), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9733), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9737), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9741), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9874), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9879), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9883), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9888), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9893), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9896), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9900), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(1139), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2536), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2560), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2564), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2568), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2572), new DateTime(2020, 1, 19, 13, 54, 19, 6, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 11, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 19, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 19, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 19, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 19, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 19, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 19, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 9, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 20, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 12, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 18, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 13, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 16, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 14, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 17, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 8, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 8, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 8, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 18, 999, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 4, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 4, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 3, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 10, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 19, 13, 54, 19, 10, DateTimeKind.Local).AddTicks(7687));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 2, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(7368), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9571), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9604), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9611), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9615), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9620), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9624), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9805), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9809), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9813), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9818), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9822), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9826), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9830), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9834), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(276), new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(1982), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2005), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2009), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2014), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2020), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 8, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 0, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 0, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 0, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 991, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 995, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 996, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 17, 995, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 2, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 17, 16, 46, 18, 2, DateTimeKind.Local).AddTicks(9853));
        }
    }
}
