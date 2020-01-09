using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class TranslateTablesIdnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutSettingTranslates_AboutSettings_AboutSettingId",
                table: "AboutSettingTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_AdminCategoryTranslates_AdminCategories_AdminCategoryId",
                table: "AdminCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategoryTranslates_Categories_CategoryId",
                table: "BlogCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogTranslates_Blogs_BlogId",
                table: "BlogTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_FaqTranslates_Faqs_FaqId",
                table: "FaqTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeHeaderTranslates_HomeHeaders_HomeHeaderId",
                table: "HomeHeaderTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_OurServiceTranslates_OurServices_OurServiceId",
                table: "OurServiceTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryTranslates_ProductCategories_ProductCategoryId",
                table: "ProductCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslates_Products_ProductId",
                table: "ProductTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProperityTranslates_Properities_ProperityId",
                table: "ProperityTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicesCoverTranslates_ServicesCovers_ServicesCoverId",
                table: "ServicesCoverTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_WhatDosTranslates_WhatDos_WhatDoId",
                table: "WhatDosTranslates");

            migrationBuilder.AlterColumn<int>(
                name: "WhatDoId",
                table: "WhatDosTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServicesCoverId",
                table: "ServicesCoverTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProperityId",
                table: "ProperityTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "ProductCategoryTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OurServiceId",
                table: "OurServiceTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HomeHeaderId",
                table: "HomeHeaderTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FaqId",
                table: "FaqTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "BlogTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "BlogCategoryTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdminCategoryId",
                table: "AdminCategoryTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AboutSettingId",
                table: "AboutSettingTranslates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 488, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 471, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 473, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 473, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 474, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "BlogReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 479, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(104), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7721), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7832), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7847), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7862), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7876), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7892), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8091), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8105), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8122), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8136), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8150), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8164), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8178), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8193), new DateTime(2020, 1, 9, 14, 49, 36, 477, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 496, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 474, DateTimeKind.Local).AddTicks(6763), new DateTime(2020, 1, 9, 14, 49, 36, 474, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(1954), new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2032), new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2046), new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2061), new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2074), new DateTime(2020, 1, 9, 14, 49, 36, 475, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 519, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 519, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 519, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 519, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 519, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 493, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 494, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 494, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 494, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 494, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 494, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 494, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 522, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 522, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 522, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 522, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 522, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "HomeHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 522, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 526, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 486, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 525, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 497, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 498, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 517, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 518, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 513, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 501, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 510, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 511, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 504, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Properities",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 505, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 514, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "ProperityProducts",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 515, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 483, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 484, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 484, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 450, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 467, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 467, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "UserClients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 464, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 491, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2020, 1, 9, 14, 49, 36, 491, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.AddForeignKey(
                name: "FK_AboutSettingTranslates_AboutSettings_AboutSettingId",
                table: "AboutSettingTranslates",
                column: "AboutSettingId",
                principalTable: "AboutSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdminCategoryTranslates_AdminCategories_AdminCategoryId",
                table: "AdminCategoryTranslates",
                column: "AdminCategoryId",
                principalTable: "AdminCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategoryTranslates_Categories_CategoryId",
                table: "BlogCategoryTranslates",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTranslates_Blogs_BlogId",
                table: "BlogTranslates",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FaqTranslates_Faqs_FaqId",
                table: "FaqTranslates",
                column: "FaqId",
                principalTable: "Faqs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeHeaderTranslates_HomeHeaders_HomeHeaderId",
                table: "HomeHeaderTranslates",
                column: "HomeHeaderId",
                principalTable: "HomeHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OurServiceTranslates_OurServices_OurServiceId",
                table: "OurServiceTranslates",
                column: "OurServiceId",
                principalTable: "OurServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryTranslates_ProductCategories_ProductCategoryId",
                table: "ProductCategoryTranslates",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslates_Products_ProductId",
                table: "ProductTranslates",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProperityTranslates_Properities_ProperityId",
                table: "ProperityTranslates",
                column: "ProperityId",
                principalTable: "Properities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicesCoverTranslates_ServicesCovers_ServicesCoverId",
                table: "ServicesCoverTranslates",
                column: "ServicesCoverId",
                principalTable: "ServicesCovers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WhatDosTranslates_WhatDos_WhatDoId",
                table: "WhatDosTranslates",
                column: "WhatDoId",
                principalTable: "WhatDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutSettingTranslates_AboutSettings_AboutSettingId",
                table: "AboutSettingTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_AdminCategoryTranslates_AdminCategories_AdminCategoryId",
                table: "AdminCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategoryTranslates_Categories_CategoryId",
                table: "BlogCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogTranslates_Blogs_BlogId",
                table: "BlogTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_FaqTranslates_Faqs_FaqId",
                table: "FaqTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeHeaderTranslates_HomeHeaders_HomeHeaderId",
                table: "HomeHeaderTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_OurServiceTranslates_OurServices_OurServiceId",
                table: "OurServiceTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryTranslates_ProductCategories_ProductCategoryId",
                table: "ProductCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslates_Products_ProductId",
                table: "ProductTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ProperityTranslates_Properities_ProperityId",
                table: "ProperityTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicesCoverTranslates_ServicesCovers_ServicesCoverId",
                table: "ServicesCoverTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_WhatDosTranslates_WhatDos_WhatDoId",
                table: "WhatDosTranslates");

            migrationBuilder.AlterColumn<int>(
                name: "WhatDoId",
                table: "WhatDosTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServicesCoverId",
                table: "ServicesCoverTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProperityId",
                table: "ProperityTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "ProductCategoryTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OurServiceId",
                table: "OurServiceTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HomeHeaderId",
                table: "HomeHeaderTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FaqId",
                table: "FaqTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "BlogTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "BlogCategoryTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminCategoryId",
                table: "AdminCategoryTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AboutSettingId",
                table: "AboutSettingTranslates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AboutSettingTranslates_AboutSettings_AboutSettingId",
                table: "AboutSettingTranslates",
                column: "AboutSettingId",
                principalTable: "AboutSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdminCategoryTranslates_AdminCategories_AdminCategoryId",
                table: "AdminCategoryTranslates",
                column: "AdminCategoryId",
                principalTable: "AdminCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategoryTranslates_Categories_CategoryId",
                table: "BlogCategoryTranslates",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTranslates_Blogs_BlogId",
                table: "BlogTranslates",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FaqTranslates_Faqs_FaqId",
                table: "FaqTranslates",
                column: "FaqId",
                principalTable: "Faqs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeHeaderTranslates_HomeHeaders_HomeHeaderId",
                table: "HomeHeaderTranslates",
                column: "HomeHeaderId",
                principalTable: "HomeHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OurServiceTranslates_OurServices_OurServiceId",
                table: "OurServiceTranslates",
                column: "OurServiceId",
                principalTable: "OurServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryTranslates_ProductCategories_ProductCategoryId",
                table: "ProductCategoryTranslates",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategoryTranslates_ProductSubCategories_ProductSubCategoryId",
                table: "ProductSubCategoryTranslates",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslates_Products_ProductId",
                table: "ProductTranslates",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProperityTranslates_Properities_ProperityId",
                table: "ProperityTranslates",
                column: "ProperityId",
                principalTable: "Properities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicesCoverTranslates_ServicesCovers_ServicesCoverId",
                table: "ServicesCoverTranslates",
                column: "ServicesCoverId",
                principalTable: "ServicesCovers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WhatDosTranslates_WhatDos_WhatDoId",
                table: "WhatDosTranslates",
                column: "WhatDoId",
                principalTable: "WhatDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
