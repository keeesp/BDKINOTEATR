#pragma checksum "C:\Users\Кирилл\source\repos\DBKINOTEATR\DBKINOTEATR\Pages\FilReq\Request\PerDep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856ba594e33fdfd0abb6f491e1e6e1f89305c8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DBKINOTEATR.Pages.FilReq.Request.Pages_FilReq_Request_PerDep), @"mvc.1.0.razor-page", @"/Pages/FilReq/Request/PerDep.cshtml")]
namespace DBKINOTEATR.Pages.FilReq.Request
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
#line 1 "C:\Users\Кирилл\source\repos\DBKINOTEATR\DBKINOTEATR\Pages\_ViewImports.cshtml"
using DBKINOTEATR;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"856ba594e33fdfd0abb6f491e1e6e1f89305c8a7", @"/Pages/FilReq/Request/PerDep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88213c5c8d1f7a7ffbe4f07cbe6b9889b01cea2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Request_PerDep : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            \r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Кирилл\source\repos\DBKINOTEATR\DBKINOTEATR\Pages\FilReq\Request\PerDep.cshtml"
           Write(Html.DisplayNameFor(model => model.SOTRUDNIKI[0].FIO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Кирилл\source\repos\DBKINOTEATR\DBKINOTEATR\Pages\FilReq\Request\PerDep.cshtml"
         foreach (var item in Model.SOTRUDNIKI)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n               \r\n                \r\n              \r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Кирилл\source\repos\DBKINOTEATR\DBKINOTEATR\Pages\FilReq\Request\PerDep.cshtml"
               Write(Html.DisplayFor(modelItem => item.FIO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Кирилл\source\repos\DBKINOTEATR\DBKINOTEATR\Pages\FilReq\Request\PerDep.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DBKINOTEATR.Pages.FilReq.Request.PerDepModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DBKINOTEATR.Pages.FilReq.Request.PerDepModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DBKINOTEATR.Pages.FilReq.Request.PerDepModel>)PageContext?.ViewData;
        public DBKINOTEATR.Pages.FilReq.Request.PerDepModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591