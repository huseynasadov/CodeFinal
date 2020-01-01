using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class HomeHeaderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "HomeHeaders",
                maxLength: 250,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 81, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(9510), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1798), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1834), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1839), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1843), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1847), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1851), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1855), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1859), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1863), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1868), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1871), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1876), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1881), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1885), new DateTime(2020, 1, 1, 10, 44, 3, 83, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(2400), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3969), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3992), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3996), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(4000), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(4004), new DateTime(2020, 1, 1, 10, 44, 3, 82, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 87, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Əla Dizayn");

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedAt", "Photo", "ProductId" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(9124), "slider/slider4", 56 });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Order", "Photo", "ProductId" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(9964), null, "slider/slider5", 24 });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedAt", "Photo", "ProductId" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(9996), "slider/slider6", 77 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 85, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 95, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7919), "category/9ca97-kicik-meiset-esyalari.png" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7924), "category/0427b-simcart.png" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7926), "category/6e7e5-icon.png" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7929), "category/581ea-barcode_scanner.png" });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 93, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 89, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 90, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 84, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 84, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 84, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 77, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 79, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 79, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 86, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 86, DateTimeKind.Local).AddTicks(7557));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "HomeHeaders");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 991, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 987, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 987, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 987, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 987, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(6561), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8526), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8560), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8564), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8568), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8572), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8576), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8579), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8584), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8638), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8642), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8646), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8650), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8654), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8657), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 987, DateTimeKind.Local).AddTicks(9817), new DateTime(2019, 12, 31, 15, 24, 48, 987, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1219), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1243), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1247), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1250), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1254), new DateTime(2019, 12, 31, 15, 24, 48, 988, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 992, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Ən yaxşı Görünüş");

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedAt", "ProductId" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(3025), 32 });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Order", "ProductId" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(3776), 2, 1 });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedAt", "ProductId" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(3796), 33 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 990, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 999, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8275), "9ca97-kicik-meiset-esyalari.png" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8280), "0427b-simcart.png" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8283), "6e7e5-icon.png" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 31, 15, 24, 48, 993, DateTimeKind.Local).AddTicks(8285), "581ea-barcode_scanner.png" });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 998, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 994, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 996, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 997, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 995, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 989, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 989, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 989, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 984, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 985, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 986, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 991, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 31, 15, 24, 48, 991, DateTimeKind.Local).AddTicks(9647));
        }
    }
}
