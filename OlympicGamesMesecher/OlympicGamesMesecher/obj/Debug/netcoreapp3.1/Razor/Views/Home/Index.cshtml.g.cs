#pragma checksum "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee65f446dc56019988bd59cccaa2dcc455cf02c"
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
#line 1 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\_ViewImports.cshtml"
using OlympicGamesMesecher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\_ViewImports.cshtml"
using OlympicGamesMesecher.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee65f446dc56019988bd59cccaa2dcc455cf02c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a84c80a73a8bf40c95e453ae499bb700e4236c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountryListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Olympic Games";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <h3 class=\"mt-3\">Game</h3>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 9 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
             foreach (Game gm in Model.Games)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee65f446dc56019988bd59cccaa2dcc455cf02c4567", async() => {
#nullable restore
#line 15 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                                                   Write(gm.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGm", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                       WriteLiteral(gm.GameID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGm"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGm", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGm"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                         WriteLiteral(Model.ActiveCtgy);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeCtgy"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeCtgy", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeCtgy"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "list-group-item", 423, 15, true);
#nullable restore
#line 14 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
AddHtmlAttributeValue("\r\n                       ", 438, Model.CheckActiveGm(gm.GameID), 463, 31, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <h3 class=\"mt-3\">Category</h3>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 20 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
             foreach (Category ctgy in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee65f446dc56019988bd59cccaa2dcc455cf02c9060", async() => {
#nullable restore
#line 26 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                                                           Write(ctgy.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGm", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                       WriteLiteral(Model.ActiveGm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGm"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGm", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGm"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                         WriteLiteral(ctgy.CategoryID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeCtgy"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeCtgy", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeCtgy"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 858, "list-group-item", 858, 15, true);
#nullable restore
#line 25 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
AddHtmlAttributeValue("\r\n                       ", 873, Model.CheckActiveCtgy(ctgy.CategoryID), 898, 39, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-sm-9\">\r\n        <ul class=\"list-inline\">\r\n");
#nullable restore
#line 32 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
             foreach (Country country in Model.Countries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-inline-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee65f446dc56019988bd59cccaa2dcc455cf02c13633", async() => {
                WriteLiteral("\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1289, "\"", 1313, 1);
#nullable restore
#line 36 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
WriteAttributeValue("", 1295, country.LogoImage, 1295, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1314, "\"", 1333, 1);
#nullable restore
#line 36 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
WriteAttributeValue("", 1320, country.Name, 1320, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                         title=\"", 1334, "\"", 1479, 4);
#nullable restore
#line 37 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
WriteAttributeValue("", 1368, country.Name, 1368, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1381, "|", 1382, 2, true);
#nullable restore
#line 37 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1383, country.Game.Name, 1384, 18, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
WriteAttributeValue("\r\n                                                     ", 1402, country.Category.Name, 1457, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
                                              WriteLiteral(country.CountryID);

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
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 41 "C:\Users\Presto\Documents\GitHub\CIS174-Preston-Mesecher\OlympicGamesMesecher\OlympicGamesMesecher\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountryListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
