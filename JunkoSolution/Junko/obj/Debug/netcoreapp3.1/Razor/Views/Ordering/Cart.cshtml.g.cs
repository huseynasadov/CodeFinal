#pragma checksum "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Ordering\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4c17442886d369576262d874b93007c7f86f5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordering_Cart), @"mvc.1.0.view", @"/Views/Ordering/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4c17442886d369576262d874b93007c7f86f5b", @"/Views/Ordering/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5144a00927b5e0f3184bbe62a224a706f7c8e3bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Ordering_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images//s-product/product.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images//s-product/product2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images//s-product/product3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Huseyn\Desktop\CodeFinal\JunkoSolution\Junko\Views\Ordering\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

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
                        <li>Shopping Cart</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--breadcrumbs area end-->
<!--Main Start-->
<main>

    <!--shopping cart area start -->
    <div class=""shopping_cart_area mt-60"">
        <div class=""container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4c17442886d369576262d874b93007c7f86f5b6044", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""table_desc"">
                            <div class=""cart_page table-responsive"">
                                <table>
                                    <thead>
                                        <tr>
                                            <th class=""product_remove"">Delete</th>
                                            <th class=""product_thumb"">Image</th>
                                            <th class=""product_name"">Product</th>
                                            <th class=""product-price"">Price</th>
                                            <th class=""product_quantity"">Quantity</th>
                                            <th class=""product_total"">Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
        ");
                WriteLiteral(@"                                    <td class=""product_remove"">
                                                <a href=""#""><i class=""fa fa-trash-o""></i></a>
                                            </td>
                                            <td class=""product_thumb"">
                                                <a href=""#"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d4c17442886d369576262d874b93007c7f86f5b7786", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </a>
                                            </td>
                                            <td class=""product_name""><a href=""#"">Handbag fringilla</a></td>
                                            <td class=""product-price"">£65.00</td>
                                            <td class=""product_quantity"">
                                                <label>Quantity</label> <input min=""1""
                                                                               max=""100"" value=""1"" type=""number"">
                                            </td>
                                            <td class=""product_total"">£130.00</td>
                                        </tr>
                                        <tr>
                                            <td class=""product_remove"">
                                                <a href=""#""><i class=""fa fa-trash-o""></i></a>
                                            </td>
");
                WriteLiteral("                                            <td class=\"product_thumb\">\r\n                                                <a href=\"#\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d4c17442886d369576262d874b93007c7f86f5b10234", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </a>
                                            </td>
                                            <td class=""product_name""><a href=""#"">Handbags justo</a></td>
                                            <td class=""product-price"">£90.00</td>
                                            <td class=""product_quantity"">
                                                <label>Quantity</label> <input min=""1""
                                                                               max=""100"" value=""1"" type=""number"">
                                            </td>
                                            <td class=""product_total"">£180.00</td>


                                        </tr>
                                        <tr>
                                            <td class=""product_remove"">
                                                <a href=""#""><i class=""fa fa-trash-o""></i></a>
                                            </td>");
                WriteLiteral("\n                                            <td class=\"product_thumb\">\r\n                                                <a href=\"#\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d4c17442886d369576262d874b93007c7f86f5b12685", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </a>
                                            </td>
                                            <td class=""product_name""><a href=""#"">Handbag elit</a></td>
                                            <td class=""product-price"">£80.00</td>
                                            <td class=""product_quantity"">
                                                <label>Quantity</label> <input min=""1""
                                                                               max=""100"" value=""1"" type=""number"">
                                            </td>
                                            <td class=""product_total"">£160.00</td>


                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                            <div class=""cart_submit"">
                                <button type=""submit"">update cart</button>
         ");
                WriteLiteral(@"                   </div>
                        </div>
                    </div>
                </div>
                <!--coupon code area start-->
                <div class=""coupon_area"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-md-6"">
                            <div class=""coupon_code left"">
                                <h3>Coupon</h3>
                                <div class=""coupon_inner"">
                                    <p>Enter your coupon code if you have one.</p>
                                    <input placeholder=""Coupon code"" type=""text"">
                                    <button type=""submit"">Apply coupon</button>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-6 col-md-6"">
                            <div class=""coupon_code right"">
                                <h3>Cart Totals</h3>
                              ");
                WriteLiteral(@"  <div class=""coupon_inner"">
                                    <div class=""cart_subtotal"">
                                        <p>Subtotal</p>
                                        <p class=""cart_amount"">£215.00</p>
                                    </div>
                                    <div class=""cart_subtotal "">
                                        <p>Shipping</p>
                                        <p class=""cart_amount""><span>Flat Rate:</span> £255.00</p>
                                    </div>
                                    <a href=""#"">Calculate shipping</a>

                                    <div class=""cart_subtotal"">
                                        <p>Total</p>
                                        <p class=""cart_amount"">£215.00</p>
                                    </div>
                                    <div class=""checkout_btn"">
                                        <a href=""#"">Proceed to Checkout</a>
                               ");
                WriteLiteral("     </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!--coupon code area end-->\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!--shopping cart area end -->\r\n</main>\r\n<!--Main End-->\r\n");
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
