#pragma checksum "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d54268dd9bb0b2ea8adc53fcba1e1434ffb364e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d54268dd9bb0b2ea8adc53fcba1e1434ffb364e", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d74a7592af933458469e08f9ca7634db2dc2ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EMS.MODEL.Models.EmployeeResponseModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
  
    ViewData["title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Employee Dashboard</h1>\r\n\r\n<h1 class=\"text-center\">");
#nullable restore
#line 9 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
                   Write(ViewBag.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"container-fluid\">\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 27 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.EmployeeAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.EmployeeAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.EmployeeEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.EmployeeEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.EmployeeJoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.EmployeeJoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.EmployeeExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.EmployeeExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Technology));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.Technology));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\My Projects\ASP.net Core MVC\EmployeeManagementSystem\EmployeeManagementSystem\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(x => x.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EMS.MODEL.Models.EmployeeResponseModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
