#pragma checksum "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa316c3c9ed28ad8ea9393fd4a0701bac8fcc96"
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
using Junko.Data.Entries;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa316c3c9ed28ad8ea9393fd4a0701bac8fcc96", @"/Views/Login/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3486063a9f3db427679abb1248bb55d849aebc76", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Login\Account.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--breadcrumbs area start-->
<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""index.html"">home</a></li>
                        <li>My Account</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--breadcrumbs area end-->
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
                                    <a href");
            WriteLiteral(@"=""#dashboard"" data-toggle=""tab"" class=""nav-link active"">Dashboard</a>
                                </li>
                                <li> <a href=""#orders"" data-toggle=""tab"" class=""nav-link"">Orders</a></li>
                                <li><a href=""#downloads"" data-toggle=""tab"" class=""nav-link"">Downloads</a></li>
                                <li><a href=""#address"" data-toggle=""tab"" class=""nav-link"">Addresses</a></li>
                                <li>
                                    <a href=""#account-details"" data-toggle=""tab"" class=""nav-link"">
                                        Account
                                        details
                                    </a>
                                </li>
                                <li><a href=""login.html"" class=""nav-link"">logout</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-md-9 col-lg-9"">
                   ");
            WriteLiteral(@"     <!-- Tab panes -->
                        <div class=""tab-content dashboard_content"">
                            <div class=""tab-pane fade show active"" id=""dashboard"">
                                <h3>Dashboard </h3>
                                <p>
                                    From your account dashboard. you can easily check &amp; view your <a href=""#"">recent orders</a>, manage your <a href=""#"">
                                        shipping and billing
                                        addresses
                                    </a> and <a href=""#"">Edit your password and account details.</a>
                                </p>
                            </div>
                            <div class=""tab-pane fade"" id=""orders"">
                                <h3>Orders</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                  ");
            WriteLiteral(@"                          <tr>
                                                <th>Order</th>
                                                <th>Date</th>
                                                <th>Status</th>
                                                <th>Total</th>
                                                <th>Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>May 10, 2018</td>
                                                <td><span class=""success"">Completed</span></td>
                                                <td>$25.00 for 1 item </td>
                                                <td><a href=""cart.html"" class=""view"">view</a></td>
                                            </tr>
              ");
            WriteLiteral(@"                              <tr>
                                                <td>2</td>
                                                <td>May 10, 2018</td>
                                                <td>Processing</td>
                                                <td>$17.00 for 1 item </td>
                                                <td><a href=""cart.html"" class=""view"">view</a></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""downloads"">
                                <h3>Downloads</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                          ");
            WriteLiteral(@"      <th>Product</th>
                                                <th>Downloads</th>
                                                <th>Expires</th>
                                                <th>Download</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Shopnovilla - Free Real Estate PSD Template</td>
                                                <td>May 10, 2018</td>
                                                <td><span class=""danger"">Expired</span></td>
                                                <td>
                                                    <a href=""#"" class=""view"">Click Here To Download Your File</a>
                                                </td>
                                            </tr>
                                            <tr>
       ");
            WriteLiteral(@"                                         <td>Organic - ecommerce html template</td>
                                                <td>Sep 11, 2018</td>
                                                <td>Never</td>
                                                <td>
                                                    <a href=""#"" class=""view"">Click Here To Download Your File</a>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <h4 class=""billing-address"">Billing address</h4>
                                <a href=""#"" class=""view"">Edit</a>
                                <");
            WriteLiteral(@"p><strong>Bobby Jackson</strong></p>
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
                                <h3>Account details </h3>
                                <div class=""login"">
                                    <div class=""login_form_container"">
                                        <div class=""account_login_form"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aa316c3c9ed28ad8ea9393fd4a0701bac8fcc9612386", async() => {
                WriteLiteral(@"
                                                <p>Already have an account? <a href=""#"">Log in instead!</a></p>
                                                <div class=""input-radio"">
                                                    <span class=""custom-radio"">
                                                        <input type=""radio"" value=""1""
                                                               name=""id_gender""> Mr.
                                                    </span>
                                                    <span class=""custom-radio"">
                                                        <input type=""radio"" value=""1""
                                                               name=""id_gender""> Mrs.
                                                    </span>
                                                </div> <br>
                                                <label>First Name</label>
                                                <input type=""text"" ");
                WriteLiteral(@"name=""first-name"">
                                                <label>Last Name</label>
                                                <input type=""text"" name=""last-name"">
                                                <label>Email</label>
                                                <input type=""text"" name=""email-name"">
                                                <label>Password</label>
                                                <input type=""password"" name=""user-password"">
                                                <label>Birthdate</label>
                                                <input type=""text"" placeholder=""MM/DD/YYYY""");
                BeginWriteAttribute("value", " value=\"", 9807, "\"", 9815, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                                       name=""birthday"">
                                                <span class=""example"">
                                                    (E.g.: 05/31/1970)
                                                </span>
                                                <br>
                                                <span class=""custom_checkbox"">
                                                    <input type=""checkbox"" value=""1"" name=""optin"">
                                                    <label>Receive offers from our partners</label>
                                                </span>
                                                <br>
                                                <span class=""custom_checkbox"">
                                                    <input type=""checkbox"" value=""1"" name=""newsletter"">
                                                    <label>
                                                        ");
                WriteLiteral(@"Sign up for our newsletter<br><em>
                                                            You may unsubscribe at
                                                            any moment. For that purpose, please find our contact
                                                            info in the legal notice.
                                                        </em>
                                                    </label>
                                                </span>
                                                <div class=""save_button primary_btn default_button"">
                                                    <button type=""submit"">Save</button>
                                                </div>
                                            ");
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
