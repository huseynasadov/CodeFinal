using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class BlogServiceTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LanguageCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminManagers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminCategoryId = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 250, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Photo = table.Column<string>(maxLength: 300, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeadLineAt = table.Column<DateTime>(nullable: true),
                    Token = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminManagers_AdminCategories_AdminCategoryId",
                        column: x => x.AdminCategoryId,
                        principalTable: "AdminCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminCategoryTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminCategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCategoryTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminCategoryTranslates_AdminCategories_AdminCategoryId",
                        column: x => x.AdminCategoryId,
                        principalTable: "AdminCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(maxLength: 400, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OurServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Icon = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OurServices_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicesCovers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(maxLength: 250, nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesCovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicesCovers_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Logo = table.Column<string>(maxLength: 50, nullable: false),
                    PhotoLogo = table.Column<string>(maxLength: 250, nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setting_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Desc = table.Column<string>(maxLength: 700, nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTranslates_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    BlogId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCategories_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogCategories_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategoryTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategoryTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCategoryTranslates_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OurServiceTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OurServiceId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Desc = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServiceTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OurServiceTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OurServiceTranslates_OurServices_OurServiceId",
                        column: x => x.OurServiceId,
                        principalTable: "OurServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicesCoverTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesCoverId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Desc = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesCoverTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicesCoverTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicesCoverTranslates_ServicesCovers_ServicesCoverId",
                        column: x => x.ServicesCoverId,
                        principalTable: "ServicesCovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SettingTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    SettingId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 300, nullable: false),
                    FAQTitle = table.Column<string>(maxLength: 200, nullable: true),
                    FAQContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettingTranslates_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SettingTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SettingTranslates_Setting_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Setting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialActivities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    SettingId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Link = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialActivities_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SocialActivities_Setting_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Setting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdminCategories",
                columns: new[] { "Id", "Status" },
                values: new object[] { 1, true });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageCode", "Name" },
                values: new object[,]
                {
                    { 1, "en-US", "English" },
                    { 2, "az-Latn-AZ", "Azerbaijan" }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "AdminManagerId", "Email", "Location", "Logo", "ModifiedAt", "Phone", "PhotoLogo" },
                values: new object[] { 1, null, "Junko@mail.com", "Code Academy", "Junko", new DateTime(2019, 12, 25, 11, 13, 27, 432, DateTimeKind.Local).AddTicks(5159), "+994 50 787 01 81", "logo/logo.png" });

            migrationBuilder.InsertData(
                table: "AdminCategoryTranslates",
                columns: new[] { "Id", "AdminCategoryId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Director" },
                    { 2, 1, 2, "Direktor" }
                });

            migrationBuilder.InsertData(
                table: "AdminManagers",
                columns: new[] { "Id", "AdminCategoryId", "CreatedAt", "DeadLineAt", "Email", "Firstname", "Lastname", "Password", "Phone", "Photo", "Status", "Token" },
                values: new object[] { 1, 1, new DateTime(2019, 12, 25, 11, 13, 27, 435, DateTimeKind.Local).AddTicks(2401), null, "Huseynia@code.edu.az", "Huseyn", "Asadov", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "download.jpeg", true, null });

            migrationBuilder.InsertData(
                table: "SettingTranslates",
                columns: new[] { "Id", "Address", "AdminManagerId", "FAQContent", "FAQTitle", "LanguageId", "ModifiedAt", "SettingId" },
                values: new object[,]
                {
                    { 1, " Nizami street 203B, AF Business House", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec id erat sagittis, faucibus metus malesuada, eleifend turpis. Mauris semper augue id nisl aliquet, a porta lectus mattis. Nulla at tortor augue. In eget enim diam. Donec gravida tortor sem, ac fermentum nibh rutrum sit amet. Nulla convallis mauris vitae congue consequat. Donec interdum nunc purus, vitae vulputate arcu fringilla quis. Vivamus iaculis euismod dui.", "Below are frequently asked questions, you may find the answer for yourself", 1, new DateTime(2019, 12, 25, 11, 13, 27, 434, DateTimeKind.Local).AddTicks(1660), 1 },
                    { 2, " Nizami küç. 203B, AF Business House, 2-ci mərtəbə", null, "", "Aşağıda tez-tez verilən suallarla özünüz üçün cavab tapa bilərsiniz", 2, new DateTime(2019, 12, 25, 11, 13, 27, 434, DateTimeKind.Local).AddTicks(1758), 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialActivities",
                columns: new[] { "Id", "AdminManagerId", "Link", "ModifiedAt", "Name", "SettingId" },
                values: new object[,]
                {
                    { 1, null, "https://www.facebook.com/", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facebook", 1 },
                    { 2, null, "https://twitter.com/?lang=en", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "twitter", 1 },
                    { 3, null, "https://www.instagram.com/", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "instagram", 1 },
                    { 4, null, "https://www.linkedin.com/feed/", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "linkedin", 1 },
                    { 5, null, "https://www.google.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "google", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(6506), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(6495), "blog/blog1.jpg", true },
                    { 15, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8567), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8566), "blog/blog5.jpg", true },
                    { 14, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8564), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8562), "blog/blog4.jpg", true },
                    { 13, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8560), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8558), "blog/blog3.jpg", true },
                    { 12, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8556), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8555), "blog/blog2.jpg", true },
                    { 10, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8549), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8548), "blog/blog5.jpg", true },
                    { 9, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8546), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8544), "blog/blog4.jpg", true },
                    { 11, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8553), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8551), "blog/blog1.jpg", true },
                    { 7, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8539), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8537), "blog/blog2.jpg", true },
                    { 6, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8535), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8533), "blog/blog1.jpg", true },
                    { 5, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8531), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8530), "blog/blog5.jpg", true },
                    { 4, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8527), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8526), "blog/blog4.jpg", true },
                    { 3, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8523), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8522), "blog/blog3.jpg", true },
                    { 2, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8492), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8481), "blog/blog2.jpg", true },
                    { 8, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8542), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8541), "blog/blog3.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Status" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1786), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1784), true },
                    { 1, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(426), new DateTime(2019, 12, 25, 11, 13, 27, 435, DateTimeKind.Local).AddTicks(9699), true },
                    { 2, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1756), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1736), true },
                    { 3, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1778), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1776), true },
                    { 4, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1782), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1780), true },
                    { 6, 1, new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1789), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1787), true }
                });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "Id", "AdminManagerId", "BlogId", "CategoryId", "ModifiedAt" },
                values: new object[,]
                {
                    { 21, 1, 15, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, 12, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, 14, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 13, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BlogCategoryTranslates",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 6, 3, 2, "Qalareya" },
                    { 5, 3, 1, "Gallery" },
                    { 10, 5, 2, "Digər" },
                    { 9, 5, 1, "Other" },
                    { 4, 2, 2, "Şirkət" },
                    { 3, 2, 1, "Company" },
                    { 11, 6, 1, "Video" },
                    { 12, 6, 2, "Video" },
                    { 7, 4, 1, "Travel" },
                    { 8, 4, 2, "Səyahət" },
                    { 2, 1, 2, "Audio" },
                    { 1, 1, 1, "Audio" }
                });

            migrationBuilder.InsertData(
                table: "BlogTranslates",
                columns: new[] { "Id", "BlogId", "Content", "Desc", "LanguageId", "Title" },
                values: new object[,]
                {
                    { 32, 15, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Yeni paylaşım" },
                    { 17, 1, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Xəbər Şəkil Paylaşımı" },
                    { 2, 2, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Post With Gallery" },
                    { 18, 2, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Qalareya Paylaşımı" },
                    { 3, 3, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Maecenas Ultricies" },
                    { 19, 3, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Texniki Paylaşım" },
                    { 4, 4, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Post With Audio" },
                    { 20, 4, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Elektrotexnika" },
                    { 5, 5, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Praesent Imperdiet" },
                    { 21, 5, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Yeni Robotlar" },
                    { 6, 6, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Gallery Post" },
                    { 23, 6, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Yeni İphone 11" },
                    { 7, 7, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Ultricies Maecenas" },
                    { 24, 7, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Səyahət Paylaşımı" },
                    { 8, 8, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, " Audio Post" },
                    { 9, 9, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Image Post" },
                    { 26, 9, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Yeni trendlər" },
                    { 10, 10, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Other Post" },
                    { 27, 10, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Digər Paylaşım" },
                    { 11, 11, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Sticy Post" },
                    { 28, 11, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Robot istehsalı" },
                    { 12, 12, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Travel Post" },
                    { 29, 12, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Avadanlıqlar" },
                    { 13, 13, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Blog with Travel" },
                    { 30, 13, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Aksesuarlar" },
                    { 14, 14, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Wordpress Post" },
                    { 31, 14, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Yeni Tozsoran" },
                    { 15, 15, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Company Post" },
                    { 25, 8, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Şirkətlər" },
                    { 1, 1, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Blog Image Post (Sticky)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminCategoryTranslates_AdminCategoryId",
                table: "AdminCategoryTranslates",
                column: "AdminCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCategoryTranslates_LanguageId",
                table: "AdminCategoryTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminManagers_AdminCategoryId",
                table: "AdminManagers",
                column: "AdminCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_AdminManagerId",
                table: "BlogCategories",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_BlogId",
                table: "BlogCategories",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_CategoryId",
                table: "BlogCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategoryTranslates_CategoryId",
                table: "BlogCategoryTranslates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategoryTranslates_LanguageId",
                table: "BlogCategoryTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AdminManagerId",
                table: "Blogs",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTranslates_BlogId",
                table: "BlogTranslates",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTranslates_LanguageId",
                table: "BlogTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AdminManagerId",
                table: "Categories",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_OurServices_AdminManagerId",
                table: "OurServices",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_OurServiceTranslates_LanguageId",
                table: "OurServiceTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OurServiceTranslates_OurServiceId",
                table: "OurServiceTranslates",
                column: "OurServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesCovers_AdminManagerId",
                table: "ServicesCovers",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesCoverTranslates_LanguageId",
                table: "ServicesCoverTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesCoverTranslates_ServicesCoverId",
                table: "ServicesCoverTranslates",
                column: "ServicesCoverId");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_AdminManagerId",
                table: "Setting",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingTranslates_AdminManagerId",
                table: "SettingTranslates",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingTranslates_LanguageId",
                table: "SettingTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingTranslates_SettingId",
                table: "SettingTranslates",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialActivities_AdminManagerId",
                table: "SocialActivities",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialActivities_SettingId",
                table: "SocialActivities",
                column: "SettingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminCategoryTranslates");

            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "BlogCategoryTranslates");

            migrationBuilder.DropTable(
                name: "BlogTranslates");

            migrationBuilder.DropTable(
                name: "OurServiceTranslates");

            migrationBuilder.DropTable(
                name: "ServicesCoverTranslates");

            migrationBuilder.DropTable(
                name: "SettingTranslates");

            migrationBuilder.DropTable(
                name: "SocialActivities");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "OurServices");

            migrationBuilder.DropTable(
                name: "ServicesCovers");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "AdminManagers");

            migrationBuilder.DropTable(
                name: "AdminCategories");
        }
    }
}
