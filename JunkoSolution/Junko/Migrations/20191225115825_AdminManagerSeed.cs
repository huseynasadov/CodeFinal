using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class AdminManagerSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.InsertData(
                table: "AdminCategories",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 4, true },
                    { 2, true },
                    { 3, true }
                });

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 364, DateTimeKind.Local).AddTicks(6816), "about/about-us-person1.png" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(1802), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(3981), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4018), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4023), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4027), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4032), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4035), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4039), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4043), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4047), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4051), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4055), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4059), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4063), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 12, 25, 15, 58, 24, 366, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(5271), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6790), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6817), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6821), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6825), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6828), new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 368, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 367, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 367, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 367, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 361, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 363, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 363, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 369, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 58, 24, 369, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.InsertData(
                table: "AdminCategoryTranslates",
                columns: new[] { "Id", "AdminCategoryId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 3, 2, 1, "Designer" },
                    { 4, 2, 2, "Dizayner" },
                    { 5, 3, 1, "Developer" },
                    { 6, 3, 2, "Proqramçı" },
                    { 7, 4, 1, "Accountant" },
                    { 8, 4, 2, "Mühasib" }
                });

            migrationBuilder.InsertData(
                table: "AdminManagers",
                columns: new[] { "Id", "AdminCategoryId", "CreatedAt", "DeadLineAt", "Email", "Firstname", "Lastname", "Password", "Phone", "Photo", "Status", "Token" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(3225), null, "Mary@code.edu.az", "Marilyn", "monroe", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person2.png", true, null },
                    { 3, 3, new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(3325), null, "Michael@code.edu.az", "Michael", "Monroe", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person3.png", true, null },
                    { 4, 4, new DateTime(2019, 12, 25, 15, 58, 24, 365, DateTimeKind.Local).AddTicks(3330), null, "James@code.edu.az", "James", "James", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "about/about-us-person4.png", true, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminCategoryTranslates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdminCategoryTranslates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdminCategoryTranslates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdminCategoryTranslates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdminCategoryTranslates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AdminCategoryTranslates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdminCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdminCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdminCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 424, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Photo" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 420, DateTimeKind.Local).AddTicks(979), "download.jpeg" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(5265), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7431), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7465), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7470), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7474), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7478), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7482), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7486), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7490), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7494), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7497), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7501), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7505), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7509), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7513), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 420, DateTimeKind.Local).AddTicks(8715), new DateTime(2019, 12, 25, 15, 42, 24, 420, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(221), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(244), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(248), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(253), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(257), new DateTime(2019, 12, 25, 15, 42, 24, 421, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 423, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 422, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 422, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 422, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 417, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 418, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 418, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 424, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 15, 42, 24, 424, DateTimeKind.Local).AddTicks(9771));
        }
    }
}
