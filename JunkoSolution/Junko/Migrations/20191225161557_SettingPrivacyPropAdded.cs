using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class SettingPrivacyPropAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Privacy",
                table: "SettingTranslates",
                type: "ntext",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 498, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(1749), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3936), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3968), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3972), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4047), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4051), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4055), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4058), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4062), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4065), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4069), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4073), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4077), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4080), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4084), new DateTime(2019, 12, 25, 20, 15, 56, 500, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(5729), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7108), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7132), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7135), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7139), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7142), new DateTime(2019, 12, 25, 20, 15, 56, 499, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 504, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 502, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 501, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 501, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 501, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 495, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedAt", "Privacy" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 497, DateTimeKind.Local).AddTicks(5720), "<div class='privacy_content section_1'> <h2>Who we are</h2> <p>Our website address is: <a href='http://1.envato.market/9LbxW'>http://1.envato.market/9LbxW</a></p> </div> <div class='privacy_content section_2'> <h2>What personal data we collect and why we collect it</h2> <h3>Comments</h3> <p>When visitors leave comments on the site we collect the data shown in the comments form, and also the visitor’s IP address and browser user agent string to help spam detection.</p> <p>An anonymized string created from your email address (also called a hash) may be provided to the Gravatar service to see if you are using it. The Gravatar service privacy policy is available here: https://automattic.com/privacy/. After approval of your comment, your profile picture is visible to the public in the context of your comment.</p> <h3>Media</h3> <p>If you upload images to the website, you should avoid uploading images with embedded location data (EXIF GPS) included. Visitors to the website can download and extract any location data from images on the website.</p> <h3>Cookies</h3> <p>If you leave a comment on our site you may opt-in to saving your name, email address and website in cookies. These are for your convenience so that you do not have to fill in your details again when you leave another comment. These cookies will last for one year.</p> <p>If you have an account and you log in to this site, we will set a temporary cookie to determine if your browser accepts cookies. This cookie contains no personal data and is discarded when you close your browser.</p> <p>When you log in, we will also set up several cookies to save your login information and your screen display choices. Login cookies last for two days, and screen options cookies last for a year. If you select “Remember Me”, your login will persist for two weeks. If you log out of your account, the login cookies will be removed.</p> <p>If you edit or publish an article, an additional cookie will be saved in your browser. This cookie includes no personal data and simply indicates the post ID of the article you just edited. It expires after 1 day.</p> <h3>Embedded content from other websites</h3> <p>Articles on this site may include embedded content (e.g. videos, images, articles, etc.). Embedded content from other websites behaves in the exact same way as if the visitor has visited the other website.</p> <p>These websites may collect data about you, use cookies, embed additional third-party tracking, and monitor your interaction with that embedded content, including tracking your interaction with the embedded content if you have an account and are logged in to that website.</p> </div> <div class='privacy_content section_3'> <h2>How long we retain your data</h2> <p>If you leave a comment, the comment and its metadata are retained indefinitely. This is so we can recognize and approve any follow-up comments automatically instead of holding them in a moderation queue.</p> <p>For UserClients that register on our website (if any), we also store the personal information they provide in their user profile. All UserClients can see, edit, or delete their personal information at any time (except they cannot change their username). Website administrators can also see and edit that information.</p> </div> <div class='privacy_content section_3'> <h2>What rights you have over your data</h2> <p>If you have an account on this site, or have left comments, you can request to receive an exported file of the personal data we hold about you, including any data you have provided to us. You can also request that we erase any personal data we hold about you. This does not include any data we are obliged to keep for administrative, legal, or security purposes.</p> </div> <div class='privacy_content section_3'> <h2>Where we send your data</h2> <p>Visitor comments may be checked through an automated spam detection service.</p> </div>" });

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Privacy" },
                values: new object[] { new DateTime(2019, 12, 25, 20, 15, 56, 497, DateTimeKind.Local).AddTicks(6517), "<div class='privacy_content section_1'> <h2>Biz kimik</h2> <p>Veb saytımızın ünvanı: <a href='http://1.envato.market/9LbxW'>http://1.envato.market/9LbxW</a></p> </div> <div class='privacy_content section_2'> <h2>Hansı şəxsi məlumatları toplayırıq və niyə toplayırıq</h2> <h3>Şərhlər</h3> <p>Saytda şərhlər buraxdıqda, şərh şəklində göstərilən məlumatları, həmçinin spamın aşkarlanmasına kömək etmək üçün ziyarətçinin IP ünvanı və brauzer istifadəçi agenti simini toplayırıq.Elektron poçtunuzun adından yaradılan bir anonim simli (hash adlanır) istifadə etdiyinizi görmək üçün Gravatar xidmətinə verilə bilər. Gravatar xidmətinin məxfilik siyasəti ilə burada tanış olmaq mümkündür: https://automattic.com/privacy/. Şərhiniz təsdiqləndikdən sonra profil şəkliniz şərhiniz daxilində ictimaiyyətə görünəcəkdir.</p> <h3>Media</h3> <p>Şəkilləri veb saytına yükləsəniz, daxil edilmiş məlumat məlumatları (EXIF GPS) daxil edilmiş şəkilləri yükləməkdən çəkinməlisiniz. Veb saytına daxil olanlar veb saytdakı şəkillərdən hər hansı bir yer məlumatını yükləyə və çıxara bilər.</p> <h3>Cookies</h3> <p>Saytımızda bir rəy yazsanız, adınızı, e-poçt adresinizi və veb saytınızı çərəzlərdə saxlamaq üçün iştirak edə bilərsiniz. Bunlar sizin rahatlığınız üçündür ki, başqa bir şərh yazanda yenidən məlumatlarınızı doldurmamalısınız. Bu peçenye bir il davam edəcəkdir.Bir hesabınız varsa və bu sayta daxil olsanız, brauzerinizin çerezləri qəbul edib etmədiyini müəyyənləşdirmək üçün müvəqqəti bir çərəz hazırlayacağıq. Bu çerezdə şəxsi məlumat yoxdur və brauzerinizi bağladığınız zaman atılır.Giriş etdiyiniz zaman giriş məlumatlarınızı və ekrandakı seçimlərinizi saxlamaq üçün bir neçə çərəz hazırlayacağıq. Giriş peçenye iki gün davam edir və ekran seçimləri peçenye bir il davam edir. 'Məni yadda saxla' seçsəniz, girişiniz iki həftə davam edəcəkdir. Hesabınızdan çıxsanız, giriş cookies-ləri silinəcəkdir.Bir məqaləni redaktə etsəniz və ya dərc etsəniz, əlavə bir çərəz brauzerinizdə saxlanacaqdır. Bu çerez heç bir şəxsi məlumatı ehtiva etmir və sadəcə redaktə etdiyiniz məqalənin poçt nömrəsini göstərir. 1 gündən sonra bitəcək.</p> <h3>Digər veb saytlardan daxil edilmiş məzmun</h3> <p>Bu saytdakı məqalələr əlaqədar məzmunu ehtiva edə bilər (məsələn, video, şəkillər, məqalələr və s.). Digər veb saytlardan daxil edilmiş məzmun, qonaq digər veb saytı ziyarət etdiyi kimi eyni şəkildə davranır.Bu veb saytlar sizin haqqınızda məlumat toplaya bilər, peçenye istifadə edə bilər, əlavə üçüncü tərəf izləmə əlavə edə bilər və daxil edilmiş məzmunla qarşılıqlı əlaqənizi, habelə hesabınız varsa və həmin veb sayta daxil olmağınızla əlaqəli əlaqənizi izləyə bilər.</p> </div> <div class='privacy_content section_3'> <h2>Verilənlərinizi necə saxlayırıq?</h2> <p>Bir şərh buraxsanız, şərh və onun metadatası qeyri-müəyyən olaraq saxlanılır. Bu, hər hansı bir izləmə şərhlərini moderasiya növbəsində saxlamaq əvəzinə avtomatik olaraq tanıya və təsdiqləyə biləcəyimizdir.Veb saytımızda (əgər varsa) qeydiyyatdan keçən istifadəçilər üçün təqdim etdikləri şəxsi məlumatları istifadəçi profilində saxlayırıq. Bütün istifadəçilər istənilən vaxt şəxsi məlumatlarını görə bilər, redaktə edə və ya silə bilər (istifadəçi adlarını dəyişə bilməyincə). Veb sayt rəhbərləri də həmin məlumatları görə və redaktə edə bilərlər.</p> </div> <div class='privacy_content section_3'> <h2>Məlumatlarınız üzərində hansı hüquqlara sahibsiniz</h2> <p>Bu saytda bir hesabınız varsa və ya şərhlər buraxmısınızsa, sizə təqdim etdiyiniz hər hansı bir məlumat daxil olmaqla, sizin haqqımızda saxladığımız fərdi məlumatların ixrac edilmiş sənədini tələb edə bilərsiniz. Ayrıca, sizin haqqınızda saxladığımız şəxsi məlumatlarınızı silməyimizi tələb edə bilərsiniz. Buraya inzibati, qanuni və ya təhlükəsizlik məqsədləri üçün saxlamalı olduğumuz hər hansı bir məlumat daxil deyil.</p> </div> <div class='privacy_content section_3'> <h2>Məlumatlarınızı hara göndəririk</h2> <p>Ziyarətçilərin şərhləri avtomatlaşdırılmış spam aşkarlama xidməti vasitəsilə yoxlanıla bilər..</p> </div>" });

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 503, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 20, 15, 56, 503, DateTimeKind.Local).AddTicks(5754));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Privacy",
                table: "SettingTranslates");

            migrationBuilder.UpdateData(
                table: "AboutSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 930, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 925, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(3039), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5278), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5310), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5315), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5320), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5324), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5328), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5332), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5335), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5339), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5343), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5348), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5353), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5357), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5361), new DateTime(2019, 12, 25, 17, 9, 15, 927, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(5594), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7225), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7426), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7431), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7435), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7440), new DateTime(2019, 12, 25, 17, 9, 15, 926, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 931, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 932, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 929, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 928, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 928, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 928, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 921, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 924, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 924, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 931, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "WhatDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 17, 9, 15, 931, DateTimeKind.Local).AddTicks(2987));
        }
    }
}
