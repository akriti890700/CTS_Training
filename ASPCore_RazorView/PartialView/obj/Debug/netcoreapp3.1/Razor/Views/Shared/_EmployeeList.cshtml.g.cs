#pragma checksum "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd02f90f20d4b61550fc446732a25c08b816db19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeeList), @"mvc.1.0.view", @"/Views/Shared/_EmployeeList.cshtml")]
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
#line 1 "C:\Users\890700\Desktop\PartialView\Views\_ViewImports.cshtml"
using PartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\890700\Desktop\PartialView\Views\_ViewImports.cshtml"
using PartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd02f90f20d4b61550fc446732a25c08b816db19", @"/Views/Shared/_EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7447ae80986a5cd61172c7f6e8f771eaf552cff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RazorViewModelBinding.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <span class=\"col-md-2\">\r\n        <b>\r\n            ");
#nullable restore
#line 5 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </b>\r\n    </span>\r\n    <span class=\"col-md-2\">\r\n        <b>\r\n            ");
#nullable restore
#line 10 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </b>\r\n    </span>\r\n    <span class=\"col-md-2\">\r\n        <b>\r\n            ");
#nullable restore
#line 15 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </b>\r\n    </span>\r\n    <span class=\"col-md-2\">\r\n        <b>\r\n            ");
#nullable restore
#line 20 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayNameFor(model => model.IsParmanent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </b>\r\n    </span>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 25 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
 foreach (var item in Model)
{
    if (item.IsParmanent == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"row\">\r\n            <span class=\"col-md-2\">\r\n                <b>\r\n                    ");
#nullable restore
#line 32 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </b>\r\n            </span>\r\n            <span class=\"col-md-2\">\r\n                <b>\r\n                    ");
#nullable restore
#line 37 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </b>\r\n            </span>\r\n            <span class=\"col-md-2\">\r\n                <b>\r\n                    ");
#nullable restore
#line 42 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </b>\r\n            </span>\r\n            <span class=\"col-md-2\">\r\n                <b>\r\n                    ");
#nullable restore
#line 47 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsParmanent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </b>\r\n            </span>\r\n        </div>\r\n      <br /> \r\n");
#nullable restore
#line 52 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
                    
    }
                                    
    else                                   
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <span class=\"col-md-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <span class=\"col-md-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <span class=\"col-md-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <span class=\"col-md-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
       Write(Html.DisplayFor(modelItem => item.IsParmanent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n");
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 73 "C:\Users\890700\Desktop\PartialView\Views\Shared\_EmployeeList.cshtml"
    }
                                                 
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RazorViewModelBinding.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
