using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class AdminBlogTranslateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminManagerId",
                table: "SocialActivities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminManagerId",
                table: "SettingTranslates",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminManagerId",
                table: "Setting",
                nullable: true);

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
                name: "BlogCategory",
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
                    table.PrimaryKey("PK_BlogCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCategory_AdminManagers_AdminManagerId",
                        column: x => x.AdminManagerId,
                        principalTable: "AdminManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogCategory_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategory_Categories_CategoryId",
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

            migrationBuilder.InsertData(
                table: "AdminCategories",
                columns: new[] { "Id", "Status" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 21, 32, 24, 431, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 21, 32, 24, 432, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 21, 32, 24, 432, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "SocialActivities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "linkedin");

            migrationBuilder.InsertData(
                table: "AdminCategoryTranslates",
                columns: new[] { "Id", "AdminCategoryId", "LanguageId", "Name" },
                values: new object[] { 1, 1, 1, "Director" });

            migrationBuilder.InsertData(
                table: "AdminCategoryTranslates",
                columns: new[] { "Id", "AdminCategoryId", "LanguageId", "Name" },
                values: new object[] { 2, 1, 2, "Direktor" });

            migrationBuilder.InsertData(
                table: "AdminManagers",
                columns: new[] { "Id", "AdminCategoryId", "CreatedAt", "DeadLineAt", "Email", "Firstname", "Lastname", "Password", "Phone", "Photo", "Status", "Token" },
                values: new object[] { 1, 1, new DateTime(2019, 12, 23, 21, 32, 24, 433, DateTimeKind.Local).AddTicks(9934), null, "Huseynia@code.edu.az", "Huseyn", "Asadov", "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==", "+994507870181", "download.jpeg", true, null });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(3843), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(3832), "blog/blog1.jpg", true },
                    { 15, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5996), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5995), "blog/blog15.jpg", true },
                    { 14, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5993), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5991), "blog/blog14.jpg", true },
                    { 13, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5989), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5987), "blog/blog13.jpg", true },
                    { 12, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5985), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5984), "blog/blog12.jpg", true },
                    { 10, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5978), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5977), "blog/blog10.jpg", true },
                    { 9, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5975), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5973), "blog/blog9.jpg", true },
                    { 11, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5982), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5980), "blog/blog11.jpg", true },
                    { 7, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5968), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5966), "blog/blog7.jpg", true },
                    { 6, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5964), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5962), "blog/blog6.jpg", true },
                    { 5, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5960), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5958), "blog/blog5.jpg", true },
                    { 4, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5956), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5955), "blog/blog4.jpg", true },
                    { 3, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5952), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5950), "blog/blog3.jpg", true },
                    { 2, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5917), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5906), "blog/blog2.jpg", true },
                    { 8, 1, new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5971), new DateTime(2019, 12, 23, 21, 32, 24, 435, DateTimeKind.Local).AddTicks(5969), "blog/blog1.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AdminManagerId", "CreatedAt", "ModifiedAt", "Status" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9215), new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9214), true },
                    { 1, 1, new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(7789), new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(7043), true },
                    { 2, 1, new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9187), new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9166), true },
                    { 3, 1, new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9208), new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9205), true },
                    { 4, 1, new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9211), new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9210), true },
                    { 6, 1, new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9219), new DateTime(2019, 12, 23, 21, 32, 24, 434, DateTimeKind.Local).AddTicks(9217), true }
                });

            migrationBuilder.InsertData(
                table: "BlogCategory",
                columns: new[] { "Id", "AdminManagerId", "BlogId", "CategoryId", "ModifiedAt" },
                values: new object[,]
                {
                    { 21, null, 15, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, null, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, 12, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, null, 14, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, null, 13, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { 29, 12, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Acadanlıqlar" },
                    { 13, 13, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Blog with Travel" },
                    { 30, 13, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Aksesuarlar" },
                    { 14, 14, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Wordpress Post" },
                    { 31, 14, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Yeni Tozsoran" },
                    { 15, 15, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Company Post" },
                    { 25, 8, "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.", 2, "Şirkətlər" },
                    { 1, 1, "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ", "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.", 1, "Blog Image Post (Sticky)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocialActivities_AdminManagerId",
                table: "SocialActivities",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingTranslates_AdminManagerId",
                table: "SettingTranslates",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_AdminManagerId",
                table: "Setting",
                column: "AdminManagerId");

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
                name: "IX_BlogCategory_AdminManagerId",
                table: "BlogCategory",
                column: "AdminManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_BlogId",
                table: "BlogCategory",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_CategoryId",
                table: "BlogCategory",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Setting_AdminManagers_AdminManagerId",
                table: "Setting",
                column: "AdminManagerId",
                principalTable: "AdminManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SettingTranslates_AdminManagers_AdminManagerId",
                table: "SettingTranslates",
                column: "AdminManagerId",
                principalTable: "AdminManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialActivities_AdminManagers_AdminManagerId",
                table: "SocialActivities",
                column: "AdminManagerId",
                principalTable: "AdminManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Setting_AdminManagers_AdminManagerId",
                table: "Setting");

            migrationBuilder.DropForeignKey(
                name: "FK_SettingTranslates_AdminManagers_AdminManagerId",
                table: "SettingTranslates");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialActivities_AdminManagers_AdminManagerId",
                table: "SocialActivities");

            migrationBuilder.DropTable(
                name: "AdminCategoryTranslates");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropTable(
                name: "BlogCategoryTranslates");

            migrationBuilder.DropTable(
                name: "BlogTranslates");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "AdminManagers");

            migrationBuilder.DropTable(
                name: "AdminCategories");

            migrationBuilder.DropIndex(
                name: "IX_SocialActivities_AdminManagerId",
                table: "SocialActivities");

            migrationBuilder.DropIndex(
                name: "IX_SettingTranslates_AdminManagerId",
                table: "SettingTranslates");

            migrationBuilder.DropIndex(
                name: "IX_Setting_AdminManagerId",
                table: "Setting");

            migrationBuilder.DropColumn(
                name: "AdminManagerId",
                table: "SocialActivities");

            migrationBuilder.DropColumn(
                name: "AdminManagerId",
                table: "SettingTranslates");

            migrationBuilder.DropColumn(
                name: "AdminManagerId",
                table: "Setting");

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 35, 44, 53, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 35, 44, 55, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 23, 16, 35, 44, 55, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "SocialActivities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "linkendin");
        }
    }
}
