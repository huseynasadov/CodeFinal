#pragma checksum "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19575178c5d40838b24f0f0f76062afe425065c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Account), @"mvc.1.0.view", @"/Views/Login/Account.cshtml")]
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
#line 1 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19575178c5d40838b24f0f0f76062afe425065c9", @"/Views/Login/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce0bfaa4b60413cd42f3d5b8bb79b5b0da005ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
  
    ViewData["Title"] = _localizer["Account"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_Breadcrumb.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Main Start-->
<main>
    <!-- my account start  -->
    <section class=""main_content_area"">
        <div class=""container"">
            <div class=""account_dashboard"">
                <div class=""row"">
                    <div class=""col-sm-12 col-md-3 col-lg-3"">
                        <!-- Nav tabs -->
                        <div class=""dashboard_tab_button"">
                            <ul role=""tablist"" class=""nav flex-column dashboard-list"">
                                <li>
                                    <a href=""#dashboard"" data-toggle=""tab"" class=""nav-link active"">");
#nullable restore
#line 20 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                                              Write(_localizer["Dashboard"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n                                <li> <a href=\"#orders\" data-toggle=\"tab\" class=\"nav-link\">");
#nullable restore
#line 22 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                                     Write(_localizer["Orders"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"#address\" data-toggle=\"tab\" class=\"nav-link\">");
#nullable restore
#line 23 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                                     Write(_localizer["Addresses"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li>\r\n                                    <a href=\"#account-details\" data-toggle=\"tab\" class=\"nav-link\">\r\n                                        ");
#nullable restore
#line 26 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                   Write(_localizer["Account Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n                                <li><a href=\"login.html\" class=\"nav-link\">");
#nullable restore
#line 29 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                     Write(_localizer["Logout"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-md-9 col-lg-9"">
                        <!-- Tab panes -->
                        <div class=""tab-content dashboard_content"">
                            <div class=""tab-pane fade show active"" id=""dashboard"">
                                <h3>");
#nullable restore
#line 37 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                               Write(_localizer["Dashboard"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                               Write(_localizer["From your account dashboard. you can easily check and view your recent orders manage your shipping and and Edit your password and account details."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""tab-pane fade"" id=""orders"">
                                <h3>Orders</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>");
#nullable restore
#line 48 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                               Write(_localizer["Order"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 49 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                               Write(_localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 50 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                               Write(_localizer["Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 51 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                               Write(_localizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th>");
#nullable restore
#line 52 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                               Write(_localizer["Actions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>May 10, 2018</td>
                                                <td><span class=""success"">");
#nullable restore
#line 59 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                     Write(_localizer["Completed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                                <td>$25.00 for 1 item </td>\r\n                                                <td><a href=\"cart.html\" class=\"view\">");
#nullable restore
#line 61 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                                Write(_localizer["View"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></td>
                                            </tr>
                                            <tr>
                                                <td>2</td>
                                                <td>May 10, 2018</td>
                                                <td>");
#nullable restore
#line 66 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                               Write(_localizer["Processing"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>$17.00 for 1 item </td>\r\n                                                <td><a href=\"cart.html\" class=\"view\">");
#nullable restore
#line 68 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                                Write(_localizer["View"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <h4 class=""billing-address"">");
#nullable restore
#line 76 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                       Write(_localizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                <a href=""#"" class=""view"">Edit</a>
                                <p><strong>Bobby Jackson</strong></p>
                                <address>
                                    House #15<br>
                                    Road #1<br>
                                    Block #C <br>
                                    Banasree <br>
                                    Dhaka <br>
                                    1212
                                </address>
                                <p>Bangladesh</p>
                            </div>
                            <div class=""tab-pane fade"" id=""account-details"">
                                <h3>");
#nullable restore
#line 90 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                               Write(_localizer["Account Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <div class=\"login\">\r\n                                    <div class=\"login_form_container\">\r\n                                        <div class=\"account_login_form\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19575178c5d40838b24f0f0f76062afe425065c914648", async() => {
                WriteLiteral(@"
                                                <p>Already have an account? <a href=""#"">Log in instead!</a></p>
                                                <div class=""input-radio"">
                                                    <span class=""custom-radio"">
                                                        <input type=""radio"" value=""1""
                                                               name=""id_gender""> ");
#nullable restore
#line 99 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                            Write(_localizer["Mr"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@".
                                                        </span>
                                                        <span class=""custom-radio"">
                                                            <input type=""radio"" value=""1""
                                                                   name=""id_gender""> ");
#nullable restore
#line 103 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                                Write(_localizer["Mrs"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@".
                                                            </span>
                                                        </div> <br>
                                                        <label>First Name</label>
                                                        <input type=""text"" name=""first-name"">
                                                        <label>Last Name</label>
                                                        <input type=""text"" name=""last-name"">
                                                        <label>Email</label>
                                                        <input type=""text"" name=""email-name"">
                                                        <label>Password</label>
                                                        <input type=""password"" name=""user-password"">
                                                        <label>Birthdate</label>
                                                        <input type=""text"" placeholder=""MM/");
                WriteLiteral("DD/YYYY\"");
                BeginWriteAttribute("value", " value=\"", 7468, "\"", 7476, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                                               name=""birthday"">
                                                        <span class=""example"">
                                                            (E.g.: 05/31/1970)
                                                        </span>
                                                        <br>
                                                        <span class=""custom_checkbox"">
                                                            <input type=""checkbox"" value=""1"" name=""newsletter"">
                                                            <label>
                                                                ");
#nullable restore
#line 124 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                           Write(_localizer["Sign up for our newsletter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br><em>\r\n                                                                    ");
#nullable restore
#line 125 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                               Write(_localizer["You may unsubscribe at any moment. For that purpose, please find our info in the legal notice."]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </em>
                                                        </label>
                                                    </span>
                                                    <div class=""save_button primary_btn default_button"">
                                                        <button type=""submit"">");
#nullable restore
#line 130 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
                                                                         Write(_localizer["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                                    </div>\r\n                                                ");
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
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- my account end   -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
