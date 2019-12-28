﻿using Junko.Models;
using Junko.ModelTranslate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.DAL
{
    public class JunkoDBContext : DbContext
    {
        public JunkoDBContext(DbContextOptions<JunkoDBContext> options) : base(options)
        {

        }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<SettingTranslate> SettingTranslates { get; set; }
        public DbSet<SocialActivity> SocialActivities { get; set; }
        public DbSet<AdminManager> AdminManagers { get; set; }
        public DbSet<AdminCategory> AdminCategories { get; set; }
        public DbSet<AdminCategoryTranslate> AdminCategoryTranslates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogCategoryTranslate> BlogCategoryTranslates { get; set; }
        public DbSet<BlogTranslate> BlogTranslates { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<ServicesCover> ServicesCovers { get; set; }
        public DbSet<ServicesCoverTranslate> ServicesCoverTranslates { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<OurServiceTranslate> OurServiceTranslates { get; set; }
        public DbSet<AboutSetting> AboutSettings { get; set; }
        public DbSet<AboutSettingTranslate> AboutSettingTranslates { get; set; }
        public DbSet<WhatDo> WhatDos { get; set; }
        public DbSet<WhatDoTranslate> WhatDosTranslates { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqTranslate> FaqTranslates { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCategoryTranslate> ProductCategoryTranslates { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<ProductSubCategoryTranslate> ProductSubCategoryTranslates { get; set; }
        public DbSet<BrandProductCategory> BrandProductCategories { get; set; }
        public DbSet<Properity> Properities { get; set; }
        public DbSet<ProperityTranslate> ProperityTranslates { get; set; }
        public DbSet<ProperityCategory> ProperityCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslate> ProductTranslates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Language
            modelBuilder.Entity<Language>().HasData(
                   new Language
                   {
                       Id = 1,
                       Name = "English",
                       LanguageCode = "en-US",

                   },
                    new Language
                    {
                        Id = 2,
                        Name = "Azerbaijan",
                        LanguageCode = "az-Latn-AZ"
                    }
                  );

            // Setting
            modelBuilder.Entity<Setting>().HasData(
                new Setting
                {
                    Id = 1,
                    Logo = "Junko",
                    PhotoLogo = "logo/logo.png",
                    Phone = "+994 50 787 01 81",
                    Location = "Code Academy",
                    Email = "Junko@mail.com",
                    ModifiedAt = DateTime.Now,

                }
               );

            // Setting Translate
            modelBuilder.Entity<SettingTranslate>().HasData(
               new SettingTranslate
               {
                   Id = 1,
                   SettingId = 1,
                   LanguageId = 1,
                   Address = " Nizami street 203B, AF Business House",
                   FAQTitle = "Below are frequently asked questions, you may find the answer for yourself",
                   FAQContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec id erat sagittis, faucibus metus malesuada, eleifend turpis. Mauris semper augue id nisl aliquet, a porta lectus mattis. Nulla at tortor augue. In eget enim diam. Donec gravida tortor sem, ac fermentum nibh rutrum sit amet. Nulla convallis mauris vitae congue consequat. Donec interdum nunc purus, vitae vulputate arcu fringilla quis. Vivamus iaculis euismod dui.",
                   ModifiedAt = DateTime.Now,
                   Privacy= "<div class='privacy_content section_1'> <h2>Who we are</h2> <p>Our website address is: <a href='http://1.envato.market/9LbxW'>http://1.envato.market/9LbxW</a></p> </div> <div class='privacy_content section_2'> <h2>What personal data we collect and why we collect it</h2> <h3>Comments</h3> <p>When visitors leave comments on the site we collect the data shown in the comments form, and also the visitor’s IP address and browser user agent string to help spam detection.</p> <p>An anonymized string created from your email address (also called a hash) may be provided to the Gravatar service to see if you are using it. The Gravatar service privacy policy is available here: https://automattic.com/privacy/. After approval of your comment, your profile picture is visible to the public in the context of your comment.</p> <h3>Media</h3> <p>If you upload images to the website, you should avoid uploading images with embedded location data (EXIF GPS) included. Visitors to the website can download and extract any location data from images on the website.</p> <h3>Cookies</h3> <p>If you leave a comment on our site you may opt-in to saving your name, email address and website in cookies. These are for your convenience so that you do not have to fill in your details again when you leave another comment. These cookies will last for one year.</p> <p>If you have an account and you log in to this site, we will set a temporary cookie to determine if your browser accepts cookies. This cookie contains no personal data and is discarded when you close your browser.</p> <p>When you log in, we will also set up several cookies to save your login information and your screen display choices. Login cookies last for two days, and screen options cookies last for a year. If you select “Remember Me”, your login will persist for two weeks. If you log out of your account, the login cookies will be removed.</p> <p>If you edit or publish an article, an additional cookie will be saved in your browser. This cookie includes no personal data and simply indicates the post ID of the article you just edited. It expires after 1 day.</p> <h3>Embedded content from other websites</h3> <p>Articles on this site may include embedded content (e.g. videos, images, articles, etc.). Embedded content from other websites behaves in the exact same way as if the visitor has visited the other website.</p> <p>These websites may collect data about you, use cookies, embed additional third-party tracking, and monitor your interaction with that embedded content, including tracking your interaction with the embedded content if you have an account and are logged in to that website.</p> </div> <div class='privacy_content section_3'> <h2>How long we retain your data</h2> <p>If you leave a comment, the comment and its metadata are retained indefinitely. This is so we can recognize and approve any follow-up comments automatically instead of holding them in a moderation queue.</p> <p>For users that register on our website (if any), we also store the personal information they provide in their user profile. All users can see, edit, or delete their personal information at any time (except they cannot change their username). Website administrators can also see and edit that information.</p> </div> <div class='privacy_content section_3'> <h2>What rights you have over your data</h2> <p>If you have an account on this site, or have left comments, you can request to receive an exported file of the personal data we hold about you, including any data you have provided to us. You can also request that we erase any personal data we hold about you. This does not include any data we are obliged to keep for administrative, legal, or security purposes.</p> </div> <div class='privacy_content section_3'> <h2>Where we send your data</h2> <p>Visitor comments may be checked through an automated spam detection service.</p> </div>"
               },
               new SettingTranslate
               {
                   Id = 2,
                   SettingId = 1,
                   LanguageId = 2,
                   Address = " Nizami küç. 203B, AF Business House, 2-ci mərtəbə",
                   FAQTitle = "Aşağıda tez-tez verilən suallarla özünüz üçün cavab tapa bilərsiniz",
                   FAQContent = "",
                   ModifiedAt = DateTime.Now,
                   Privacy= "<div class='privacy_content section_1'> <h2>Biz kimik</h2> <p>Veb saytımızın ünvanı: <a href='http://1.envato.market/9LbxW'>http://1.envato.market/9LbxW</a></p> </div> <div class='privacy_content section_2'> <h2>Hansı şəxsi məlumatları toplayırıq və niyə toplayırıq</h2> <h3>Şərhlər</h3> <p>Saytda şərhlər buraxdıqda, şərh şəklində göstərilən məlumatları, həmçinin spamın aşkarlanmasına kömək etmək üçün ziyarətçinin IP ünvanı və brauzer istifadəçi agenti simini toplayırıq.Elektron poçtunuzun adından yaradılan bir anonim simli (hash adlanır) istifadə etdiyinizi görmək üçün Gravatar xidmətinə verilə bilər. Gravatar xidmətinin məxfilik siyasəti ilə burada tanış olmaq mümkündür: https://automattic.com/privacy/. Şərhiniz təsdiqləndikdən sonra profil şəkliniz şərhiniz daxilində ictimaiyyətə görünəcəkdir.</p> <h3>Media</h3> <p>Şəkilləri veb saytına yükləsəniz, daxil edilmiş məlumat məlumatları (EXIF GPS) daxil edilmiş şəkilləri yükləməkdən çəkinməlisiniz. Veb saytına daxil olanlar veb saytdakı şəkillərdən hər hansı bir yer məlumatını yükləyə və çıxara bilər.</p> <h3>Cookies</h3> <p>Saytımızda bir rəy yazsanız, adınızı, e-poçt adresinizi və veb saytınızı çərəzlərdə saxlamaq üçün iştirak edə bilərsiniz. Bunlar sizin rahatlığınız üçündür ki, başqa bir şərh yazanda yenidən məlumatlarınızı doldurmamalısınız. Bu peçenye bir il davam edəcəkdir.Bir hesabınız varsa və bu sayta daxil olsanız, brauzerinizin çerezləri qəbul edib etmədiyini müəyyənləşdirmək üçün müvəqqəti bir çərəz hazırlayacağıq. Bu çerezdə şəxsi məlumat yoxdur və brauzerinizi bağladığınız zaman atılır.Giriş etdiyiniz zaman giriş məlumatlarınızı və ekrandakı seçimlərinizi saxlamaq üçün bir neçə çərəz hazırlayacağıq. Giriş peçenye iki gün davam edir və ekran seçimləri peçenye bir il davam edir. 'Məni yadda saxla' seçsəniz, girişiniz iki həftə davam edəcəkdir. Hesabınızdan çıxsanız, giriş cookies-ləri silinəcəkdir.Bir məqaləni redaktə etsəniz və ya dərc etsəniz, əlavə bir çərəz brauzerinizdə saxlanacaqdır. Bu çerez heç bir şəxsi məlumatı ehtiva etmir və sadəcə redaktə etdiyiniz məqalənin poçt nömrəsini göstərir. 1 gündən sonra bitəcək.</p> <h3>Digər veb saytlardan daxil edilmiş məzmun</h3> <p>Bu saytdakı məqalələr əlaqədar məzmunu ehtiva edə bilər (məsələn, video, şəkillər, məqalələr və s.). Digər veb saytlardan daxil edilmiş məzmun, qonaq digər veb saytı ziyarət etdiyi kimi eyni şəkildə davranır.Bu veb saytlar sizin haqqınızda məlumat toplaya bilər, peçenye istifadə edə bilər, əlavə üçüncü tərəf izləmə əlavə edə bilər və daxil edilmiş məzmunla qarşılıqlı əlaqənizi, habelə hesabınız varsa və həmin veb sayta daxil olmağınızla əlaqəli əlaqənizi izləyə bilər.</p> </div> <div class='privacy_content section_3'> <h2>Verilənlərinizi necə saxlayırıq?</h2> <p>Bir şərh buraxsanız, şərh və onun metadatası qeyri-müəyyən olaraq saxlanılır. Bu, hər hansı bir izləmə şərhlərini moderasiya növbəsində saxlamaq əvəzinə avtomatik olaraq tanıya və təsdiqləyə biləcəyimizdir.Veb saytımızda (əgər varsa) qeydiyyatdan keçən istifadəçilər üçün təqdim etdikləri şəxsi məlumatları istifadəçi profilində saxlayırıq. Bütün istifadəçilər istənilən vaxt şəxsi məlumatlarını görə bilər, redaktə edə və ya silə bilər (istifadəçi adlarını dəyişə bilməyincə). Veb sayt rəhbərləri də həmin məlumatları görə və redaktə edə bilərlər.</p> </div> <div class='privacy_content section_3'> <h2>Məlumatlarınız üzərində hansı hüquqlara sahibsiniz</h2> <p>Bu saytda bir hesabınız varsa və ya şərhlər buraxmısınızsa, sizə təqdim etdiyiniz hər hansı bir məlumat daxil olmaqla, sizin haqqımızda saxladığımız fərdi məlumatların ixrac edilmiş sənədini tələb edə bilərsiniz. Ayrıca, sizin haqqınızda saxladığımız şəxsi məlumatlarınızı silməyimizi tələb edə bilərsiniz. Buraya inzibati, qanuni və ya təhlükəsizlik məqsədləri üçün saxlamalı olduğumuz hər hansı bir məlumat daxil deyil.</p> </div> <div class='privacy_content section_3'> <h2>Məlumatlarınızı hara göndəririk</h2> <p>Ziyarətçilərin şərhləri avtomatlaşdırılmış spam aşkarlama xidməti vasitəsilə yoxlanıla bilər..</p> </div>"
               }
              );

            // SocialActivity
            modelBuilder.Entity<SocialActivity>().HasData(
                new SocialActivity
                {
                    Id = 1,
                    Name = "facebook",
                    Link = "https://www.facebook.com/",
                    SettingId = 1
                },
                new SocialActivity
                {
                    Id = 2,
                    Name = "twitter",
                    Link = "https://twitter.com/?lang=en",
                    SettingId = 1
                },
                new SocialActivity
                {
                    Id = 3,
                    Name = "instagram",
                    Link = "https://www.instagram.com/",
                    SettingId = 1
                },
                 new SocialActivity
                 {
                     Id = 4,
                     Name = "linkedin",
                     Link = "https://www.linkedin.com/feed/",
                     SettingId = 1
                 },
                  new SocialActivity
                  {
                      Id = 5,
                      Name = "google",
                      Link = "https://www.google.com",
                      SettingId = 1
                  }
               );

            // Admin Category
            modelBuilder.Entity<AdminCategory>().HasData(
                new AdminCategory{Id = 1,Status = true},
                new AdminCategory{Id = 2,Status = true},
                new AdminCategory{Id = 3,Status = true},
                new AdminCategory{Id = 4,Status = true}
                );
            // Admin Categori Translate
            modelBuilder.Entity<AdminCategoryTranslate>().HasData(
                new AdminCategoryTranslate{Id = 1,AdminCategoryId = 1,LanguageId = 1,Name = "Director"},
                new AdminCategoryTranslate{Id = 2,AdminCategoryId = 1,LanguageId = 2,Name = "Direktor"},
                new AdminCategoryTranslate{Id = 3,AdminCategoryId = 2,LanguageId = 1,Name = "Designer"},
                new AdminCategoryTranslate{Id = 4,AdminCategoryId = 2,LanguageId = 2,Name = "Dizayner"},
                new AdminCategoryTranslate{Id = 5,AdminCategoryId = 3,LanguageId = 1,Name = "Developer"},
                new AdminCategoryTranslate { Id = 6, AdminCategoryId = 3, LanguageId = 2, Name = "Proqramçı" },
                new AdminCategoryTranslate { Id = 7, AdminCategoryId = 4, LanguageId = 1, Name = "Accountant" },
                new AdminCategoryTranslate { Id = 8, AdminCategoryId = 4, LanguageId = 2, Name = "Mühasib" }                );

            // Admin Manager
            modelBuilder.Entity<AdminManager>().HasData(
                 new AdminManager
                 {
                     Id = 1,
                     CreatedAt = DateTime.Now,
                     Email = "Huseynia@code.edu.az",
                     Password = "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==",
                     Firstname = "Huseyn",
                     Lastname = "Asadov",
                     Status = true,
                     Phone = "+994507870181",
                     AdminCategoryId = 1,
                     Photo = "about/about-us-person1.png"
                 },
                 new AdminManager
                 {
                     Id = 2,
                     CreatedAt = DateTime.Now,
                     Email = "Mary@code.edu.az",
                     Password = "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==",
                     Firstname = "Marilyn",
                     Lastname = "monroe",
                     Status = true,
                     Phone = "+994507870181",
                     AdminCategoryId = 2,
                     Photo = "about/about-us-person2.png"
                 },
                  new AdminManager
                  {
                      Id = 3,
                      CreatedAt = DateTime.Now,
                      Email = "Michael@code.edu.az",
                      Password = "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==",
                      Firstname = "Michael",
                      Lastname = "Monroe",
                      Status = true,
                      Phone = "+994507870181",
                      AdminCategoryId = 3,
                      Photo = "about/about-us-person3.png"
                  },
                  new AdminManager
                  {
                      Id = 4,
                      CreatedAt = DateTime.Now,
                      Email = "James@code.edu.az",
                      Password = "AGFkhc5OoWZDrhVUgtfONApKOIJtIZyZZTc93zg1bpihQMs6UrndQXnCgZ6K5Qg8hA==",
                      Firstname = "James",
                      Lastname = "James",
                      Status = true,
                      Phone = "+994507870181",
                      AdminCategoryId = 4,
                      Photo = "about/about-us-person4.png"
                  }

                 );

            // Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new Category { Id = 2, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new Category { Id = 3, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new Category { Id = 4, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new Category { Id = 5, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new Category { Id = 6, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true }
                );

            // Category Translate
            modelBuilder.Entity<BlogCategoryTranslate>().HasData(
                new BlogCategoryTranslate { Id = 1, CategoryId = 1, LanguageId = 1, Name = "Audio" },
                new BlogCategoryTranslate { Id = 2, CategoryId = 1, LanguageId = 2, Name = "Audio" },
                new BlogCategoryTranslate { Id = 3, CategoryId = 2, LanguageId = 1, Name = "Company" },
                new BlogCategoryTranslate { Id = 4, CategoryId = 2, LanguageId = 2, Name = "Şirkət" },
                new BlogCategoryTranslate { Id = 5, CategoryId = 3, LanguageId = 1, Name = "Gallery" },
                new BlogCategoryTranslate { Id = 6, CategoryId = 3, LanguageId = 2, Name = "Qalareya" },
                new BlogCategoryTranslate { Id = 7, CategoryId = 4, LanguageId = 1, Name = "Travel" },
                new BlogCategoryTranslate { Id = 8, CategoryId = 4, LanguageId = 2, Name = "Səyahət" },
                new BlogCategoryTranslate { Id = 9, CategoryId = 5, LanguageId = 1, Name = "Other" },
                new BlogCategoryTranslate { Id = 10, CategoryId = 5, LanguageId = 2, Name = "Digər" },
                new BlogCategoryTranslate { Id = 11, CategoryId = 6, LanguageId = 1, Name = "Video" },
                new BlogCategoryTranslate { Id = 12, CategoryId = 6, LanguageId = 2, Name = "Video" }
                );

            // Blog 
            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 1, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog1.jpg" },
                new Blog { Id = 2, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog2.jpg" },
                new Blog { Id = 3, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog3.jpg" },
                new Blog { Id = 4, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog4.jpg" },
                new Blog { Id = 5, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog5.jpg" },
                new Blog { Id = 6, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog1.jpg" },
                new Blog { Id = 7, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog2.jpg" },
                new Blog { Id = 8, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog3.jpg" },
                new Blog { Id = 9, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog4.jpg" },
                new Blog { Id = 10, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog5.jpg" },
                new Blog { Id = 11, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog1.jpg" },
                new Blog { Id = 12, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog2.jpg" },
                new Blog { Id = 13, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog3.jpg" },
                new Blog { Id = 14, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog4.jpg" },
                new Blog { Id = 15, ModifiedAt = DateTime.Now, AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true, Photo = "blog/blog5.jpg" }
                );

            // Blog Translate
            modelBuilder.Entity<BlogTranslate>().HasData(
                new BlogTranslate{Id = 1,BlogId = 1,LanguageId = 1,Slug= "Blog-Image-Post", Title = "Blog Image Post (Sticky)",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 2,BlogId = 2,LanguageId = 1, Slug = "Post-With-Gallery", Title = "Post With Gallery", Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 3,BlogId = 3,LanguageId = 1, Slug = "Maecenas-Ultricies", Title = "Maecenas Ultricies", Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 4,BlogId = 4,LanguageId = 1, Slug = "Post-with-audio", Title = "Post With Audio", Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 5,BlogId = 5,LanguageId = 1, Slug = "preasent-imperdiet", Title = "Praesent Imperdiet", Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 6,BlogId = 6,LanguageId = 1, Slug = "gallery-post", Title = "Gallery Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 7,BlogId = 7,LanguageId = 1, Slug = "Ultricies-Maecenas", Title = "Ultricies Maecenas", Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 8,BlogId = 8,LanguageId = 1, Slug = "Audio-Post", Title = " Audio Post", Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 9,BlogId = 9,LanguageId = 1, Slug = "Image-Post", Title = "Image Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 10,BlogId = 10,LanguageId = 1, Slug = "Other-Post", Title = "Other Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 11,BlogId = 11,LanguageId = 1, Slug = "Sticy-Post", Title = "Sticy Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 12,BlogId = 12,LanguageId = 1, Slug = "Travel-Post", Title = "Travel Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 13,BlogId = 13,LanguageId = 1, Slug = "Blog-with-Travel", Title = "Blog with Travel",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 14,BlogId = 14,LanguageId = 1, Slug = "Wordpress-Post", Title = "Wordpress Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 15,BlogId = 15,LanguageId = 1, Slug = "Company-Post", Title = "Company Post",Desc = "Donec vitae hendrerit arcu, sit amet faucibus nisl. Cras pretium arcu ex. Aenean posuere libero eu augue condimentum rhoncus. Praesent ornare tortor ac ante egestas hendrerit. Aliquam et metus pharetra, bibendum massa nec, fermentum odio.",Content = "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 17,BlogId = 1,LanguageId = 2, Slug = "xabar-sakil-paylasimi", Title = "Xəbər Şəkil Paylaşımı",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 18,BlogId = 2,LanguageId = 2, Slug = "qalaraya-paylasimi", Title = "Qalareya Paylaşımı",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 19,BlogId = 3,LanguageId = 2, Slug = "texniki-paylasim", Title = "Texniki Paylaşım",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 20,BlogId = 4,LanguageId = 2, Slug = "elektronika", Title = "Elektrotexnika",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 21,BlogId = 5,LanguageId = 2, Slug = "yeni-robotlar", Title = "Yeni Robotlar",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 23,BlogId = 6,LanguageId = 2, Slug = "yeni-iphone-11", Title = "Yeni İphone 11",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 24,BlogId = 7,LanguageId = 2, Slug = "seyahet-paylasimi", Title = "Səyahət Paylaşımı",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 25,BlogId = 8,LanguageId = 2, Slug = "sirketler", Title = "Şirkətlər",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 26,BlogId = 9,LanguageId = 2, Slug = "yeni-trendler", Title = "Yeni trendlər",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 27,BlogId = 10,LanguageId = 2, Slug = "diger-paylasim", Title = "Digər Paylaşım",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 28,BlogId = 11,LanguageId = 2, Slug = "robot-istehsali", Title = "Robot istehsalı",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 29,BlogId = 12,LanguageId = 2, Slug = "avadanliqlar", Title = "Avadanlıqlar",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 30,BlogId = 13,LanguageId = 2, Slug = "aksesuarlar", Title = "Aksesuarlar",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 31,BlogId = 14,LanguageId = 2, Slug = "yeni-tozsoram", Title = "Yeni Tozsoran",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "},
                new BlogTranslate{Id = 32,BlogId = 15,LanguageId = 2, Slug = "yeni-paylasim", Title = "Yeni paylaşım",Desc = "LoremIpsum360 ° pulsuz online generator saxta mətn. Bu modellər üçün əvəz mətn və ya alternativ mətn yaratmaq üçün tam mətn simulator edir. Bu müxtəlif dillərdə mətnlərin nümunələri yaratmaq üçün latın və kiril qrafikası ilə müxtəlif təsadüfi mətnlər edir.",Content = "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> "}
                );

            // Blog Category
            modelBuilder.Entity<BlogCategory>().HasData(
                new BlogCategory {Id=1,BlogId=1,CategoryId=1,AdminManagerId=1},
                new BlogCategory {Id=2,BlogId=1,CategoryId=2, AdminManagerId = 1 },
                new BlogCategory {Id=3,BlogId=1,CategoryId=3, AdminManagerId = 1 },
                new BlogCategory {Id=4,BlogId=2,CategoryId=4, AdminManagerId = 1 },
                new BlogCategory {Id=5,BlogId=2,CategoryId=5, AdminManagerId = 1 },
                new BlogCategory {Id=6,BlogId=2,CategoryId=6, AdminManagerId = 1 },
                new BlogCategory {Id=7,BlogId=3,CategoryId=1, AdminManagerId = 1 },
                new BlogCategory {Id=8,BlogId=3,CategoryId=3, AdminManagerId = 1 },
                new BlogCategory {Id=9,BlogId=3,CategoryId=5, AdminManagerId = 1 },
                new BlogCategory {Id=10,BlogId=4,CategoryId=1, AdminManagerId = 1 },
                new BlogCategory {Id=11,BlogId=5,CategoryId=2, AdminManagerId = 1 },
                new BlogCategory {Id=12,BlogId=6,CategoryId=3, AdminManagerId = 1 },
                new BlogCategory {Id=13,BlogId=7,CategoryId=4, AdminManagerId = 1 },
                new BlogCategory {Id=14,BlogId=8,CategoryId=5, AdminManagerId = 1 },
                new BlogCategory {Id=15,BlogId=9,CategoryId=6, AdminManagerId = 1 },
                new BlogCategory {Id=16,BlogId=10,CategoryId=1, AdminManagerId = 1 },
                new BlogCategory {Id=17,BlogId=11,CategoryId=2, AdminManagerId = 1 },
                new BlogCategory {Id=18,BlogId=12,CategoryId=3, AdminManagerId = 1 },
                new BlogCategory {Id=19,BlogId=13,CategoryId=4, AdminManagerId = 1 },
                new BlogCategory {Id=20,BlogId=14,CategoryId=5, AdminManagerId = 1 },
                new BlogCategory {Id=21,BlogId=15,CategoryId=6, AdminManagerId = 1 }
                );

            // Services Cover 
            modelBuilder.Entity<ServicesCover>().HasData(
                new ServicesCover { Id = 1, AdminManagerId = 1, ModifiedAt = DateTime.Now, Photo = "service/services1.jpg", Status = true, Order = 1 },
                new ServicesCover { Id = 2, AdminManagerId = 1, ModifiedAt = DateTime.Now, Photo = "service/services2.jpg", Status = true, Order = 2 },
                new ServicesCover { Id = 3, AdminManagerId = 1, ModifiedAt = DateTime.Now, Photo = "service/services3.jpg", Status = true, Order = 3 }
                );

            // Services Cover Translate
            modelBuilder.Entity<ServicesCoverTranslate>().HasData(
                new ServicesCoverTranslate { Id = 1, ServicesCoverId = 1, LanguageId = 1, Title = "DESIGN THE COVER", Desc = "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima." },
                new ServicesCoverTranslate { Id = 2, ServicesCoverId = 2, LanguageId = 1, Title = "DESIGN THE COVER", Desc = "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima." },
                new ServicesCoverTranslate { Id = 3, ServicesCoverId = 3, LanguageId = 1, Title = "DESIGN THE COVER", Desc = "Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima." },
                new ServicesCoverTranslate { Id = 4, ServicesCoverId = 1, LanguageId = 2, Title = "ƏSAS DİZAYN", Desc = "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm." },
                new ServicesCoverTranslate { Id = 5, ServicesCoverId = 2, LanguageId = 2, Title = "ƏSAS DİZAYN", Desc = "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm." },
                new ServicesCoverTranslate { Id = 6, ServicesCoverId = 3, LanguageId = 2, Title = "ƏSAS DİZAYN", Desc = "Usuf öy usuf həncərsən ayna durinan beyjə öy yağlaşoy, sumsux qredit siyəndər vızqırt yağlaşoy qağa basırıx mamoa bimürvət dayna aya siyəndər anarıdan-bəri ölüm." }
                );

            // Services 
            modelBuilder.Entity<OurService>().HasData(
                new OurService { Id = 1, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-sliders", Status = true,Order=1 },
                new OurService { Id = 2, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-umbrella", Status = true, Order = 2 },
                new OurService { Id = 3, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-camera", Status = true, Order = 3 },
                new OurService { Id = 4, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-cog", Status = true, Order = 4 },
                new OurService { Id = 5, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-file-code-o", Status = true, Order = 5 },
                new OurService { Id = 6, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-bar-chart", Status = true, Order = 6 },
                new OurService { Id = 7, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-headphones", Status = true, Order = 7 },
                new OurService { Id = 8, AdminManagerId = 1, ModifiedAt = DateTime.Now, Icon = "fa fa-leaf", Status = true, Order = 8 }
                );

            // Services Translate
            modelBuilder.Entity<OurServiceTranslate>().HasData(
                new OurServiceTranslate { Id = 1, OurServiceId = 1, LanguageId = 1, Title = "BRANDING", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 2, OurServiceId = 2, LanguageId = 1, Title = "WEB DESIGN", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 3, OurServiceId = 3, LanguageId = 1, Title = "PHOTOGRAPHY", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 4, OurServiceId = 4, LanguageId = 1, Title = "WEB DEVELOPMENT", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 5, OurServiceId = 5, LanguageId = 1, Title = "CODING", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 6, OurServiceId = 6, LanguageId = 1, Title = "MARKETING", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 7, OurServiceId = 7, LanguageId = 1, Title = "SUPPORT", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 8, OurServiceId = 8, LanguageId = 1, Title = "GRAPHIC DESIGN", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 9, OurServiceId = 1, LanguageId = 2, Title = "Brendinq", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 10, OurServiceId = 2, LanguageId = 2, Title = "Web Dizayn", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 11, OurServiceId = 3, LanguageId = 2, Title = "Potoqrafiya", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 12, OurServiceId = 4, LanguageId = 2, Title = "Web proqranlaşdırma", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 13, OurServiceId = 5, LanguageId = 2, Title = "Kod", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 14, OurServiceId = 6, LanguageId = 2, Title = "Marketinq", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 15, OurServiceId = 7, LanguageId = 2, Title = "Təchizat", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." },
                new OurServiceTranslate { Id = 16, OurServiceId = 8, LanguageId = 2, Title = "Qrafik Dizayn", Desc = "Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem." }
                );


            // About Setting
            modelBuilder.Entity<AboutSetting>().HasData(
                new AboutSetting {Id=1, AdminManagerId=1, ModifiedAt=DateTime.Now, Photo= "about/about1.jpg" }
                );

            // About Setting Translate
            modelBuilder.Entity<AboutSettingTranslate>().HasData(
                new AboutSettingTranslate {Id=1, AboutSettingId=1, LanguageId=1, Title= "ECommerce For Electronics Store", Desc= "Adipiscing lacus ut elementum, nec duis, tempor litora turpis dapibus. Imperdiet cursus odio tortor in elementum. Egestas nunc eleifend feugiat lectus laoreet, vel nunc taciti integer cras. Hac pede dis, praesent nibh ac dui mauris sit. Pellentesque mi, facilisi mauris, elit sociis leo sodales accumsan. Iaculis ac fringilla torquent lorem consectetuer, sociosqu phasellus risus urna aliquam, ornare." },
                new AboutSettingTranslate {Id=2, AboutSettingId=1, LanguageId=2, Title="Elektronika Mağazası üçün Kommersiya fəaliyyəti",Desc= "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı." }
                );

            // WhatDo 
            modelBuilder.Entity<WhatDo>().HasData(
                new WhatDo {Id=1, AdminManagerId=1, ModifiedAt=DateTime.Now, Photo= "about/about2.jpg", Status=true},
                new WhatDo {Id=2, AdminManagerId=1, ModifiedAt=DateTime.Now, Photo= "about/about3.jpg", Status=true}
                );

            // WhatDo Translate
            modelBuilder.Entity<WhatDoTranslate>().HasData(
                new WhatDoTranslate {Id=1, WhatDoId=1, LanguageId=1, Title= "What Do We Do?", Desc= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ‘Content here, content here’, making it look like readable English." },
                new WhatDoTranslate {Id=2, WhatDoId=2, LanguageId=1, Title= "History Of Us", Desc= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ‘Content here, content here’, making it look like readable English." },
                new WhatDoTranslate {Id=3, WhatDoId=1, LanguageId=2, Title="Fəaliyyətimiz Nədir?", Desc= "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı." },
                new WhatDoTranslate {Id=4, WhatDoId=2, LanguageId=2, Title="Tariximiz", Desc= "Beyjə murtta səni yağlaşoy səni göyüz xışdıyaram, qağa ciji qayır öy a qıvlasız mamoğlu dığlatdın, eşiy anarıdan-bəri səni öy qayır. Çırtımına yiyə dursan? ayna durinan suruxvat ayna durinan dayna sülöymən kiri a qıvlasız səni, ciji siyəndər qalet murtta dığlatdın dınqı anarıdan-bəri, qavağında ölöm döyğa tutaşmıyın mamoğlu a bimürvət ayna durinan mığı." }
                );

            // FAQ 
            modelBuilder.Entity<Faq>().HasData(
                new Faq {Id=1, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=1, Status=true },
                new Faq {Id=2, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=2, Status=true },
                new Faq {Id=3, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=3, Status=true },
                new Faq {Id=4, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=4, Status=true },
                new Faq {Id=5, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=5, Status=true },
                new Faq {Id=6, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=6, Status=true },
                new Faq {Id=7, AdminManagerId=1, ModifiedAt=DateTime.Now, Order=7, Status=true }
                );

            // Faq Translate
            modelBuilder.Entity<FaqTranslate>().HasData(
                new FaqTranslate {Id=1, FaqId=1, LanguageeId=1, Question= "Donec mattis finibus elit ut tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=2, FaqId=2, LanguageeId=1, Question= "mattis finibus elit ut tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=3, FaqId=3, LanguageeId=1, Question= "finibus elit ut tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=4, FaqId=4, LanguageeId=1, Question= "elit mattis finibus elit ut tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=5, FaqId=5, LanguageeId=1, Question= "ut Donec mattis finibus elit ut tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=6, FaqId=6, LanguageeId=1, Question= "Trist mattis finibus elit ut tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=7, FaqId=7, LanguageeId=1, Question= "Donec tristique?", Answer= "Donec mattis finibus elit ut tristique.Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur lorem eu viverra lobortis.Morbi gravidanisi id ultricieselit lorem eleifend " },
                new FaqTranslate {Id=8, FaqId=1, LanguageeId=2, Question= "Saytda hansı ödəmə vasitələri var?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " },
                new FaqTranslate {Id=9, FaqId=2, LanguageeId=2, Question= "Çatdırılma necə həyata keçir?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " },
                new FaqTranslate {Id=10, FaqId=3, LanguageeId=2, Question= "Vakansiyalar ne vaxt olacaq?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " },
                new FaqTranslate {Id=11, FaqId=4, LanguageeId=2, Question= "Mobil tetbiqi də hazırlanırmı?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " },
                new FaqTranslate {Id=12, FaqId=5, LanguageeId=2, Question= "Digərlərindən fərqi nədir?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " },
                new FaqTranslate {Id=13, FaqId=6, LanguageeId=2, Question= "Nə üstünlüklər verilir?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " },
                new FaqTranslate {Id=14, FaqId=7, LanguageeId=2, Question= "ikinci əl satılırmı?", Answer= "Nullam tempus nunc eget vulputateeu porttitor tellus commodo.Aliquam erat volutpat.consectetur " }
                );

            // Brand
            modelBuilder.Entity<Brand>().HasData(
                new Brand {Id=1, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Apple",Slug="apple", Status=true },
                new Brand {Id=2, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Samsung",Slug= "Samsung", Status=true },
                new Brand {Id=3, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Huawei",Slug= "Huawei", Status=true },
                new Brand {Id=4, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Xiaomi",Slug= "Xiaomi", Status=true },
                new Brand {Id=5, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Meizu",Slug= "Meizu", Status=true },
                new Brand {Id=6, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Nokia",Slug= "Nokia", Status=true },
                new Brand {Id=7, AdminManagerId=1, CreatedAt=DateTime.Now, Name="FLY",Slug= "FLY", Status=true },
                new Brand {Id=8, AdminManagerId=1, CreatedAt=DateTime.Now, Name="UleFone",Slug= "UleFone", Status=true },
                new Brand {Id=9, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Honor",Slug= "Honor", Status=true },
                new Brand {Id=10, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Lenovo",Slug= "Lenovo", Status=true },
                new Brand {Id=11, AdminManagerId=1, CreatedAt=DateTime.Now, Name="Balafon",Slug= "Balafon", Status=true },
                new Brand {Id=12, AdminManagerId=1, CreatedAt=DateTime.Now, Name="LG",Slug= "LG", Status=true },
                new Brand {Id=13, AdminManagerId=1, CreatedAt=DateTime.Now, Name="HTC",Slug= "HTC", Status=true },
                new Brand {Id=14, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Hitachi", Slug= "Hitachi", Status=true },
                new Brand {Id=15, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Zanussi", Slug= "Zanussi", Status=true },
                new Brand {Id=16, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Bosch", Slug= "Bosch", Status=true },
                new Brand {Id=17, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Vestel", Slug= "Vestel", Status=true },
                new Brand {Id=18, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Mitsubishi", Slug= "Mitsubishi", Status=true },
                new Brand {Id=19, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Gree", Slug= "Gree", Status=true },
                new Brand {Id=20, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "AUX", Slug= "AUX", Status=true },
                new Brand {Id=21, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "İndesit", Slug= "İndesit", Status=true },
                new Brand {Id=22, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Gorenje", Slug= "Gorenje", Status=true },
                new Brand {Id=23, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Asus", Slug= "Asus", Status=true },
                new Brand {Id=24, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Acer", Slug= "Acer", Status=true },
                new Brand {Id=25, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Dell", Slug= "Dell", Status=true },
                new Brand {Id=26, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "HP", Slug= "HP", Status=true },
                new Brand {Id=27, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Canon", Slug= "Canon", Status=true },
                new Brand {Id=28, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Epson ", Slug= "Epson ", Status=true },
                new Brand {Id=29, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Philips ", Slug= "Philips ", Status=true },
                new Brand {Id=30, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Aiwa ", Slug= "Aiwa ", Status=true },
                new Brand {Id=31, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Shivaki ", Slug= "Shivaki ", Status=true },
                new Brand {Id=32, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Sony ", Slug= "Sony ", Status=true },
                new Brand {Id=33, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Xbox ", Slug= "Xbox ", Status=true },
                new Brand {Id=34, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Logitech ", Slug= "Logitech ", Status=true },
                new Brand {Id=35, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Oculus ", Slug= "Oculus ", Status=true },
                new Brand {Id=36, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Panasonic ", Slug= "Panasonic ", Status=true },
                new Brand {Id=37, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Rowenta ", Slug= "Rowenta ", Status=true },
                new Brand {Id=38, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Tefal ", Slug= "Tefal ", Status=true },
                new Brand {Id=39, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Vitek ", Slug= "Vitek ", Status=true },
                new Brand {Id=40, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Braun ", Slug= "Braun ", Status=true },
                new Brand {Id=41, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "F&D ", Slug= "F&D ", Status=true },
                new Brand {Id=42, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Genius ", Slug= "Genius ", Status=true },
                new Brand {Id=43, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "JBL ", Slug= "JBL ", Status=true },
                new Brand {Id=44, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Gigaset ", Slug= "Gigaset ", Status=true },
                new Brand {Id=45, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Remax ", Slug= "Remax ", Status=true },
                new Brand {Id=46, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Rock ", Slug= "Rock ", Status=true },
                new Brand {Id=47, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Baseus ", Slug= "Baseus ", Status=true },
                new Brand {Id=48, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "A4Tech ", Slug= "A4Tech ", Status=true },
                new Brand {Id=49, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "SanDisk ", Slug= "SanDisk ", Status=true },
                new Brand {Id=50, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Beats ", Slug= "Beats ", Status=true },
                new Brand {Id=51, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Jabra ", Slug= "Jabra ", Status=true },
                new Brand {Id=52, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Roman ", Slug= "Roman ", Status=true },
                new Brand {Id=53, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Proda ", Slug= "Proda ", Status=true },
                new Brand {Id=54, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "WK ", Slug= "WK ", Status=true },
                new Brand {Id=55, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Aspor ", Slug= "Aspor ", Status=true },
                new Brand {Id=56, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Bilitong ", Slug= "Bilitong ", Status=true },
                new Brand {Id=57, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Adata ", Slug= "Adata ", Status=true },
                new Brand {Id=58, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "BAKCELL ", Slug= "bakcell ", Status=true },
                new Brand {Id=59, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "AZERCELL ", Slug= "AZERCELL ", Status=true },
                new Brand {Id=60, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "NAR ", Slug= "NAR ", Status=true },
                new Brand {Id=61, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "İROBOT ", Slug= "İROBOT ", Status=true },
                new Brand {Id=62, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Symbol ", Slug= "Symbol ", Status=true },
                new Brand {Id=63, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Argox ", Slug= "Argox ", Status=true },
                new Brand {Id=64, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Datalogic ", Slug= "Datalogic ", Status=true },
                new Brand {Id=65, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "ACLAS ", Slug= "ACLAS ", Status=true },
                new Brand {Id=66, AdminManagerId=1, CreatedAt=DateTime.Now, Name= "Star ", Slug= "Star ", Status=true }
                );

            // Product Category 
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory {Id=1,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "category/e7132-telefon.png"},
                new ProductCategory {Id=2,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "category/73913-meiset-esyalari.png" },
                new ProductCategory {Id=3,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "category/44444-ofis-mehsullari.png" },
                new ProductCategory {Id=4,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "category/ee515-televior.png" },
                new ProductCategory {Id=5,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "category/9c45c-game-blue-.png" },
                new ProductCategory {Id=6,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "9ca97-kicik-meiset-esyalari.png" },
                new ProductCategory {Id=7,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "category/90694-dasinabilen.png" },
                new ProductCategory {Id=8,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "0427b-simcart.png" },
                new ProductCategory {Id=9,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "6e7e5-icon.png" },
                new ProductCategory {Id=10,AdminManagerId=1,CreatedAt=DateTime.Now, Status=true,Photo= "581ea-barcode_scanner.png" }
                );

            // Product Category Translate
            modelBuilder.Entity<ProductCategoryTranslate>().HasData(
                new ProductCategoryTranslate {Id=1, ProductCategoryId=1,LanguageId=1, Name= "Telephone and tablets", Slug= "Telephones-and-tablets" },
                new ProductCategoryTranslate {Id=2, ProductCategoryId=2,LanguageId=1, Name= "Household Items", Slug= "Household-Items" },
                new ProductCategoryTranslate {Id=3, ProductCategoryId=3,LanguageId=1, Name= "Computers and office equipment", Slug= "Computers-and-office-equipment" },
                new ProductCategoryTranslate {Id=4, ProductCategoryId=4,LanguageId=1, Name= "TV and Audio Systems", Slug= "TV-and-Audio-Systems" },
                new ProductCategoryTranslate {Id=5, ProductCategoryId=5,LanguageId=1, Name= "Game consoles", Slug= "Game-consoles" },
                new ProductCategoryTranslate {Id=6, ProductCategoryId=6,LanguageId=1, Name= "Small household items", Slug= "Small-household-items" },
                new ProductCategoryTranslate {Id=7, ProductCategoryId=7,LanguageId=1, Name= "Accessories", Slug= "Accessories" },
                new ProductCategoryTranslate {Id=8, ProductCategoryId=8,LanguageId=1, Name= "Numbers", Slug= "Numbers" },
                new ProductCategoryTranslate {Id=9, ProductCategoryId=9,LanguageId=1, Name= "İROBOT", Slug= "İROBOT" },
                new ProductCategoryTranslate {Id=10, ProductCategoryId=10,LanguageId=1, Name= "Office Equipment", Slug= "Office-Equipment" },
                new ProductCategoryTranslate {Id=11, ProductCategoryId=1,LanguageId=2, Name= "Telefon və planşetlər", Slug="telefon-ve-plansetler" },
                new ProductCategoryTranslate {Id=12, ProductCategoryId=2,LanguageId=2, Name= "Məişət əşyaları", Slug="meiset-esyalari" },
                new ProductCategoryTranslate {Id=13, ProductCategoryId=3,LanguageId=2, Name= "Kompüterlər və ofis avadanlıqları", Slug="koputer-ve-ofis-avadanliqlari" },
                new ProductCategoryTranslate {Id=14, ProductCategoryId=4,LanguageId=2, Name= "TV və Audio sistemlər", Slug="tv-ve-audio-sistemler" },
                new ProductCategoryTranslate {Id=15, ProductCategoryId=5,LanguageId=2, Name= "Oyun konsolları", Slug="oyun-konsollari" },
                new ProductCategoryTranslate {Id=16, ProductCategoryId=6,LanguageId=2, Name= "Kiçik ev əşyaları", Slug="kicik-ev-esyalari" },
                new ProductCategoryTranslate {Id=17, ProductCategoryId=7,LanguageId=2, Name= "Aksessuarlar", Slug= "Aksessuarlar" },
                new ProductCategoryTranslate {Id=18, ProductCategoryId=8,LanguageId=2, Name= "Nömrələr", Slug= "Nomreler" },
                new ProductCategoryTranslate {Id=19, ProductCategoryId=9,LanguageId=2, Name= "İROBOT", Slug= "İROBOT" },
                new ProductCategoryTranslate {Id=20, ProductCategoryId=10,LanguageId=2, Name= "Ofis Avadanlıqları", Slug= "Ofis Avadanlıqları" }
                );

            // Product Sub Category 
            modelBuilder.Entity<ProductSubCategory>().HasData(
                new ProductSubCategory {Id=1, ProductCategoryId=1, Photo= "category/6fe81-ceptelefon.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=2, ProductCategoryId = 1, Photo = "category/5f28a-tabletler.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=3, ProductCategoryId = 1, Photo = "category/3d444-akillisaatler.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=4, ProductCategoryId = 1, Photo = "category/c6c32-4c725ea90ea12cefddd054328870a61f-online-mobile-second-hand.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=5, ProductCategoryId = 2, Photo = "category/37bcc-soyuducu.png", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=6, ProductCategoryId = 2, Photo = "category/5818a-klima.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=7, ProductCategoryId = 2, Photo = "category/531d2-paltaryuyan.png", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=8, ProductCategoryId = 2, Photo = "category/a79f3-kitchenaid-logo.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=9, ProductCategoryId = 2, Photo = "category/bccf0-pilte.png", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=10, ProductCategoryId = 2, Photo = "category/63377-mikrodalga.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=11, ProductCategoryId = 3, Photo = "category/ddf24-notebook.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=12, ProductCategoryId = 3, Photo = "category/9b6f3-masaustu.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=13, ProductCategoryId = 3, Photo = "category/bd8b6-notebook.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=14, ProductCategoryId = 3, Photo = "category/d6ad6-yazicilar.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=15, ProductCategoryId = 3, Photo = "category/70f58-monitorkatr.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=16, ProductCategoryId = 4, Photo = "category/900d4-televizyonlar.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=17, ProductCategoryId = 4, Photo = "category/ec35f-ses_ev.png", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=18, ProductCategoryId = 4, Photo = "category/a6cf0-soundbar.png", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=19, ProductCategoryId = 4, Photo = "category/a9a78-evsinema.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=20, ProductCategoryId = 4, Photo = "category/d73ad-projeksiyon.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=21, ProductCategoryId = 5, Photo = "category/712b6-ps4.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=22, ProductCategoryId = 5, Photo = "category/8b3c4-unnamed.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=23, ProductCategoryId = 5, Photo = "category/47bfc-xbox-logo_318-9975.jpg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=24, ProductCategoryId = 5, Photo = "category/7e1df-37229008_21039398.jpeg", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory {Id=25, ProductCategoryId = 6, Photo = "category/00858-a4726b678f87bd94ea880eeef0ecdfcb-silhouette-black-white-vacuum-cleaner.png", AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new ProductSubCategory { Id = 26, ProductCategoryId = 6, Photo = "category/6a0f2-pngtree-vector-hair-dryer-icon-png-image_701315.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 27, ProductCategoryId = 6, Photo = "category/a7af1-electric-iron-icon-simple-style-vector-21484883.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 28, ProductCategoryId = 6, Photo = "category/560ee-meat-grinder-machine-icon-simple-style-vector-22276672.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 29, ProductCategoryId = 6, Photo = "category/ae188-electric-kettle-household-appliance-icon-vector-8275057.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 30, ProductCategoryId = 6, Photo = "category/d879f-juicer-icon-simple-style-vector-10155704.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 31, ProductCategoryId = 6, Photo = "category/11f7a-a-gray-stationary-blender-icon-vector-13417582.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 32, ProductCategoryId = 6, Photo = "category/cea64-toaster-icon-simple-black-style-vector-18839754.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 33, ProductCategoryId = 6, Photo = "category/4f398-90652265-stock-vector-mixer-kitchen-icon-simple-illustration-of-mixer-kitchen-vector-icon-for-web.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 34, ProductCategoryId = 7, Photo = "category/7b5b8-ekran-koruyucu.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 35, ProductCategoryId = 7, Photo = "category/9a881-iphonea.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 36, ProductCategoryId = 7, Photo = "category/eee1f-003386-glossy-black-icon-media-music-speaker.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 37, ProductCategoryId = 7, Photo = "category/6d65f-86666-cordless-phone.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 38, ProductCategoryId = 7, Photo = "category/74601-car-flat-icon-01-.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 39, ProductCategoryId = 7, Photo = "category/8ebb1-kablo.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 40, ProductCategoryId = 7, Photo = "category/03ba9-telefonkilif.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 41, ProductCategoryId = 7, Photo = "category/b1347-business-suitcase-bag-icon.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 42, ProductCategoryId = 7, Photo = "category/b40b8-network.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 43, ProductCategoryId = 7, Photo = "category/6d0d5-mouse.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 44, ProductCategoryId = 7, Photo = "category/f3ba8-sdcard.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 45, ProductCategoryId = 7, Photo = "category/b813a-kulaklikkategori.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 46, ProductCategoryId = 7, Photo = "category/2ed8d-tasinabilirsarj.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 47, ProductCategoryId = 7, Photo = "category/528ea-monopad.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 48, ProductCategoryId = 7, Photo = "category/c1af5-usb-bellek.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 49, ProductCategoryId = 8, Photo = "category/b3323-bakcell.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 50, ProductCategoryId = 8, Photo = "category/6fb9a-azercell.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 51, ProductCategoryId = 8, Photo = "category/bdd2e-nar.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 52, ProductCategoryId = 9, Photo = "category/d9046-81sbl3t77zl._sl1500_.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 53, ProductCategoryId = 10, Photo = "category/b3747-bar-code.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 54, ProductCategoryId = 10, Photo = "category/3a824-intermec_pc42d_icon_1.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 55, ProductCategoryId = 10, Photo = "category/09a3c-xprinter-thermal-barcode-printer-80mm-xp-350b-.jpg", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true },
                new ProductSubCategory { Id = 56, ProductCategoryId = 10, Photo = "category/eaf6d-sk50-1.png", AdminManagerId = 1, CreatedAt = DateTime.Now, Status = true }
                );


            // Product Sub Category Translate
            modelBuilder.Entity<ProductSubCategoryTranslate>().HasData(
                new ProductSubCategoryTranslate {Id=1, ProductSubCategoryId=1,LanguageId=1, Name="Mobile Phone" },
                new ProductSubCategoryTranslate {Id=2, ProductSubCategoryId=2,LanguageId=1, Name= "Tablets" },
                new ProductSubCategoryTranslate {Id=3, ProductSubCategoryId=3,LanguageId=1, Name= "SmartWatch" },
                new ProductSubCategoryTranslate {Id=4, ProductSubCategoryId=4,LanguageId=1, Name= "Second hand mobile phones" },
                new ProductSubCategoryTranslate {Id=5, ProductSubCategoryId=5,LanguageId=1, Name= "Refrigerator" },
                new ProductSubCategoryTranslate {Id=6, ProductSubCategoryId=6,LanguageId=1, Name= "Air conditioning" },
                new ProductSubCategoryTranslate {Id=7, ProductSubCategoryId=7,LanguageId=1, Name= "Washing machine" },
                new ProductSubCategoryTranslate {Id=8, ProductSubCategoryId=8,LanguageId=1, Name= "KitchenAid" },
                new ProductSubCategoryTranslate {Id=9, ProductSubCategoryId=9,LanguageId=1, Name= "Plates" },
                new ProductSubCategoryTranslate {Id=10, ProductSubCategoryId=10,LanguageId=1, Name= "Ovens" },
                new ProductSubCategoryTranslate {Id=11, ProductSubCategoryId=11,LanguageId=1, Name= "Notebook" },
                new ProductSubCategoryTranslate {Id=12, ProductSubCategoryId=12,LanguageId=1, Name= "Desktop computer" },
                new ProductSubCategoryTranslate {Id=13, ProductSubCategoryId=13,LanguageId=1, Name= "Monoblok " },
                new ProductSubCategoryTranslate {Id=14, ProductSubCategoryId=14,LanguageId=1, Name= "Printer" },
                new ProductSubCategoryTranslate {Id=15, ProductSubCategoryId=15,LanguageId=1, Name= "Monitor" },
                new ProductSubCategoryTranslate {Id=16, ProductSubCategoryId=16,LanguageId=1, Name="TV" },
                new ProductSubCategoryTranslate {Id=17, ProductSubCategoryId=17,LanguageId=1, Name= "Home Cinema" },
                new ProductSubCategoryTranslate {Id=18, ProductSubCategoryId=18,LanguageId=1, Name= "Soundbar" },
                new ProductSubCategoryTranslate {Id=19, ProductSubCategoryId=19,LanguageId=1, Name= "DVD player" },
                new ProductSubCategoryTranslate {Id=20, ProductSubCategoryId=20,LanguageId=1, Name= "Projector" },
                new ProductSubCategoryTranslate {Id=21, ProductSubCategoryId=21,LanguageId=1, Name= "PlayStation" },
                new ProductSubCategoryTranslate {Id=22, ProductSubCategoryId=22,LanguageId=1, Name="Games" },
                new ProductSubCategoryTranslate {Id=23, ProductSubCategoryId=23,LanguageId=1, Name= "Microsof Box " },
                new ProductSubCategoryTranslate {Id=24, ProductSubCategoryId=24,LanguageId=1, Name= "Game Manipulators" },
                new ProductSubCategoryTranslate {Id=25, ProductSubCategoryId=25,LanguageId=1, Name= "Vacuum cleaners" },
                new ProductSubCategoryTranslate {Id=26, ProductSubCategoryId=26,LanguageId=1, Name= "Subjects" },
                new ProductSubCategoryTranslate {Id=27, ProductSubCategoryId=27,LanguageId=1, Name= "Irons" },
                new ProductSubCategoryTranslate {Id=28, ProductSubCategoryId=28,LanguageId=1, Name= "Grinders" },
                new ProductSubCategoryTranslate {Id=29, ProductSubCategoryId=29,LanguageId=1, Name= "Kettles" },
                new ProductSubCategoryTranslate {Id=30, ProductSubCategoryId=30,LanguageId=1, Name= "Juicers" },
                new ProductSubCategoryTranslate {Id=31, ProductSubCategoryId=31,LanguageId=1, Name= "Blenders" },
                new ProductSubCategoryTranslate {Id=32, ProductSubCategoryId=32,LanguageId=1, Name= "Toasts" },
                new ProductSubCategoryTranslate {Id=33, ProductSubCategoryId=33,LanguageId=1, Name= "Mixers" },
                new ProductSubCategoryTranslate {Id=34, ProductSubCategoryId=34,LanguageId=1, Name= "Screen Protector" },
                new ProductSubCategoryTranslate {Id=35, ProductSubCategoryId=35,LanguageId=1, Name= "Apple Accessories" },
                new ProductSubCategoryTranslate {Id=36, ProductSubCategoryId=36,LanguageId=1, Name= "Amplifier" },
                new ProductSubCategoryTranslate {Id=37, ProductSubCategoryId=37,LanguageId=1, Name= "DECT Phones" },
                new ProductSubCategoryTranslate {Id=38, ProductSubCategoryId=38,LanguageId=1, Name= "Car accessories" },
                new ProductSubCategoryTranslate {Id=39, ProductSubCategoryId=39,LanguageId=1, Name= "Adapters" },
                new ProductSubCategoryTranslate {Id=40, ProductSubCategoryId=40,LanguageId=1, Name= "Phone Cases" },
                new ProductSubCategoryTranslate {Id=41, ProductSubCategoryId=41,LanguageId=1, Name= "Bags" },
                new ProductSubCategoryTranslate {Id=42, ProductSubCategoryId=42,LanguageId=1, Name= "Modems" },
                new ProductSubCategoryTranslate {Id=43, ProductSubCategoryId=43,LanguageId=1, Name= "Mouse" },
                new ProductSubCategoryTranslate {Id=44, ProductSubCategoryId=44,LanguageId=1, Name= "Memory Cards" },
                new ProductSubCategoryTranslate {Id=45, ProductSubCategoryId=45,LanguageId=1, Name= "Headphones" },
                new ProductSubCategoryTranslate {Id=46, ProductSubCategoryId=46,LanguageId=1, Name= "Power Bank" },
                new ProductSubCategoryTranslate {Id=47, ProductSubCategoryId=47,LanguageId=1, Name= "Monopod" },
                new ProductSubCategoryTranslate {Id=48, ProductSubCategoryId=48,LanguageId=1, Name= "USB Flash" },
                new ProductSubCategoryTranslate {Id=49, ProductSubCategoryId=49,LanguageId=1, Name= "Bakcell" },
                new ProductSubCategoryTranslate {Id=50, ProductSubCategoryId=50,LanguageId=1, Name= "Azercell" },
                new ProductSubCategoryTranslate {Id=51, ProductSubCategoryId=51,LanguageId=1, Name="Nar" },
                new ProductSubCategoryTranslate {Id=52, ProductSubCategoryId=52,LanguageId=1, Name= "İROBOT" },
                new ProductSubCategoryTranslate {Id=53, ProductSubCategoryId=53,LanguageId=1, Name= "Barcode Reader" },
                new ProductSubCategoryTranslate {Id=54, ProductSubCategoryId=54,LanguageId=1, Name= "Barcode Printer" },
                new ProductSubCategoryTranslate {Id=55, ProductSubCategoryId=55,LanguageId=1, Name= "Check Printer" },
                new ProductSubCategoryTranslate {Id=56, ProductSubCategoryId=56,LanguageId=1, Name= "Price Reader" },
                new ProductSubCategoryTranslate { Id = 57, ProductSubCategoryId = 1, LanguageId = 2, Name = "Mobil Telefonlar" },
                new ProductSubCategoryTranslate { Id = 58, ProductSubCategoryId = 2, LanguageId = 2, Name = "Planşetlər" },
                new ProductSubCategoryTranslate { Id = 59, ProductSubCategoryId = 3, LanguageId = 2, Name = "SmartWatch" },
                new ProductSubCategoryTranslate { Id = 60, ProductSubCategoryId = 4, LanguageId = 2, Name = "İkinci əl mobil telefonlar" },
                new ProductSubCategoryTranslate { Id = 61, ProductSubCategoryId = 5, LanguageId = 2, Name = "Soyuducu" },
                new ProductSubCategoryTranslate { Id = 62, ProductSubCategoryId = 6, LanguageId = 2, Name = "Kondisioner" },
                new ProductSubCategoryTranslate { Id = 63, ProductSubCategoryId = 7, LanguageId = 2, Name = "Paltaryuyan" },
                new ProductSubCategoryTranslate { Id = 64, ProductSubCategoryId = 8, LanguageId = 2, Name = "KitchenAid" },
                new ProductSubCategoryTranslate { Id = 65, ProductSubCategoryId = 9, LanguageId = 2, Name = "Plitələr" },
                new ProductSubCategoryTranslate { Id = 66, ProductSubCategoryId = 10, LanguageId = 2, Name = "Sobalar" },
                new ProductSubCategoryTranslate { Id = 67, ProductSubCategoryId = 11, LanguageId = 2, Name = "Noutbuk" },
                new ProductSubCategoryTranslate { Id = 68, ProductSubCategoryId = 12, LanguageId = 2, Name = "Masaüstü kompüter" },
                new ProductSubCategoryTranslate { Id = 69, ProductSubCategoryId = 13, LanguageId = 2, Name = "Monoblok" },
                new ProductSubCategoryTranslate { Id = 70, ProductSubCategoryId = 14, LanguageId = 2, Name = "Printer" },
                new ProductSubCategoryTranslate { Id = 71, ProductSubCategoryId = 15, LanguageId = 2, Name = "Monitor" },
                new ProductSubCategoryTranslate { Id = 72, ProductSubCategoryId = 16, LanguageId = 2, Name = "Televizor" },
                new ProductSubCategoryTranslate { Id = 73, ProductSubCategoryId = 17, LanguageId = 2, Name = "Ev kinoteatrı" },
                new ProductSubCategoryTranslate { Id = 74, ProductSubCategoryId = 18, LanguageId = 2, Name = "Soundbar" },
                new ProductSubCategoryTranslate { Id = 75, ProductSubCategoryId = 19, LanguageId = 2, Name = "DVD player" },
                new ProductSubCategoryTranslate { Id = 76, ProductSubCategoryId = 20, LanguageId = 2, Name = "Projektor" },
                new ProductSubCategoryTranslate { Id = 77, ProductSubCategoryId = 21, LanguageId = 2, Name = "PlayStation" },
                new ProductSubCategoryTranslate { Id = 78, ProductSubCategoryId = 22, LanguageId = 2, Name = "Oyunlar" },
                new ProductSubCategoryTranslate { Id = 79, ProductSubCategoryId = 23, LanguageId = 2, Name = "Microsof Box" },
                new ProductSubCategoryTranslate { Id = 80, ProductSubCategoryId = 24, LanguageId = 2, Name = "Oyun Manipulyatorları" },
                new ProductSubCategoryTranslate { Id = 81, ProductSubCategoryId = 25, LanguageId = 2, Name = "Tozsoranlar" },
                new ProductSubCategoryTranslate { Id = 82, ProductSubCategoryId = 26, LanguageId = 2, Name = "Fenlər " },
                new ProductSubCategoryTranslate { Id = 83, ProductSubCategoryId = 27, LanguageId = 2, Name = "Ütülər" },
                new ProductSubCategoryTranslate { Id = 84, ProductSubCategoryId = 28, LanguageId = 2, Name = "Ətçəkənlər" },
                new ProductSubCategoryTranslate { Id = 85, ProductSubCategoryId = 29, LanguageId = 2, Name = "Çaydanlar" },
                new ProductSubCategoryTranslate { Id = 86, ProductSubCategoryId = 30, LanguageId = 2, Name = "Şirəçəkənlər" },
                new ProductSubCategoryTranslate { Id = 87, ProductSubCategoryId = 31, LanguageId = 2, Name = "Blenderlər" },
                new ProductSubCategoryTranslate { Id = 88, ProductSubCategoryId = 32, LanguageId = 2, Name = "Tosterlər" },
                new ProductSubCategoryTranslate { Id = 89, ProductSubCategoryId = 33, LanguageId = 2, Name = "Mikserlər" },
                new ProductSubCategoryTranslate { Id = 90, ProductSubCategoryId = 34, LanguageId = 2, Name = "Screen Protector" },
                new ProductSubCategoryTranslate { Id = 91, ProductSubCategoryId = 35, LanguageId = 2, Name = "Apple Aksessuarları" },
                new ProductSubCategoryTranslate { Id = 92, ProductSubCategoryId = 36, LanguageId = 2, Name = "Səs gücləndirici" },
                new ProductSubCategoryTranslate { Id = 93, ProductSubCategoryId = 37, LanguageId = 2, Name = "DECT Telefonlar" },
                new ProductSubCategoryTranslate { Id = 94, ProductSubCategoryId = 38, LanguageId = 2, Name = "Avtomobil aksessuarları" },
                new ProductSubCategoryTranslate { Id = 95, ProductSubCategoryId = 39, LanguageId = 2, Name = "Adapterlər" },
                new ProductSubCategoryTranslate { Id = 96, ProductSubCategoryId = 40, LanguageId = 2, Name = "Telefon Qabları" },
                new ProductSubCategoryTranslate { Id = 97, ProductSubCategoryId = 41, LanguageId = 2, Name = "Çantalar" },
                new ProductSubCategoryTranslate { Id = 98, ProductSubCategoryId = 42, LanguageId = 2, Name = "Modemlər" },
                new ProductSubCategoryTranslate { Id = 99, ProductSubCategoryId = 43, LanguageId = 2, Name = "Mouse" },
                new ProductSubCategoryTranslate { Id = 100, ProductSubCategoryId = 44, LanguageId = 2, Name = "Yaddaş Kartları" },
                new ProductSubCategoryTranslate { Id = 101, ProductSubCategoryId = 45, LanguageId = 2, Name = "Qulaqcıqlar" },
                new ProductSubCategoryTranslate { Id = 102, ProductSubCategoryId = 46, LanguageId = 2, Name = "Power Bank" },
                new ProductSubCategoryTranslate { Id = 103, ProductSubCategoryId = 47, LanguageId = 2, Name = "Monopod " },
                new ProductSubCategoryTranslate { Id = 104, ProductSubCategoryId = 48, LanguageId = 2, Name = "USB Flash" },
                new ProductSubCategoryTranslate { Id = 105, ProductSubCategoryId = 49, LanguageId = 2, Name = "Bakcell" },
                new ProductSubCategoryTranslate { Id = 106, ProductSubCategoryId = 50, LanguageId = 2, Name = "Azercell" },
                new ProductSubCategoryTranslate { Id = 107, ProductSubCategoryId = 51, LanguageId = 2, Name = "Nar" },
                new ProductSubCategoryTranslate { Id = 108, ProductSubCategoryId = 52, LanguageId = 2, Name = "İRobot" },
                new ProductSubCategoryTranslate { Id = 109, ProductSubCategoryId = 53, LanguageId = 2, Name = "Barkod Oxuyucu" },
                new ProductSubCategoryTranslate { Id = 110, ProductSubCategoryId = 54, LanguageId = 2, Name = "Barkod Printer" },
                new ProductSubCategoryTranslate { Id = 111, ProductSubCategoryId = 55, LanguageId = 2, Name = "Çek Printe" },
                new ProductSubCategoryTranslate { Id = 112, ProductSubCategoryId = 56, LanguageId = 2, Name = "Qiymət Oxuyucu" }
                );

            // Brand Product Sub Category 
            modelBuilder.Entity<BrandProductCategory>().HasData(
                new BrandProductCategory {Id=1, BrandId=1, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=2, BrandId=1, ProductSubCategoryId=2 },
                new BrandProductCategory {Id=3, BrandId=1, ProductSubCategoryId=3 },
                new BrandProductCategory {Id=4, BrandId=1, ProductSubCategoryId=4 },
                new BrandProductCategory {Id=5, BrandId=1, ProductSubCategoryId=11 },
                new BrandProductCategory {Id=6, BrandId=1, ProductSubCategoryId=34 },
                new BrandProductCategory {Id=7, BrandId=1, ProductSubCategoryId=35 },
                new BrandProductCategory {Id=8, BrandId=1, ProductSubCategoryId=39 },
                new BrandProductCategory {Id=9, BrandId=1, ProductSubCategoryId=40 },
                new BrandProductCategory {Id=10, BrandId=2, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=11, BrandId=2, ProductSubCategoryId=2 },
                new BrandProductCategory {Id=12, BrandId=2, ProductSubCategoryId=3 },
                new BrandProductCategory {Id=13, BrandId=2, ProductSubCategoryId=4 },
                new BrandProductCategory {Id=14, BrandId=2, ProductSubCategoryId= 5},
                new BrandProductCategory {Id=15, BrandId=2, ProductSubCategoryId= 7},
                new BrandProductCategory {Id=16, BrandId=2, ProductSubCategoryId= 16},
                new BrandProductCategory {Id=17, BrandId=2, ProductSubCategoryId= 34},
                new BrandProductCategory {Id=18, BrandId=2, ProductSubCategoryId= 39},
                new BrandProductCategory {Id=19, BrandId=2, ProductSubCategoryId= 40},
                new BrandProductCategory {Id=20, BrandId=2, ProductSubCategoryId= 45},
                new BrandProductCategory {Id=21, BrandId=3, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=22, BrandId=3, ProductSubCategoryId=2 },
                new BrandProductCategory {Id=23, BrandId=4, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=24, BrandId=4, ProductSubCategoryId=3 },
                new BrandProductCategory {Id=25, BrandId=4, ProductSubCategoryId=4 },
                new BrandProductCategory {Id=26, BrandId=4, ProductSubCategoryId=34 },
                new BrandProductCategory {Id=27, BrandId=4, ProductSubCategoryId= 46},
                new BrandProductCategory {Id=28, BrandId=5, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=29, BrandId=6, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=30, BrandId=7, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=31, BrandId=8, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=32, BrandId=8, ProductSubCategoryId=4 },
                new BrandProductCategory {Id=33, BrandId=9, ProductSubCategoryId=1 },
                new BrandProductCategory {Id=34, BrandId=10, ProductSubCategoryId=2 },
                new BrandProductCategory {Id=35, BrandId=10, ProductSubCategoryId=11 },
                new BrandProductCategory {Id=36, BrandId=11, ProductSubCategoryId=3 },
                new BrandProductCategory {Id=37, BrandId=12, ProductSubCategoryId=4 },
                new BrandProductCategory {Id=38, BrandId=12, ProductSubCategoryId=5 },
                new BrandProductCategory {Id=39, BrandId=12, ProductSubCategoryId=7 },
                new BrandProductCategory {Id=40, BrandId=12, ProductSubCategoryId=16 },
                new BrandProductCategory {Id=41, BrandId=13, ProductSubCategoryId= 4},
                new BrandProductCategory {Id=42, BrandId=14, ProductSubCategoryId=5 },
                new BrandProductCategory {Id=43, BrandId=15, ProductSubCategoryId=5 },
                new BrandProductCategory {Id=44, BrandId=16, ProductSubCategoryId=5 },
                new BrandProductCategory {Id=45, BrandId=16, ProductSubCategoryId=9 },
                new BrandProductCategory {Id=46, BrandId=16, ProductSubCategoryId=10 },
                new BrandProductCategory {Id=47, BrandId=16, ProductSubCategoryId= 25},
                new BrandProductCategory {Id=48, BrandId=16, ProductSubCategoryId= 27},
                new BrandProductCategory {Id=49, BrandId=16, ProductSubCategoryId= 30},
                new BrandProductCategory {Id=51, BrandId=16, ProductSubCategoryId=31 },
                new BrandProductCategory {Id=52, BrandId=16, ProductSubCategoryId= 32},
                new BrandProductCategory {Id=53, BrandId=16, ProductSubCategoryId= 33},
                new BrandProductCategory {Id=54, BrandId=17, ProductSubCategoryId=5 },
                new BrandProductCategory {Id=55, BrandId=18, ProductSubCategoryId=6 },
                new BrandProductCategory {Id=56, BrandId=19, ProductSubCategoryId=6 },
                new BrandProductCategory {Id=57, BrandId=20, ProductSubCategoryId=6 },
                new BrandProductCategory {Id=58, BrandId=21, ProductSubCategoryId=7 },
                new BrandProductCategory {Id=59, BrandId=22, ProductSubCategoryId=7 },
                new BrandProductCategory {Id=60, BrandId=23, ProductSubCategoryId=11 },
                new BrandProductCategory {Id=61, BrandId=24, ProductSubCategoryId= 11},
                new BrandProductCategory {Id=62, BrandId=25, ProductSubCategoryId= 11},
                new BrandProductCategory {Id=63, BrandId=26, ProductSubCategoryId= 11},
                new BrandProductCategory {Id=64, BrandId=26, ProductSubCategoryId=13 },
                new BrandProductCategory {Id=65, BrandId=26, ProductSubCategoryId=14 },
                new BrandProductCategory {Id=66, BrandId=26, ProductSubCategoryId= 15},
                new BrandProductCategory {Id=67, BrandId=26, ProductSubCategoryId= 43},
                new BrandProductCategory {Id=68, BrandId=26, ProductSubCategoryId= 48},
                new BrandProductCategory {Id=69, BrandId=27, ProductSubCategoryId= 14},
                new BrandProductCategory {Id=70, BrandId=28, ProductSubCategoryId=14 },
                new BrandProductCategory {Id=71, BrandId=29, ProductSubCategoryId=16 },
                new BrandProductCategory {Id=72, BrandId=29, ProductSubCategoryId= 25},
                new BrandProductCategory {Id=73, BrandId=29, ProductSubCategoryId= 26},
                new BrandProductCategory {Id=74, BrandId=29, ProductSubCategoryId= 27},
                new BrandProductCategory {Id=75, BrandId=29, ProductSubCategoryId= 28},
                new BrandProductCategory {Id=76, BrandId=29, ProductSubCategoryId= 29},
                new BrandProductCategory {Id=77, BrandId=29, ProductSubCategoryId= 30},
                new BrandProductCategory {Id=78, BrandId=29, ProductSubCategoryId= 31},
                new BrandProductCategory {Id=79, BrandId=29, ProductSubCategoryId= 32},
                new BrandProductCategory {Id=80, BrandId=30, ProductSubCategoryId=16 },
                new BrandProductCategory {Id=81, BrandId=30, ProductSubCategoryId=45 },
                new BrandProductCategory {Id=82, BrandId=31, ProductSubCategoryId=16 },
                new BrandProductCategory {Id=83, BrandId=32, ProductSubCategoryId= 21},
                new BrandProductCategory {Id=84, BrandId=32, ProductSubCategoryId= 22},
                new BrandProductCategory {Id=85, BrandId=32, ProductSubCategoryId= 24},
                new BrandProductCategory {Id=86, BrandId=33, ProductSubCategoryId=23 },
                new BrandProductCategory {Id=87, BrandId=33, ProductSubCategoryId=24 },
                new BrandProductCategory {Id=88, BrandId=34, ProductSubCategoryId= 24},
                new BrandProductCategory {Id=89, BrandId=34, ProductSubCategoryId= 43},
                new BrandProductCategory {Id=90, BrandId=35, ProductSubCategoryId= 24},
                new BrandProductCategory {Id=91, BrandId=36, ProductSubCategoryId= 25},
                new BrandProductCategory {Id=92, BrandId=36, ProductSubCategoryId= 37},
                new BrandProductCategory {Id=93, BrandId=37, ProductSubCategoryId=26 },
                new BrandProductCategory {Id=94, BrandId=38, ProductSubCategoryId= 27},
                new BrandProductCategory {Id=95, BrandId=38, ProductSubCategoryId=28 },
                new BrandProductCategory {Id=96, BrandId=38, ProductSubCategoryId=29 },
                new BrandProductCategory {Id=97, BrandId=38, ProductSubCategoryId=30 },
                new BrandProductCategory {Id=98, BrandId=38, ProductSubCategoryId= 31},
                new BrandProductCategory {Id=99, BrandId=38, ProductSubCategoryId= 33},
                new BrandProductCategory {Id=100, BrandId=39, ProductSubCategoryId= 27},
                new BrandProductCategory {Id=101, BrandId=40, ProductSubCategoryId= 27},
                new BrandProductCategory {Id=102, BrandId=41, ProductSubCategoryId= 36},
                new BrandProductCategory {Id=103, BrandId=42, ProductSubCategoryId= 36},
                new BrandProductCategory {Id=104, BrandId=42, ProductSubCategoryId= 43},
                new BrandProductCategory {Id=105, BrandId=43, ProductSubCategoryId= 36},
                new BrandProductCategory {Id=106, BrandId=44, ProductSubCategoryId= 37},
                new BrandProductCategory {Id=107, BrandId=45, ProductSubCategoryId= 39},
                new BrandProductCategory {Id=108, BrandId=45, ProductSubCategoryId= 45},
                new BrandProductCategory {Id=109, BrandId=45, ProductSubCategoryId= 46},
                new BrandProductCategory {Id=110, BrandId=46, ProductSubCategoryId=39 },
                new BrandProductCategory {Id=111, BrandId=47, ProductSubCategoryId= 40},
                new BrandProductCategory {Id=112, BrandId=48, ProductSubCategoryId= 43},
                new BrandProductCategory {Id=113, BrandId=49, ProductSubCategoryId= 44},
                new BrandProductCategory {Id=114, BrandId=49, ProductSubCategoryId= 48},
                new BrandProductCategory {Id=115, BrandId=50, ProductSubCategoryId= 45},
                new BrandProductCategory {Id=116, BrandId=51, ProductSubCategoryId= 45},
                new BrandProductCategory {Id=117, BrandId=52, ProductSubCategoryId= 45},
                new BrandProductCategory {Id=118, BrandId=53, ProductSubCategoryId= 46},
                new BrandProductCategory {Id=119, BrandId=54, ProductSubCategoryId= 46},
                new BrandProductCategory {Id=120, BrandId=55, ProductSubCategoryId= 46},
                new BrandProductCategory {Id=121, BrandId=56, ProductSubCategoryId= 46},
                new BrandProductCategory {Id=122, BrandId=57, ProductSubCategoryId= 48},
                new BrandProductCategory {Id=123, BrandId=58, ProductSubCategoryId= 49},
                new BrandProductCategory {Id=124, BrandId=59, ProductSubCategoryId= 50},
                new BrandProductCategory {Id=125, BrandId=60, ProductSubCategoryId= 51},
                new BrandProductCategory {Id=126, BrandId=61, ProductSubCategoryId= 52},
                new BrandProductCategory {Id=127, BrandId=62, ProductSubCategoryId= 53},
                new BrandProductCategory {Id=128, BrandId=63, ProductSubCategoryId= 53},
                new BrandProductCategory {Id=129, BrandId=63, ProductSubCategoryId= 54},
                new BrandProductCategory {Id=130, BrandId=64, ProductSubCategoryId= 53},
                new BrandProductCategory {Id=131, BrandId=65, ProductSubCategoryId= 55},
                new BrandProductCategory {Id=132, BrandId=66, ProductSubCategoryId= 55}
                );

            // Properity
            modelBuilder.Entity<Properity>().HasData(
                new Properity {Id=1, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=2, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=3, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=4, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=5, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=6, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=7, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=8, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=9, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=10, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=11, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=12, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=13, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=14, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=15, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=16, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=17, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=18, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=19, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=20, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=21, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=22, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=23, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=24, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=25, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=26, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=27, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=28, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=29, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=30, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=31, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=32, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=33, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=34, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=35, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=36, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=37, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=38, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=39, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=40, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=41, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=42, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=43, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=44, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=45, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=46, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=47, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=48, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=49, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=50, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=51, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=52, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true },
                new Properity {Id=53, AdminManagerId=1, CreatedAt=DateTime.Now, Status=true }
                );

            // Properity Translate
            modelBuilder.Entity<ProperityTranslate>().HasData(
                new ProperityTranslate { Id =1 , ProperityId=1,LanguageId=2, Name = "Ölçüləri", Slug ="olculeri" },
                new ProperityTranslate { Id = 2, ProperityId=2,LanguageId=2, Name = "Çəkisi", Slug ="cekisi" },
                new ProperityTranslate { Id =3 , ProperityId=3,LanguageId=2, Name = "SİM", Slug = "SİM" },
                new ProperityTranslate { Id =4 , ProperityId=4,LanguageId=2, Name = "Əməliyyat sistemi", Slug ="emeliyyat-sistemi" },
                new ProperityTranslate { Id =5 , ProperityId=5,LanguageId=2, Name = "Prosessor", Slug = "Prosessor" },
                new ProperityTranslate { Id =6 , ProperityId=6,LanguageId=2, Name = "Nüvə", Slug ="nuve" },
                new ProperityTranslate { Id =7 , ProperityId=7,LanguageId=2, Name = "Daxili yaddaş", Slug ="daxili-yaddas" },
                new ProperityTranslate { Id =8 , ProperityId=8,LanguageId=2, Name = "RAM", Slug = "RAM" },
                new ProperityTranslate { Id =9 , ProperityId=9,LanguageId=2, Name = "Yaddaş kartı", Slug = "Yaddas-karti" },
                new ProperityTranslate { Id =10 , ProperityId=10,LanguageId=2, Name = "Əsas kamera", Slug ="esas-kamera" },
                new ProperityTranslate { Id = 11, ProperityId=11,LanguageId=2, Name = "Video", Slug ="video" },
                new ProperityTranslate { Id = 12, ProperityId=12,LanguageId=2, Name = "Ön kamera", Slug ="on-kamera" },
                new ProperityTranslate { Id = 13, ProperityId=13,LanguageId=2, Name = "WLAN", Slug = "WLAN" },
                new ProperityTranslate { Id = 14, ProperityId=14,LanguageId=2, Name = "Bluetooth", Slug = "Bluetooth" },
                new ProperityTranslate { Id = 15, ProperityId=15,LanguageId=2, Name = "Batareya həcmi", Slug = "Batareya-həcmi" },
                new ProperityTranslate { Id =16 , ProperityId=16,LanguageId=2, Name = "Ekran ölçüsü", Slug ="ekran-olcusu" },
                new ProperityTranslate { Id =17 , ProperityId=17,LanguageId=2, Name = "Növü", Slug ="novu" },
                new ProperityTranslate { Id = 18, ProperityId=18,LanguageId=2, Name = "Ümumi həcmi", Slug ="umumi-hecmi" },
                new ProperityTranslate { Id = 19, ProperityId=19,LanguageId=2, Name = "Enerji sinifi", Slug ="enerji-sinfi" },
                new ProperityTranslate { Id = 20, ProperityId=20,LanguageId=2, Name = "Soyuducu hissənin həcmi", Slug ="soyuducu-hissenin-hecmi" },
                new ProperityTranslate { Id = 21, ProperityId=21,LanguageId=2, Name = "Dondurma kamerasının həcmi", Slug ="dondurma-kamerasinin-hecmi" },
                new ProperityTranslate { Id = 22, ProperityId=22,LanguageId=2, Name = "Xüsusiyyətləri", Slug ="xususiyetleri" },
                new ProperityTranslate { Id = 23, ProperityId=23,LanguageId=2, Name = "Soyuducu maye", Slug = "Soyuducu-maye" },
                new ProperityTranslate { Id = 24, ProperityId=24,LanguageId=2, Name = "Təsir sahəsi", Slug ="tesir-sahesi" },
                new ProperityTranslate { Id = 25, ProperityId=25,LanguageId=2, Name = "Tutum", Slug ="tutum" },
                new ProperityTranslate { Id = 26, ProperityId=26,LanguageId=2, Name = "Sıxma sürəti", Slug = "Sıxma-sureti" },
                new ProperityTranslate { Id = 27, ProperityId=27,LanguageId=2, Name = "Enerji sinifi", Slug = "Enerji-sinifi" },
                new ProperityTranslate { Id = 28, ProperityId=28,LanguageId=2, Name = "Proqramlar", Slug = "Proqramlar" },
                new ProperityTranslate { Id = 29, ProperityId=29,LanguageId=2, Name = "Uşaq kilidi", Slug = "Uşaq-kilidi" },
                new ProperityTranslate { Id = 30, ProperityId=30,LanguageId=2, Name = "Keramik qızdırıcı", Slug = "Keramik-qızdırıcı" },
                new ProperityTranslate { Id = 31, ProperityId=31,LanguageId=2, Name = "Portlar", Slug = "Portlar" },
                new ProperityTranslate { Id = 32, ProperityId=32,LanguageId=2, Name = "Şəbəkə", Slug = "Şəbəkə" },
                new ProperityTranslate { Id = 33, ProperityId=33,LanguageId=2, Name = "Qrafik yaddaş", Slug = "Qrafik-yaddaş" },
                new ProperityTranslate { Id = 34, ProperityId=34,LanguageId=2, Name = "Ekran növü", Slug = "Ekran-növü" },
                new ProperityTranslate { Id = 35, ProperityId=35,LanguageId=2, Name = "Tezlik", Slug = "Tezlik" },
                new ProperityTranslate { Id = 36, ProperityId=36,LanguageId=2, Name = "Rəqəmsal Tuner", Slug = "Rəqəmsal-Tuner" },
                new ProperityTranslate { Id = 37, ProperityId=37,LanguageId=2, Name = "Dəstəklənən çıxışlar", Slug = "Dəstəklənən-çıxışlar" },
                new ProperityTranslate { Id = 38, ProperityId=38,LanguageId=2, Name = "Wi-Fi", Slug = "Wi-Fi" },
                new ProperityTranslate { Id = 39, ProperityId=39,LanguageId=2, Name = "3D", Slug = "3D" },
                new ProperityTranslate { Id = 40, ProperityId=40,LanguageId=2, Name = "Dəstəklənən formatlar", Slug = "Dəstəklənən-formatlar" },
                new ProperityTranslate { Id = 41, ProperityId=41,LanguageId=2, Name = "Gücü", Slug = "Gücü" },
                new ProperityTranslate { Id = 42, ProperityId=42,LanguageId=2, Name = "Sovurma Gücü", Slug = "Sovurma-Gücü" },
                new ProperityTranslate { Id = 43, ProperityId=43,LanguageId=2, Name = "Naqilin Uzunluğu", Slug = "Naqilin-Uzunluğu" },
                new ProperityTranslate { Id = 44, ProperityId=44,LanguageId=2, Name = "Toz qabının növü", Slug = "Toz-qabının-növü" },
                new ProperityTranslate { Id = 45, ProperityId=45,LanguageId=2, Name = "Sürət sayı", Slug = "Sürət-sayı" },
                new ProperityTranslate { Id = 46, ProperityId=46,LanguageId=2, Name = "Temperatur rejimlərinin sayı", Slug = "Temperatur-rejimlərinin-sayı" },
                new ProperityTranslate { Id = 47, ProperityId=47,LanguageId=2, Name = "Başlıqlar", Slug = "Başlıqlar" },
                new ProperityTranslate { Id = 48, ProperityId=48,LanguageId=2, Name = "Buxar Gücü", Slug = "Buxar-Gücü" },
                new ProperityTranslate { Id = 49, ProperityId=49,LanguageId=2, Name = "Su tutumu", Slug = "Su-tutumu" },
                new ProperityTranslate { Id = 50, ProperityId=50,LanguageId=2, Name = "Məsafəsi", Slug = "Məsafəsi" },
                new ProperityTranslate { Id = 51, ProperityId=51,LanguageId=2, Name = "Genişliyi", Slug = "Genişliyi" },
                new ProperityTranslate { Id = 52, ProperityId=52,LanguageId=2, Name = "Sürəti", Slug = "Sürəti" },
                new ProperityTranslate { Id = 53, ProperityId=53,LanguageId=2, Name = "Keyfiyyəti", Slug = "Keyfiyyəti" },
                new ProperityTranslate { Id = 54, ProperityId=1,LanguageId=1, Name = "Dimensions", Slug = "Dimensions" },
                new ProperityTranslate { Id = 55, ProperityId=2,LanguageId=1, Name = "Weight", Slug = "Weight" },
                new ProperityTranslate { Id = 56, ProperityId=3,LanguageId=1, Name = "SIM", Slug = "SIM" },
                new ProperityTranslate { Id = 57, ProperityId=4,LanguageId=1, Name = "Operating system", Slug = "Operating-system" },
                new ProperityTranslate { Id = 58, ProperityId=5,LanguageId=1, Name = "Processor", Slug = "Processor" },
                new ProperityTranslate { Id = 59, ProperityId=6,LanguageId=1, Name = "Nuclear", Slug = "Nuclear" },
                new ProperityTranslate { Id = 60, ProperityId=7,LanguageId=1, Name = "Internal memory", Slug = "Internal-memory" },
                new ProperityTranslate { Id = 61, ProperityId=8,LanguageId=1, Name = "RAM", Slug = "ram" },
                new ProperityTranslate { Id = 62, ProperityId=9,LanguageId=1, Name = "Memory card", Slug = "Memory-card" },
                new ProperityTranslate { Id = 63, ProperityId=10,LanguageId=1, Name = "The main camera", Slug = "The-main-camera" },
                new ProperityTranslate { Id = 64, ProperityId=11,LanguageId=1, Name = "Video", Slug = "video" },
                new ProperityTranslate { Id = 65, ProperityId=12,LanguageId=1, Name = "Front camera", Slug = "Front-camera" },
                new ProperityTranslate { Id = 66, ProperityId=13,LanguageId=1, Name = "WLAN", Slug = "WLAN" },
                new ProperityTranslate { Id = 67, ProperityId=14,LanguageId=1, Name = "Bluetooth", Slug = "Bluetooth" },
                new ProperityTranslate { Id = 68, ProperityId=15,LanguageId=1, Name = "Battery volume", Slug = "Battery-volume" },
                new ProperityTranslate { Id = 69, ProperityId=16,LanguageId=1, Name = "Screen size", Slug = "Screen-size" },
                new ProperityTranslate { Id = 70, ProperityId=17,LanguageId=1, Name = "Type", Slug = "Type" },
                new ProperityTranslate { Id = 71, ProperityId=18,LanguageId=1, Name = "Total volume", Slug = "Total-volume" },
                new ProperityTranslate { Id = 72, ProperityId=19,LanguageId=1, Name = "Energy class", Slug = "Energy-class" },
                new ProperityTranslate { Id = 73, ProperityId=20,LanguageId=1, Name = "The volume of the refrigerator compartment", Slug = "The-volume-of-the-refrigerator-compartment" },
                new ProperityTranslate { Id = 74, ProperityId=21,LanguageId=1, Name = "Freezing chamber volume", Slug = "Freezing-chamber-volume" },
                new ProperityTranslate { Id = 75, ProperityId=22,LanguageId=1, Name = "Features", Slug = "Features" },
                new ProperityTranslate { Id = 76, ProperityId=23,LanguageId=1, Name = "Refrigerant liquid", Slug = "Refrigerant-liquid" },
                new ProperityTranslate { Id = 77, ProperityId=24,LanguageId=1, Name = "Influence area", Slug = "Influence-area" },
                new ProperityTranslate { Id = 78, ProperityId=25,LanguageId=1, Name = "Capacity", Slug = "Capacity" },
                new ProperityTranslate { Id = 79, ProperityId=26,LanguageId=1, Name = "Compression rate", Slug = "Compression-rate" },
                new ProperityTranslate { Id = 80, ProperityId=27,LanguageId=1, Name = "Energy class", Slug = "Energy-class" },
                new ProperityTranslate { Id = 81, ProperityId=28,LanguageId=1, Name = "Applications", Slug = "Applications" },
                new ProperityTranslate { Id = 82, ProperityId=29,LanguageId=1, Name = "Child lock", Slug = "Child-lock" },
                new ProperityTranslate { Id = 83, ProperityId=30,LanguageId=1, Name = "Ceramic heater", Slug = "Ceramic-heater" },
                new ProperityTranslate { Id = 84, ProperityId=31,LanguageId=1, Name = "Ports", Slug = "Ports" },
                new ProperityTranslate { Id = 85, ProperityId=32,LanguageId=1, Name = "Network", Slug = "Network" },
                new ProperityTranslate { Id = 86, ProperityId=33,LanguageId=1, Name = "Graphic memory", Slug = "Graphic-memory" },
                new ProperityTranslate { Id = 87, ProperityId=34,LanguageId=1, Name = "Screen type", Slug = "Screen-type" },
                new ProperityTranslate { Id = 88, ProperityId=35,LanguageId=1, Name = "Speed", Slug = "Speed" },
                new ProperityTranslate { Id = 89, ProperityId=36,LanguageId=1, Name = "Digital Tuner", Slug = "Digital-Tuner" },
                new ProperityTranslate { Id = 90, ProperityId=37,LanguageId=1, Name = "Supported speeches", Slug = "Supported-speeches" },
                new ProperityTranslate { Id = 91, ProperityId=38,LanguageId=1, Name = "Wi-Fi", Slug = "Wi-Fi" },
                new ProperityTranslate { Id = 92, ProperityId=39,LanguageId=1, Name = "3D", Slug = "3D" },
                new ProperityTranslate { Id = 93, ProperityId=40,LanguageId=1, Name = "Supported formats", Slug = "Supported-formats" },
                new ProperityTranslate { Id = 94, ProperityId=41,LanguageId=1, Name = "Power", Slug = "Power" },
                new ProperityTranslate { Id = 95, ProperityId=42,LanguageId=1, Name = "Cooling Power", Slug = "Cooling-Power" },
                new ProperityTranslate { Id = 96, ProperityId=43,LanguageId=1, Name = "Length of wire", Slug = "Length-of-wire" },
                new ProperityTranslate { Id = 97, ProperityId=44,LanguageId=1, Name = "Dust container type", Slug = "Dust-container-type" },
                new ProperityTranslate { Id = 98, ProperityId=45,LanguageId=1, Name = "Number of speeds", Slug = "Number-of-speeds" },
                new ProperityTranslate { Id = 99, ProperityId=46,LanguageId=1, Name = "Number of temperature modes", Slug = "Number-of-temperature-modes" },
                new ProperityTranslate { Id = 100, ProperityId=47,LanguageId=1, Name = "Headlines", Slug = "Headlines" },
                new ProperityTranslate { Id = 101, ProperityId=48,LanguageId=1, Name = "Steam Power", Slug = "Steam-Power" },
                new ProperityTranslate { Id = 102, ProperityId=49,LanguageId=1, Name = "Water capacity", Slug = "Water-capacity" },
                new ProperityTranslate { Id = 103, ProperityId=50,LanguageId=1, Name = "Distance", Slug = "Distance" },
                new ProperityTranslate { Id = 104, ProperityId=51,LanguageId=1, Name = "Width", Slug = "Width" },
                new ProperityTranslate { Id = 105, ProperityId=52,LanguageId=1, Name = "Speed", Slug = "speed" },
                new ProperityTranslate { Id = 106, ProperityId=53,LanguageId=1, Name = "Quality", Slug = "Quality" }
                );

            // Properity Category
            modelBuilder.Entity<ProperityCategory>().HasData(
                new ProperityCategory { Id =1 , ProperityId =1, ProductSubCategoryId = 1},
                new ProperityCategory { Id =2 , ProperityId =2, ProductSubCategoryId = 1},
                new ProperityCategory { Id =3 , ProperityId =3, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 4, ProperityId =4, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 5, ProperityId =5, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 6, ProperityId =6, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 7, ProperityId =7, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 8, ProperityId =8, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 9, ProperityId =9, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 10, ProperityId =10, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 11, ProperityId =11, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 12, ProperityId =12, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 13, ProperityId =13, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 14, ProperityId =14, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 15, ProperityId =15, ProductSubCategoryId = 1},
                new ProperityCategory { Id = 16, ProperityId =1, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 17, ProperityId =16, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 18, ProperityId =3, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 19, ProperityId =4, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 20, ProperityId =5, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 21, ProperityId =7, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 22, ProperityId =10, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 23, ProperityId =12, ProductSubCategoryId = 2},
                new ProperityCategory { Id = 24, ProperityId =1, ProductSubCategoryId = 3},
                new ProperityCategory { Id = 25, ProperityId =2, ProductSubCategoryId = 3},
                new ProperityCategory { Id = 26, ProperityId =16, ProductSubCategoryId = 3},
                new ProperityCategory { Id = 27, ProperityId =9, ProductSubCategoryId = 3},
                new ProperityCategory { Id = 28, ProperityId =1, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 29, ProperityId =2, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 30, ProperityId =3, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 31, ProperityId =4, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 32, ProperityId =5, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 33, ProperityId =6, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 34, ProperityId =7, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 35, ProperityId =8, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 36, ProperityId =9, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 37, ProperityId =10, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 38, ProperityId =11, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 39, ProperityId =12, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 40, ProperityId =13, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 41, ProperityId =14, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 42, ProperityId =15, ProductSubCategoryId = 4},
                new ProperityCategory { Id = 43, ProperityId =1, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 44, ProperityId =17, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 45, ProperityId =18, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 46, ProperityId =19, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 47, ProperityId =20, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 48, ProperityId =21, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 49, ProperityId =22, ProductSubCategoryId = 5},
                new ProperityCategory { Id = 50, ProperityId =17, ProductSubCategoryId = 6},
                new ProperityCategory { Id = 51, ProperityId =23, ProductSubCategoryId = 6},
                new ProperityCategory { Id = 52, ProperityId =24, ProductSubCategoryId = 6},
                new ProperityCategory { Id = 53, ProperityId =1, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 54, ProperityId =25, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 55, ProperityId =26, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 56, ProperityId =27, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 57, ProperityId =28, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 58, ProperityId =29, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 59, ProperityId =30, ProductSubCategoryId = 7},
                new ProperityCategory { Id = 60, ProperityId =5, ProductSubCategoryId = 11},
                new ProperityCategory { Id = 61, ProperityId =7, ProductSubCategoryId = 11},
                new ProperityCategory { Id = 62, ProperityId =8, ProductSubCategoryId = 11},
                new ProperityCategory { Id =63 , ProperityId =31, ProductSubCategoryId = 11},
                new ProperityCategory { Id = 64, ProperityId =32, ProductSubCategoryId = 11},
                new ProperityCategory { Id = 65, ProperityId =5, ProductSubCategoryId = 13},
                new ProperityCategory { Id = 66, ProperityId =7, ProductSubCategoryId = 13},
                new ProperityCategory { Id = 67, ProperityId =8, ProductSubCategoryId = 13},
                new ProperityCategory { Id = 68, ProperityId =31, ProductSubCategoryId = 13},
                new ProperityCategory { Id = 69, ProperityId =32, ProductSubCategoryId = 13},
                new ProperityCategory { Id = 70, ProperityId =33, ProductSubCategoryId = 15},
                new ProperityCategory { Id = 71, ProperityId =16, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 72, ProperityId =34, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 73, ProperityId =35, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 74, ProperityId =36, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 75, ProperityId =37, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 76, ProperityId =38, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 77, ProperityId =39, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 78, ProperityId =40, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 79, ProperityId =1, ProductSubCategoryId = 16},
                new ProperityCategory { Id = 80, ProperityId =25, ProductSubCategoryId = 25},
                new ProperityCategory { Id = 81, ProperityId =41, ProductSubCategoryId = 25},
                new ProperityCategory { Id = 82, ProperityId =42, ProductSubCategoryId = 25},
                new ProperityCategory { Id = 83, ProperityId =43, ProductSubCategoryId = 25},
                new ProperityCategory { Id = 84, ProperityId =44, ProductSubCategoryId = 25},
                new ProperityCategory { Id = 85, ProperityId =41, ProductSubCategoryId =26 },
                new ProperityCategory { Id = 86, ProperityId =45, ProductSubCategoryId =26 },
                new ProperityCategory { Id = 87, ProperityId =46, ProductSubCategoryId =26 },
                new ProperityCategory { Id = 88, ProperityId =47, ProductSubCategoryId =26 },
                new ProperityCategory { Id = 89, ProperityId =41, ProductSubCategoryId = 27},
                new ProperityCategory { Id = 90, ProperityId =48, ProductSubCategoryId = 27},
                new ProperityCategory { Id = 91, ProperityId =49, ProductSubCategoryId =27 },
                new ProperityCategory { Id = 92, ProperityId =17, ProductSubCategoryId =52 },
                new ProperityCategory { Id = 93, ProperityId =17, ProductSubCategoryId =53 },
                new ProperityCategory { Id = 94, ProperityId =1, ProductSubCategoryId =53 },
                new ProperityCategory { Id = 95, ProperityId =2, ProductSubCategoryId =53 },
                new ProperityCategory { Id = 96, ProperityId =18, ProductSubCategoryId =53 },
                new ProperityCategory { Id = 97, ProperityId =50, ProductSubCategoryId =53 },
                new ProperityCategory { Id = 98, ProperityId =51, ProductSubCategoryId =54 },
                new ProperityCategory { Id = 99, ProperityId =52, ProductSubCategoryId =54 },
                new ProperityCategory { Id = 100, ProperityId =53, ProductSubCategoryId =54 },
                new ProperityCategory { Id = 101, ProperityId =51, ProductSubCategoryId =55 },
                new ProperityCategory { Id = 102, ProperityId =52, ProductSubCategoryId =55 },
                new ProperityCategory { Id = 103, ProperityId =53, ProductSubCategoryId =55 }
                );

            //// Product
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "iPhone 11 Pro Max 256 GB",Slug= "iPhone-11-Pro-Max-256-GB", BrandProductCategoryId = 1, Price =3029, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 2, Name = "iPhone 11 Pro 256 GB", Slug = "iphone-11-pro-256-gb", BrandProductCategoryId = 1, Price =2850, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 3, Name = "iPhone 11 Pro Max 64 GB", Slug = "iphone-11-pro-max-64-gb", BrandProductCategoryId = 1, Price =2759, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 4, Name = "iPhone 11 Pro 64 GB", Slug = "iphone-11-pro-64-gb", BrandProductCategoryId = 1, Price =2519, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 5, Name = "iPhone XS Max 256 GB", Slug = "iPhone-XS-Max-256-GB", BrandProductCategoryId = 1, Price =2449, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 6, Name = "iPhone XS Max 64 GB Dual", Slug = "iPhone-XS-Max-64-GB-Dual", BrandProductCategoryId = 1, Price =2379, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 7, Name = "iPhone XS Max 64 GB", Slug = "iPhone-XS-Max-64-GB", BrandProductCategoryId = 1, Price =2199, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 8, Name = "iPhone XS  256 GB", Slug = "iPhone-XS-256-GB", BrandProductCategoryId = 1, Price =2189, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 9, Name = "iPhone XS  64 GB", Slug = "iPhone-XS-64-GB", BrandProductCategoryId = 1, Price =1999, Discount = 10, DiscountDate = 10, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 10, Name = "APPLE IPAD PRO 10.5 WI-FI 4G 256 GB", Slug = "APPLE-IPAD-PRO-10-5-WI-FI-4G-256-GB", BrandProductCategoryId = 2, Price =1799, Discount = 0, DiscountDate = 0, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 11, Name = "APPLE IPAD Air 256 GB (2019)", Slug = "APPLE-IPAD-Air-256-GB-2019", BrandProductCategoryId = 2, Price =1649, Discount = 0, DiscountDate = 0, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 12, Name = "Apple Watch Series 5 44mm", Slug = "Apple-Watch-Series-5-44mm", BrandProductCategoryId = 3, Price =999, Discount = 0, DiscountDate = 0, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 13, Name = "Apple Watch Series 4 40mm", Slug = "Apple-Watch-Series-4-40mm", BrandProductCategoryId = 3, Price =849, Discount = 0, DiscountDate = 0, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 14, Name = "iPhone XS Max 256 Gb black", Slug = "IPhone-XS-Max-256-Gb-black", BrandProductCategoryId = 4, Price =1859, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 15, Name = "iPhone XS Max 64 GB Gold", Slug = "iPhone-XS-Max-64-GB-Gold", BrandProductCategoryId = 4, Price =1759, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 16, Name = "Apple MacBook Pro MR942", Slug = "Apple-MacBook-Pro-MR942", BrandProductCategoryId = 5, Price =5490, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id = 17, Name = "iPhone X 5D Baseus Chamilyon", Slug = "iPhone-X-5D-Baseus-Chamilyon", BrandProductCategoryId = 6, Price =25, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =18 , Name = "iPhone Original Hi-Fi", Slug = "iPhone-Original-Hi-Fi", BrandProductCategoryId = 7, Price =59, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =19 , Name = "Apple iPhone USB Original", Slug = "Apple-iPhone-USB-Original", BrandProductCategoryId = 8, Price =25, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =20, Name = "iPhone X Comma Premium Gift", Slug = "iPhone-X-Comma-Premium-Gift", BrandProductCategoryId = 9, Price =99, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =21, Name = "Samsung Galaxy Note 10 plus", Slug = "Samsung-Galaxy-Note-10-plus", BrandProductCategoryId =10 , Price =2149, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =22, Name = "Samsung Galaxy Note 10", Slug = "Samsung-Galaxy-Note-10", BrandProductCategoryId =10 , Price =1949, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =23, Name = "Samsung Galaxy S10 Plus", Slug = "Samsung-Galaxy-S10-Plus", BrandProductCategoryId =10 , Price =1899, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =24, Name = "Samsung Galaxy S10", Slug = "Samsung-Galaxy-S10", BrandProductCategoryId =10 , Price =1699, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =25, Name = "Samsung Galaxy Note 9", Slug = "Samsung-Galaxy-Note-9", BrandProductCategoryId =10 , Price =1499, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =26, Name = "Samsung Galaxy S10 E", Slug = "Samsung-Galaxy-S10-E", BrandProductCategoryId =10 , Price =1449, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =27, Name = "Samsung Galaxy Tab S2 VE 8.0", Slug = "Samsung-Galaxy-Tab-S2-VE-8-0", BrandProductCategoryId =11 , Price =799, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =28, Name = "Samsung Galaxy Tab A 10.1", Slug = "Samsung-Galaxy-Tab-A-10-1", BrandProductCategoryId =11 , Price =549, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =29, Name = "Samsung Galaxy Tab A/8.0 LTE", Slug = "Samsung-Galaxy-Tab-A-8-0-LTE", BrandProductCategoryId =11 , Price =369, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =30, Name = "Samsung Galaxy Watch (46 mm)", Slug = "Samsung-Galaxy-Watch-46-mm", BrandProductCategoryId =12 , Price =599, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =31, Name = "Samsung Galaxy S8 Plus Black", Slug = "Samsung-Galaxy-S8-Plus-Black", BrandProductCategoryId =13 , Price =699, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =32, Name = "Samsung RS57K4000SA/WT", Slug = "Samsung-RS57K4000SA-WT", BrandProductCategoryId =14 , Price =2369,  Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =33, Name = "Samsung WW70K62E00SDLP", Slug = "Samsung-WW70K62E00SDLP", BrandProductCategoryId =15 , Price =1199, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =34, Name = "Samsung UE65RU7300UXRU", Slug = "Samsung-UE65RU7300UXRU", BrandProductCategoryId =16 , Price =2669, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =35, Name = "S8 Plus 3D Black S/P", Slug = "S8-Plus-3D-Black-S-P", BrandProductCategoryId =17 , Price =20, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =36, Name = "Samsung Travel Adater Fast Type C", Slug = "Samsung-Travel-Adater-Fast-Type-C", BrandProductCategoryId =18 , Price =25, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =37, Name = "Samsung Note 8 Active Case", Slug = "Samsung-Note-8-Active-Case", BrandProductCategoryId =19 , Price =70, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =38, Name = "Samsung Hi-Fi Level upro", Slug = "Samsung-Hi-Fi-Level-upro", BrandProductCategoryId =20 , Price =59, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =39, Name = "Huawei P 30 Pro", Slug = "Huawei-P-30-Pro", BrandProductCategoryId =21 , Price =1999, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =40, Name = "Huawei Media Tab 3 10.1", Slug = "Huawei-Media-Tab-3-10-1", BrandProductCategoryId =22 , Price =399, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =41, Name = "Xiaomi Black Shark", Slug = "Xiaomi-Black-Shark", BrandProductCategoryId =23 , Price =1119, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =42, Name = "Xiaomi Amazfit Stratos", Slug = "Xiaomi-Amazfit-Stratos", BrandProductCategoryId =24 , Price =369, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =43, Name = "Xiaomi Mi 8 128 GB Blue", Slug = "Xiaomi-Mi-8-128-GB-Blue", BrandProductCategoryId =25 , Price =559, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =44, Name = "Xiaomi Note 5 5D S/P", Slug = "Xiaomi-Note-5-5D-S-P", BrandProductCategoryId =26 , Price =10, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =45, Name = "Power Bank Xiaomi 20000 mAh", Slug = "Power-Bank-Xiaomi-20000-mAh", BrandProductCategoryId =27 , Price =79, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =46, Name = "Meizu M6t", Slug = "Meizu-M6t", BrandProductCategoryId =28 , Price =329, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =47, Name = "NOKIA 6.1 2018", Slug = "NOKIA-6-1-2018", BrandProductCategoryId =29 , Price =689, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =48, Name = "FLY CIRRUS 7", Slug = "FLY-CIRRUS-7", BrandProductCategoryId =30 , Price =259, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =49, Name = "ULEFONE S9 Pro", Slug = "ULEFONE-S9-Pro", BrandProductCategoryId =31 , Price =229, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =50, Name = "uleFone S8 (16 GB) Black", Slug = "uleFone-S8-16-GB-Black", BrandProductCategoryId =32 , Price =129, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =51, Name = "Honor 10", Slug = "Honor-10", BrandProductCategoryId =33 , Price =1029, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =52, Name = "Lenovo Tab P 10", Slug = "Lenovo-Tab-P-10", BrandProductCategoryId =34 , Price =829, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =53, Name = "Lenovo Yoga 510-14IKB Touch", Slug = "Lenovo-Yoga-510-14IKB-Touch", BrandProductCategoryId =35 , Price =1771, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =54, Name = "Balafon GPS Watch", Slug = "Balafon-GPS-Watch", BrandProductCategoryId =36 , Price =69, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =55, Name = "LG GR-B650GLPL", Slug = "LG-GR-B650GLPL", BrandProductCategoryId =38 , Price =1869, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =56, Name = "LG F1296TDT24", Slug = "LG-F1296TDT24", BrandProductCategoryId =39 , Price =1139, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =57, Name = "LG OLED55B8SLB", Slug = "LG-OLED55B8SLB", BrandProductCategoryId =40 , Price =3599, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =58, Name = "HTC One X9 Gold Dual SIM ", Slug = "HTC-One-X9-Gold-Dual-SIM ", BrandProductCategoryId =41 , Price =399, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =59, Name = "HITACHI R-W720FPUC1X", Slug = "HITACHI-R-W720FPUC1X", BrandProductCategoryId =42 , Price =2959, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =60, Name = "Zanussi ZRB 36101 XA", Slug = "Zanussi-ZRB-36101-XA", BrandProductCategoryId =43 , Price =1099, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =61, Name = "Bosch GSN36AI31U", Slug = "Bosch-GSN36AI31U", BrandProductCategoryId =44 , Price =1899, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =62, Name = "BOSCH PKN811FP1E", Slug = "BOSCH-PKN811FP1E", BrandProductCategoryId =45 , Price =1309, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =63, Name = "BOSCH HMG636BS1", Slug = "BOSCH-HMG636BS1", BrandProductCategoryId =46 , Price =2829, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =64, Name = "Bosch BGS5335", Slug = "Bosch-BGS5335", BrandProductCategoryId =47 , Price =699, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =65, Name = "Bosch TDI902836A", Slug = "Bosch-TDI902836A", BrandProductCategoryId =48 , Price =259, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =66, Name = "Bosch MES4000", Slug = "Bosch-MES4000", BrandProductCategoryId =49 , Price =379, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =67, Name = "Bosch MSM67190", Slug = "Bosch-MSM67190", BrandProductCategoryId =51 , Price =269, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =68, Name = "Bosch TAT6A913", Slug = "Bosch-TAT6A913", BrandProductCategoryId =52 , Price =109, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =69, Name = "Bosch MFQ3540", Slug = "Bosch-MFQ3540", BrandProductCategoryId =53 , Price =99, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =70, Name = "Vestel SD453GR", Slug = "Vestel-SD453GR", BrandProductCategoryId =54 , Price =999, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =71, Name = "Mitsubishi SRC71ZSPR-S", Slug = "Mitsubishi-SRC71ZSPR-S", BrandProductCategoryId =55 , Price =3199, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =72, Name = "Gree GWH24AAB-K3NNA1A/O", Slug = "Gree-GWH24AAB-K3NNA1A-O", BrandProductCategoryId =56 , Price =1569, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =73, Name = "AUX ASW-H30A4/JR1", Slug = "AUX-ASW-H30A4-JR1", BrandProductCategoryId =57 , Price =2099, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =74, Name = "Gorenje PS10/21100-W7503/S1", Slug = "Gorenje-PS10-21100-W7503-S1", BrandProductCategoryId =59 , Price =819, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =75, Name = "ASUS Zenbook UX301L", Slug = "ASUS-Zenbook-UX301L", BrandProductCategoryId =60 , Price =2359, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =76, Name = "Acer Nitro 5 AN515-51-782P", Slug = "Acer-Nitro-5-AN515-51-782P", BrandProductCategoryId =61 , Price =2299, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =77, Name = "Dell Inspirion 17 5759", Slug = "Dell-Inspirion-17-5759", BrandProductCategoryId =62 , Price =2249, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =78, Name = "HP Pavilion - 15-cs0056ur", Slug = "HP-Pavilion-15-cs0056ur", BrandProductCategoryId =63 , Price =2289, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =79, Name = "HP Pavilion All-in-One 27-xa0049ur", Slug = "HP-Pavilion-All-in-One-27-xa0049ur", BrandProductCategoryId =64 , Price =2899, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =80, Name = "HP LaserJet M130 a", Slug = "HP-LaserJet-M130-a", BrandProductCategoryId =65 , Price =329, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =81, Name = "HP F24", Slug = "HP-F24", BrandProductCategoryId =66 , Price =389, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =82, Name = "Mouse HP Gaming M100", Slug = "Mouse-HP-Gaming-M100", BrandProductCategoryId =67 , Price =18, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =83, Name = "HP USB Flash Drive 16GB", Slug = "HP-USB-Flash-Drive-16GB", BrandProductCategoryId =68 , Price =30, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =84, Name = "Canon MF 633 Cdw", Slug = "Canon-MF-633-Cdw", BrandProductCategoryId =69 , Price =859, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =85, Name = "Epson M 2140", Slug = "Epson-M-2140", BrandProductCategoryId =70 , Price =499, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =86, Name = "Philips FC9735/01", Slug = "Philips-FC9735-01", BrandProductCategoryId =72 , Price =669, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =87, Name = "Philips BHD184/00", Slug = "Philips-BHD184-00", BrandProductCategoryId =73 , Price =179, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =88, Name = "Philips GC3802/27", Slug = "Philips-GC3802-27", BrandProductCategoryId =74 , Price =179, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =89, Name = "Philips HR2711/20", Slug = "Philips-HR2711-20", BrandProductCategoryId =75 , Price =289, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =90, Name = "Philips HD9342/01", Slug = "Philips-HD9342-01", BrandProductCategoryId =76 , Price =209, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =91, Name = "Philips HR1837/00", Slug = "Philips-HR1837-00", BrandProductCategoryId =77 , Price =279, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =92, Name = "Philips HR1627/00", Slug = "Philips-HR1627-00", BrandProductCategoryId =78 , Price =169, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =93, Name = "Philips HD2637/00", Slug = "Philips-HD2637-00", BrandProductCategoryId =79 , Price =139, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =94, Name = "Aiwa JH32TS700S", Slug = "Aiwa-JH32TS700S", BrandProductCategoryId =80 , Price =479, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =95, Name = "Awei Bluetooth Headset A990", Slug = "Awei-Bluetooth-Headset-A990", BrandProductCategoryId =81 , Price =50, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =96, Name = "Shivaki 43SF90G", Slug = "Shivaki-43SF90G", BrandProductCategoryId =82 , Price =589, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =97, Name = "Playstation 4 VR Bundle 3 in 1", Slug = "Playstation-4-VR-Bundle-3-in-1", BrandProductCategoryId =83 , Price =1049, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =98, Name = "Playstation 4 Fifa 2020", Slug = "Playstation-4-Fifa-2020", BrandProductCategoryId =84 , Price =149, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =99, Name = "PlayStation 4 DualShock Joystick", Slug = "PlayStation-4-DualShock-Joystick", BrandProductCategoryId =85 , Price =119, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =100, Name = "Xbox One X 1TB", Slug = "Xbox-One-X-1TB", BrandProductCategoryId =86 , Price =1119, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =101, Name = "Xbox One S/X Controller", Slug = "Xbox-One-S-X-Controller", BrandProductCategoryId =87 , Price =129, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =102, Name = "Playstation 4 Logitech G29", Slug = "Playstation-4-Logitech-G29", BrandProductCategoryId =88 , Price =849, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =103, Name = "Mouse Logitech M187", Slug = "Mouse-Logitech-M187", BrandProductCategoryId =89 , Price =10, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =104, Name = "Oculus Rift VR Bundle", Slug = "Oculus-Rift-VR-Bundle", BrandProductCategoryId =90 , Price =1239, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =105, Name = "Panasonic MC-CG715K149", Slug = "Panasonic-MC-CG715K149", BrandProductCategoryId =91 , Price =399, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =106, Name = "Panasonic KX-3722", Slug = "Panasonic-KX-3722", BrandProductCategoryId =92 , Price =199, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =107, Name = "Rowenta CV5090F0", Slug = "Rowenta-CV5090F0", BrandProductCategoryId =93 , Price =89, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =108, Name = "Tefal FV9848", Slug = "Tefal-FV9848", BrandProductCategoryId =94 , Price =229, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =109, Name = "Tefal Kiyma Makinesi", Slug = "Tefal-Kiyma-Makinesi", BrandProductCategoryId =95 , Price =449, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =110, Name = "Tefal My Tea red", Slug = "Tefal-My-Tea-red", BrandProductCategoryId =96 , Price =129, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =111, Name = "Tefal ZE550D38", Slug = "Tefal-ZE550D38", BrandProductCategoryId =97 , Price =259, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =112, Name = "Tefal Actiflow Pro Set", Slug = "Tefal-Actiflow-Pro-Set", BrandProductCategoryId =98 , Price =199, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =113, Name = "Tefal HT400B30", Slug = "Tefal-HT400B30", BrandProductCategoryId =99 , Price =79, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =114, Name = "VITEK VT-8318", Slug = "VITEK-VT-8318", BrandProductCategoryId =100 , Price =89, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =115, Name = "Braun IS7056BK", Slug = "Braun-IS7056BK", BrandProductCategoryId =101 , Price =699, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =116, Name = "Speaker Genius SP-U115", Slug = "Speaker-Genius-SP-U115", BrandProductCategoryId =103 , Price =25, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =117, Name = "Speaker Genius SP-U115", Slug = "Speaker-Genius-SP-U115", BrandProductCategoryId =104 , Price =25, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =118, Name = "JBL PARTY BOX 300", Slug = "JBL-PARTY-BOX-300", BrandProductCategoryId =105 , Price =1149, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =119, Name = "Magnet USB Remax", Slug = "Magnet-USB-Remax", BrandProductCategoryId =107 , Price =15, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =120, Name = "Remax Bluetooth Headset T6C", Slug = "Remax-Bluetooth-Headset-T6C", BrandProductCategoryId =108 , Price =55, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =121, Name = "Power Bank Remax 2600 Mah", Slug = "Power-Bank-Remax-2600-Mah", BrandProductCategoryId =109 , Price =12, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =122, Name = "Wireless Charger Rock-W3", Slug = "Wireless-Charger-Rock-W3", BrandProductCategoryId =110 , Price =75, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =123, Name = "iPhone X Baseus Weaving case", Slug = "iPhone-X-Baseus-Weaving-case", BrandProductCategoryId =111 , Price =18, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =124, Name = "Mouse A4Tech R7 Bloody", Slug = "Mouse-A4Tech-R7-Bloody", BrandProductCategoryId =112 , Price =89, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =125, Name = "SanDisk Micro 128GB 10 Class Ultra", Slug = "SanDisk-Micro-128GB-10-Class-Ultra", BrandProductCategoryId =113 , Price =99, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =126, Name = "USB Dual Driver Sandisk 32GB", Slug = "USB-Dual-Driver-Sandisk-32GB", BrandProductCategoryId =114 , Price =40, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =127, Name = "Beats S460 red", Slug = "Beats-S460-red", BrandProductCategoryId =115 , Price =35, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =128, Name = "Bluetooth Jabra Storm", Slug = "Bluetooth-Jabra-Storm", BrandProductCategoryId =116 , Price =45, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =129, Name = "Roman Bluetooth Headset X2S", Slug = "Roman-Bluetooth-Headset-X2S", BrandProductCategoryId =117 , Price =27, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =130, Name = "Power Bank Proda 10000 Mah", Slug = "Power-Bank-Proda-10000-Mah", BrandProductCategoryId =118 , Price =65, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =131, Name = "Power Bank WK 10000 Mah", Slug = "Power-Bank-WK-10000-Mah", BrandProductCategoryId =119 , Price =45, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =132, Name = "Power Bank Aspor 6000 Mah", Slug = "Power-Bank-Aspor-6000-Mah", BrandProductCategoryId =120 , Price =25, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =133, Name = "Power Bank Bilitong 10000 Mah", Slug = "Power-Bank-Bilitong-10000-Mah", BrandProductCategoryId =121 , Price =35, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =134, Name = "USB Flash Adata 64GB", Slug = "USB-Flash-Adata-64GB", BrandProductCategoryId =122 , Price =59, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =135, Name = "Roomba 980", Slug = "Roomba-980", BrandProductCategoryId =126 , Price =2400, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =136, Name = "Symbol Barkod Reader (LS 2208)", Slug = "Symbol-Barkod-Reader-LS-2208", BrandProductCategoryId =127 , Price =169, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =137, Name = "Argox Barkod Reader Z3100", Slug = "Argox-Barkod-Reader-Z3100", BrandProductCategoryId =128 , Price =99, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =138, Name = "Argox Barkod Printer OS 214 Plus", Slug = "Argox-Barkod-Printer-OS-214-Plus", BrandProductCategoryId =129 , Price =489, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =139, Name = "DataLogic Barkod Oxuyucu QW", Slug = "DataLogic-Barkod-Oxuyucu-QW", BrandProductCategoryId =130 , Price =129, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =140, Name = "ACLAS Çek Printer PP7X USB", Slug = "ACLAS-Çek-Printer-PP7X-USB", BrandProductCategoryId =131 , Price =269, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true },
                new Product { Id =141, Name = "Star Çek Printer TSP-143 U", Slug = "Star-Çek-Printer-TSP-143-U", BrandProductCategoryId =132 , Price =489, Discount = 10, DiscountDate = 5, AdminManagerId=1, CreatedAt =DateTime.Now, Status=true }
                );


            //// Product Translate
            modelBuilder.Entity<ProductTranslate>().HasData(
                new ProductTranslate {Id=1, ProductId=1, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=2, ProductId=2, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=3, ProductId=3, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=4, ProductId=4, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=5, ProductId=5, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=6, ProductId=6, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=7, ProductId=7, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=8, ProductId=8, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=9, ProductId=9, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=10, ProductId=10, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=11, ProductId=11, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=12, ProductId=12, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=13, ProductId=13, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=14, ProductId=14, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=15, ProductId=15, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=16, ProductId=16, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=17, ProductId=17, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=18, ProductId=18, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=19, ProductId=19, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=20, ProductId=20, LanguageId=1, Desc= "Pellentesque aliquet, sem eget laoreet ultrices, ipsum metus feugiat sem, quis fermentum turpis eros eget velit. Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio quis mi. Cras neque metus, consequat et blandit et, luctus a nunc. Etiam gravida vehicula tellus, in imperdiet ligula euismod eget." },
                new ProductTranslate {Id=21, ProductId=1, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=22, ProductId=2, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=23, ProductId=3, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=24, ProductId=4, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=25, ProductId=5, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=26, ProductId=6, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=27, ProductId=7, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=28, ProductId=8, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=29, ProductId=9, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=30, ProductId=10, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=31, ProductId=11, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=32, ProductId=12, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=33, ProductId=13, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=34, ProductId=14, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=35, ProductId=15, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=36, ProductId=16, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=37, ProductId=17, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=38, ProductId=18, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=39, ProductId=19, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" },
                new ProductTranslate {Id=40, ProductId=20, LanguageId=2, Desc= "Həncərsən usuf qalet çırtımına yiyə dursan? basırıx qağa nağaresan mığı, usuf qayır varıf dana təntitmə tutaşmıyın dığlatdın, murtta sortuxla a bimürvət qağa a bimürvət qayır. A qıvlasız vızqırt oynaxlanma dana eşiy əppəy beyjə əppəy sumsux, a bimürvət tutaşmıyın ciji tutaşmıyın sortuxla a qıvlasız öy dana basırıx, tova dayna eşiy ciji anarıdan-bəri qağa çırtımına yiyə dursan?. Vızqırt əppəy a bimürvət murtta ağrın alem çırtımına yiyə dursan? sumsux, bıy dərdin alem varıf mığı varıf nağarersan? öy ağrın alem, ciji dığlatdın sortuxla göy" }
                );
        }
    }
}
