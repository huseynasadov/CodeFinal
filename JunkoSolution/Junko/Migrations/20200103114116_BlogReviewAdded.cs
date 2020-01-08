using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class BlogReviewAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    BlogId = table.Column<int>(nullable: false),
                    UserClientId = table.Column<int>(nullable: true),
                    AdminManagerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogReviews_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogReviews_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogReviews_UserClients_UserClientId",
                        column: x => x.UserClientId,
                        principalTable: "UserClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 955, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 955, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 955, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 955, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.InsertData(
                table: "BlogReviews",
                columns: new[] { "Id", "AdminManagerId", "BlogId", "Content", "CreatedAt", "UserClientId" },
                values: new object[] { 3, 1, 1, "Vnunc vitae erat pellentesque, ac placerat arcu consectetur", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2669), null });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(4960), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7029), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7064), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7069), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7074), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7078), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7081), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7086), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7090), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7094), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7097), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7102), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7107), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7112), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7115), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 955, DateTimeKind.Local).AddTicks(9009), new DateTime(2020, 1, 3, 15, 41, 12, 955, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(344), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(366), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(370), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(374), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(378), new DateTime(2020, 1, 3, 15, 41, 12, 956, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 967, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 958, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 959, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 968, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 961, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 966, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 962, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 963, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 965, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 958, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 958, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 958, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 947, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 953, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 954, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.InsertData(
                table: "UserClients",
                columns: new[] { "Id", "Address", "Birthday", "CreatedAt", "Email", "Firstname", "Gender", "Lastname", "Password", "Token" },
                values: new object[] { 1, "Sumqayit seheri H.Z.Tagiyev Qesesebesi", new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 3, 15, 41, 12, 953, DateTimeKind.Local).AddTicks(1845), "Huseynis@code.edu.az", "Huseyn", 0, "Asadov", "AIdRrgaJylkMlIfb0SOtVptIxShQUR06oD9A8EenQfuWYy4/Avoa01hQKAknD9Nxqw==", null });

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 3, 15, 41, 12, 960, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.InsertData(
                table: "BlogReviews",
                columns: new[] { "Id", "AdminManagerId", "BlogId", "Content", "CreatedAt", "UserClientId" },
                values: new object[,]
                {
                    { 1, null, 1, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(1100), 1 },
                    { 2, null, 1, "Quisque semper nunc vitae erat pellentesque, ac placerat arcu consectetur", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(1918), 1 },
                    { 4, null, 2, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2682), 1 },
                    { 5, null, 3, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2685), 1 },
                    { 6, null, 4, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2688), 1 },
                    { 7, null, 5, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2690), 1 },
                    { 8, null, 6, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2693), 1 },
                    { 9, null, 7, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2695), 1 },
                    { 10, null, 8, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2697), 1 },
                    { 11, null, 9, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2700), 1 },
                    { 12, null, 10, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 3, 15, 41, 12, 957, DateTimeKind.Local).AddTicks(2702), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogReviews_AdminManagerId",
                table: "BlogReviews",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogReviews_BlogId",
                table: "BlogReviews",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogReviews_UserClientId",
                table: "BlogReviews",
                column: "UserClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogReviews");

            migrationBuilder.DeleteData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
