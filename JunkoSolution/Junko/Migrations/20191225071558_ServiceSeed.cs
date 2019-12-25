using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class ServiceSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(4299), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6242), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6272), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6276), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6281), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6285), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6289), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6292), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6296), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6300), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6303), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6307), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6310), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6314), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6318), new DateTime(2019, 12, 25, 11, 15, 57, 660, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(8332), new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9664), new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9687), new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9691), new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9694), new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9698), new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.InsertData(
                table: "OurServices",
                columns: new[] { "Id", "AdminManagerId", "Icon", "ModifiedAt", "Status" },
                values: new object[,]
                {
                    { 8, 1, "fa fa-leaf", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2285), true },
                    { 7, 1, "fa fa-headphones", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2282), true },
                    { 6, 1, "fa fa-bar-chart", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2280), true },
                    { 5, 1, "fa fa-file-code-o", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2277), true },
                    { 4, 1, "fa fa-cog", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2275), true },
                    { 3, 1, "fa fa-camera", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2272), true },
                    { 2, 1, "fa fa-umbrella", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2246), true },
                    { 1, 1, "fa fa-sliders", new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(959), true }
                });

            migrationBuilder.InsertData(
                table: "ServicesCovers",
                columns: new[] { "Id", "AdminManagerId", "ModifiedAt", "Photo", "Status" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2019, 12, 25, 11, 15, 57, 661, DateTimeKind.Local).AddTicks(5899), "service/services3.jpg", true },
                    { 2, 1, new DateTime(2019, 12, 25, 11, 15, 57, 661, DateTimeKind.Local).AddTicks(5868), "service/services2.jpg", true },
                    { 1, 1, new DateTime(2019, 12, 25, 11, 15, 57, 661, DateTimeKind.Local).AddTicks(4606), "service/services1.jpg", true }
                });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 656, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 657, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 657, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.InsertData(
                table: "OurServiceTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "OurServiceId", "Title" },
                values: new object[,]
                {
                    { 1, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 1, "BRANDING" },
                    { 16, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 8, "Qrafik Dizayn" },
                    { 8, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 8, "GRAPHIC DESIGN" },
                    { 15, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 7, "Təchizat" },
                    { 7, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 7, "SUPPORT" },
                    { 14, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 6, "Marketinq" },
                    { 13, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 5, "Kod" },
                    { 5, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 5, "CODING" },
                    { 6, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 6, "MARKETING" },
                    { 4, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 4, "WEB DEVELOPMENT" },
                    { 11, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 3, "Potoqrafiya" },
                    { 3, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 3, "PHOTOGRAPHY" },
                    { 10, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 2, "Web Dizayn" },
                    { 2, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 1, 2, "WEB DESIGN" },
                    { 9, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 1, "Brendinq" },
                    { 12, "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.", 2, 4, "Web proqranlaşdırma" }
                });

            migrationBuilder.InsertData(
                table: "ServicesCoverTranslates",
                columns: new[] { "Id", "Desc", "LanguageId", "ServicesCoverId", "Title" },
                values: new object[,]
                {
                    { 3, "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima.", 1, 3, "DESIGN THE COVER" },
                    { 1, "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima.", 1, 1, "DESIGN THE COVER" },
                    { 4, "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm.", 2, 1, "ƏSAS DİZAYN" },
                    { 2, "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima.", 1, 2, "DESIGN THE COVER" },
                    { 5, "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm.", 2, 2, "ƏSAS DİZAYN" },
                    { 6, "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm.", 2, 3, "ƏSAS DİZAYN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OurServiceTranslates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ServicesCoverTranslates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServicesCoverTranslates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServicesCoverTranslates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ServicesCoverTranslates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ServicesCoverTranslates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ServicesCoverTranslates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 11, 13, 27, 435, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(6506), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8492), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8523), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8527), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8531), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8535), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8539), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8542), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8546), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8549), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8553), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8556), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8560), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8564), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8567), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(426), new DateTime(2019, 12, 25, 11, 13, 27, 435, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1756), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1778), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1782), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1786), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1789), new DateTime(2019, 12, 25, 11, 13, 27, 436, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 13, 27, 432, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 13, 27, 434, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 13, 27, 434, DateTimeKind.Local).AddTicks(1758));
        }
    }
}
