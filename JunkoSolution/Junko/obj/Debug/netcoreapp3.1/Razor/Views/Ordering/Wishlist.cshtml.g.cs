#pragma checksum "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f2e5e8a1b8f18919a1c4b326803b50624f0cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordering_Wishlist), @"mvc.1.0.view", @"/Views/Ordering/Wishlist.cshtml")]
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
#line 2 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f2e5e8a1b8f18919a1c4b326803b50624f0cd0", @"/Views/Ordering/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce0bfaa4b60413cd42f3d5b8bb79b5b0da005ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Ordering_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ordering", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addToCart btn btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "clearWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-warning btn "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Junko.Helpers.PriceTagHelper __Junko_Helpers_PriceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
  
    ViewData["Title"] = "Wishlist";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--breadcrumbs area start-->\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_Breadcrumb.cshtml", model: Model.Breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--breadcrumbs area end-->\r\n<!--Main Start-->\r\n<main>\r\n\r\n    <!--wishlist area start -->\r\n    <div class=\"wishlist_area mt-60\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 18 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
             if (Model.CartItems.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd07445", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""table_desc"">
                                <div class=""cart_page table-responsive"">
                                    <table>
                                        <thead>
                                            <tr>
                                                <th class=""product_remove"">");
#nullable restore
#line 28 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                      Write(_localizer["Delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                                <th class=\"product_thumb\">");
#nullable restore
#line 29 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                     Write(_localizer["Image"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                                <th class=\"product_name\">");
#nullable restore
#line 30 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                    Write(_localizer["Product"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                                <th class=\"product-price\">");
#nullable restore
#line 31 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                     Write(_localizer["Price"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                                <th class=\"product_quantity\">");
#nullable restore
#line 32 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                        Write(_localizer["Quantity"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                                <th class=\"product_total\">");
#nullable restore
#line 33 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                     Write(_localizer["Add to Cart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                             foreach (var item in Model.CartItems)
                                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td class=\"product_remove\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd011209", async() => {
                    WriteLiteral("<i class=\"fa fa-trash-o\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                                                                   WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </td>
                                                    <td class=""product_thumb"">
                                                        <a href=""#"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd014073", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2375, "~/images/", 2375, 9, true);
#nullable restore
#line 46 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
AddHtmlAttributeValue("", 2384, item.Image, 2384, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
AddHtmlAttributeValue("", 2402, item.ProductName, 2402, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        </a>\r\n                                                    </td>\r\n                                                    <td class=\"product_name\"><a href=\"#\">");
#nullable restore
#line 49 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                                    Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                    <td class=\"product-price\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("price", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd016839", async() => {
                }
                );
                __Junko_Helpers_PriceTagHelper = CreateTagHelper<global::Junko.Helpers.PriceTagHelper>();
                __tagHelperExecutionContext.Add(__Junko_Helpers_PriceTagHelper);
#nullable restore
#line 51 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
__Junko_Helpers_PriceTagHelper.Price = item.Price;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("price", __Junko_Helpers_PriceTagHelper.Price, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
__Junko_Helpers_PriceTagHelper.DiscountPrice = 0;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("discount-price", __Junko_Helpers_PriceTagHelper.DiscountPrice, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
__Junko_Helpers_PriceTagHelper.LanguageId = Model.LanguageId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("language-id", __Junko_Helpers_PriceTagHelper.LanguageId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"product_quantity\">\r\n                                                        ");
#nullable restore
#line 54 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"product_total\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd019788", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                                                                                                                                                                                        Write(_localizer["Add to cart"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                                                                                                                                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
AddHtmlAttributeValue("", 3446, _localizer["Add to cart"], 3446, 26, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                                <div class=\"cart_submit\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd024727", async() => {
#nullable restore
#line 66 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                                                                                Write(_localizer["Clear Cart"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                    <!--coupon code area start-->
                    <div class=""coupon_area"">
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""coupon_code right"">
                                    <h3>");
#nullable restore
#line 76 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                   Write(_localizer["Cart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 76 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                                       Write(_localizer["Total"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <div class=\"coupon_inner\">\r\n                                        <div class=\"cart_subtotal\">\r\n                                            <p>");
#nullable restore
#line 79 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                          Write(_localizer["Total"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            <p class=\"cart_amount\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("price", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f2e5e8a1b8f18919a1c4b326803b50624f0cd028189", async() => {
                }
                );
                __Junko_Helpers_PriceTagHelper = CreateTagHelper<global::Junko.Helpers.PriceTagHelper>();
                __tagHelperExecutionContext.Add(__Junko_Helpers_PriceTagHelper);
#nullable restore
#line 81 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
__Junko_Helpers_PriceTagHelper.Price = Model.GrandTotal;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("price", __Junko_Helpers_PriceTagHelper.Price, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 81 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
__Junko_Helpers_PriceTagHelper.DiscountPrice = 0;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("discount-price", __Junko_Helpers_PriceTagHelper.DiscountPrice, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 81 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
__Junko_Helpers_PriceTagHelper.LanguageId = Model.LanguageId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("language-id", __Junko_Helpers_PriceTagHelper.LanguageId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--coupon code area end-->
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"display-4 text-center\">");
#nullable restore
#line 94 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
                                             Write(_localizer["Your Cart Is Empty"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n");
#nullable restore
#line 95 "C:\Users\Huseyn\Desktop\Code Academy\Final\CodeFinal\JunkoSolution\Junko\Views\Ordering\Wishlist.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-12"">
                    <div class=""wishlist_share"">
                        <h4>Share on:</h4>
                        <ul>
                            <li><a href=""#""><i class=""fa fa-rss""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-tumblr""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-pinterest""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <!--wishlist area end -->
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $(""a.addToCart"").click(function (e) {
                e.preventDefault();
                let id = $(this).data(""id"");
                $.get('/ordering/add/' + id, {}, function (data) {
                    $(""div.smallCart"").html(data);
                });
            });
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
