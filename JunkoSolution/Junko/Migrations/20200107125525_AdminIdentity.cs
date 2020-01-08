using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class AdminIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    AppAdminId = table.Column<string>(nullable: true),
                    Ocupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 57, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 52, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 52, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 52, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 52, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 54, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(7506), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9661), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9697), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9701), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9705), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9709), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9713), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9718), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9723), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9727), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9731), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9736), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9740), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9743), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9748), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(745), new DateTime(2020, 1, 6, 20, 19, 59, 52, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2222), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2243), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2338), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2342), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2347), new DateTime(2020, 1, 6, 20, 19, 59, 53, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 58, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 67, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 67, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 67, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 67, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 67, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 67, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 56, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 68, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 59, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 66, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 60, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 63, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 61, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 64, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 65, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 55, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 55, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 55, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 43, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 50, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 51, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 50, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 57, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 6, 20, 19, 59, 57, DateTimeKind.Local).AddTicks(8501));
        }
    }
}
