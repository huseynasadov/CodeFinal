using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Junko.Migrations
{
    public partial class changeServiceOrderSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ServicesCovers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "OurServices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "BlogTranslates",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 919, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Blog-Image-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Post-With-Gallery" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Maecenas-Ultricies" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Post-with-audio" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "preasent-imperdiet" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "gallery-post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Ultricies-Maecenas" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Audio-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Image-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Other-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Sticy-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Travel-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Blog-with-Travel" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Wordpress-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><blockquote><p>Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</p></blockquote><p>Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "Company-Post" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "xabar-sakil-paylasimi" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "qalaraya-paylasimi" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "texniki-paylasim" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "elektronika" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "yeni-robotlar" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "yeni-iphone-11" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "seyahet-paylasimi" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "sirketler" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "yeni-trendler" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "diger-paylasim" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "robot-istehsali" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "avadanliqlar" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "aksesuarlar" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "yeni-tozsoram" });

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "Slug" },
                values: new object[] { "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</p><p>Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</p></div> ", "yeni-paylasim" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(6818), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8852), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8885), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8889), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8893), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8896), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8900), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8905), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8908), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8912), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8917), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8921), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8925), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8928), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8932), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(714), new DateTime(2019, 12, 25, 11, 38, 4, 919, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2104), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2125), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2130), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2134), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2138), new DateTime(2019, 12, 25, 11, 38, 4, 920, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(6126), 1 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8036), 2 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8095), 3 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8099), 4 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8102), 5 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8104), 6 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8107), 7 });

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(8110), 8 });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 921, DateTimeKind.Local).AddTicks(8106), 1 });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(823), 2 });

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedAt", "Order" },
                values: new object[] { new DateTime(2019, 12, 25, 11, 38, 4, 922, DateTimeKind.Local).AddTicks(862), 3 });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 916, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 918, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "SettingTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 38, 4, 918, DateTimeKind.Local).AddTicks(1523));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "ServicesCovers");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "BlogTranslates");

            migrationBuilder.UpdateData(
                table: "AdminManagers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 659, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 7,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 9,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 10,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 11,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 12,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 13,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 14,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 15,
                column: "Content",
                value: "<p>Aenean et tempor eros,vitae sollicitudin velit.Etiam varius enim nec quam tempor sed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < blockquote < p Quisque semper nunc vitae erat pellentesqueac placerat consectetur.In venenatis elit ac ultrices convallis.Duis est nisitincidunt ac urna sedcursus blandit lectus.In ullamcorper amet ligula ut eleifend.Proin dictum tempor ligulaac metus.Sed finibus tortor eu scelerisque scelerisque</ p </ blockquote < p Aenean et tempor erosvitae sollicitudin velit.Etiam varius enim quam temporsed efficitur ex ultrices.Phasellus pretium est vel vestibulum condimentum.Aenean nec suscipit nibh.Phasellus nec lacus arcu facilisis elementum.Curabitur lobortiselit ut elementum congueerat ex bibendum odionec iaculis lacus sem non lorem.Duis metus antesed convallis quam posuere quis.Ut tincidunt eleifend odioac fringilla mi vehicula nec.Nunc vitae lacus eget lectus tempus sed in dui.Nam molestie magna at risus suscipit justo dignissim.Sed vitae fringilla enimnec arcu</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 17,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 18,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 19,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 20,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 21,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 23,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 24,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 25,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 26,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 27,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 28,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 29,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 30,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 31,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

            migrationBuilder.UpdateData(
                table: "BlogTranslates",
                keyColumn: "Id",
                keyValue: 32,
                column: "Content",
                value: "<p>Bəzi orqanları 90 sarı tramvay və ya sarı metro adlı mətn yayılan həssas content daha müasir bir görünüş vermək üçün Lorem Ipsum dəyişin. Fransız və ya İngilis dili idi, lakin bir çox insanlar, istədiyiniz təsiri nail olunmayıb mətn oxumaq üçün axtarırdılar. Distractions səbəb ola bilər istiqamətləri olan, oxunaqlı mətn İş və bu layout diqqət kömək edə bilər.</ p < p Suspendisse turpis ipsumtempus in nulla euposuere pharetra nibh.dignissim vitae lorem non mollis.Praesent pretium tellus in viverra condimentum.Nullam dignissim facilisis nislaccumsan justo ultricies vel.Vivamus finibus mi a neque pretiumut dui lacinia.Morbi a rutrum velit.Curabitur sagittis quam consectetur mattis.Aenean sit amet quam vel turpis interdum sagittis eget neque.Nunc ante quamluctus et neque ainterdum iaculis metusAliquam vel ante mattisplacerat orci idvehicula quam.quis eros cursusviverra urna sedcommodo mauris.Cras diam arcufringilla a sem condimentumviverra facilisis nunc.Curabitur orci id nulla maximus maximus.Nunc pulvinar sollicitudin molestie</ p </ div > ");

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

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "OurServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 662, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 661, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 661, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ServicesCovers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2019, 12, 25, 11, 15, 57, 661, DateTimeKind.Local).AddTicks(5899));

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
        }
    }
}
