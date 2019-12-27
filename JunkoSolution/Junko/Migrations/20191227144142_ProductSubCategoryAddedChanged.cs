using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProductSubCategoryAddedChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "ProductSubCategoryTranslate",
                keyColumn: "Id",
                keyValue: 112,
                column: "ProductSubCategoryId",
                value: 56);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "ProductSubCategory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 27, 18, 36, 15, 649, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductSubCategoryTranslate",
                keyColumn: "Id",
                keyValue: 112,
                column: "ProductSubCategoryId",
                value: 36);

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
        }
    }
}
