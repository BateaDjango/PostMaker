#pragma checksum "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fb12cffebcb027d52904d5c0e9ab2e00a3bb2b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\_ViewImports.cshtml"
using PostMaker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
using PostMaker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fb12cffebcb027d52904d5c0e9ab2e00a3bb2b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d640428f9ff7e6ef11948852eebaa0411ade1e95", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <a href=\"/Home/CreatePost\" class=\"text-right\">\r\n        <h5>Create Your Post</h5>\r\n    </a>\r\n    \r\n");
#nullable restore
#line 13 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
     if(Model.Any())
    {
        foreach(var post in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"post-container\">\r\n                <div><b>");
#nullable restore
#line 18 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
                   Write(post.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> posted:</div>\r\n                <div class=\"post-content\">");
#nullable restore
#line 19 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
                                     Write(Html.Raw(post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
                                                             Write(post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"text-right\">");
#nullable restore
#line 20 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
                                   Write(post.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>No Posts in the last 24 hours to show.</h5>\r\n");
#nullable restore
#line 27 "C:\Users\spinu\Desktop\PostMaker\PostMaker\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
