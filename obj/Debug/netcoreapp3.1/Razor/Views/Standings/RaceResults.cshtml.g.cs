#pragma checksum "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08f3e932be78f6cc1b77773d1063657cd0851532"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Standings_RaceResults), @"mvc.1.0.view", @"/Views/Standings/RaceResults.cshtml")]
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
#line 1 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
using F1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f3e932be78f6cc1b77773d1063657cd0851532", @"/Views/Standings/RaceResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e653edd85815f250a2e42a30e3a035dde200cdbe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Standings_RaceResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RaceResult>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeamStandings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Standings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DriverStandings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
  
    ViewData["Title"] = "Race Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <h1>\r\n                2022 Race Results\r\n            </h1>\r\n            <p>\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08f3e932be78f6cc1b77773d1063657cd08515324327", async() => {
                WriteLiteral("Team Standings");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08f3e932be78f6cc1b77773d1063657cd08515325750", async() => {
                WriteLiteral("Driver Standings");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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

    <table class=""resultsarchive-table"">
    <thead>
            <tr>
                <th class=""limiter""></th>
                <th>Grand Prix</th>
                <th class=""hide-for-mobile"">Date</th>
                <th>Winner</th>
                <th>Car</th>
                <th class=""hide-for-mobile"">Laps</th>
                <th class=""hide-for-tablet"">Time</th>
                <th class=""limiter""></th>
            </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 37 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n                <td class=\"limiter\"></td>\r\n                <td class=\"dark bold\">");
#nullable restore
#line 41 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"dark hide-for-mobile\">");
#nullable restore
#line 42 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
                                            Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"dark bold\">");
#nullable restore
#line 43 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
                                 Write(item.Winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"semi-bold uppercase \">");
#nullable restore
#line 44 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
                                            Write(item.Team);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"bold hide-for-mobile\">");
#nullable restore
#line 45 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
                                            Write(item.Laps);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"dark bold hide-for-tablet\">");
#nullable restore
#line 46 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
                                                 Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"limiter\"></td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "D:\dip\F1\F1\Views\Standings\RaceResults.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RaceResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591