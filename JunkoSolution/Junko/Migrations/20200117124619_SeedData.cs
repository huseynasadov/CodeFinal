using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class SeedData : Migration
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
                    Ocupation = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Code = table.Column<string>(maxLength: 40, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
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
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Token = table.Column<string>(maxLength: 400, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClients", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "AdminCategoryTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminCategoryId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSettings_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Slug = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_AdminManagers_AdminManagerId",
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
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faqs_AdminManagers_AdminManagerId",
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
                    Status = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
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
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Photo = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partners_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properities_AdminManagers_AdminManagerId",
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
                    Status = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
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
                    PhotoLogo = table.Column<string>(maxLength: 250, nullable: true),
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
                name: "WhatDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(maxLength: 300, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: true),
                    WhatDoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatDos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatDos_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WhatDos_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WhatDos_WhatDos_WhatDoId",
                        column: x => x.WhatDoId,
                        principalTable: "WhatDos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AboutSettingTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutSettingId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Desc = table.Column<string>(maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSettingTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSettingTranslates_AboutSettings_AboutSettingId",
                        column: x => x.AboutSettingId,
                        principalTable: "AboutSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AboutSettingTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "BlogTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Slug = table.Column<string>(maxLength: 300, nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                    CategoryId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaqTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaqId = table.Column<int>(nullable: true),
                    LanguageeId = table.Column<int>(nullable: false),
                    Question = table.Column<string>(maxLength: 100, nullable: false),
                    Answer = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaqTranslates_Faqs_FaqId",
                        column: x => x.FaqId,
                        principalTable: "Faqs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FaqTranslates_Languages_LanguageeId",
                        column: x => x.LanguageeId,
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
                    OurServiceId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Slug = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslates_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(maxLength: 250, nullable: true),
                    Discount = table.Column<byte>(nullable: true),
                    DiscountDate = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProperityTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProperityId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Slug = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProperityTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProperityTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProperityTranslates_Properities_ProperityId",
                        column: x => x.ProperityId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicesCoverTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesCoverId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
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
                    FAQContent = table.Column<string>(nullable: true),
                    Privacy = table.Column<string>(type: "ntext", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "WhatDosTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhatDoId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Desc = table.Column<string>(maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatDosTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatDosTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WhatDosTranslates_WhatDos_WhatDoId",
                        column: x => x.WhatDoId,
                        principalTable: "WhatDos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BrandProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(nullable: false),
                    ProductSubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandProductCategories_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandProductCategories_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategoryTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSubCategoryId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategoryTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategoryTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProperityCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProperityId = table.Column<int>(nullable: false),
                    ProductSubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProperityCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProperityCategories_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProperityCategories_Properities_ProperityId",
                        column: x => x.ProperityId,
                        principalTable: "Properities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminManagerId = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Slug = table.Column<string>(maxLength: 100, nullable: false),
                    BrandProductCategoryId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<byte>(nullable: true),
                    DiscountDate = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    FollowCount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_BrandProductCategories_BrandProductCategoryId",
                        column: x => x.BrandProductCategoryId,
                        principalTable: "BrandProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(maxLength: 250, nullable: true),
                    Order = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeHeaders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserClientId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Complete = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_UserClients_UserClientId",
                        column: x => x.UserClientId,
                        principalTable: "UserClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    UserClientId = table.Column<int>(nullable: true),
                    AdminManagerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviews_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductReviews_UserClients_UserClientId",
                        column: x => x.UserClientId,
                        principalTable: "UserClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "HomeHeaderTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeHeaderId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeHeaderTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeHeaderTranslates_HomeHeaders_HomeHeaderId",
                        column: x => x.HomeHeaderId,
                        principalTable: "HomeHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomeHeaderTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdminCategories",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, true },
                    { 2, true },
                    { 3, true },
                    { 4, true }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "CreatedAt", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "#000000", new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(5463), "Black", true },
                    { 2, "#bebebe", new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6883), "Grey", true },
                    { 3, "#fe0000", new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6908), "Red", true },
                    { 4, "#ffff01", new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6957), "Yellow", true },
                    { 5, "#fff", new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(6960), "White", true }
                });

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
                values: new object[] { 1, null, "Junko@mail.com", "Code Academy", "Junko", new DateTime(2020, 1, 17, 16, 46, 17, 991, DateTimeKind.Local).AddTicks(601), "+994 50 787 01 81", "logo/logo.png" });

            migrationBuilder.InsertData(
                table: "UserClients",
                columns: new[] { "Id", "Address", "Birthday", "CreatedAt", "Email", "Firstname", "Gender", "Lastname", "Password", "Token" },
                values: new object[] { 1, "Sumqayit seheri H.Z.Tagiyev Qesesebesi", new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 17, 16, 46, 17, 995, DateTimeKind.Local).AddTicks(406), "Huseynis@code.edu.az", "Huseyn", 0, "Asadov", "AIdRrgaJylkMlIfb0SOtVptIxShQUR06oD9A8EenQfuWYy4/Avoa01hQKAknD9Nxqw==", null });

            migrationBuilder.InsertData(
                table: "AdminCategoryTranslates",
                columns: new[] { "Id", "AdminCategoryId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 4, 2, 2, "Dizayner" },
                    { 8, 4, 2, "Mühasib" },
                    { 6, 3, 2, "Proqramçı" },
                    { 2, 1, 2, "Direktor" },
                    { 1, 1, 1, "Director" },
                    { 3, 2, 1, "Designer" },
                    { 5, 3, 1, "Developer" },
                    { 7, 4, 1, "Accountant" }
                });

            migrationBuilder.InsertData(
                table: "AdminManagers",
                columns: new[] { "Id", "AdminCategoryId", "CreatedAt", "DeadLineAt", "Email", "Firstname", "Lastname", "Password", "Phone", "Photo", "Status", "Token" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(2052), null, "Huseynia@code.edu.az", "Huseyn", "Asadov", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person1.png", true, null },
                    { 3, 3, new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(8318), null, "Michael@code.edu.az", "Michael", "Monroe", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person3.png", true, null },
                    { 2, 2, new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(8184), null, "Mary@code.edu.az", "Marilyn", "monroe", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person2.png", true, null },
                    { 4, 4, new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(8324), null, "James@code.edu.az", "James", "James", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person4.png", true, null }
                });

            migrationBuilder.InsertData(
                table: "SettingTranslates",
                columns: new[] { "Id", "Address", "AdminManagerId", "FAQContent", "FAQTitle", "LanguageId", "ModifiedAt", "Privacy", "SettingId" },
                values: new object[,]
                {
                    { 1, " Nizami street 203B, AF Business House", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec id erat sagittis, faucibus metus malesuada, eleifend turpis. Mauris semper augue id nisl aliquet, a porta lectus mattis. Nulla at tortor augue. In eget enim diam. Donec gravida tortor sem, ac fermentum nibh rutrum sit amet. Nulla convallis mauris vitae congue consequat. Donec interdum nunc purus, vitae vulputate arcu fringilla quis. Vivamus iaculis euismod dui.", "Below are frequently asked questions, you may find the answer for yourself", 1, new DateTime(2020, 1, 17, 16, 46, 17, 995, DateTimeKind.Local).AddTicks(9307), "<div class='privacy_content section_1'> <h2>Who we are</h2> <p>Our website address is: <a href='http://1.envato.market/9LbxW'>http://1.envato.market/9LbxW</a></p> </div> <div class='privacy_content section_2'> <h2>What personal data we collect and why we collect it</h2> <h3>Comments</h3> <p>When visitors leave comments on the site we collect the data shown in the comments form, and also the visitor’s IP address and browser user agent string to help spam detection.</p> <p>An anonymized string created from your email address (also called a hash) may be provided to the Gravatar service to see if you are using it. The Gravatar service privacy policy is available here: https://automattic.com/privacy/. After approval of your comment, your profile picture is visible to the public in the context of your comment.</p> <h3>Media</h3> <p>If you upload images to the website, you should avoid uploading images with embedded location data (EXIF GPS) included. Visitors to the website can download and extract any location data from images on the website.</p> <h3>Cookies</h3> <p>If you leave a comment on our site you may opt-in to saving your name, email address and website in cookies. These are for your convenience so that you do not have to fill in your details again when you leave another comment. These cookies will last for one year.</p> <p>If you have an account and you log in to this site, we will set a temporary cookie to determine if your browser accepts cookies. This cookie contains no personal data and is discarded when you close your browser.</p> <p>When you log in, we will also set up several cookies to save your login information and your screen display choices. Login cookies last for two days, and screen options cookies last for a year. If you select “Remember Me”, your login will persist for two weeks. If you log out of your account, the login cookies will be removed.</p> <p>If you edit or publish an article, an additional cookie will be saved in your browser. This cookie includes no personal data and simply indicates the post ID of the article you just edited. It expires after 1 day.</p> <h3>Embedded content from other websites</h3> <p>Articles on this site may include embedded content (e.g. videos, images, articles, etc.). Embedded content from other websites behaves in the exact same way as if the visitor has visited the other website.</p> <p>These websites may collect data about you, use cookies, embed additional third-party tracking, and monitor your interaction with that embedded content, including tracking your interaction with the embedded content if you have an account and are logged in to that website.</p> </div> <div class='privacy_content section_3'> <h2>How long we retain your data</h2> <p>If you leave a comment, the comment and its metadata are retained indefinitely. This is so we can recognize and approve any follow-up comments automatically instead of holding them in a moderation queue.</p> <p>For UserClients that register on our website (if any), we also store the personal information they provide in their user profile. All UserClients can see, edit, or delete their personal information at any time (except they cannot change their username). Website administrators can also see and edit that information.</p> </div> <div class='privacy_content section_3'> <h2>What rights you have over your data</h2> <p>If you have an account on this site, or have left comments, you can request to receive an exported file of the personal data we hold about you, including any data you have provided to us. You can also request that we erase any personal data we hold about you. This does not include any data we are obliged to keep for administrative, legal, or security purposes.</p> </div> <div class='privacy_content section_3'> <h2>Where we send your data</h2> <p>Visitor comments may be checked through an automated spam detection service.</p> </div>", 1 },
                    { 2, " Nizami küç. 203B, AF Business House, 2-ci mərtəbə", null, "", "Aşağıda tez-tez verilən suallarla özünüz üçün cavab tapa bilərsiniz", 2, new DateTime(2020, 1, 17, 16, 46, 17, 996, DateTimeKind.Local).AddTicks(139), "<div class='privacy_content section_1'> <h2>Biz kimik</h2> <p>Veb saytımızın ünvanı: <a href='http://1.envato.market/9LbxW'>http://1.envato.market/9LbxW</a></p> </div> <div class='privacy_content section_2'> <h2>Hansı şəxsi məlumatları toplayırıq və niyə toplayırıq</h2> <h3>Şərhlər</h3> <p>Saytda şərhlər buraxdıqda, şərh şəklində göstərilən məlumatları, həmçinin spamın aşkarlanmasına kömək etmək üçün ziyarətçinin IP ünvanı və brauzer istifadəçi agenti simini toplayırıq.Elektron poçtunuzun adından yaradılan bir anonim simli (hash adlanır) istifadə etdiyinizi görmək üçün Gravatar xidmətinə verilə bilər. Gravatar xidmətinin məxfilik siyasəti ilə burada tanış olmaq mümkündür: https://automattic.com/privacy/. Şərhiniz təsdiqləndikdən sonra profil şəkliniz şərhiniz daxilində ictimaiyyətə görünəcəkdir.</p> <h3>Media</h3> <p>Şəkilləri veb saytına yükləsəniz, daxil edilmiş məlumat məlumatları (EXIF GPS) daxil edilmiş şəkilləri yükləməkdən çəkinməlisiniz. Veb saytına daxil olanlar veb saytdakı şəkillərdən hər hansı bir yer məlumatını yükləyə və çıxara bilər.</p> <h3>Cookies</h3> <p>Saytımızda bir rəy yazsanız, adınızı, e-poçt adresinizi və veb saytınızı çərəzlərdə saxlamaq üçün iştirak edə bilərsiniz. Bunlar sizin rahatlığınız üçündür ki, başqa bir şərh yazanda yenidən məlumatlarınızı doldurmamalısınız. Bu peçenye bir il davam edəcəkdir.Bir hesabınız varsa və bu sayta daxil olsanız, brauzerinizin çerezləri qəbul edib etmədiyini müəyyənləşdirmək üçün müvəqqəti bir çərəz hazırlayacağıq. Bu çerezdə şəxsi məlumat yoxdur və brauzerinizi bağladığınız zaman atılır.Giriş etdiyiniz zaman giriş məlumatlarınızı və ekrandakı seçimlərinizi saxlamaq üçün bir neçə çərəz hazırlayacağıq. Giriş peçenye iki gün davam edir və ekran seçimləri peçenye bir il davam edir. 'Məni yadda saxla' seçsəniz, girişiniz iki həftə davam edəcəkdir. Hesabınızdan çıxsanız, giriş cookies-ləri silinəcəkdir.Bir məqaləni redaktə etsəniz və ya dərc etsəniz, əlavə bir çərəz brauzerinizdə saxlanacaqdır. Bu çerez heç bir şəxsi məlumatı ehtiva etmir və sadəcə redaktə etdiyiniz məqalənin poçt nömrəsini göstərir. 1 gündən sonra bitəcək.</p> <h3>Digər veb saytlardan daxil edilmiş məzmun</h3> <p>Bu saytdakı məqalələr əlaqədar məzmunu ehtiva edə bilər (məsələn, video, şəkillər, məqalələr və s.). Digər veb saytlardan daxil edilmiş məzmun, qonaq digər veb saytı ziyarət etdiyi kimi eyni şəkildə davranır.Bu veb saytlar sizin haqqınızda məlumat toplaya bilər, peçenye istifadə edə bilər, əlavə üçüncü tərəf izləmə əlavə edə bilər və daxil edilmiş məzmunla qarşılıqlı əlaqənizi, habelə hesabınız varsa və həmin veb sayta daxil olmağınızla əlaqəli əlaqənizi izləyə bilər.</p> </div> <div class='privacy_content section_3'> <h2>Verilənlərinizi necə saxlayırıq?</h2> <p>Bir şərh buraxsanız, şərh və onun metadatası qeyri-müəyyən olaraq saxlanılır. Bu, hər hansı bir izləmə şərhlərini moderasiya növbəsində saxlamaq əvəzinə avtomatik olaraq tanıya və təsdiqləyə biləcəyimizdir.Veb saytımızda (əgər varsa) qeydiyyatdan keçən istifadəçilər üçün təqdim etdikləri şəxsi məlumatları istifadəçi profilində saxlayırıq. Bütün istifadəçilər istənilən vaxt şəxsi məlumatlarını görə bilər, redaktə edə və ya silə bilər (istifadəçi adlarını dəyişə bilməyincə). Veb sayt rəhbərləri də həmin məlumatları görə və redaktə edə bilərlər.</p> </div> <div class='privacy_content section_3'> <h2>Məlumatlarınız üzərində hansı hüquqlara sahibsiniz</h2> <p>Bu saytda bir hesabınız varsa və ya şərhlər buraxmısınızsa, sizə təqdim etdiyiniz hər hansı bir məlumat daxil olmaqla, sizin haqqımızda saxladığımız fərdi məlumatların ixrac edilmiş sənədini tələb edə bilərsiniz. Ayrıca, sizin haqqınızda saxladığımız şəxsi məlumatlarınızı silməyimizi tələb edə bilərsiniz. Buraya inzibati, qanuni və ya təhlükəsizlik məqsədləri üçün saxlamalı olduğumuz hər hansı bir məlumat daxil deyil.</p> </div> <div class='privacy_content section_3'> <h2>Məlumatlarınızı hara göndəririk</h2> <p>Ziyarətçilərin şərhləri avtomatlaşdırılmış spam aşkarlama xidməti vasitəsilə yoxlanıla bilər..</p> </div>", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialActivities",
                columns: new[] { "Id", "AdminManagerId", "Link", "ModifiedAt", "Name", "SettingId" },
                values: new object[,]
                {
                    { 4, null, "https://www.linkedin.com/feed/", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "linkedin", 1 },
                    { 1, null, "https://www.facebook.com/", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facebook", 1 },
                    { 2, null, "https://twitter.com/?lang=en", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "twitter", 1 },
                    { 3, null, "https://www.instagram.com/", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "instagram", 1 },
                    { 5, null, "https://www.google.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "google", 1 }
                });

            migrationBuilder.InsertData(
                table: "AboutSettings",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Photo" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 2, DateTimeKind.Local).AddTicks(1676), "about/about1.jpg" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 14, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9830), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9828), "blog/blog4.jpg", true },
                    { 13, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9826), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9824), "blog/blog3.jpg", true },
                    { 12, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9822), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9820), "blog/blog2.jpg", true },
                    { 11, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9818), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9816), "blog/blog1.jpg", true },
                    { 10, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9813), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9812), "blog/blog5.jpg", true },
                    { 9, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9809), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9808), "blog/blog4.jpg", true },
                    { 8, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9805), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9801), "blog/blog3.jpg", true },
                    { 15, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9834), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9832), "blog/blog5.jpg", true },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9620), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9617), "blog/blog1.jpg", true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9615), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9613), "blog/blog5.jpg", true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9611), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9608), "blog/blog4.jpg", true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9604), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9602), "blog/blog3.jpg", true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9571), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9559), "blog/blog2.jpg", true },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(7368), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(7356), "blog/blog1.jpg", true },
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9624), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(9623), "blog/blog2.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Name", "Slug", "Status" },
                values: new object[,]
                {
                    { 48, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6781), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4Tech ", "A4Tech ", true },
                    { 47, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6778), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baseus ", "Baseus ", true },
                    { 46, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6776), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock ", "Rock ", true },
                    { 45, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6772), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Remax ", "Remax ", true },
                    { 44, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6769), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gigaset ", "Gigaset ", true },
                    { 43, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6767), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JBL ", "JBL ", true },
                    { 39, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6757), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitek ", "Vitek ", true },
                    { 41, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6762), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F&D ", "F&D ", true },
                    { 40, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Braun ", "Braun ", true },
                    { 38, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6754), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal ", "Tefal ", true },
                    { 37, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6752), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rowenta ", "Rowenta ", true },
                    { 36, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6750), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic ", "Panasonic ", true },
                    { 49, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6783), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SanDisk ", "SanDisk ", true },
                    { 42, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6764), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genius ", "Genius ", true },
                    { 50, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6786), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beats ", "Beats ", true },
                    { 58, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BAKCELL ", "bakcell ", true },
                    { 52, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman ", "Roman ", true },
                    { 66, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6827), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star ", "Star ", true },
                    { 65, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACLAS ", "ACLAS ", true },
                    { 64, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6822), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Datalogic ", "Datalogic ", true },
                    { 63, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argox ", "Argox ", true },
                    { 62, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6817), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Symbol ", "Symbol ", true },
                    { 61, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6814), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İROBOT ", "İROBOT ", true },
                    { 51, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6788), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jabra ", "Jabra ", true },
                    { 60, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NAR ", "NAR ", true },
                    { 35, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6747), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oculus ", "Oculus ", true },
                    { 57, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adata ", "Adata ", true },
                    { 56, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6800), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilitong ", "Bilitong ", true },
                    { 55, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspor ", "Aspor ", true },
                    { 54, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6795), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WK ", "WK ", true },
                    { 53, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6793), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proda ", "Proda ", true },
                    { 59, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZERCELL ", "AZERCELL ", true },
                    { 34, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6745), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logitech ", "Logitech ", true },
                    { 30, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aiwa ", "Aiwa ", true },
                    { 32, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6740), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony ", "Sony ", true },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(3676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", "apple", true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung", "Samsung", true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6661), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei", "Huawei", true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi", "Xiaomi", true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6669), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meizu", "Meizu", true },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6671), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nokia", "Nokia", true },
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6674), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FLY", "FLY", true },
                    { 8, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UleFone", "UleFone", true },
                    { 9, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor", "Honor", true },
                    { 10, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6682), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo", "Lenovo", true },
                    { 11, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6685), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balafon", "Balafon", true },
                    { 33, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6742), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox ", "Xbox ", true },
                    { 13, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6690), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTC", "HTC", true },
                    { 14, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hitachi", "Hitachi", true },
                    { 15, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zanussi", "Zanussi", true },
                    { 12, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6687), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG", "LG", true },
                    { 17, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vestel", "Vestel", true },
                    { 31, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shivaki ", "Shivaki ", true },
                    { 29, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips ", "Philips ", true },
                    { 16, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch", "Bosch", true },
                    { 27, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canon", "Canon", true },
                    { 26, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6724), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP", "HP", true },
                    { 25, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell", "Dell", true },
                    { 28, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Epson ", "Epson ", true },
                    { 23, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6716), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asus", "Asus", true },
                    { 22, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorenje", "Gorenje", true },
                    { 21, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İndesit", "İndesit", true },
                    { 20, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AUX", "AUX", true },
                    { 19, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6707), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gree", "Gree", true },
                    { 18, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6704), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitsubishi", "Mitsubishi", true },
                    { 24, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(6719), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acer", "Acer", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(276), new DateTime(2020, 1, 17, 16, 46, 17, 997, DateTimeKind.Local).AddTicks(9460), true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(1982), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(1960), true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2005), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2003), true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2009), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2008), true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2014), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2012), true },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2020), new DateTime(2020, 1, 17, 16, 46, 17, 998, DateTimeKind.Local).AddTicks(2016), true }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Order", "Status" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7267), 6, true },
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7269), 7, true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7264), 5, true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7228), 2, true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7257), 3, true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(7260), 4, true },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 3, DateTimeKind.Local).AddTicks(5712), 1, true }
                });

            migrationBuilder.InsertData(
                table: "OurServices",
                columns: new[] { "Id", "AdminManagerId", "Icon", "ModifiedAt", "Order", "Status" },
                values: new object[,]
                {
                    { 1, 1, "fa fa-sliders", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(3636), 1, true },
                    { 2, 1, "fa fa-umbrella", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5738), 2, true },
                    { 3, 1, "fa fa-camera", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5777), 3, true },
                    { 4, 1, "fa fa-cog", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5780), 4, true },
                    { 5, 1, "fa fa-file-code-o", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5783), 5, true },
                    { 6, 1, "fa fa-bar-chart", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5787), 6, true },
                    { 7, 1, "fa fa-headphones", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5791), 7, true },
                    { 8, 1, "fa fa-leaf", new DateTime(2020, 1, 17, 16, 46, 18, 1, DateTimeKind.Local).AddTicks(5794), 8, true }
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Name", "Photo" },
                values: new object[,]
                {
                    { 8, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2184), "Photograph", "brand/brand8.jpg" },
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2180), "Business", "brand/brand7.jpg" },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2177), "Retrobrand", "brand/brand6.jpg" },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2175), "Okeandor", "brand/brand5.jpg" },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2107), "Designers", "brand/brand1.jpg" },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2170), "Prestige", "brand/brand3.jpg" },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2166), "Shopname", "brand/brand2.jpg" },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(2172), "Prestiges", "brand/brand4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/90694-dasinabilen.png", true },
                    { 10, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(295), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/581ea-barcode_scanner.png", true },
                    { 8, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(288), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/0427b-simcart.png", true },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(283), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9ca97-kicik-meiset-esyalari.png", true },
                    { 9, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(292), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6e7e5-icon.png", true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(278), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ee515-televior.png", true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/44444-ofis-mehsullari.png", true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(236), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/73913-meiset-esyalari.png", true },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 4, DateTimeKind.Local).AddTicks(8022), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/e7132-telefon.png", true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(280), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9c45c-game-blue-.png", true }
                });

            migrationBuilder.InsertData(
                table: "Properities",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Status" },
                values: new object[,]
                {
                    { 39, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2981), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 53, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3016), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 38, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 37, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2974), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 36, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2972), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 34, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2967), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 33, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2964), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 32, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2962), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 31, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2959), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 30, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2957), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 35, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2969), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 40, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2984), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 42, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2989), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 43, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2991), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 44, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2994), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 45, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 46, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 47, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3002), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 48, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3004), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 49, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3006), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 50, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3009), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 51, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3011), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 52, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(3014), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 29, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2953), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 41, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2986), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 28, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2895), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 15, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2862), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 26, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2891), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(939), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2834), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2837), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2839), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2844), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 27, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2893), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 11, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 14, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2859), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 25, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2888), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 24, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2886), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 13, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 22, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2881), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 21, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2879), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 23, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2884), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 19, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2873), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 18, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2870), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 17, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2867), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 16, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2865), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 20, 1, new DateTime(2020, 1, 17, 16, 46, 18, 7, DateTimeKind.Local).AddTicks(2876), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "ServicesCovers",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Order", "Photo", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 0, DateTimeKind.Local).AddTicks(5597), 1, "service/services1.jpg", true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 0, DateTimeKind.Local).AddTicks(7719), 2, "service/services2.jpg", true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 0, DateTimeKind.Local).AddTicks(7764), 3, "service/services3.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "WhatDos",
                columns: new[] { "Id", "AdminManagerId", "LanguageId", "ModifiedAt", "Photo", "Status", "WhatDoId" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2020, 1, 17, 16, 46, 18, 2, DateTimeKind.Local).AddTicks(8416), "about/about2.jpg", true, null },
                    { 2, 1, null, new DateTime(2020, 1, 17, 16, 46, 18, 2, DateTimeKind.Local).AddTicks(9853), "about/about3.jpg", true, null }
                });

            migrationBuilder.InsertData(
                table: "AboutSettingTranslates",
                columns: new[] { "Id", "AboutSettingId", "Desc", "LanguageId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Adipiscing lacus ut elementum, nec duis, tempor litora turpis dapibus. Imperdiet cursus odio tortor in elementum. Egestas nunc eleifend feugiat lectus laoreet, vel nunc taciti integer cras. Hac pede dis, praesent nibh ac dui mauris sit. Pellentesque mi, facilisi mauris, elit sociis leo sodales accumsan. Iaculis ac fringilla torquent lorem consectetuer, sociosqu phasellus risus urna aliquam, ornare.", 1, "ECommerce For Electronics Store" },
                    { 2, 1, "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı.", 2, "Elektronika Mağazası üçün Kommersiya fəaliyyəti" }
                });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "Id", "AdminManagerId", "BlogId", "CategoryId", "ModifiedAt" },
                values: new object[,]
                {
                    { 10, 1, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, 12, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 13, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, 14, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, 15, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BlogCategoryTranslates",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 6, 3, 2, "Qalareya" },
                    { 2, 1, 2, "Audio" },
                    { 1, 1, 1, "Audio" },
                    { 7, 4, 1, "Travel" },
                    { 8, 4, 2, "Səyahət" },
                    { 12, 6, 2, "Video" },
                    { 3, 2, 1, "Company" },
                    { 11, 6, 1, "Video" },
                    { 5, 3, 1, "Gallery" },
                    { 9, 5, 1, "Other" },
                    { 10, 5, 2, "Digər" },
                    { 4, 2, 2, "Şirkət" }
                });

            migrationBuilder.InsertData(
                table: "BlogReviews",
                columns: new[] { "Id", "AdminManagerId", "BlogId", "Content", "CreatedAt", "UserClientId" },
                values: new object[,]
                {
                    { 8, null, 6, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5609), 1 },
                    { 4, null, 2, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5598), 1 },
                    { 3, 1, 1, "Vnunc vitae erat pellentesque, ac placerat arcu consectetur", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5584), null },
                    { 2, null, 1, "Quisque semper nunc vitae erat pellentesque, ac placerat arcu consectetur", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(4795), 1 },
                    { 12, null, 10, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5620), 1 },
                    { 1, null, 1, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(3927), 1 },
                    { 11, null, 9, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5618), 1 },
                    { 10, null, 8, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5615), 1 },
                    { 6, null, 4, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5603), 1 },
                    { 9, null, 7, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5613), 1 },
                    { 7, null, 5, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5606), 1 },
                    { 5, null, 3, "But I must explain to you how all this mistaken idea of denouncing pleasure", new DateTime(2020, 1, 17, 16, 46, 17, 999, DateTimeKind.Local).AddTicks(5601), 1 }
                });

            migrationBuilder.InsertData(
                table: "BlogTranslates",
                columns: new[] { "Id", "BlogId", "Content", "Desc", "LanguageId", "Slug", "Title" },
                values: new object[,]
                {
                    { 4, 4, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Post-with-audio", "Post With Audio" },
                    { 20, 4, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "elektronika", "Elektrotexnika" },
                    { 18, 2, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "qalaraya-paylasimi", "Qalareya Paylaşımı" },
                    { 3, 3, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Maecenas-Ultricies", "Maecenas Ultricies" },
                    { 2, 2, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Post-With-Gallery", "Post With Gallery" },
                    { 17, 1, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "xabar-sakil-paylasimi", "Xəbər Şəkil Paylaşımı" },
                    { 1, 1, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Blog-Image-Post", "Blog Image Post (Sticky)" },
                    { 7, 7, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Ultricies-Maecenas", "Ultricies Maecenas" },
                    { 19, 3, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "texniki-paylasim", "Texniki Paylaşım" },
                    { 24, 7, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "seyahet-paylasimi", "Səyahət Paylaşımı" },
                    { 21, 5, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "yeni-robotlar", "Yeni Robotlar" },
                    { 11, 11, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Sticy-Post", "Sticy Post" },
                    { 8, 8, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Audio-Post", " Audio Post" },
                    { 9, 9, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Image-Post", "Image Post" },
                    { 26, 9, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "yeni-trendler", "Yeni trendlər" },
                    { 10, 10, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Other-Post", "Other Post" },
                    { 27, 10, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "diger-paylasim", "Digər Paylaşım" },
                    { 5, 5, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "preasent-imperdiet", "Praesent Imperdiet" },
                    { 28, 11, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "robot-istehsali", "Robot istehsalı" },
                    { 12, 12, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Travel-Post", "Travel Post" },
                    { 29, 12, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "avadanliqlar", "Avadanlıqlar" },
                    { 13, 13, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Blog-with-Travel", "Blog with Travel" },
                    { 30, 13, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "aksesuarlar", "Aksesuarlar" },
                    { 14, 14, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Wordpress-Post", "Wordpress Post" },
                    { 31, 14, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "yeni-tozsoram", "Yeni Tozsoran" },
                    { 15, 15, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Company-Post", "Company Post" },
                    { 32, 15, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "yeni-paylasim", "Yeni paylaşım" },
                    { 23, 6, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "yeni-iphone-11", "Yeni İphone 11" },
                    { 6, 6, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "gallery-post", "Gallery Post" },
                    { 25, 8, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "sirketler", "Şirkətlər" }
                });

            migrationBuilder.InsertData(
                table: "FaqTranslates",
                columns: new[] { "Id", "Answer", "FaqId", "LanguageeId", "Question" },
                values: new object[,]
                {
                    { 6, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 6, 1, "Trist mattis finibus elit ut tristique?" },
                    { 5, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 5, 1, "ut Donec mattis finibus elit ut tristique?" },
                    { 7, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 7, 1, "Donec tristique?" },
                    { 14, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 7, 2, "ikinci əl satılırmı?" },
                    { 13, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 6, 2, "Nə üstünlüklər verilir?" },
                    { 11, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 4, 2, "Mobil tetbiqi də hazırlanırmı?" },
                    { 12, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 5, 2, "Digərlərindən fərqi nədir?" },
                    { 10, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 3, 2, "Vakansiyalar ne vaxt olacaq?" },
                    { 1, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 1, 1, "Donec mattis finibus elit ut tristique?" },
                    { 8, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 1, 2, "Saytda hansı ödəmə vasitələri var?" },
                    { 4, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 4, 1, "elit mattis finibus elit ut tristique?" },
                    { 9, "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur ", 2, 2, "Çatdırılma necə həyata keçir?" },
                    { 3, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 3, 1, "finibus elit ut tristique?" },
                    { 2, "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend ", 2, 1, "mattis finibus elit ut tristique?" }
                });

            migrationBuilder.InsertData(
                table: "OurServiceTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "OurServiceId", "Title" },
                values: new object[,]
                {
                    { 16, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 8, "Qrafik Dizayn" },
                    { 8, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 8, "GRAPHIC DESIGN" },
                    { 15, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 7, "Təchizat" },
                    { 7, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 7, "SUPPORT" },
                    { 6, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 6, "MARKETING" },
                    { 5, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 5, "CODING" },
                    { 12, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 4, "Web proqranlaşdırma" },
                    { 14, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 6, "Marketinq" },
                    { 11, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 3, "Potoqrafiya" },
                    { 4, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 4, "WEB DEVELOPMENT" },
                    { 1, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 1, "BRANDING" },
                    { 9, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 1, "Brendinq" },
                    { 13, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 5, "Kod" },
                    { 10, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 2, "Web Dizayn" },
                    { 3, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 3, "PHOTOGRAPHY" },
                    { 2, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 2, "WEB DESIGN" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategoryTranslates",
                columns: new[] { "Id", "LanguageId", "Name", "ProductCategoryId", "Slug" },
                values: new object[,]
                {
                    { 14, 2, "TV və Audio sistemlər", 4, "tv-ve-audio-sistemler" },
                    { 19, 2, "İROBOT", 9, "İROBOT" },
                    { 6, 1, "Small household items", 6, "Small-household-items" },
                    { 8, 1, "Numbers", 8, "Numbers" },
                    { 18, 2, "Nömrələr", 8, "Nomreler" },
                    { 16, 2, "Kiçik ev əşyaları", 6, "kicik-ev-esyalari" },
                    { 13, 2, "Kompüterlər və ofis avadanlıqları", 3, "koputer-ve-ofis-avadanliqlari" },
                    { 3, 1, "Computers and office equipment", 3, "Computers-and-office-equipment" },
                    { 9, 1, "İROBOT", 9, "İROBOT" },
                    { 4, 1, "TV and Audio Systems", 4, "TV-and-Audio-Systems" },
                    { 17, 2, "Aksessuarlar", 7, "Aksessuarlar" },
                    { 20, 2, "Ofis Avadanlıqları", 10, "Ofis Avadanlıqları" },
                    { 7, 1, "Accessories", 7, "Accessories" },
                    { 1, 1, "Telephone and tablets", 1, "Telephones-and-tablets" },
                    { 11, 2, "Telefon və planşetlər", 1, "telefon-ve-plansetler" },
                    { 10, 1, "Office Equipment", 10, "Office-Equipment" },
                    { 15, 2, "Oyun konsolları", 5, "oyun-konsollari" },
                    { 2, 1, "Household Items", 2, "Household-Items" },
                    { 12, 2, "Məişət əşyaları", 2, "meiset-esyalari" },
                    { 5, 1, "Game consoles", 5, "Game-consoles" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubCategories",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "Discount", "DiscountDate", "ModifiedAt", "Photo", "ProductCategoryId", "Status" },
                values: new object[,]
                {
                    { 35, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9355), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9a881-iphonea.png", 7, true },
                    { 34, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9353), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/7b5b8-ekran-koruyucu.jpg", 7, true },
                    { 36, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9357), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/eee1f-003386-glossy-black-icon-media-music-speaker.png", 7, true },
                    { 37, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9360), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6d65f-86666-cordless-phone.png", 7, true },
                    { 39, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9365), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/8ebb1-kablo.jpg", 7, true },
                    { 40, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9368), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/03ba9-telefonkilif.jpg", 7, true },
                    { 41, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9370), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b1347-business-suitcase-bag-icon.jpg", 7, true },
                    { 42, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9372), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b40b8-network.jpg", 7, true },
                    { 38, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9362), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/74601-car-flat-icon-01-.jpg", 7, true },
                    { 52, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9399), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d9046-81sbl3t77zl._sl1500_.jpg", 9, true },
                    { 44, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9379), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/f3ba8-sdcard.png", 7, true },
                    { 45, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9382), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b813a-kulaklikkategori.png", 7, true },
                    { 46, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9384), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/2ed8d-tasinabilirsarj.jpg", 7, true },
                    { 47, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9386), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/528ea-monopad.png", 7, true },
                    { 48, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9389), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/c1af5-usb-bellek.jpg", 7, true },
                    { 49, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9392), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b3323-bakcell.png", 8, true },
                    { 50, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9394), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6fb9a-azercell.png", 8, true },
                    { 51, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9397), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/bdd2e-nar.png", 8, true },
                    { 53, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9402), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/b3747-bar-code.png", 10, true },
                    { 54, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9404), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/3a824-intermec_pc42d_icon_1.jpg", 10, true },
                    { 55, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9406), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/09a3c-xprinter-thermal-barcode-printer-80mm-xp-350b-.jpg", 10, true },
                    { 56, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9410), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/eaf6d-sk50-1.png", 10, true },
                    { 43, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9376), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6d0d5-mouse.jpg", 7, true },
                    { 33, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9350), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/4f398-90652265-stock-vector-mixer-kitchen-icon-simple-illustration-of-mixer-kitchen-vector-icon-for-web.jpg", 6, true },
                    { 31, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9345), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/11f7a-a-gray-stationary-blender-icon-vector-13417582.jpg", 6, true },
                    { 4, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9216), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/c6c32-4c725ea90ea12cefddd054328870a61f-online-mobile-second-hand.jpg", 1, true },
                    { 32, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9348), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/cea64-toaster-icon-simple-black-style-vector-18839754.jpg", 6, true },
                    { 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(7661), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6fe81-ceptelefon.jpg", 1, true },
                    { 2, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9161), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/5f28a-tabletler.jpg", 1, true },
                    { 3, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9212), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/3d444-akillisaatler.jpg", 1, true },
                    { 5, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9218), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/37bcc-soyuducu.png", 2, true },
                    { 6, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9221), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/5818a-klima.jpg", 2, true },
                    { 7, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9224), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/531d2-paltaryuyan.png", 2, true },
                    { 8, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9227), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a79f3-kitchenaid-logo.jpg", 2, true },
                    { 9, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9229), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/bccf0-pilte.png", 2, true },
                    { 10, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9232), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/63377-mikrodalga.jpg", 2, true },
                    { 12, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9294), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/9b6f3-masaustu.jpg", 3, true },
                    { 13, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9297), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/bd8b6-notebook.jpg", 3, true },
                    { 14, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9300), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d6ad6-yazicilar.jpg", 3, true },
                    { 15, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9302), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/70f58-monitorkatr.jpg", 3, true },
                    { 11, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9288), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ddf24-notebook.jpg", 3, true },
                    { 17, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9307), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ec35f-ses_ev.png", 4, true },
                    { 30, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9342), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d879f-juicer-icon-simple-style-vector-10155704.jpg", 6, true },
                    { 29, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9340), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/ae188-electric-kettle-household-appliance-icon-vector-8275057.jpg", 6, true },
                    { 28, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9337), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/560ee-meat-grinder-machine-icon-simple-style-vector-22276672.jpg", 6, true },
                    { 16, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9305), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/900d4-televizyonlar.jpg", 4, true },
                    { 26, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9330), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/6a0f2-pngtree-vector-hair-dryer-icon-png-image_701315.jpg", 6, true },
                    { 25, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9328), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/00858-a4726b678f87bd94ea880eeef0ecdfcb-silhouette-black-white-vacuum-cleaner.png", 6, true },
                    { 24, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9325), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/7e1df-37229008_21039398.jpeg", 5, true },
                    { 27, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9334), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a7af1-electric-iron-icon-simple-style-vector-21484883.jpg", 6, true },
                    { 22, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9320), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/8b3c4-unnamed.jpg", 5, true },
                    { 21, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9317), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/712b6-ps4.jpg", 5, true },
                    { 18, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9310), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a6cf0-soundbar.png", 4, true },
                    { 20, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9315), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/d73ad-projeksiyon.jpg", 4, true },
                    { 19, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9312), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/a9a78-evsinema.jpg", 4, true },
                    { 23, 1, new DateTime(2020, 1, 17, 16, 46, 18, 5, DateTimeKind.Local).AddTicks(9322), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "category/47bfc-xbox-logo_318-9975.jpg", 5, true }
                });

            migrationBuilder.InsertData(
                table: "ProperityTranslates",
                columns: new[] { "Id", "LanguageId", "Name", "ProperityId", "Slug" },
                values: new object[,]
                {
                    { 88, 1, "Speed", 35, "Speed" },
                    { 36, 2, "Rəqəmsal Tuner", 36, "Rəqəmsal-Tuner" },
                    { 89, 1, "Digital Tuner", 36, "Digital-Tuner" },
                    { 37, 2, "Dəstəklənən çıxışlar", 37, "Dəstəklənən-çıxışlar" },
                    { 38, 2, "Wi-Fi", 38, "Wi-Fi" },
                    { 91, 1, "Wi-Fi", 38, "Wi-Fi" },
                    { 39, 2, "3D", 39, "3D" },
                    { 35, 2, "Tezlik", 35, "Tezlik" },
                    { 92, 1, "3D", 39, "3D" },
                    { 90, 1, "Supported speeches", 37, "Supported-speeches" },
                    { 87, 1, "Screen type", 34, "Screen-type" },
                    { 22, 2, "Xüsusiyyətləri", 22, "xususiyetleri" },
                    { 86, 1, "Graphic memory", 33, "Graphic-memory" },
                    { 33, 2, "Qrafik yaddaş", 33, "Qrafik-yaddaş" },
                    { 85, 1, "Network", 32, "Network" },
                    { 32, 2, "Şəbəkə", 32, "Şəbəkə" },
                    { 84, 1, "Ports", 31, "Ports" },
                    { 31, 2, "Portlar", 31, "Portlar" },
                    { 83, 1, "Ceramic heater", 30, "Ceramic-heater" },
                    { 30, 2, "Keramik qızdırıcı", 30, "Keramik-qızdırıcı" },
                    { 82, 1, "Child lock", 29, "Child-lock" },
                    { 29, 2, "Uşaq kilidi", 29, "Uşaq-kilidi" },
                    { 40, 2, "Dəstəklənən formatlar", 40, "Dəstəklənən-formatlar" },
                    { 34, 2, "Ekran növü", 34, "Ekran-növü" },
                    { 93, 1, "Supported formats", 40, "Supported-formats" },
                    { 101, 1, "Steam Power", 48, "Steam-Power" },
                    { 94, 1, "Power", 41, "Power" },
                    { 106, 1, "Quality", 53, "Quality" },
                    { 53, 2, "Keyfiyyəti", 53, "Keyfiyyəti" },
                    { 105, 1, "Speed", 52, "speed" },
                    { 52, 2, "Sürəti", 52, "Sürəti" },
                    { 104, 1, "Width", 51, "Width" },
                    { 51, 2, "Genişliyi", 51, "Genişliyi" },
                    { 103, 1, "Distance", 50, "Distance" },
                    { 50, 2, "Məsafəsi", 50, "Məsafəsi" },
                    { 102, 1, "Water capacity", 49, "Water-capacity" },
                    { 49, 2, "Su tutumu", 49, "Su-tutumu" },
                    { 81, 1, "Applications", 28, "Applications" },
                    { 41, 2, "Gücü", 41, "Gücü" },
                    { 48, 2, "Buxar Gücü", 48, "Buxar-Gücü" },
                    { 47, 2, "Başlıqlar", 47, "Başlıqlar" },
                    { 99, 1, "Number of temperature modes", 46, "Number-of-temperature-modes" },
                    { 46, 2, "Temperatur rejimlərinin sayı", 46, "Temperatur-rejimlərinin-sayı" },
                    { 98, 1, "Number of speeds", 45, "Number-of-speeds" },
                    { 45, 2, "Sürət sayı", 45, "Sürət-sayı" },
                    { 97, 1, "Dust container type", 44, "Dust-container-type" },
                    { 44, 2, "Toz qabının növü", 44, "Toz-qabının-növü" },
                    { 96, 1, "Length of wire", 43, "Length-of-wire" },
                    { 43, 2, "Naqilin Uzunluğu", 43, "Naqilin-Uzunluğu" },
                    { 95, 1, "Cooling Power", 42, "Cooling-Power" },
                    { 42, 2, "Sovurma Gücü", 42, "Sovurma-Gücü" },
                    { 100, 1, "Headlines", 47, "Headlines" },
                    { 28, 2, "Proqramlar", 28, "Proqramlar" },
                    { 21, 2, "Dondurma kamerasının həcmi", 21, "dondurma-kamerasinin-hecmi" },
                    { 27, 2, "Enerji sinifi", 27, "Enerji-sinifi" },
                    { 80, 1, "Energy class", 27, "Energy-class" },
                    { 64, 1, "Video", 11, "video" },
                    { 11, 2, "Video", 11, "video" },
                    { 63, 1, "The main camera", 10, "The-main-camera" },
                    { 10, 2, "Əsas kamera", 10, "esas-kamera" },
                    { 62, 1, "Memory card", 9, "Memory-card" },
                    { 9, 2, "Yaddaş kartı", 9, "Yaddas-karti" },
                    { 61, 1, "RAM", 8, "ram" },
                    { 8, 2, "RAM", 8, "RAM" },
                    { 60, 1, "Internal memory", 7, "Internal-memory" },
                    { 7, 2, "Daxili yaddaş", 7, "daxili-yaddas" },
                    { 59, 1, "Nuclear", 6, "Nuclear" },
                    { 6, 2, "Nüvə", 6, "nuve" },
                    { 58, 1, "Processor", 5, "Processor" },
                    { 5, 2, "Prosessor", 5, "Prosessor" },
                    { 57, 1, "Operating system", 4, "Operating-system" },
                    { 4, 2, "Əməliyyat sistemi", 4, "emeliyyat-sistemi" },
                    { 56, 1, "SIM", 3, "SIM" },
                    { 3, 2, "SİM", 3, "SİM" },
                    { 55, 1, "Weight", 2, "Weight" },
                    { 2, 2, "Çəkisi", 2, "cekisi" },
                    { 54, 1, "Dimensions", 1, "Dimensions" },
                    { 1, 2, "Ölçüləri", 1, "olculeri" },
                    { 65, 1, "Front camera", 12, "Front-camera" },
                    { 13, 2, "WLAN", 13, "WLAN" },
                    { 12, 2, "Ön kamera", 12, "on-kamera" },
                    { 14, 2, "Bluetooth", 14, "Bluetooth" },
                    { 79, 1, "Compression rate", 26, "Compression-rate" },
                    { 26, 2, "Sıxma sürəti", 26, "Sıxma-sureti" },
                    { 78, 1, "Capacity", 25, "Capacity" },
                    { 25, 2, "Tutum", 25, "tutum" },
                    { 77, 1, "Influence area", 24, "Influence-area" },
                    { 24, 2, "Təsir sahəsi", 24, "tesir-sahesi" },
                    { 76, 1, "Refrigerant liquid", 23, "Refrigerant-liquid" },
                    { 23, 2, "Soyuducu maye", 23, "Soyuducu-maye" },
                    { 75, 1, "Features", 22, "Features" },
                    { 66, 1, "WLAN", 13, "WLAN" },
                    { 73, 1, "The volume of the refrigerator compartment", 20, "The-volume-of-the-refrigerator-compartment" },
                    { 74, 1, "Freezing chamber volume", 21, "Freezing-chamber-volume" },
                    { 72, 1, "Energy class", 19, "Energy-class" },
                    { 67, 1, "Bluetooth", 14, "Bluetooth" },
                    { 15, 2, "Batareya həcmi", 15, "Batareya-həcmi" },
                    { 20, 2, "Soyuducu hissənin həcmi", 20, "soyuducu-hissenin-hecmi" },
                    { 16, 2, "Ekran ölçüsü", 16, "ekran-olcusu" },
                    { 69, 1, "Screen size", 16, "Screen-size" },
                    { 68, 1, "Battery volume", 15, "Battery-volume" },
                    { 70, 1, "Type", 17, "Type" },
                    { 18, 2, "Ümumi həcmi", 18, "umumi-hecmi" },
                    { 71, 1, "Total volume", 18, "Total-volume" },
                    { 19, 2, "Enerji sinifi", 19, "enerji-sinfi" },
                    { 17, 2, "Növü", 17, "novu" }
                });

            migrationBuilder.InsertData(
                table: "ServicesCoverTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "ServicesCoverId", "Title" },
                values: new object[,]
                {
                    { 6, "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm.", 2, 3, "ƏSAS DİZAYN" },
                    { 1, "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima.", 1, 1, "DESIGN THE COVER" },
                    { 4, "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm.", 2, 1, "ƏSAS DİZAYN" },
                    { 2, "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima.", 1, 2, "DESIGN THE COVER" },
                    { 5, "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm.", 2, 2, "ƏSAS DİZAYN" },
                    { 3, "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima.", 1, 3, "DESIGN THE COVER" }
                });

            migrationBuilder.InsertData(
                table: "WhatDosTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "Title", "WhatDoId" },
                values: new object[,]
                {
                    { 3, "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı.", 2, "Fəaliyyətimiz Nədir?", 1 },
                    { 2, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ‘Content here, content here’, making it look like readable English.", 1, "History Of Us", 2 },
                    { 1, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ‘Content here, content here’, making it look like readable English.", 1, "What Do We Do?", 1 },
                    { 4, "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı.", 2, "Tariximiz", 2 }
                });

            migrationBuilder.InsertData(
                table: "BrandProductCategories",
                columns: new[] { "Id", "BrandId", "ProductSubCategoryId" },
                values: new object[,]
                {
                    { 9, 1, 40 },
                    { 45, 16, 9 },
                    { 105, 43, 36 },
                    { 46, 16, 10 },
                    { 103, 42, 36 },
                    { 102, 41, 36 },
                    { 5, 1, 11 },
                    { 35, 10, 11 },
                    { 60, 23, 11 },
                    { 61, 24, 11 },
                    { 62, 25, 11 },
                    { 63, 26, 11 },
                    { 7, 1, 35 },
                    { 26, 4, 34 },
                    { 17, 2, 34 },
                    { 6, 1, 34 },
                    { 92, 36, 37 },
                    { 106, 44, 37 },
                    { 8, 1, 39 },
                    { 18, 2, 39 },
                    { 54, 17, 5 },
                    { 104, 42, 43 },
                    { 89, 34, 43 },
                    { 67, 26, 43 },
                    { 55, 18, 6 },
                    { 56, 19, 6 },
                    { 57, 20, 6 },
                    { 64, 26, 13 },
                    { 111, 47, 40 },
                    { 47, 16, 25 },
                    { 15, 2, 7 },
                    { 39, 12, 7 },
                    { 58, 21, 7 },
                    { 59, 22, 7 },
                    { 110, 46, 39 },
                    { 107, 45, 39 },
                    { 19, 2, 40 },
                    { 44, 16, 5 },
                    { 99, 38, 33 },
                    { 79, 29, 32 },
                    { 101, 40, 27 },
                    { 100, 39, 27 },
                    { 94, 38, 27 },
                    { 74, 29, 27 },
                    { 83, 32, 21 },
                    { 48, 16, 27 },
                    { 84, 32, 22 },
                    { 93, 37, 26 },
                    { 86, 33, 23 },
                    { 73, 29, 26 },
                    { 85, 32, 24 },
                    { 87, 33, 24 },
                    { 88, 34, 24 },
                    { 90, 35, 24 },
                    { 91, 36, 25 },
                    { 75, 29, 28 },
                    { 95, 38, 28 },
                    { 76, 29, 29 },
                    { 96, 38, 29 },
                    { 52, 16, 32 },
                    { 65, 26, 14 },
                    { 69, 27, 14 },
                    { 70, 28, 14 },
                    { 66, 26, 15 },
                    { 98, 38, 31 },
                    { 78, 29, 31 },
                    { 53, 16, 33 },
                    { 51, 16, 31 },
                    { 40, 12, 16 },
                    { 71, 29, 16 },
                    { 80, 30, 16 },
                    { 82, 31, 16 },
                    { 97, 38, 30 },
                    { 77, 29, 30 },
                    { 49, 16, 30 },
                    { 16, 2, 16 },
                    { 43, 15, 5 },
                    { 72, 29, 25 },
                    { 38, 12, 5 },
                    { 22, 3, 2 },
                    { 34, 10, 2 },
                    { 124, 59, 50 },
                    { 123, 58, 49 },
                    { 122, 57, 48 },
                    { 42, 14, 5 },
                    { 11, 2, 2 },
                    { 68, 26, 48 },
                    { 12, 2, 3 },
                    { 24, 4, 3 },
                    { 36, 11, 3 },
                    { 121, 56, 46 },
                    { 120, 55, 46 },
                    { 119, 54, 46 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 125, 60, 51 },
                    { 126, 61, 52 },
                    { 132, 66, 55 },
                    { 1, 1, 1 },
                    { 10, 2, 1 },
                    { 21, 3, 1 },
                    { 23, 4, 1 },
                    { 28, 5, 1 },
                    { 29, 6, 1 },
                    { 30, 7, 1 },
                    { 31, 8, 1 },
                    { 33, 9, 1 },
                    { 131, 65, 55 },
                    { 129, 63, 54 },
                    { 130, 64, 53 },
                    { 128, 63, 53 },
                    { 127, 62, 53 },
                    { 4, 1, 4 },
                    { 13, 2, 4 },
                    { 114, 49, 48 },
                    { 25, 4, 4 },
                    { 14, 2, 5 },
                    { 112, 48, 43 },
                    { 113, 49, 44 },
                    { 20, 2, 45 },
                    { 81, 30, 45 },
                    { 108, 45, 45 },
                    { 116, 51, 45 },
                    { 117, 52, 45 },
                    { 27, 4, 46 },
                    { 109, 45, 46 },
                    { 118, 53, 46 },
                    { 41, 13, 4 },
                    { 115, 50, 45 },
                    { 32, 8, 4 },
                    { 37, 12, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductSubCategoryTranslates",
                columns: new[] { "Id", "LanguageId", "Name", "ProductSubCategoryId" },
                values: new object[,]
                {
                    { 35, 1, "Apple Accessories", 35 },
                    { 30, 1, "Juicers", 30 },
                    { 47, 1, "Monopod", 47 },
                    { 38, 1, "Car accessories", 38 },
                    { 85, 2, "Çaydanlar", 29 },
                    { 29, 1, "Kettles", 29 },
                    { 101, 2, "Qulaqcıqlar", 45 },
                    { 54, 1, "Barcode Printer", 54 },
                    { 84, 2, "Ətçəkənlər", 28 },
                    { 28, 1, "Grinders", 28 },
                    { 110, 2, "Barkod Printer", 54 },
                    { 45, 1, "Headphones", 45 },
                    { 55, 1, "Check Printer", 55 },
                    { 111, 2, "Çek Printe", 55 },
                    { 41, 1, "Bags", 41 },
                    { 97, 2, "Çantalar", 41 },
                    { 83, 2, "Ütülər", 27 },
                    { 42, 1, "Modems", 42 },
                    { 27, 1, "Irons", 27 },
                    { 98, 2, "Modemlər", 42 },
                    { 43, 1, "Mouse", 43 },
                    { 99, 2, "Mouse", 43 },
                    { 82, 2, "Fenlər ", 26 },
                    { 100, 2, "Yaddaş Kartları", 44 },
                    { 44, 1, "Memory Cards", 44 },
                    { 26, 1, "Subjects", 26 },
                    { 93, 2, "DECT Telefonlar", 37 },
                    { 86, 2, "Şirəçəkənlər", 30 },
                    { 91, 2, "Apple Aksessuarları", 35 },
                    { 109, 2, "Barkod Oxuyucu", 53 },
                    { 103, 2, "Monopod ", 47 },
                    { 95, 2, "Adapterlər", 39 },
                    { 104, 2, "USB Flash", 48 },
                    { 36, 1, "Amplifier", 36 },
                    { 90, 2, "Screen Protector", 34 },
                    { 92, 2, "Səs gücləndirici", 36 },
                    { 34, 1, "Screen Protector", 34 },
                    { 39, 1, "Adapters", 39 },
                    { 49, 1, "Bakcell", 49 },
                    { 89, 2, "Mikserlər", 33 },
                    { 33, 1, "Mixers", 33 },
                    { 105, 2, "Bakcell", 49 },
                    { 102, 2, "Power Bank", 46 },
                    { 50, 1, "Azercell", 50 },
                    { 53, 1, "Barcode Reader", 53 },
                    { 106, 2, "Azercell", 50 },
                    { 88, 2, "Tosterlər", 32 },
                    { 32, 1, "Toasts", 32 },
                    { 94, 2, "Avtomobil aksessuarları", 38 },
                    { 48, 1, "USB Flash", 48 },
                    { 40, 1, "Phone Cases", 40 },
                    { 96, 2, "Telefon Qabları", 40 },
                    { 51, 1, "Nar", 51 },
                    { 107, 2, "Nar", 51 },
                    { 37, 1, "DECT Phones", 37 },
                    { 52, 1, "İROBOT", 52 },
                    { 108, 2, "İRobot", 52 },
                    { 87, 2, "Blenderlər", 31 },
                    { 31, 1, "Blenders", 31 },
                    { 46, 1, "Power Bank", 46 },
                    { 1, 1, "Mobile Phone", 1 },
                    { 76, 2, "Projektor", 20 },
                    { 112, 2, "Qiymət Oxuyucu", 56 },
                    { 62, 2, "Kondisioner", 6 },
                    { 59, 2, "SmartWatch", 3 },
                    { 3, 1, "SmartWatch", 3 },
                    { 81, 2, "Tozsoranlar", 25 },
                    { 72, 2, "Televizor", 16 },
                    { 16, 1, "TV", 16 },
                    { 7, 1, "Washing machine", 7 },
                    { 71, 2, "Monitor", 15 },
                    { 15, 1, "Monitor", 15 },
                    { 70, 2, "Printer", 14 },
                    { 14, 1, "Printer", 14 },
                    { 64, 2, "KitchenAid", 8 },
                    { 63, 2, "Paltaryuyan", 7 },
                    { 13, 1, "Monoblok ", 13 },
                    { 68, 2, "Masaüstü kompüter", 12 },
                    { 12, 1, "Desktop computer", 12 },
                    { 2, 1, "Tablets", 2 },
                    { 58, 2, "Planşetlər", 2 },
                    { 67, 2, "Noutbuk", 11 },
                    { 11, 1, "Notebook", 11 },
                    { 66, 2, "Sobalar", 10 },
                    { 10, 1, "Ovens", 10 },
                    { 65, 2, "Plitələr", 9 },
                    { 9, 1, "Plates", 9 },
                    { 69, 2, "Monoblok", 13 },
                    { 17, 1, "Home Cinema", 17 },
                    { 6, 1, "Air conditioning", 6 },
                    { 18, 1, "Soundbar", 18 },
                    { 57, 2, "Mobil Telefonlar", 1 },
                    { 25, 1, "Vacuum cleaners", 25 },
                    { 80, 2, "Oyun Manipulyatorları", 24 },
                    { 24, 1, "Game Manipulators", 24 },
                    { 79, 2, "Microsof Box", 23 },
                    { 5, 1, "Refrigerator", 5 },
                    { 61, 2, "Soyuducu", 5 },
                    { 73, 2, "Ev kinoteatrı", 17 },
                    { 23, 1, "Microsof Box ", 23 },
                    { 78, 2, "Oyunlar", 22 },
                    { 22, 1, "Games", 22 },
                    { 77, 2, "PlayStation", 21 },
                    { 8, 1, "KitchenAid", 8 },
                    { 56, 1, "Price Reader", 56 },
                    { 20, 1, "Projector", 20 },
                    { 60, 2, "İkinci əl mobil telefonlar", 4 },
                    { 4, 1, "Second hand mobile phones", 4 },
                    { 75, 2, "DVD player", 19 },
                    { 19, 1, "DVD player", 19 },
                    { 21, 1, "PlayStation", 21 },
                    { 74, 2, "Soundbar", 18 }
                });

            migrationBuilder.InsertData(
                table: "ProperityCategories",
                columns: new[] { "Id", "ProductSubCategoryId", "ProperityId" },
                values: new object[,]
                {
                    { 33, 4, 6 },
                    { 32, 4, 5 },
                    { 31, 4, 4 },
                    { 27, 3, 9 },
                    { 26, 3, 16 },
                    { 25, 3, 2 },
                    { 17, 2, 16 },
                    { 19, 2, 4 },
                    { 18, 2, 3 },
                    { 30, 4, 3 },
                    { 29, 4, 2 },
                    { 20, 2, 5 },
                    { 21, 2, 7 },
                    { 23, 2, 12 },
                    { 28, 4, 1 },
                    { 24, 3, 1 },
                    { 22, 2, 10 },
                    { 12, 1, 12 },
                    { 15, 1, 15 },
                    { 103, 55, 53 },
                    { 102, 55, 52 },
                    { 101, 55, 51 },
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 100, 54, 53 },
                    { 99, 54, 52 },
                    { 98, 54, 51 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 16, 2, 1 },
                    { 97, 53, 50 },
                    { 95, 53, 2 },
                    { 94, 53, 1 },
                    { 93, 53, 17 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 1, 10 },
                    { 11, 1, 11 },
                    { 92, 52, 17 },
                    { 34, 4, 7 },
                    { 13, 1, 13 },
                    { 14, 1, 14 },
                    { 96, 53, 18 },
                    { 35, 4, 8 },
                    { 52, 6, 24 },
                    { 37, 4, 10 },
                    { 67, 13, 8 },
                    { 68, 13, 31 },
                    { 69, 13, 32 },
                    { 70, 15, 33 },
                    { 71, 16, 16 },
                    { 72, 16, 34 },
                    { 73, 16, 35 },
                    { 74, 16, 36 },
                    { 75, 16, 37 },
                    { 76, 16, 38 },
                    { 77, 16, 39 },
                    { 66, 13, 7 },
                    { 78, 16, 40 },
                    { 91, 27, 49 },
                    { 90, 27, 48 },
                    { 89, 27, 41 },
                    { 88, 26, 47 },
                    { 87, 26, 46 },
                    { 86, 26, 45 },
                    { 85, 26, 41 },
                    { 84, 25, 44 },
                    { 83, 25, 43 },
                    { 82, 25, 42 },
                    { 81, 25, 41 },
                    { 79, 16, 1 },
                    { 36, 4, 9 },
                    { 65, 13, 5 },
                    { 63, 11, 31 },
                    { 38, 4, 11 },
                    { 39, 4, 12 },
                    { 40, 4, 13 },
                    { 41, 4, 14 },
                    { 42, 4, 15 },
                    { 43, 5, 1 },
                    { 44, 5, 17 },
                    { 45, 5, 18 },
                    { 46, 5, 19 },
                    { 47, 5, 20 },
                    { 48, 5, 21 },
                    { 64, 11, 32 },
                    { 49, 5, 22 },
                    { 51, 6, 23 },
                    { 53, 7, 1 },
                    { 54, 7, 25 },
                    { 55, 7, 26 },
                    { 56, 7, 27 },
                    { 57, 7, 28 },
                    { 58, 7, 29 },
                    { 59, 7, 30 },
                    { 60, 11, 5 },
                    { 61, 11, 7 },
                    { 62, 11, 8 },
                    { 50, 6, 17 },
                    { 80, 25, 25 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdminManagerId", "BrandProductCategoryId", "CreatedAt", "Discount", "DiscountDate", "FollowCount", "ModifiedAt", "Name", "Price", "Slug", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 8, DateTimeKind.Local).AddTicks(8600), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro Max 256 GB", 3029m, "iPhone-11-Pro-Max-256-GB", true },
                    { 44, 1, 26, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1442), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note 5 5D S/P", 10m, "Xiaomi-Note-5-5D-S-P", true },
                    { 35, 1, 17, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1407), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S8 Plus 3D Black S/P", 20m, "S8-Plus-3D-Black-S-P", true },
                    { 17, 1, 6, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1339), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X 5D Baseus Chamilyon", 25m, "iPhone-X-5D-Baseus-Chamilyon", true },
                    { 113, 1, 99, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1760), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal HT400B30", 79m, "Tefal-HT400B30", true },
                    { 69, 1, 53, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1570), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch MFQ3540", 99m, "Bosch-MFQ3540", true },
                    { 93, 1, 79, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1689), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HD2637/00", 139m, "Philips-HD2637-00", true },
                    { 68, 1, 52, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1565), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch TAT6A913", 109m, "Bosch-TAT6A913", true },
                    { 112, 1, 98, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1756), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal Actiflow Pro Set", 199m, "Tefal-Actiflow-Pro-Set", true },
                    { 92, 1, 78, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1649), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HR1627/00", 169m, "Philips-HR1627-00", true },
                    { 67, 1, 51, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1562), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch MSM67190", 269m, "Bosch-MSM67190", true },
                    { 111, 1, 97, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1752), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal ZE550D38", 259m, "Tefal-ZE550D38", true },
                    { 91, 1, 77, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1646), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HR1837/00", 279m, "Philips-HR1837-00", true },
                    { 66, 1, 49, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1559), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch MES4000", 379m, "Bosch-MES4000", true },
                    { 110, 1, 96, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1749), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal My Tea red", 129m, "Tefal-My-Tea-red", true },
                    { 90, 1, 76, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1642), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HD9342/01", 209m, "Philips-HD9342-01", true },
                    { 109, 1, 95, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1746), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal Kiyma Makinesi", 449m, "Tefal-Kiyma-Makinesi", true },
                    { 89, 1, 75, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1639), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips HR2711/20", 289m, "Philips-HR2711-20", true },
                    { 99, 1, 85, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1710), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayStation 4 DualShock Joystick", 119m, "PlayStation-4-DualShock-Joystick", true },
                    { 101, 1, 87, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1718), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox One S/X Controller", 129m, "Xbox-One-S-X-Controller", true },
                    { 102, 1, 88, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1721), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playstation 4 Logitech G29", 849m, "Playstation-4-Logitech-G29", true },
                    { 104, 1, 90, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1728), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oculus Rift VR Bundle", 1239m, "Oculus-Rift-VR-Bundle", true },
                    { 64, 1, 47, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1552), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch BGS5335", 699m, "Bosch-BGS5335", true },
                    { 86, 1, 72, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1628), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips FC9735/01", 669m, "Philips-FC9735-01", true },
                    { 18, 1, 7, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1344), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone Original Hi-Fi", 59m, "iPhone-Original-Hi-Fi", true },
                    { 105, 1, 91, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1732), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic MC-CG715K149", 399m, "Panasonic-MC-CG715K149", true },
                    { 107, 1, 93, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1739), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rowenta CV5090F0", 89m, "Rowenta-CV5090F0", true },
                    { 65, 1, 48, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1555), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch TDI902836A", 259m, "Bosch-TDI902836A", true },
                    { 88, 1, 74, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1636), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips GC3802/27", 179m, "Philips-GC3802-27", true },
                    { 108, 1, 94, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1743), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tefal FV9848", 229m, "Tefal-FV9848", true },
                    { 114, 1, 100, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1763), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VITEK VT-8318", 89m, "VITEK-VT-8318", true },
                    { 115, 1, 101, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1766), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Braun IS7056BK", 699m, "Braun-IS7056BK", true },
                    { 87, 1, 73, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1631), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philips BHD184/00", 179m, "Philips-BHD184-00", true },
                    { 116, 1, 103, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1770), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speaker Genius SP-U115", 25m, "Speaker-Genius-SP-U115", true },
                    { 118, 1, 105, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1776), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JBL PARTY BOX 300", 1149m, "JBL-PARTY-BOX-300", true },
                    { 106, 1, 92, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1735), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic KX-3722", 199m, "Panasonic-KX-3722", true },
                    { 45, 1, 27, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1445), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Xiaomi 20000 mAh", 79m, "Power-Bank-Xiaomi-20000-mAh", true },
                    { 121, 1, 109, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1788), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Remax 2600 Mah", 12m, "Power-Bank-Remax-2600-Mah", true },
                    { 130, 1, 118, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1818), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Proda 10000 Mah", 65m, "Power-Bank-Proda-10000-Mah", true },
                    { 131, 1, 119, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1822), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank WK 10000 Mah", 45m, "Power-Bank-WK-10000-Mah", true },
                    { 132, 1, 120, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1825), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Aspor 6000 Mah", 25m, "Power-Bank-Aspor-6000-Mah", true },
                    { 133, 1, 121, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1829), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Bank Bilitong 10000 Mah", 35m, "Power-Bank-Bilitong-10000-Mah", true },
                    { 129, 1, 117, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1815), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman Bluetooth Headset X2S", 27m, "Roman-Bluetooth-Headset-X2S", true },
                    { 83, 1, 68, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1618), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP USB Flash Drive 16GB", 30m, "HP-USB-Flash-Drive-16GB", true },
                    { 134, 1, 122, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1832), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USB Flash Adata 64GB", 59m, "USB-Flash-Adata-64GB", true },
                    { 135, 1, 126, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1836), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roomba 980", 2400m, "Roomba-980", true },
                    { 136, 1, 127, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1875), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Symbol Barkod Reader (LS 2208)", 169m, "Symbol-Barkod-Reader-LS-2208", true },
                    { 137, 1, 128, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1879), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argox Barkod Reader Z3100", 99m, "Argox-Barkod-Reader-Z3100", true },
                    { 139, 1, 130, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1888), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DataLogic Barkod Oxuyucu QW", 129m, "DataLogic-Barkod-Oxuyucu-QW", true },
                    { 138, 1, 129, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1883), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argox Barkod Printer OS 214 Plus", 489m, "Argox-Barkod-Printer-OS-214-Plus", true },
                    { 126, 1, 114, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1805), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USB Dual Driver Sandisk 32GB", 40m, "USB-Dual-Driver-Sandisk-32GB", true },
                    { 100, 1, 86, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1714), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox One X 1TB", 1119m, "Xbox-One-X-1TB", true },
                    { 128, 1, 116, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1811), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bluetooth Jabra Storm", 45m, "Bluetooth-Jabra-Storm", true },
                    { 120, 1, 108, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1783), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Remax Bluetooth Headset T6C", 55m, "Remax-Bluetooth-Headset-T6C", true },
                    { 19, 1, 8, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1348), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple iPhone USB Original", 25m, "Apple-iPhone-USB-Original", true },
                    { 36, 1, 18, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1410), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Travel Adater Fast Type C", 25m, "Samsung-Travel-Adater-Fast-Type-C", true },
                    { 119, 1, 107, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1779), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnet USB Remax", 15m, "Magnet-USB-Remax", true },
                    { 122, 1, 110, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1791), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wireless Charger Rock-W3", 75m, "Wireless-Charger-Rock-W3", true },
                    { 20, 1, 9, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1351), (byte)10, 5, 4m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X Comma Premium Gift", 99m, "iPhone-X-Comma-Premium-Gift", true },
                    { 37, 1, 19, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1417), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Note 8 Active Case", 70m, "Samsung-Note-8-Active-Case", true },
                    { 127, 1, 115, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1808), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beats S460 red", 35m, "Beats-S460-red", true },
                    { 123, 1, 111, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1794), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X Baseus Weaving case", 18m, "iPhone-X-Baseus-Weaving-case", true },
                    { 103, 1, 89, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1725), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse Logitech M187", 10m, "Mouse-Logitech-M187", true },
                    { 117, 1, 104, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1773), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speaker Genius SP-U115", 25m, "Speaker-Genius-SP-U115", true },
                    { 124, 1, 112, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1798), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse A4Tech R7 Bloody", 89m, "Mouse-A4Tech-R7-Bloody", true },
                    { 125, 1, 113, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1801), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SanDisk Micro 128GB 10 Class Ultra", 99m, "SanDisk-Micro-128GB-10-Class-Ultra", true },
                    { 38, 1, 20, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1420), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Hi-Fi Level upro", 59m, "Samsung-Hi-Fi-Level-upro", true },
                    { 95, 1, 81, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1697), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awei Bluetooth Headset A990", 50m, "Awei-Bluetooth-Headset-A990", true },
                    { 82, 1, 67, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1614), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse HP Gaming M100", 18m, "Mouse-HP-Gaming-M100", true },
                    { 140, 1, 131, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1891), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACLAS Çek Printer PP7X USB", 269m, "ACLAS-Çek-Printer-PP7X-USB", true },
                    { 98, 1, 84, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1707), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playstation 4 Fifa 2020", 149m, "Playstation-4-Fifa-2020", true },
                    { 96, 1, 82, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1700), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shivaki 43SF90G", 589m, "Shivaki-43SF90G", true },
                    { 30, 1, 12, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1389), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Watch (46 mm)", 599m, "Samsung-Galaxy-Watch-46-mm", true },
                    { 13, 1, 3, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1323), (byte)0, 0, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Watch Series 4 40mm", 849m, "Apple-Watch-Series-4-40mm", true },
                    { 12, 1, 3, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1320), (byte)0, 0, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Watch Series 5 44mm", 999m, "Apple-Watch-Series-5-44mm", true },
                    { 52, 1, 34, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1509), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Tab P 10", 829m, "Lenovo-Tab-P-10", true },
                    { 40, 1, 22, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1426), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Media Tab 3 10.1", 399m, "Huawei-Media-Tab-3-10-1", true },
                    { 29, 1, 11, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1384), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab A/8.0 LTE", 369m, "Samsung-Galaxy-Tab-A-8-0-LTE", true },
                    { 28, 1, 11, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1380), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab A 10.1", 549m, "Samsung-Galaxy-Tab-A-10-1", true },
                    { 27, 1, 11, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1377), (byte)10, 5, 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Tab S2 VE 8.0", 799m, "Samsung-Galaxy-Tab-S2-VE-8-0", true },
                    { 11, 1, 2, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1316), (byte)0, 0, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE IPAD Air 256 GB (2019)", 1649m, "APPLE-IPAD-Air-256-GB-2019", true },
                    { 10, 1, 2, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1310), (byte)0, 0, 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE IPAD PRO 10.5 WI-FI 4G 256 GB", 1799m, "APPLE-IPAD-PRO-10-5-WI-FI-4G-256-GB", true },
                    { 51, 1, 33, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1504), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honor 10", 1029m, "Honor-10", true },
                    { 49, 1, 31, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1459), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ULEFONE S9 Pro", 229m, "ULEFONE-S9-Pro", true },
                    { 48, 1, 30, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1455), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FLY CIRRUS 7", 259m, "FLY-CIRRUS-7", true },
                    { 47, 1, 29, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1451), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOKIA 6.1 2018", 689m, "NOKIA-6-1-2018", true },
                    { 46, 1, 28, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1448), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meizu M6t", 329m, "Meizu-M6t", true },
                    { 41, 1, 23, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1430), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Black Shark", 1119m, "Xiaomi-Black-Shark", true },
                    { 39, 1, 21, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1423), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei P 30 Pro", 1999m, "Huawei-P-30-Pro", true },
                    { 2, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1186), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro 256 GB", 2850m, "iphone-11-pro-256-gb", true },
                    { 3, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1225), (byte)10, 10, 17m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro Max 64 GB", 2759m, "iphone-11-pro-max-64-gb", true },
                    { 4, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1229), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 11 Pro 64 GB", 2519m, "iphone-11-pro-64-gb", true },
                    { 5, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1235), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 256 GB", 2449m, "iPhone-XS-Max-256-GB", true },
                    { 6, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1240), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 64 GB Dual", 2379m, "iPhone-XS-Max-64-GB-Dual", true },
                    { 7, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1244), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 64 GB", 2199m, "iPhone-XS-Max-64-GB", true },
                    { 42, 1, 24, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1433), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Amazfit Stratos", 369m, "Xiaomi-Amazfit-Stratos", true },
                    { 8, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1302), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS  256 GB", 2189m, "iPhone-XS-256-GB", true },
                    { 21, 1, 10, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1355), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 10 plus", 2149m, "Samsung-Galaxy-Note-10-plus", true },
                    { 22, 1, 10, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1358), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 10", 1949m, "Samsung-Galaxy-Note-10", true },
                    { 23, 1, 10, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1361), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10 Plus", 1899m, "Samsung-Galaxy-S10-Plus", true },
                    { 24, 1, 10, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1367), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10", 1699m, "Samsung-Galaxy-S10", true },
                    { 25, 1, 10, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1370), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 9", 1499m, "Samsung-Galaxy-Note-9", true },
                    { 26, 1, 10, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1374), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10 E", 1449m, "Samsung-Galaxy-S10-E", true },
                    { 9, 1, 1, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1306), (byte)10, 10, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS  64 GB", 1999m, "iPhone-XS-64-GB", true },
                    { 54, 1, 36, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1516), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balafon GPS Watch", 69m, "Balafon-GPS-Watch", true },
                    { 14, 1, 4, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1327), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 256 Gb black", 1859m, "IPhone-XS-Max-256-Gb-black", true },
                    { 15, 1, 4, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1331), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone XS Max 64 GB Gold", 1759m, "iPhone-XS-Max-64-GB-Gold", true },
                    { 16, 1, 5, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1334), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple MacBook Pro MR942", 5490m, "Apple-MacBook-Pro-MR942", true },
                    { 53, 1, 35, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1513), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Yoga 510-14IKB Touch", 1771m, "Lenovo-Yoga-510-14IKB-Touch", true },
                    { 75, 1, 60, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1590), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASUS Zenbook UX301L", 2359m, "ASUS-Zenbook-UX301L", true },
                    { 76, 1, 61, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1593), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acer Nitro 5 AN515-51-782P", 2299m, "Acer-Nitro-5-AN515-51-782P", true },
                    { 77, 1, 62, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1597), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell Inspirion 17 5759", 2249m, "Dell-Inspirion-17-5759", true },
                    { 78, 1, 63, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1600), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP Pavilion - 15-cs0056ur", 2289m, "HP-Pavilion-15-cs0056ur", true },
                    { 63, 1, 46, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1549), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOSCH HMG636BS1", 2829m, "BOSCH-HMG636BS1", true },
                    { 79, 1, 64, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1604), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP Pavilion All-in-One 27-xa0049ur", 2899m, "HP-Pavilion-All-in-One-27-xa0049ur", true },
                    { 84, 1, 69, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1621), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canon MF 633 Cdw", 859m, "Canon-MF-633-Cdw", true },
                    { 85, 1, 70, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1624), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Epson M 2140", 499m, "Epson-M-2140", true },
                    { 81, 1, 66, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1611), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP F24", 389m, "HP-F24", true },
                    { 34, 1, 16, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1403), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung UE65RU7300UXRU", 2669m, "Samsung-UE65RU7300UXRU", true },
                    { 57, 1, 40, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1527), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG OLED55B8SLB", 3599m, "LG-OLED55B8SLB", true },
                    { 94, 1, 80, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1694), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aiwa JH32TS700S", 479m, "Aiwa-JH32TS700S", true },
                    { 80, 1, 65, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1607), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP LaserJet M130 a", 329m, "HP-LaserJet-M130-a", true },
                    { 97, 1, 83, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1704), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playstation 4 VR Bundle 3 in 1", 1049m, "Playstation-4-VR-Bundle-3-in-1", true },
                    { 62, 1, 45, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1545), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOSCH PKN811FP1E", 1309m, "BOSCH-PKN811FP1E", true },
                    { 56, 1, 39, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1524), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG F1296TDT24", 1139m, "LG-F1296TDT24", true },
                    { 31, 1, 13, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1394), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S8 Plus Black", 699m, "Samsung-Galaxy-S8-Plus-Black", true },
                    { 43, 1, 25, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1437), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi 8 128 GB Blue", 559m, "Xiaomi-Mi-8-128-GB-Blue", true },
                    { 50, 1, 32, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1463), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "uleFone S8 (16 GB) Black", 129m, "uleFone-S8-16-GB-Black", true },
                    { 58, 1, 41, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1532), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTC One X9 Gold Dual SIM ", 399m, "HTC-One-X9-Gold-Dual-SIM ", true },
                    { 32, 1, 14, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1397), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung RS57K4000SA/WT", 2369m, "Samsung-RS57K4000SA-WT", true },
                    { 55, 1, 38, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1519), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG GR-B650GLPL", 1869m, "LG-GR-B650GLPL", true },
                    { 74, 1, 59, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1586), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorenje PS10/21100-W7503/S1", 819m, "Gorenje-PS10-21100-W7503-S1", true },
                    { 59, 1, 42, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1535), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HITACHI R-W720FPUC1X", 2959m, "HITACHI-R-W720FPUC1X", true },
                    { 61, 1, 44, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1541), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosch GSN36AI31U", 1899m, "Bosch-GSN36AI31U", true },
                    { 70, 1, 54, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1573), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vestel SD453GR", 999m, "Vestel-SD453GR", true },
                    { 71, 1, 55, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1576), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitsubishi SRC71ZSPR-S", 3199m, "Mitsubishi-SRC71ZSPR-S", true },
                    { 72, 1, 56, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1579), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gree GWH24AAB-K3NNA1A/O", 1569m, "Gree-GWH24AAB-K3NNA1A-O", true },
                    { 73, 1, 57, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1583), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AUX ASW-H30A4/JR1", 2099m, "AUX-ASW-H30A4-JR1", true },
                    { 33, 1, 15, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1400), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung WW70K62E00SDLP", 1199m, "Samsung-WW70K62E00SDLP", true },
                    { 60, 1, 43, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1538), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zanussi ZRB 36101 XA", 1099m, "Zanussi-ZRB-36101-XA", true },
                    { 141, 1, 132, new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(1894), (byte)10, 5, 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Çek Printer TSP-143 U", 489m, "Star-Çek-Printer-TSP-143-U", true }
                });

            migrationBuilder.InsertData(
                table: "HomeHeaders",
                columns: new[] { "Id", "ModifiedAt", "Order", "Photo", "ProductId" },
                values: new object[,]
                {
                    { 7, new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5480), 6, "slider/slider1.jpg", 34 },
                    { 1, new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(4641), 1, "slider/slider4.jpg", 56 },
                    { 2, new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5453), 2, "slider/slider5.jpg", 24 },
                    { 6, new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5477), 5, "slider/slider17.jpg", 75 },
                    { 5, new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5475), 4, "slider/slider2.jpg", 43 },
                    { 3, new DateTime(2020, 1, 17, 16, 46, 18, 12, DateTimeKind.Local).AddTicks(5472), 3, "slider/slider6.jpg", 77 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "ColorId", "Complete", "CreatedAt", "Price", "ProductId", "Quantity", "Status", "UserClientId" },
                values: new object[,]
                {
                    { 7, 1, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9925), 3000m, 2, 1, true, 1 },
                    { 6, 1, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9922), 12000m, 2, 4, true, 1 },
                    { 2, 3, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9760), 6000m, 2, 2, true, 1 },
                    { 4, 2, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9916), 9000m, 4, 3, true, 1 },
                    { 5, 1, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9919), 3000m, 5, 1, true, 1 },
                    { 3, 1, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9911), 3000m, 3, 1, true, 1 },
                    { 1, 1, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(6897), 3000m, 1, 1, true, 1 },
                    { 8, 3, 0, new DateTime(2020, 1, 17, 16, 46, 18, 13, DateTimeKind.Local).AddTicks(9928), 3000m, 1, 1, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "ColorId", "ProductId" },
                values: new object[,]
                {
                    { 92, 1, 92 },
                    { 91, 1, 91 },
                    { 17, 1, 17 },
                    { 52, 1, 52 },
                    { 113, 1, 113 },
                    { 69, 1, 69 },
                    { 12, 1, 12 },
                    { 164, 5, 12 },
                    { 168, 4, 14 },
                    { 165, 2, 12 },
                    { 169, 3, 14 },
                    { 14, 1, 14 },
                    { 93, 1, 93 },
                    { 68, 1, 68 },
                    { 13, 1, 13 },
                    { 166, 2, 13 },
                    { 167, 3, 13 },
                    { 40, 1, 40 },
                    { 111, 1, 111 },
                    { 30, 2, 30 },
                    { 200, 3, 30 },
                    { 54, 1, 54 },
                    { 67, 1, 67 },
                    { 201, 4, 30 },
                    { 42, 1, 42 },
                    { 112, 1, 112 },
                    { 199, 4, 29 },
                    { 175, 3, 17 },
                    { 106, 1, 106 },
                    { 48, 1, 48 },
                    { 118, 1, 118 },
                    { 49, 1, 49 },
                    { 116, 1, 116 },
                    { 51, 1, 51 },
                    { 177, 4, 18 },
                    { 176, 3, 18 },
                    { 10, 1, 10 },
                    { 160, 3, 10 },
                    { 161, 4, 10 },
                    { 18, 2, 18 },
                    { 34, 1, 34 },
                    { 11, 1, 11 },
                    { 162, 4, 11 },
                    { 163, 5, 11 },
                    { 44, 1, 44 },
                    { 27, 1, 27 },
                    { 194, 2, 27 },
                    { 195, 3, 27 },
                    { 28, 1, 28 },
                    { 196, 2, 28 },
                    { 197, 3, 28 },
                    { 35, 1, 35 },
                    { 29, 1, 29 },
                    { 198, 3, 29 },
                    { 66, 1, 66 },
                    { 174, 2, 17 },
                    { 15, 3, 15 },
                    { 203, 3, 31 },
                    { 171, 5, 15 },
                    { 62, 1, 62 },
                    { 64, 1, 64 },
                    { 63, 1, 63 },
                    { 104, 1, 104 },
                    { 16, 3, 16 },
                    { 172, 4, 16 },
                    { 173, 5, 16 },
                    { 102, 1, 102 },
                    { 101, 1, 101 },
                    { 99, 1, 99 },
                    { 53, 1, 53 },
                    { 100, 1, 100 },
                    { 74, 1, 74 },
                    { 75, 1, 75 },
                    { 76, 1, 76 },
                    { 77, 1, 77 },
                    { 97, 1, 97 },
                    { 78, 1, 78 },
                    { 96, 1, 96 },
                    { 79, 1, 79 },
                    { 94, 1, 94 },
                    { 80, 1, 80 },
                    { 84, 1, 84 },
                    { 57, 1, 57 },
                    { 85, 1, 85 },
                    { 81, 1, 81 },
                    { 98, 1, 98 },
                    { 170, 4, 15 },
                    { 86, 1, 86 },
                    { 105, 1, 105 },
                    { 110, 1, 110 },
                    { 31, 1, 31 },
                    { 202, 2, 31 },
                    { 47, 1, 47 },
                    { 90, 1, 90 },
                    { 43, 1, 43 },
                    { 109, 1, 109 },
                    { 50, 1, 50 },
                    { 58, 1, 58 },
                    { 89, 1, 89 },
                    { 32, 1, 32 },
                    { 55, 1, 55 },
                    { 56, 1, 56 },
                    { 115, 1, 115 },
                    { 114, 1, 114 },
                    { 60, 1, 60 },
                    { 108, 1, 108 },
                    { 61, 1, 61 },
                    { 88, 1, 88 },
                    { 70, 1, 70 },
                    { 65, 1, 65 },
                    { 71, 1, 71 },
                    { 107, 1, 107 },
                    { 73, 1, 73 },
                    { 87, 1, 87 },
                    { 33, 1, 33 },
                    { 59, 1, 59 },
                    { 19, 1, 19 },
                    { 72, 1, 72 },
                    { 46, 1, 46 },
                    { 153, 3, 6 },
                    { 95, 1, 95 },
                    { 38, 1, 38 },
                    { 126, 1, 126 },
                    { 125, 1, 125 },
                    { 7, 1, 7 },
                    { 154, 2, 7 },
                    { 155, 3, 7 },
                    { 134, 1, 134 },
                    { 83, 1, 83 },
                    { 124, 1, 124 },
                    { 8, 1, 8 },
                    { 156, 2, 8 },
                    { 157, 3, 8 },
                    { 135, 1, 135 },
                    { 146, 3, 3 },
                    { 82, 1, 82 },
                    { 9, 1, 9 },
                    { 158, 2, 9 },
                    { 136, 1, 136 },
                    { 117, 1, 117 },
                    { 159, 3, 9 },
                    { 152, 2, 6 },
                    { 178, 2, 19 },
                    { 130, 1, 130 },
                    { 3, 1, 3 },
                    { 121, 1, 121 },
                    { 131, 1, 131 },
                    { 4, 1, 4 },
                    { 148, 2, 4 },
                    { 149, 3, 4 },
                    { 132, 1, 132 },
                    { 45, 1, 45 },
                    { 6, 1, 6 },
                    { 129, 1, 129 },
                    { 144, 4, 2 },
                    { 2, 1, 2 },
                    { 128, 1, 128 },
                    { 5, 2, 5 },
                    { 150, 3, 5 },
                    { 151, 4, 5 },
                    { 133, 1, 133 },
                    { 127, 1, 127 },
                    { 120, 1, 120 },
                    { 145, 5, 2 },
                    { 123, 1, 123 },
                    { 103, 1, 103 },
                    { 189, 4, 24 },
                    { 24, 2, 24 },
                    { 188, 3, 24 },
                    { 21, 1, 21 },
                    { 20, 2, 20 },
                    { 25, 3, 25 },
                    { 190, 4, 25 },
                    { 140, 1, 140 },
                    { 191, 5, 25 },
                    { 122, 1, 122 },
                    { 26, 1, 26 },
                    { 192, 2, 26 },
                    { 193, 3, 26 },
                    { 119, 1, 119 },
                    { 143, 3, 1 },
                    { 39, 1, 39 },
                    { 142, 2, 1 },
                    { 36, 1, 36 },
                    { 1, 1, 1 },
                    { 41, 1, 41 },
                    { 141, 1, 141 },
                    { 179, 4, 19 },
                    { 138, 1, 138 },
                    { 180, 4, 20 },
                    { 147, 4, 3 },
                    { 187, 3, 23 },
                    { 182, 2, 21 },
                    { 183, 3, 21 },
                    { 137, 1, 137 },
                    { 139, 1, 139 },
                    { 181, 5, 20 },
                    { 184, 2, 22 },
                    { 185, 3, 22 },
                    { 37, 1, 37 },
                    { 22, 1, 22 },
                    { 186, 2, 23 },
                    { 23, 1, 23 }
                });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "Id", "CreatedAt", "Photo", "ProductId", "Status" },
                values: new object[,]
                {
                    { 146, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2089), "product/d29c5-1-aiwa-jh32bt700s.jpg", 94, true },
                    { 150, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2099), "product/de456-PS-VR-1.jpg", 97, true },
                    { 181, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2169), "product/812e6-sandisk-ultra-dual-usb-m3-0-micro.jpg", 126, true },
                    { 159, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2120), "product/58f92-97af2475ef574516a0c7c42f5f22ff28.jpeg", 105, true },
                    { 59, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1841), "product/a8df2-1129201_v01_b.jpg", 34, true },
                    { 185, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2178), "product/90df9-241531185.jpg", 130, true },
                    { 149, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2096), "product/2d5ed-sony_3001560_playstation_vr_ps4_1245989.jpg", 97, true },
                    { 186, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2180), "product/8962a-image-244538.jpg", 131, true },
                    { 155, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2110), "product/745d0-9558d591a8eff0d270ad94a5c1896826.jpg", 101, true },
                    { 138, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2030), "product/6f999-2.jpg", 86, true },
                    { 191, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2191), "product/180f3-886.jpg", 135, true },
                    { 100, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1940), "product/26bcf-lg_oled_tv_55b8slb1-1.jpg", 57, true },
                    { 193, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2196), "product/40167-argox-as-8000-ccd-kablolu-barkod-okuyucu.jpg", 137, true },
                    { 187, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2182), "product/a9db2-ZUVA0014.png", 132, true },
                    { 111, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1967), "product/22142-11.jpg", 64, true },
                    { 101, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1943), "product/2767d-lg_oled_tv_55b8slb3.jpg", 57, true },
                    { 194, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2198), "product/8abd1-zebra-gc-420t-barkod-yazici-barkod-yazici-38130_500.jpg", 138, true },
                    { 151, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2101), "product/2e9b2-fifa2020.jpeg", 98, true },
                    { 134, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2021), "product/eda36-HP-V220W-USB2.0.jpg", 83, true },
                    { 153, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2105), "product/product11.jpg", 99, true },
                    { 196, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2204), "product/a6474-aclas-pp7x-usb-x.jpg", 140, true },
                    { 158, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2116), "product/a31df-447a2b44-b89c-4b43-ab24-71789d6585cb.jpeg", 104, true },
                    { 152, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2103), "product/product12.jpg", 99, true },
                    { 195, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2200), "product/07461-datalogic-quickscan-lite-qw210.jpg", 139, true },
                    { 156, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2112), "product/7b8ae-61tmThxXwCL._SX425_.jpg", 102, true },
                    { 148, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2094), "product/1b89a-shivaki_32sh90g_2019-02-12_13-52-21.jpg", 96, true },
                    { 188, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2185), "product/a5b90-bilitong-10000mah-power-bank--500x500.jpg", 133, true },
                    { 189, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2187), "product/655d4-Brand-new-Fashion.jpg", 134, true },
                    { 154, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2107), "product/cc70a-Xbox-One-X-600x400.jpg", 100, true },
                    { 190, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2189), "product/19a63-b4e306f7-2672-49a3-92ae-674701322bd7.png", 135, true },
                    { 192, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2193), "product/40167-argox-as-8000-ccd-kablolu-barkod-okuyucu.jpg", 136, true },
                    { 147, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2092), "product/a96ad-bluetooth_stereo_garnitura_awei_a990_bl_black_46.jpg", 95, true },
                    { 161, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2124), "product/b86db-rowenta_cv_5090_images_8899783856.jpg", 107, true },
                    { 133, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2019), "product/eb436-item_XL_24487273_36024943.jpg", 82, true },
                    { 166, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2135), "product/c43dd-5077_1510001396.1200X1200_700x700--1-.jpg", 112, true },
                    { 115, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1977), "product/193d2-MCSA01619347_G1895_TAT6A913_1070026_def.jpg", 68, true },
                    { 178, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2163), "product/dd5ab-item_XL_27390553_67835296.jpg", 123, true },
                    { 145, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2048), "product/5a045-p1cv07udbb3p41ggd1omi3oa19kf4.jpg", 93, true },
                    { 116, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1979), "product/32213-61Jz8-WoS2L._SX425_.jpg", 69, true },
                    { 65, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1855), "product/916ef-coque-etui-housse-pour-samsung.jpg", 37, true },
                    { 167, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2138), "product/c9d5c-a4e391610eb4e3f191e20f0745afd9d8.jpg", 113, true },
                    { 64, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1852), "product/c3658-galaxy-note8-acc_standing.jpg", 37, true },
                    { 34, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1781), "product/1dfb4-2en_2.jpg", 20, true },
                    { 31, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1774), "product/0c1aa-Baseus-Full-Coverage-Screen-Protector.jpg", 17, true },
                    { 60, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1844), "product/5255b-0000260_3d-curved-edge-full.jpeg", 35, true },
                    { 61, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1846), "product/d17fe-SAMS8LCDSCPR83B-1000__17859.1491533735.500.750.jpg", 35, true },
                    { 177, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2159), "product/37d24-2d497ee1-b6d9-42a2-a22f-423c8bc91fd1.jpg", 122, true },
                    { 77, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1886), "product/872a6-MAKAVO-For-Xiaomi-Redmi-Note-5-Pro.jpg", 44, true },
                    { 174, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2153), "product/aa500-390-500x554.jpg", 119, true },
                    { 32, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1776), "product/43f8a-s-l1000.jpg", 18, true },
                    { 63, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1850), "product/db145-samsung-ep-ta20iweugin-travel-adapter_1487920932.jpeg", 36, true },
                    { 171, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2146), "product/5a790-item_XL_8323336_7940917.jpg", 116, true },
                    { 62, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1848), "product/d2605-travel_adapter_samsung_fast.jpg", 36, true },
                    { 173, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2151), "product/04e4d-jbl-partybox-300-wireless-party-speaker.jpg", 118, true },
                    { 33, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1779), "product/73fd6-Wholesale-for-iPhone-8-Pin-Lightning.jpg", 19, true },
                    { 160, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2122), "product/f061c-KX-TG3722.jpg", 106, true },
                    { 144, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2046), "product/234fd-philips_hr1627_00_images_8734980833.jpg", 92, true },
                    { 139, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2033), "product/e48ec-6.jpg", 87, true },
                    { 157, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2114), "product/50380-s0657161_sc7.jpg", 103, true },
                    { 172, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2149), "product/4fcdc-traveler_9000r_2_02.jpg", 117, true },
                    { 176, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2157), "product/c43ec-Remax-Power-Box-Mini-2600-mAh-9292-900x900.jpg", 121, true },
                    { 80, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1892), "product/14fe3-1.jpg", 45, true },
                    { 112, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1970), "product/ef50c-1720017047_w640_h640_utyug-bosch-tdi902836a.jpg", 65, true },
                    { 79, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1890), "product/55d3e-vneshnij-akkumulyator-xiaomi.jpg", 45, true },
                    { 140, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2036), "product/87640-GC3802_27-IMS-ru_RU.jpg", 88, true },
                    { 162, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2126), "product/0a059-6863_1830007152.1200X1200_700x700.jpg", 108, true },
                    { 184, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2176), "product/6d56b-ORIG-Roman-X3s-1428x1228.jpg", 129, true },
                    { 168, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2140), "product/26502-vitek-vt-1209-vt_images_1425588609.jpg", 114, true },
                    { 183, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2174), "product/05d53-item_XL_11469506_16186303.jpg", 128, true },
                    { 169, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2142), "product/de5c3-IS7056BK-1000x1000.jpg", 115, true },
                    { 170, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2144), "product/4711a-braun_is_7056_bk_d.jpg", 115, true },
                    { 141, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2038), "product/1d986-7127109_images_1457230048.jpg", 89, true },
                    { 182, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2171), "product/e4a4e-Beats_Solo_HD_Bluetooth_S_460_Red.jpg", 127, true },
                    { 163, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2128), "product/a8978-1--1-.jpg", 109, true },
                    { 175, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2155), "product/ba53e-advertising-s1.jpg", 120, true },
                    { 142, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2042), "product/d74d6-20038860b.jpg", 90, true },
                    { 66, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1859), "product/02457-Pdpdefault-eo-bg935cbegus-600x600-C1-052016.jpg", 38, true },
                    { 164, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2131), "product/b28f2-mytea_red-1.jpg", 110, true },
                    { 180, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2167), "product/9b4a9-0042341_memorijskakartica-sandisk.jpg", 125, true },
                    { 113, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1972), "product/4391f-juicer-bosch-mes4000-silver.jpg", 66, true },
                    { 143, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2044), "product/e0788-1cyyBR9sQRE74UHjZ3DSQ.jpg", 91, true },
                    { 179, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2165), "product/35a78-A4TECH-Bloody-R7-R70-Wireless-Gaming-Mouse-World-s-Fastest-Key.jpg", 124, true },
                    { 165, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2133), "product/a3c2a-1b-sokovyzhimalka-tefal-ze550d38.jpg", 111, true },
                    { 114, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1974), "product/b111c-MCSA00726979_E4593_MSM67190_378570_korr_def.jpg", 67, true },
                    { 78, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1888), "product/be99b-gs100.jpg", 44, true },
                    { 198, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2208), "product/555b5-sraseq.jpg", 141, true },
                    { 131, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2015), "product/bda07-c06179404.png", 81, true },
                    { 11, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1664), "product/be5f7-l_10185950_001.jpg", 6, true },
                    { 132, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2017), "product/96ef6-monoblok-hp-pavilion-27-xa0046ur-aio-5kp15ea-belyj-27.jpg", 81, true },
                    { 20, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1747), "product/17122--------------iPad-6------------------------.jpg", 11, true },
                    { 47, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1813), "product/06a0b-Samsung-Galaxy-Tab-S2-VE.png", 27, true },
                    { 48, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1816), "product/52832-Samsung-Galaxy-Tab-A-10.png", 27, true },
                    { 49, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1819), "product/52832-Samsung-Galaxy-Tab-A-10.png", 28, true },
                    { 50, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1821), "product/06a0b-Samsung-Galaxy-Tab-S2-VE.png", 28, true },
                    { 51, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1823), "product/3193f-Samsung-Galaxy-Tab-A7.0-2.png", 29, true },
                    { 52, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1825), "product/06a0b-Samsung-Galaxy-Tab-S2-VE.png", 29, true },
                    { 69, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1867), "product/a7331-41AdlRlQzRL._SY355_.jpg", 40, true },
                    { 70, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1869), "product/b56fb-csm_4_zu_3_Huawei_MediaPad_T3_10_57ec177426.jpg", 40, true },
                    { 91, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1919), "product/c2606-lenovo-tab-p10.jpg", 52, true },
                    { 12, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1667), "product/f2ddd-l_10185951_001.jpg", 6, true },
                    { 92, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1922), "product/80a1d-Lenovo-Tab-M10-Tablet-600x507.jpg", 52, true },
                    { 9, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1657), "product/a0915-3ff7e-1.jpg", 5, true },
                    { 21, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1749), "product/8dcf6-bb582ec8128fd58df69520834e1ab7ae.jpg", 12, true },
                    { 22, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1752), "product/00d79-MTPK2_VW_34FR-watch-44-alum-silver-nc-5s_VW_34FR_WF_CO.jpg", 12, true },
                    { 23, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1754), "product/50de3-44-alu-gold-sport-pink-sand-nc-s4-gallery1_GEO_GB.jpg", 13, true },
                    { 24, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1756), "product/00d79-MTPK2_VW_34FR-watch-44-alum-silver-nc-5s_VW_34FR_WF_CO.jpg", 13, true },
                    { 53, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1828), "product/d891c-samsung_sm_r800nzsaxar_galileo_smartwatch_silver_1429263.jpg", 30, true },
                    { 73, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1876), "product/258ac-1000.1000_1f9e58da626e43e9b33aafea1b061d2c.jpg", 42, true },
                    { 74, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1879), "product/5ca3c-49848484.jpg", 42, true },
                    { 95, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1928), "product/47220-68526_Gps-tracker-kid-safe-smart-watch.jpg", 54, true },
                    { 15, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1673), "product/be5f7-l_10185950_001.jpg", 8, true },
                    { 25, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1758), "product/a0915-3ff7e-1.jpg", 14, true },
                    { 26, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1761), "product/7adc3-6e4b1-Apple-IPHONE-XS-MAX-64-GB-grey.jpg", 14, true },
                    { 10, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1661), "product/7adc3-6e4b1-Apple-IPHONE-XS-MAX-64-GB-grey.jpg", 5, true },
                    { 19, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1745), "product/17122--------------iPad-6------------------------.jpg", 10, true },
                    { 90, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1917), "product/8e3c3-428_428_1523443560490.jpg", 51, true },
                    { 88, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1912), "product/0dbb1-989.png", 49, true },
                    { 17, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1678), "product/f2ddd-l_10185951_001.jpg", 9, true },
                    { 18, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1741), "product/be5f7-l_10185950_001.jpg", 9, true },
                    { 35, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1783), "product/6b44f-samsung-galaxy-note10-plus-aura-black.jpg", 21, true },
                    { 36, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1786), "product/90ecf-samsung-galaxy-note10-plus-aura-white.jpg", 21, true },
                    { 37, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1788), "product/9de81-samsung-galaxy-note10-aura-white.jpg", 22, true },
                    { 38, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1791), "product/6b44f-samsung-galaxy-note10-plus-aura-black.jpg", 22, true },
                    { 39, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1793), "product/ad082-61jE22Q4J2L._SX425_.jpg", 23, true },
                    { 40, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1795), "product/41928-61YVqHdFRxL._SL1322_.jpg", 23, true },
                    { 41, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1798), "product/78896-Samsung-Galaxy-S10-128GB.jpg", 24, true },
                    { 14, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1671), "product/be5f7-l_10185950_001.jpg", 7, true },
                    { 42, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1800), "product/a0e2e-s10_2-1.jpg", 24, true },
                    { 43, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1802), "product/91e94-81vB-Irbk9L._SL1500_.jpg", 25, true },
                    { 44, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1804), "product/9c9a0-samsng_note_9.jpg", 25, true },
                    { 45, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1807), "product/d9d15-190202-samsung-galaxy-s10e-01.jpg", 26, true },
                    { 46, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1810), "product/6afdd-samsung-galaxy-s10e-white.jpg", 26, true },
                    { 67, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1862), "product/3e6c7-p30proaurorahero.jpg.4e68899253.999x600x550.jpg", 39, true },
                    { 68, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1864), "product/4e434-51zDfRUUhHL._SX425_.jpg", 39, true },
                    { 71, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1871), "product/ce7aa-xiaomi-black-shark-8gb128gb-black-global.jpg", 41, true },
                    { 72, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1874), "product/619ed-xiaomi-black-shark-6gb-64gb-dual-sim-black.jpg", 41, true },
                    { 81, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1895), "product/45f67-Meizu_M6T_L_1.jpg", 46, true },
                    { 82, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1897), "product/4a4c1-2c4839a6cc370f5269233bffec6369e9-254x300.jpg", 46, true },
                    { 13, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1669), "product/f2ddd-l_10185951_001.jpg", 7, true },
                    { 83, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1900), "product/59f3a-61eGeaQ45VL._SX569_.jpg", 47, true },
                    { 84, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1903), "product/ef41b-1519637855_635_nokia_6_android_one.jpg", 47, true },
                    { 85, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1905), "product/31c63-FLY-NIMBUS-9.png", 48, true },
                    { 86, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1908), "product/c0960-37a4c0b68c456c44742f59a38127b45f_300x300.jpg", 48, true },
                    { 87, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1910), "product/4c564-s9pro.png", 49, true },
                    { 7, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1652), "product/48d85-221132_pjpeg.jpg", 4, true },
                    { 27, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1763), "product/be5f7-l_10185950_001.jpg", 15, true },
                    { 8, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1654), "product/7920f-iPhone-XI.jpeg", 4, true },
                    { 54, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1830), "product/21cb8-Samsung-Galaxy-S8-Plus-1.png", 31, true },
                    { 121, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1991), "product/57572-8845618053150.jpg", 74, true },
                    { 109, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1963), "product/6869e-mcsa01734543-pkn811fp1e-electrichob-bosch-stp-def.jpg", 62, true },
                    { 110, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1965), "product/397bd-mcsa00766690-411043-hmg636bs1-def.jpg", 63, true },
                    { 28, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1766), "product/f2ddd-l_10185951_001.jpg", 15, true },
                    { 30, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1772), "product/8e3a1-apple-macbook-pro-15-retina.png", 16, true },
                    { 6, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1650), "product/48d85-221132_pjpeg.jpg", 3, true },
                    { 5, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1647), "product/7920f-iPhone-XI.jpeg", 3, true },
                    { 93, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1924), "product/55fe3-4zu3_Lenovo_Yoga_510_Teaser.jpg", 53, true },
                    { 94, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1926), "product/a2f82-copy_lenovo_80vb005fra_587e1b47dadc1_images_1837230040.jpg", 53, true },
                    { 122, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1994), "product/411e1-ASUS-Zenbook-UX301L.png", 75, true },
                    { 123, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1996), "product/a15f4-ASUS-Zenbook-UX301L.jpg", 75, true },
                    { 124, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1999), "product/60264-large_9212_acer-nitro-5-an515-51-nh-q2rer-001-black-1304615-1.jpg", 76, true },
                    { 125, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2001), "product/cff28-Dell-Inspirion-17-5759.jpeg", 77, true },
                    { 126, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2003), "product/26989-Dell-Inspirion-17-57592.jpg", 77, true },
                    { 127, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2006), "product/8b7e0-1157594-1024x768.jpg", 78, true },
                    { 128, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2008), "product/bda07-c06179404.png", 79, true },
                    { 129, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2010), "product/96ef6-monoblok-hp-pavilion-27-xa0046ur-aio-5kp15ea-belyj-27.jpg", 79, true },
                    { 130, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2013), "product/3cefb-14265876.jpg", 80, true },
                    { 135, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2023), "product/31ee5-1475c009aa-1_1_1.jpg", 84, true },
                    { 136, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2026), "product/54de5-Canon-i-SENSYS-MF633-Left-Large.jpg", 84, true },
                    { 4, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1645), "product/a6bc8-iPhone-11-Pro-Max-256GB-Gold-1.png", 2, true },
                    { 3, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1642), "product/48d85-221132_pjpeg.jpg", 2, true },
                    { 2, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1614), "product/a6bc8-iPhone-11-Pro-Max-256GB-Gold-1.png", 1, true },
                    { 1, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(52), "product/856a5-iphone-11-pro-select-2019-family.jpg", 1, true },
                    { 137, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2028), "product/acd36-155135057906695c77bb331062c240.jpeg", 85, true },
                    { 99, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1938), "product/a7437-medium04_F12B8QD5_FrontOpen_Silver.jpg", 56, true },
                    { 98, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1936), "product/53aaf-mega-medium.jpg", 56, true },
                    { 29, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1769), "product/010bd-ddsadasdsadasdasdad.jpg", 16, true },
                    { 57, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1837), "product/2f980-Samsung-WW70K62E00SDLP.jpg", 33, true },
                    { 75, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1881), "product/cb256-888888.jpg", 43, true },
                    { 76, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1883), "product/ef431-707d6-Global-Version.jpg", 43, true },
                    { 89, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1915), "product/3064e-s8.jpg", 50, true },
                    { 102, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1945), "product/b9145-x9.jpg", 58, true },
                    { 55, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1832), "product/04759-Samsung-RS57K4000SAWT.jpg", 32, true },
                    { 56, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1834), "product/f2e47-Samsung-RS57K4000SAWT2.jpg", 32, true },
                    { 96, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1931), "product/a3dff-refrigerators-gr-b650glpl-750x480.jpg", 55, true },
                    { 97, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1933), "product/4db1f-copy-large02.jpg", 55, true },
                    { 103, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1948), "product/58251-soyuducu-hitachi-r-w720puc1-gbk-new-630x552.jpg", 59, true },
                    { 104, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1951), "product/5d3dc-hitachi-r-w720fpuc1x-gbk_images_1490044930-630x552.jpg", 59, true },
                    { 58, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1839), "product/0b362-Samsung-WW70K62E00SDLP2.jpg", 33, true },
                    { 105, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1954), "product/7a81a-Zanussi-ZRB-36101-XA.jpg", 60, true },
                    { 106, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1956), "product/295ac-Zanussi-ZRB-36101XA.jpg", 60, true },
                    { 107, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1959), "product/84b16-mcsa02343948-i2025-1745639-gsn36ai31u-cmyk-def.jpg", 61, true },
                    { 108, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1961), "product/dfb76-mcsa02343828-i2015-1745524-gsn36ai31u-pga2-cmyk-def.jpg", 61, true },
                    { 16, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1675), "product/f2ddd-l_10185951_001.jpg", 8, true },
                    { 117, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1981), "product/64bbe-98-1-vestel-sd450g-a-46970778995.jpg", 70, true },
                    { 118, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1984), "product/ce317-srk-zspr-s-3.jpg", 71, true },
                    { 197, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(2206), "product/3d33b-staer.jpg", 141, true },
                    { 120, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1988), "product/311b2-5b111ad12a7ff.jpg", 73, true },
                    { 119, new DateTime(2020, 1, 17, 16, 46, 18, 11, DateTimeKind.Local).AddTicks(1986), "product/e18c1-31bb1-p1cegsbak5at11i9f1d6t1c61ui16.jpg", 72, true }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "AdminManagerId", "Content", "CreatedAt", "ProductId", "UserClientId" },
                values: new object[,]
                {
                    { 7, null, "Excelent!!!", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7637), 6, 1 },
                    { 1, null, "Excelent!!!", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(6780), 1, 1 },
                    { 3, null, "Ucuzdur!!!", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7627), 2, 1 },
                    { 5, null, "Cheap!!!", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7632), 4, 1 },
                    { 2, 1, "Endirimli Mehsullarimizdan yararlanin", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7607), 1, null },
                    { 6, null, "Very Cheap!!!", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7634), 5, 1 },
                    { 4, null, "Bahadir!!!", new DateTime(2020, 1, 17, 16, 46, 18, 9, DateTimeKind.Local).AddTicks(7629), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "ProductId" },
                values: new object[,]
                {
                    { 27, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 7 },
                    { 24, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 4 },
                    { 28, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 8 },
                    { 21, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 1 },
                    { 2, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 2 },
                    { 26, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 6 },
                    { 6, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 6 },
                    { 8, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 8 },
                    { 4, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 4 },
                    { 7, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 7 },
                    { 5, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 5 },
                    { 23, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 3 },
                    { 3, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 3 },
                    { 22, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 2 },
                    { 25, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 5 },
                    { 31, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 11 },
                    { 29, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 9 },
                    { 9, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 9 },
                    { 36, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 16 },
                    { 16, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 16 },
                    { 35, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 15 },
                    { 15, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 15 },
                    { 34, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 14 },
                    { 14, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 14 },
                    { 33, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 13 },
                    { 13, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 13 },
                    { 32, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 12 },
                    { 12, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 12 },
                    { 1, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 1 },
                    { 37, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 17 },
                    { 11, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 11 },
                    { 18, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 18 },
                    { 38, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 18 },
                    { 30, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 10 },
                    { 10, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 10 },
                    { 19, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 19 },
                    { 39, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 19 },
                    { 20, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 20 },
                    { 17, "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget.", 1, 17 },
                    { 40, "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy", 2, 20 }
                });

            migrationBuilder.InsertData(
                table: "ProperityProducts",
                columns: new[] { "Id", "CreatedAt", "Key", "ProductId", "ProperityId" },
                values: new object[,]
                {
                    { 6, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2514), "Hexa-core (2x2.65 GHz Lightning + 4x1.8 GHz Thunder)", 1, 6 },
                    { 5, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2512), "Apple A13 Bionic (7 nm+)", 1, 5 },
                    { 4, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2509), "iOS 13, upgradable to iOS 13.1", 1, 4 },
                    { 3, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2506), "Single SIM  or Dual SIM", 1, 3 },
                    { 2, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2486), "226 g (7.97 oz)", 1, 2 },
                    { 23, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2713), "100 Hz", 34, 35 },
                    { 25, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2718), "USB, HDMI", 34, 37 },
                    { 24, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2715), "+", 34, 36 },
                    { 7, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2516), "256 GB", 1, 7 },
                    { 22, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2711), "LED", 34, 34 },
                    { 21, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2707), "65(164 sm)", 34, 16 },
                    { 1, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(1653), "158 x 77.8 x 8.1 mm (6.22 x 3.06 x 0.32 in)", 1, 1 },
                    { 8, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2518), "4 GB RAM", 1, 8 },
                    { 14, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2532), "5.0, A2DP, LE", 1, 14 },
                    { 10, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2523), "12 MP, f/1.8, 26mm (wide), 1/2.55", 1, 10 },
                    { 11, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2525), "2160p@24/30/60fps, 1080p@30/60/120/240fps, HDR, stereo sound rec.", 1, 11 },
                    { 12, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2528), "12 MP, f/2.2 TOF 3D camera", 1, 12 },
                    { 13, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2530), "Wi-Fi 802.11 a/b/g/n/ac/ax, dual-band, hotspot", 1, 13 },
                    { 15, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2534), "Non-removable Li-Ion 3969 mAh battery (15.04 Wh)", 1, 15 },
                    { 26, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2720), "+", 34, 38 },
                    { 27, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2722), "-", 34, 39 },
                    { 28, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2724), "AVI, DivX, MKV, MPEG4,MP3,WMA,JPEG", 34, 40 },
                    { 29, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2726), "1452.7 x 918.1 x 312.8 mm", 34, 1 },
                    { 19, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2543), "USB, HDMI, VGA", 16, 31 },
                    { 18, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2541), "16 GB", 16, 8 },
                    { 17, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2538), "512 GB SSD", 16, 7 },
                    { 16, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2536), "Intel Core i7,2.6Ghz", 16, 5 },
                    { 9, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2521), "-", 1, 9 },
                    { 20, new DateTime(2020, 1, 17, 16, 46, 18, 10, DateTimeKind.Local).AddTicks(2701), "Wi-Fi / LAN / BT", 16, 32 }
                });

            migrationBuilder.InsertData(
                table: "HomeHeaderTranslates",
                columns: new[] { "Id", "HomeHeaderId", "LanguageId", "Title" },
                values: new object[,]
                {
                    { 2, 2, 1, "dual front" },
                    { 5, 2, 2, "2 kameralı" },
                    { 7, 5, 1, "New 2019" },
                    { 9, 5, 2, "Yeni 2019" },
                    { 1, 1, 1, "best skin" },
                    { 4, 1, 2, "Əla Dizayn" },
                    { 8, 6, 1, "Sale Off Laptop" },
                    { 10, 6, 2, "Endirimli" },
                    { 3, 3, 1, "Hurry Up!" },
                    { 6, 3, 2, "Tələsin!" },
                    { 11, 7, 1, "Sale Off Laptop" },
                    { 12, 7, 2, "Endirimli" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutSettings_AdminManagerId",
                table: "AboutSettings",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSettingTranslates_AboutSettingId",
                table: "AboutSettingTranslates",
                column: "AboutSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSettingTranslates_LanguageId",
                table: "AboutSettingTranslates",
                column: "LanguageId");

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
                name: "IX_BrandProductCategories_BrandId",
                table: "BrandProductCategories",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandProductCategories_ProductSubCategoryId",
                table: "BrandProductCategories",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_AdminManagerId",
                table: "Brands",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AdminManagerId",
                table: "Categories",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_AdminManagerId",
                table: "Faqs",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_FaqTranslates_FaqId",
                table: "FaqTranslates",
                column: "FaqId");

            migrationBuilder.CreateIndex(
                name: "IX_FaqTranslates_LanguageeId",
                table: "FaqTranslates",
                column: "LanguageeId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeHeaders_ProductId",
                table: "HomeHeaders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeHeaderTranslates_HomeHeaderId",
                table: "HomeHeaderTranslates",
                column: "HomeHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeHeaderTranslates_LanguageId",
                table: "HomeHeaderTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ColorId",
                table: "OrderProducts",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_UserClientId",
                table: "OrderProducts",
                column: "UserClientId");

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
                name: "IX_Partners_AdminManagerId",
                table: "Partners",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_AdminManagerId",
                table: "ProductCategories",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslates_LanguageId",
                table: "ProductCategoryTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslates_ProductCategoryId",
                table: "ProductCategoryTranslates",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ColorId",
                table: "ProductColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductId",
                table: "ProductColors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPhotos_ProductId",
                table: "ProductPhotos",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_AdminManagerId",
                table: "ProductReviews",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_UserClientId",
                table: "ProductReviews",
                column: "UserClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdminManagerId",
                table: "Products",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandProductCategoryId",
                table: "Products",
                column: "BrandProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_AdminManagerId",
                table: "ProductSubCategories",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategoryTranslates_LanguageId",
                table: "ProductSubCategoryTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategoryTranslates_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslates_LanguageId",
                table: "ProductTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslates_ProductId",
                table: "ProductTranslates",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Properities_AdminManagerId",
                table: "Properities",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityCategories_ProductSubCategoryId",
                table: "ProperityCategories",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityCategories_ProperityId",
                table: "ProperityCategories",
                column: "ProperityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityProducts_ProductId",
                table: "ProperityProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityProducts_ProperityId",
                table: "ProperityProducts",
                column: "ProperityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityTranslates_LanguageId",
                table: "ProperityTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProperityTranslates_ProperityId",
                table: "ProperityTranslates",
                column: "ProperityId");

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

            migrationBuilder.CreateIndex(
                name: "IX_WhatDos_AdminManagerId",
                table: "WhatDos",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDos_LanguageId",
                table: "WhatDos",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDos_WhatDoId",
                table: "WhatDos",
                column: "WhatDoId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDosTranslates_LanguageId",
                table: "WhatDosTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatDosTranslates_WhatDoId",
                table: "WhatDosTranslates",
                column: "WhatDoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutSettingTranslates");

            migrationBuilder.DropTable(
                name: "AdminCategoryTranslates");

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
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "BlogCategoryTranslates");

            migrationBuilder.DropTable(
                name: "BlogReviews");

            migrationBuilder.DropTable(
                name: "BlogTranslates");

            migrationBuilder.DropTable(
                name: "FaqTranslates");

            migrationBuilder.DropTable(
                name: "HomeHeaderTranslates");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "OurServiceTranslates");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "ProductCategoryTranslates");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductPhotos");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "ProductSubCategoryTranslates");

            migrationBuilder.DropTable(
                name: "ProductTranslates");

            migrationBuilder.DropTable(
                name: "ProperityCategories");

            migrationBuilder.DropTable(
                name: "ProperityProducts");

            migrationBuilder.DropTable(
                name: "ProperityTranslates");

            migrationBuilder.DropTable(
                name: "ServicesCoverTranslates");

            migrationBuilder.DropTable(
                name: "SettingTranslates");

            migrationBuilder.DropTable(
                name: "SocialActivities");

            migrationBuilder.DropTable(
                name: "WhatDosTranslates");

            migrationBuilder.DropTable(
                name: "AboutSettings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "HomeHeaders");

            migrationBuilder.DropTable(
                name: "OurServices");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "UserClients");

            migrationBuilder.DropTable(
                name: "Properities");

            migrationBuilder.DropTable(
                name: "ServicesCovers");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "WhatDos");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "BrandProductCategories");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AdminManagers");

            migrationBuilder.DropTable(
                name: "AdminCategories");
        }
    }
}
