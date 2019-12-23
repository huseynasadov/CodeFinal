﻿// <auto-generated />
using System;
using Junko.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Junko.Migrations
{
    [DbContext(typeof(JunkoDBContext))]
    [Migration("20191223123544_SocialLinkTable")]
    partial class SocialLinkTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Junko.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LanguageCode = "en-US",
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            LanguageCode = "az-Latn-AZ",
                            Name = "Azerbaijan"
                        });
                });

            modelBuilder.Entity("Junko.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PhotoLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Setting");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Junko@mail.com",
                            Location = "Code Academy",
                            Logo = "Junko",
                            ModifiedAt = new DateTime(2019, 12, 23, 16, 35, 44, 53, DateTimeKind.Local).AddTicks(3184),
                            Phone = "+994 50 787 01 81",
                            PhotoLogo = "logo/logo.png"
                        });
                });

            modelBuilder.Entity("Junko.Models.SettingTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("FAQContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FAQTitle")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("SettingId");

                    b.ToTable("SettingTranslates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = " Nizami street 203B, AF Business House",
                            FAQContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec id erat sagittis, faucibus metus malesuada, eleifend turpis. Mauris semper augue id nisl aliquet, a porta lectus mattis. Nulla at tortor augue. In eget enim diam. Donec gravida tortor sem, ac fermentum nibh rutrum sit amet. Nulla convallis mauris vitae congue consequat. Donec interdum nunc purus, vitae vulputate arcu fringilla quis. Vivamus iaculis euismod dui.",
                            FAQTitle = "Below are frequently asked questions, you may find the answer for yourself",
                            LanguageId = 1,
                            ModifiedAt = new DateTime(2019, 12, 23, 16, 35, 44, 55, DateTimeKind.Local).AddTicks(635),
                            SettingId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = " Nizami küç. 203B, AF Business House, 2-ci mərtəbə",
                            FAQContent = "",
                            FAQTitle = "Aşağıda tez-tez verilən suallarla özünüz üçün cavab tapa bilərsiniz",
                            LanguageId = 2,
                            ModifiedAt = new DateTime(2019, 12, 23, 16, 35, 44, 55, DateTimeKind.Local).AddTicks(748),
                            SettingId = 1
                        });
                });

            modelBuilder.Entity("Junko.Models.SocialActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.ToTable("SocialActivities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Link = "https://www.facebook.com/",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "facebook",
                            SettingId = 1
                        },
                        new
                        {
                            Id = 2,
                            Link = "https://twitter.com/?lang=en",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "twitter",
                            SettingId = 1
                        },
                        new
                        {
                            Id = 3,
                            Link = "https://www.instagram.com/",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "instagram",
                            SettingId = 1
                        },
                        new
                        {
                            Id = 4,
                            Link = "https://www.linkedin.com/feed/",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "linkendin",
                            SettingId = 1
                        },
                        new
                        {
                            Id = 5,
                            Link = "https://www.google.com",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "google",
                            SettingId = 1
                        });
                });

            modelBuilder.Entity("Junko.Models.SettingTranslate", b =>
                {
                    b.HasOne("Junko.Models.Language", "Language")
                        .WithMany("SettingTranslates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Junko.Models.Setting", "Setting")
                        .WithMany("SettingTranslates")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Junko.Models.SocialActivity", b =>
                {
                    b.HasOne("Junko.Models.Setting", "Setting")
                        .WithMany("SocialActivities")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
