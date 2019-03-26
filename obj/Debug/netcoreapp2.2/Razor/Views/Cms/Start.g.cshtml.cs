#pragma checksum "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c23b28b690e9798b9745c88467a5607ca8c09853"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Start), @"mvc.1.0.view", @"/Views/Cms/Start.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cms/Start.cshtml", typeof(AspNetCore.Views_Cms_Start))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23b28b690e9798b9745c88467a5607ca8c09853", @"/Views/Cms/Start.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Start : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiranhaBoringBlog.Models.StartPage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.HasImage = Model.Heading.PrimaryImage.HasValue;

    string PrimaryImage() {
        if (Model.Heading.PrimaryImage.HasValue) {
            return $"style=background-image:url({Url.Content(Model.Heading.PrimaryImage)})";
        }
        return "";
    }

#line default
#line hidden
            BeginContext(373, 29, true);
            WriteLiteral("\n<header class=\"page-header\" ");
            EndContext();
            BeginContext(403, 14, false);
#line 15 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                       Write(PrimaryImage());

#line default
#line hidden
            EndContext();
            BeginContext(417, 111, true);
            WriteLiteral(">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-sm-9\">\n                <h1>");
            EndContext();
            BeginContext(529, 11, false);
#line 19 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(540, 59, true);
            WriteLiteral("</h1>\n                <p class=\"lead\">\n                    ");
            EndContext();
            BeginContext(600, 31, false);
#line 21 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
               Write(Html.Raw(Model.Heading.Ingress));

#line default
#line hidden
            EndContext();
            BeginContext(631, 125, true);
            WriteLiteral("\n                </p>\n            </div>\n        </div>\n    </div>\n</header>\n\n<div class=\"main\">\n    <div class=\"container\">\n");
            EndContext();
#line 30 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
         if (Model.Teasers.Count > 0) {
            var pos = 0;
            var size = 4;

            while (pos < Model.Teasers.Count) {
                var rest = Model.Teasers.Count - pos;
                var cols = 0;
                
                if (rest == 1) {
                    size = 8;
                    cols = 1;
                } else if (rest <= 4 && rest % 3 != 0 && rest % 2 == 0) {
                    size = 6;
                    cols = 2;
                } else {
                    size = 4;
                    cols = 3;
                }


#line default
#line hidden
            BeginContext(1328, 65, true);
            WriteLiteral("                <div class=\"row justify-content-center teasers\">\n");
            EndContext();
#line 50 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                     for (var n = 0; n < cols; n++) {
                        var teaser = Model.Teasers[pos + n];


#line default
#line hidden
            BeginContext(1509, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1537, "\"", 1573, 4);
            WriteAttributeValue("", 1545, "col-sm-6", 1545, 8, true);
            WriteAttributeValue(" ", 1553, "col-md-", 1554, 8, true);
#line 53 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
WriteAttributeValue("", 1561, size, 1561, 5, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1566, "teaser", 1567, 7, true);
            EndWriteAttribute();
            BeginContext(1574, 118, true);
            WriteLiteral(">\n                            <div class=\"teaser-body\">\n                                <span class=\"teaser-subtitle\">");
            EndContext();
            BeginContext(1693, 15, false);
#line 55 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                                                         Write(teaser.SubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1708, 44, true);
            WriteLiteral("</span>\n                                <h3>");
            EndContext();
            BeginContext(1753, 12, false);
#line 56 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                               Write(teaser.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1765, 38, true);
            WriteLiteral("</h3>\n                                ");
            EndContext();
            BeginContext(1804, 21, false);
#line 57 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                           Write(Html.Raw(teaser.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 58 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                                 if (teaser.PageLink.HasValue) {

#line default
#line hidden
            BeginContext(1891, 41, true);
            WriteLiteral("                                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1932, "\"", 1970, 1);
#line 59 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
WriteAttributeValue("", 1939, teaser.PageLink.Page.Permalink, 1939, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1971, 21, true);
            WriteLiteral(">Read more..</a></p>\n");
            EndContext();
#line 60 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                                } else if (teaser.PostLink.HasValue) {

#line default
#line hidden
            BeginContext(2063, 41, true);
            WriteLiteral("                                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2104, "\"", 2142, 1);
#line 61 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
WriteAttributeValue("", 2111, teaser.PostLink.Post.Permalink, 2111, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2143, 53, true);
            WriteLiteral(">Read more..</a></p>                                \n");
            EndContext();
#line 62 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                                }

#line default
#line hidden
            BeginContext(2230, 90, true);
            WriteLiteral("                            </div>\n                        </div>                        \n");
            EndContext();
#line 65 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                    }

#line default
#line hidden
            BeginContext(2342, 23, true);
            WriteLiteral("                </div>\n");
            EndContext();
#line 67 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
                pos += cols;
            }
        }

#line default
#line hidden
            BeginContext(2418, 112, true);
            WriteLiteral("\n        <div class=\"row justify-content-center\">\n            <div class=\"col-sm-10 page-body\">\n                ");
            EndContext();
            BeginContext(2531, 30, false);
#line 73 "/Users/gozhack/Projects/net/PiranhaBoringBlog/Views/Cms/Start.cshtml"
           Write(Html.DisplayFor(m => m.Blocks));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 53, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiranhaBoringBlog.Models.StartPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
