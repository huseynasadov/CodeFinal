using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ProperityProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProperityProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProperityId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Key = table.Column<string>(maxLength: 400, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProperityProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProperityProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProperityProducts_Properities_ProperityId",
                        column: x => x.ProperityId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(maxLength: 250, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Token = table.Column<string>(maxLength: 400, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClients", x => x.Id);
                });

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
                columns: new[] { "ModifiedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(8945), "slider/slider4.jpg" });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Order", "Photo" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9763), 2, "slider/slider5.jpg" });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9784), "slider/slider6.jpg" });

            migrationBuilder.InsertData(
                table: "HomeHeaders",
                columns: new[] { "Id", "ModifiedAt", "Order", "Photo", "ProductId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9787), 4, "slider/slider2.jpg", 43 },
                    { 6, new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9790), 5, "slider/slider17.jpg", 75 },
                    { 7, new DateTime(2020, 1, 2, 19, 7, 24, 152, DateTimeKind.Local).AddTicks(9792), 6, "slider/slider1.jpg", 34 }
                });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1817), 17m });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1845), 12m });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1880), 4m });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(1910), 15m });

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

            migrationBuilder.InsertData(
                table: "ProperityProducts",
                columns: new[] { "Id", "CreatedAt", "Key", "ProductId", "ProperityId" },
                values: new object[,]
                {
                    { 14, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7258), "5.0, A2DP, LE", 1, 14 },
                    { 13, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7256), "Wi-Fi 802.11 a/b/g/n/ac/ax, dual-band, hotspot", 1, 13 },
                    { 12, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7253), "12 MP, f/2.2 TOF 3D camera", 1, 12 },
                    { 11, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7251), "2160p@24/30/60fps, 1080p@30/60/120/240fps, HDR, stereo sound rec.", 1, 11 },
                    { 10, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7249), "12 MP, f/1.8, 26mm (wide), 1/2.55", 1, 10 },
                    { 9, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7247), "-", 1, 9 },
                    { 5, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7238), "Apple A13 Bionic (7 nm+)", 1, 5 },
                    { 7, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7242), "256 GB", 1, 7 },
                    { 6, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7240), "Hexa-core (2x2.65 GHz Lightning + 4x1.8 GHz Thunder)", 1, 6 },
                    { 15, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7260), "Non-removable Li-Ion 3969 mAh battery (15.04 Wh)", 1, 15 },
                    { 4, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7235), "iOS 13, upgradable to iOS 13.1", 1, 4 },
                    { 3, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7232), "Single SIM  or Dual SIM", 1, 3 },
                    { 2, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7211), "226 g (7.97 oz)", 1, 2 },
                    { 1, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(6378), "158 x 77.8 x 8.1 mm (6.22 x 3.06 x 0.32 in)", 1, 1 },
                    { 8, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7244), "4 GB RAM", 1, 8 },
                    { 16, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7262), "Intel Core i7,2.6Ghz", 16, 5 },
                    { 20, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7272), "Wi-Fi / LAN / BT", 16, 32 },
                    { 18, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7267), "16 GB", 16, 8 },
                    { 29, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7293), "1452.7 x 918.1 x 312.8 mm", 34, 1 },
                    { 17, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7264), "512 GB SSD", 16, 7 },
                    { 27, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7288), "-", 34, 39 },
                    { 26, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7286), "+", 34, 38 },
                    { 25, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7284), "USB, HDMI", 34, 37 },
                    { 28, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7290), "AVI, DivX, MKV, MPEG4,MP3,WMA,JPEG", 34, 40 },
                    { 23, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7280), "100 Hz", 34, 35 },
                    { 22, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7277), "LED", 34, 34 },
                    { 21, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7274), "65(164 sm)", 34, 16 },
                    { 19, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7269), "USB, HDMI, VGA", 16, 31 },
                    { 24, new DateTime(2020, 1, 2, 19, 7, 24, 150, DateTimeKind.Local).AddTicks(7282), "+", 34, 36 }
                });

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

            migrationBuilder.InsertData(
                table: "HomeHeaderTranslates",
                columns: new[] { "Id", "HomeHeaderId", "LanguageId", "Title" },
                values: new object[,]
                {
                    { 7, 5, 1, "New 2019" },
                    { 9, 5, 2, "Yeni 2019" },
                    { 8, 6, 1, "Sale Off Laptop" },
                    { 10, 6, 2, "Endirimli" },
                    { 11, 7, 1, "Sale Off Laptop" },
                    { 12, 7, 2, "Endirimli" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProperityProducts_ProductId",
                table: "ProperityProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityProducts_ProperityId",
                table: "ProperityProducts",
                column: "ProperityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProperityProducts");

            migrationBuilder.DropTable(
                name: "UserClients");

            migrationBuilder.DeleteData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HomeHeaderTranslates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7);

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
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(9124), "slider/slider4" });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Order", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(9964), null, "slider/slider5" });

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedAt", "Photo" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 94, DateTimeKind.Local).AddTicks(9996), "slider/slider6" });

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
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7919));

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
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 10, 44, 3, 88, DateTimeKind.Local).AddTicks(7929));

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5646), 1m });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5678), 1m });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5718), 1m });

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
                columns: new[] { "CreatedAt", "FollowCount" },
                values: new object[] { new DateTime(2020, 1, 1, 10, 44, 3, 92, DateTimeKind.Local).AddTicks(5747), 1m });

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
    }
}
