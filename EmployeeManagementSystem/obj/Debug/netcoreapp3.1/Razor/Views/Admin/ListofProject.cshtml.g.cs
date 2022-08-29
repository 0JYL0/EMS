#pragma checksum "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "012e3c7e376795dd062536ab6dc8d840988e57d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListofProject), @"mvc.1.0.view", @"/Views/Admin/ListofProject.cshtml")]
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
#line 1 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
using EMP.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012e3c7e376795dd062536ab6dc8d840988e57d7", @"/Views/Admin/ListofProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d74a7592af933458469e08f9ca7634db2dc2ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ListofProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EMS.MODEL.Models.ProjectResponseModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listOfProjectMembers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addProjectMembers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
  
    ViewData["title"] = "List of Projects";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container bg-secondary text-light\">\r\n    <h1 class=\"text-center\">List of Projects</h1>\r\n</div>\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 18 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
               Write(Html.DisplayNameFor(x => x.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 20 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
               Write(Html.DisplayNameFor(x => x.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 22 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
               Write(Html.DisplayNameFor(x => x.ProjectDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 24 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
               Write(Html.DisplayNameFor(x => x.ProjectTech));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 26 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
               Write(Html.DisplayNameFor(x => x.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 28 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
               Write(Html.DisplayNameFor(x => x.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>#</th>\r\n\r\n                <th>#</th>\r\n\r\n                <th>#</th>\r\n\r\n                <th>#</th>\r\n            </tr>\r\n\r\n        </thead>\r\n\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 43 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 47 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                   Write(Html.DisplayFor(x => item.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 49 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                   Write(Html.DisplayFor(x => item.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 51 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                   Write(Html.DisplayFor(x => item.ProjectDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 53 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                   Write(Html.DisplayFor(x => item.ProjectTech));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 55 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                   Write(Html.DisplayFor(x => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 57 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                   Write(Html.DisplayFor(x => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012e3c7e376795dd062536ab6dc8d840988e57d710845", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                                               WriteLiteral(item.ProjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012e3c7e376795dd062536ab6dc8d840988e57d713207", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                                                               WriteLiteral(item.ProjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012e3c7e376795dd062536ab6dc8d840988e57d715592", async() => {
                WriteLiteral("Add Member");
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
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                                                            WriteLiteral(item.ProjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012e3c7e376795dd062536ab6dc8d840988e57d717977", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
                                                 WriteLiteral(item.ProjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 76 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Admin\ListofProject.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EMS.MODEL.Models.ProjectResponseModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591