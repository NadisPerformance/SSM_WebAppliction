#pragma checksum "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838721e5ddf90dc6a0151dec530097241787ebcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_List), @"mvc.1.0.view", @"/Views/Customer/List.cshtml")]
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
#line 1 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\_ViewImports.cshtml"
using SSM_WebApplication.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\_ViewImports.cshtml"
using SSM_WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838721e5ddf90dc6a0151dec530097241787ebcb", @"/Views/Customer/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15bf252a5af72f2b38e6589da25a22b6a77d274", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SSM_WebApplication.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 1em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"mx-auto w-75 p-3\">\r\n    <p class=\"h2\" style=\"margin-bottom: 1em;\">Liste des clients</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838721e5ddf90dc6a0151dec530097241787ebcb5585", async() => {
                WriteLiteral("Ajouter");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <p class=""h2"" style=""margin-bottom: 1em;"">Clients particulier</p>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">
                    Numéro
                </th>
                <th scope=""col"">
                    Nom
                </th>
                <th scope=""col"">
                    Prénom
                </th>
                <th scope=""col"">
                    Adresse
                </th>
                <th scope=""col"">
                    Ville
                </th>
                <th scope=""col"">
                    Telephone
                </th>
                <th scope=""col"">
                    Email
                </th>
                <th scope=""col"">
                    Date d'ajout
                </th>
                <th scope=""col"">
                    Statut
                </th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
             foreach (var item in Model)
            {
                if (item.ICE == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 48 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Adresse1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 58 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Adresse2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 61 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 64 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tel1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 65 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tel2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AddDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
#nullable restore
#line 74 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td scope=\"row\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838721e5ddf90dc6a0151dec530097241787ebcb12727", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838721e5ddf90dc6a0151dec530097241787ebcb14421", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <p class=""h2"" style=""margin-bottom: 1em;"">Clients professionnels</p>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">
                    Numéro
                </th>
                <th scope=""col"">
                    Société
                </th>
                <th scope=""col"">
                    ICE
                </th>
                <th scope=""col"">
                    Adresse
                </th>
                <th scope=""col"">
                    Ville
                </th>
                <th scope=""col"">
                    Telephone
                </th>
                <th scope=""col"">
                    Email
                </th>
                <th scope=""col"">
                    Contact
                </th>
                <th scope=""col"">
                    Date d'ajout
                </th>
                <th scope=""col"">
                    Statut
 ");
            WriteLiteral("               </th>\r\n                <th scope=\"col\"></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 124 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
             foreach (var item in Model)
            {
                if (item.ICE != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 130 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 133 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 136 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ICE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 139 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adresse1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 140 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adresse2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 143 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 146 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tel1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 147 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tel2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 150 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 153 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ContactName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 156 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.AddDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 159 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838721e5ddf90dc6a0151dec530097241787ebcb22339", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838721e5ddf90dc6a0151dec530097241787ebcb24025", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
#nullable restore
#line 164 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
               Write(Html.ActionLink("Create", "Create", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 167 "C:\Users\Nadis PERFORMANCE\source\repos\SSM_WebAppliction\SSM_WebApplication\Views\Customer\List.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SSM_WebApplication.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
