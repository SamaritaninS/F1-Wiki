#pragma checksum "D:\dip\F1\F1\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1fc1a504e962a7b6318d22e1fa2c64f2b19c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Details), @"mvc.1.0.view", @"/Views/Teams/Details.cshtml")]
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
#line 1 "D:\dip\F1\F1\Views\_ViewImports.cshtml"
using F1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
using F1.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
using F1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c1fc1a504e962a7b6318d22e1fa2c64f2b19c74", @"/Views/Teams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e653edd85815f250a2e42a30e3a035dde200cdbe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<F1.Models.Team>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  <div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"page-header\">\r\n                <h1>\r\n                    ");
#nullable restore
#line 15 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h1>\r\n                <div class=\"brand-logo\">\r\n  \r\n            <img");
            BeginWriteAttribute("src", " src=", 394, "", 410, 1);
#nullable restore
#line 19 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
WriteAttributeValue("", 399, Model.Logo, 399, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""200"" height=""100"">

             </div>
            </div>
        </div>
       
    </div>

   <table class=""stat-list"">
        <tbody>
            
    <tr>
        <th scope=""row"" class=""stat-key"">
        	
        	<span class=""text"">Full Team Name</span>
        	
        </th>
        <td class=""stat-value"">");
#nullable restore
#line 36 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n            \r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">Base</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 47 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.Base);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n            \r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">Team Chief</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 58 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.Chief);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n     \r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">Power Unit</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 68 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.Power);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n            \r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">First Team Entry</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 79 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.TeamEntry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n            \r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">World Championships</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 90 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.Championships);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">Pole Positions</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 101 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.Poles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n            \r\n    <tr>\r\n        <th scope=\"row\" class=\"stat-key\">\r\n        \t\r\n        \t<span class=\"text\">Fastest Laps</span>\r\n        \t\r\n        </th>\r\n        <td class=\"stat-value\">");
#nullable restore
#line 112 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
                          Write(Model.FastesLaps);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n<div>\r\n    <img class=\"card-img-top\" alt=\"Bootstrap Thumbnail First\"");
            BeginWriteAttribute("src", " src=\"", 2490, "\"", 2506, 1);
#nullable restore
#line 123 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
WriteAttributeValue("", 2496, Model.Img, 2496, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n</div>\r\n\r\n <section class=\"information\">\r\n            \r\n    <div class=\"text parbase\">\r\n\r\n        <h3><br>In profile</h3>\r\n    \r\n    </div>\r\n\r\n    <div class=\"text parbase\">\r\n    <p>");
#nullable restore
#line 135 "D:\dip\F1\F1\Views\Teams\Details.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n </section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<F1.Models.Team> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
