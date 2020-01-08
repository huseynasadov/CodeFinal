using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class UserAdressadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "UserClients",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 693, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(9864), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2141), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2183), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2187), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2191), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2249), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2253), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2257), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2261), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2266), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2271), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2275), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2279), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2283), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2287), new DateTime(2020, 1, 3, 13, 10, 38, 695, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(2829), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4410), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4441), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4446), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4451), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4455), new DateTime(2020, 1, 3, 13, 10, 38, 694, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 699, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 696, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 697, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 706, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 700, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 705, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 701, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 703, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 702, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 704, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 696, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 696, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 696, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 690, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 692, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 692, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 698, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 13, 10, 38, 698, DateTimeKind.Local).AddTicks(5286));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "UserClients");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 139, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(9595), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1911), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1945), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1949), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1953), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1958), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1961), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1965), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1969), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1973), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1977), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1981), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1985), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1989), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1993), new DateTime(2020, 1, 2, 19, 7, 24, 141, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(2688), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4190), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4213), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4217), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4222), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4292), new DateTime(2020, 1, 2, 19, 7, 24, 140, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 145, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 143, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 153, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 146, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 151, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 147, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 149, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 148, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 142, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 142, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 142, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 136, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 138, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 138, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 144, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 2, 19, 7, 24, 144, DateTimeKind.Local).AddTicks(6234));
        }
    }
}
