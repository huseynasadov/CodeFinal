#pragma checksum "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f911fb612c35889b2769153deec82be72f62e459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\_ViewImports.cshtml"
using Junko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\_ViewImports.cshtml"
using Junko.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\_ViewImports.cshtml"
using Junko.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f911fb612c35889b2769153deec82be72f62e459", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647784e740503e2fb74681806ace87bccba35145", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
  
    ViewData["Title"] = _localizer["Login"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--breadcrumbs area start-->\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_Breadcrumb.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--breadcrumbs area end-->
<!--Main Start-->
<main>

    <!-- customer login start -->
    <div class=""customer_login mt-60"">
        <div class=""container"">
            <div class=""row"">
                <!--login area start-->
                <div class=""col-lg-6 col-md-6"">
                    <div class=""account_form"">
                        <h2>");
#nullable restore
#line 21 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
                       Write(_localizer["Login"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f911fb612c35889b2769153deec82be72f62e4595096", async() => {
                WriteLiteral(@"
                            <p>
                                <label>Username or email <span>*</span></label>
                                <input type=""text"">
                            </p>
                            <p>
                                <label>Passwords <span>*</span></label>
                                <input type=""password"">
                            </p>
                            <div class=""login_submit"">
                                <a href=""#"">");
#nullable restore
#line 32 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
                                       Write(_localizer["Lost your password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("?</a>\r\n                                <label for=\"remember\">\r\n                                    <input id=\"remember\" type=\"checkbox\">\r\n                                    ");
#nullable restore
#line 35 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
                               Write(_localizer["Remember me"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <button type=\"submit\">");
#nullable restore
#line 37 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
                                                 Write(_localizer["Login"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\r\n                            </div>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                <!--login area start-->
                <!--register area start-->
                <div class=""col-lg-6 col-md-6"">
                    <div class=""account_form register"">
                        <h2>");
#nullable restore
#line 48 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
                       Write(_localizer["Register"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f911fb612c35889b2769153deec82be72f62e4598651", async() => {
                WriteLiteral(@"
                            <p>
                                <label>Email address  <span>*</span></label>
                                <input type=""text"">
                            </p>
                            <p>
                                <label>Passwords <span>*</span></label>
                                <input type=""password"">
                            </p>
                            <div class=""login_submit"">
                                <button type=""submit"">");
#nullable restore
#line 59 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Index.cshtml"
                                                 Write(_localizer["Register"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!--register area end-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- customer login end -->\r\n</main>\r\n<!--Main End-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
