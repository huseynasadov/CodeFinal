using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Helpers
{
    public class PriceTagHelper : TagHelper
    {
        public decimal Price { get; set; }

        public byte? DiscountPrice { get; set; }
        public int LanguageId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "price_box");

            if (DiscountPrice == 0 && LanguageId==2)
            {
                output.Content.SetHtmlContent("<span class='current_price'>" + (Price!=0?Price.ToString("#.00"):"0") + " ‎₼</span>");
            }
            else if (DiscountPrice == 0 && LanguageId == 1)
            {
                output.Content.SetHtmlContent("<span class='current_price'>" + (((double)Price/1.7) != 0 ? ((double)Price / 1.7).ToString("#.00") : "0") + " ‎$</span>");
            }
            else if (LanguageId == 2)
            {
                output.Content.SetHtmlContent("<span class='current_price'>" + ((double)Price - (double)Price * DiscountPrice / 100)?.ToString("#.00") + " ‎₼</span> <del>" + Price.ToString("#.00") + " ₼</del>");
            }
            else
            {
                output.Content.SetHtmlContent("<span class='current_price'>" + (((double)Price-(double)Price* DiscountPrice/100) /1.7)?.ToString("#.00") + " ‎$</span> <del>" + ((double)Price/1.7).ToString("#.00") + " $</del>");
            }
        }
    }
}
