#pragma checksum "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1416ac222552302647afc66a63399c9ff03dff5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Post), @"mvc.1.0.view", @"/Views/Cms/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cms/Post.cshtml", typeof(AspNetCore.Views_Cms_Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1416ac222552302647afc66a63399c9ff03dff5f", @"/Views/Cms/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiranhaBoringBlog.Models.BlogPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            BeginContext(104, 165, true);
            WriteLiteral("\n<div class=\"main\">\n    <div class=\"container\">\n        <div class=\"row justify-content-center\">\n            <div class=\"col-sm-10 post-header\">\n                <h1>");
            EndContext();
            BeginContext(270, 11, false);
#line 11 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(281, 6, true);
            WriteLiteral("</h1>\n");
            EndContext();
#line 12 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
                 if (Model.Tags.Count > 0) {
                    foreach (var tag in Model.Tags) {
                        

#line default
#line hidden
            BeginContext(416, 20, true);
            WriteLiteral("<span class=\"tag\"># ");
            EndContext();
            BeginContext(437, 9, false);
#line 14 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
                                             Write(tag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(446, 7, true);
            WriteLiteral("</span>");
            EndContext();
#line 14 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
                                                                          
                    }
                }

#line default
#line hidden
            BeginContext(501, 34, true);
            WriteLiteral("            </div>\n        </div>\n");
            EndContext();
#line 19 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
         if (Model.Heading.PrimaryImage.HasValue) {

#line default
#line hidden
            BeginContext(587, 121, true);
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col-sm post-header\">\n                    <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 708, "\"", 777, 1);
#line 22 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
WriteAttributeValue("", 714, Url.Content(Model.Heading.PrimaryImage.Resize(Api, 1100, 400)), 714, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(778, 44, true);
            WriteLiteral(">\n                </div>\n            </div>\n");
            EndContext();
#line 25 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
        }

#line default
#line hidden
            BeginContext(832, 111, true);
            WriteLiteral("        <div class=\"row justify-content-center\">\n            <div class=\"col-sm-10 post-body\">\n                ");
            EndContext();
            BeginContext(944, 30, false);
#line 28 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Post.cshtml"
           Write(Html.DisplayFor(m => m.Blocks));

#line default
#line hidden
            EndContext();
            BeginContext(974, 53, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.IApi Api { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiranhaBoringBlog.Models.BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
