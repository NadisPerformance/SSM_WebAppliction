#pragma checksum "C:\Users\Nadis PERFORMANCE\Source\Repos\SSM_WebAppliction\SSM_WebApplication\Views\FuelPrice\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec27c9fb75b54febe29c5c3c4b6022537877e99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FuelPrice_Detail), @"mvc.1.0.view", @"/Views/FuelPrice/Detail.cshtml")]
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
#line 1 "C:\Users\Nadis PERFORMANCE\Source\Repos\SSM_WebAppliction\SSM_WebApplication\Views\_ViewImports.cshtml"
using SSM_WebApplication.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nadis PERFORMANCE\Source\Repos\SSM_WebAppliction\SSM_WebApplication\Views\_ViewImports.cshtml"
using SSM_WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec27c9fb75b54febe29c5c3c4b6022537877e99e", @"/Views/FuelPrice/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15bf252a5af72f2b38e6589da25a22b6a77d274", @"/Views/_ViewImports.cshtml")]
    public class Views_FuelPrice_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FuelPrice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <h2>\r\n            <a>");
#nullable restore
#line 6 "C:\Users\Nadis PERFORMANCE\Source\Repos\SSM_WebAppliction\SSM_WebApplication\Views\FuelPrice\Detail.cshtml"
          Write(Model.Fuel.FuelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h2>\r\n        <div class=\"caption-full\">\r\n            <p>");
#nullable restore
#line 9 "C:\Users\Nadis PERFORMANCE\Source\Repos\SSM_WebAppliction\SSM_WebApplication\Views\FuelPrice\Detail.cshtml"
          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FuelPrice> Html { get; private set; }
    }
}
#pragma warning restore 1591
