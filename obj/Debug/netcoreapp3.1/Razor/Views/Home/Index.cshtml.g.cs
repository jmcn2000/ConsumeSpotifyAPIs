#pragma checksum "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42fd501bdd8fbaafd1983f2ce346bb53e23f292b"
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
#line 1 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\_ViewImports.cshtml"
using ConsumeSpotifyAPIs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\_ViewImports.cshtml"
using ConsumeSpotifyAPIs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fd501bdd8fbaafd1983f2ce346bb53e23f292b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"509975a1522d41f897451fb630a4d6b5adb014ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConsumeSpotifyAPIs.Models.Release>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-1\" style=\"width:350px;\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Artists));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 13 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 551, "\"", 601, 1);
#nullable restore
#line 15 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
WriteAttributeValue("", 557, Html.DisplayFor(modelItem => item.ImageUrl), 557, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width-\"300\" height=\"300\" alt=\"Release picture\" />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 672, "\"", 719, 1);
#nullable restore
#line 16 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
WriteAttributeValue("", 679, Html.DisplayFor(modelItem => item.Link), 679, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Listen</a>\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\jmcn2\source\repos\jmcn2000\ConsumeSpotifyAPIs\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConsumeSpotifyAPIs.Models.Release>> Html { get; private set; }
    }
}
#pragma warning restore 1591
