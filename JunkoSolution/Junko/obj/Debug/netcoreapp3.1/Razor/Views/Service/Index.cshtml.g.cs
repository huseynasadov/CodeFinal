#pragma checksum "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38521ddfe76dd61237ac1ea556f4e0f02203f3a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\_ViewImports.cshtml"
using Junko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\_ViewImports.cshtml"
using Junko.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\_ViewImports.cshtml"
using Junko.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38521ddfe76dd61237ac1ea556f4e0f02203f3a6", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce0bfaa4b60413cd42f3d5b8bb79b5b0da005ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/service/services4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
  
    ViewData["Title"] = _localizer["Services"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--breadcrumbs area start-->\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_Breadcrumb.cshtml",model:Model.Breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--breadcrumbs area end-->\r\n<!--Main Start-->\r\n<main>\r\n    <!--services img area-->\r\n    <div class=\"services_gallery mt-60\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                 foreach (var ser in Model.ServicesCoverTranslates)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6\">\r\n                        <div class=\"single_services\">\r\n                            <div class=\"services_thumb\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38521ddfe76dd61237ac1ea556f4e0f02203f3a65588", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 764, "~/images/", 764, 9, true);
#nullable restore
#line 23 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
AddHtmlAttributeValue("", 773, ser.ServicesCover.Photo, 773, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"services_content\">\r\n                                <h3>");
#nullable restore
#line 26 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                               Write(ser.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>\r\n                                   ");
#nullable restore
#line 28 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                              Write(ser.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!--services img end-->
    <!--our services area-->
    <div class=""our_services"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""services_title"">
                        <h2>");
#nullable restore
#line 45 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                       Write(_localizer["OUR SERVICES"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 50 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                 foreach (var ser in Model.OurServiceTranslates)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6\">\r\n                        <div class=\"services_item\">\r\n                            <div class=\"services_icone\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 1934, "\"", 1962, 1);
#nullable restore
#line 55 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
WriteAttributeValue("", 1942, ser.OurService.Icon, 1942, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i>\r\n                            </div>\r\n                            <div class=\"services_desc\">\r\n                                <h3>");
#nullable restore
#line 58 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                               Write(ser.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 60 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                               Write(ser.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 65 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!--our services area end-->
    <!--services section area-->
    <div class=""unlimited_services"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-6 col-md-12"">
                    <div class=""services_section_thumb"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38521ddfe76dd61237ac1ea556f4e0f02203f3a611456", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-6 col-md-12"">
                    <div class=""unlimited_services_content"">
                        <h1>UNLIMITED IDEAS</h1>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Laudantium, suscipit dolorum
                            ullam soluta voluptatem quasi molestias illum possimus, accusantium assumenda inventore
                            debitis ducimus. Quis ducimus, consequatur corrupti, sunt rerum sit atque eum inventore.
                            Autem excepturi reiciendis voluptate totam sit, sunt fugiat voluptatum beatae voluptas
                            ab quia vitae accusamus assumenda facilis perferendis, quam itaque aliquid qui omnis
                            culpa consectetur placeat ipsa quaerat inventore quasi. Eligendi.
                        </p>
                        <div class=""view__work"">
                       ");
            WriteLiteral("     <a href=\"#\">");
#nullable restore
#line 91 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                                   Write(_localizer["MORE INFO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-angle-right""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--services section end-->
    <!--price table area -->
    <div class=""priceing_table"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6"">
                    <div class=""single_priceing"">
                        <div class=""priceing_title"">
                            <h1>Standard</h1>
                        </div>
                        <div class=""priceing_list"">
                            <h1><span>£19</span>/Month</h1>
                            <ul>
                                <li>2 GB Webspace</li>
                                <li>1 Domain</li>
                                <li>PHP 5 Enbled</li>
                                <li>24H – Support</li>
                            </ul>
                            <a href=""#"">");
#nullable restore
#line 116 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Service\Index.cshtml"
                                   Write(_localizer["purchase now"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""single_priceing"">
                        <div class=""priceing_title"">
                            <h1>Returns</h1>
                        </div>
                        <div class=""priceing_list"">
                            <h1><span>£23</span>/Month</h1>
                            <ul>
                                <li>2 GB Webspace</li>
                                <li>1 Domain</li>
                                <li>PHP 5 Enbled</li>
                                <li>24H – Support</li>
                            </ul>
                            <a class=""list_button"" href=""#"">purchase now </a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""single_priceing"">
                        <div class=""p");
            WriteLiteral(@"riceing_title"">
                            <h1>Affiliate</h1>
                        </div>
                        <div class=""priceing_list"">
                            <h1><span>£20</span>/Month</h1>
                            <ul>
                                <li>2 GB Webspace</li>
                                <li>1 Domain</li>
                                <li>PHP 5 Enbled</li>
                                <li>24H – Support</li>
                            </ul>
                            <a href=""#"">purchase now </a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""single_priceing"">
                        <div class=""priceing_title"">
                            <h1>Specials</h1>
                        </div>
                        <div class=""priceing_list"">
                            <h1><span>£25</span>/Month</h1>
                            <ul>
  ");
            WriteLiteral(@"                              <li>2 GB Webspace</li>
                                <li>1 Domain</li>
                                <li>PHP 5 Enbled</li>
                                <li>24H – Support</li>
                            </ul>
                            <a class=""list_button"" href=""#"">purchase now </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--price table  end-->
</main>
<!--Main End-->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer _localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
