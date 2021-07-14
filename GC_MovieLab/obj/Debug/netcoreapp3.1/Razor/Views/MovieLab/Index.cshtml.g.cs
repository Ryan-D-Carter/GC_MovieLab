#pragma checksum "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552b13ea6e904ca362f50301dbc49833112e8384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieLab_Index), @"mvc.1.0.view", @"/Views/MovieLab/Index.cshtml")]
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
#line 1 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\_ViewImports.cshtml"
using GC_MovieLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\_ViewImports.cshtml"
using GC_MovieLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552b13ea6e904ca362f50301dbc49833112e8384", @"/Views/MovieLab/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7354cb6bd4abd8a1a0dbb6826cf2d5a2296f10f8", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieLab_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552b13ea6e904ca362f50301dbc49833112e83843376", async() => {
                WriteLiteral("<button class=\"btn btn-primary\">Add a Movie</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            Id\r\n        </th>\r\n        <th>\r\n            Title\r\n        </th>\r\n        <th>\r\n            Genre\r\n        </th>\r\n        <th>\r\n            Runtime\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
           Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
           Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
           Write(movie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Minutes</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = movie.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = movie.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Ryan\source\repos\GC_MovieLab\GC_MovieLab\Views\MovieLab\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
