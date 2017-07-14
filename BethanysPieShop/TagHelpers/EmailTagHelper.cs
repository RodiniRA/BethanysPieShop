using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BethanysPieShop.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Addreess { get; set; }
        public string Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Addreess);
            output.Content.SetContent(Content);
        }
    }
}
