#pragma checksum "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "412fc3d7f3b10763ebdccf6b74c1390718fdeef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ChildrenReport), @"mvc.1.0.view", @"/Views/Employee/ChildrenReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/ChildrenReport.cshtml", typeof(AspNetCore.Views_Employee_ChildrenReport))]
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
#line 1 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412fc3d7f3b10763ebdccf6b74c1390718fdeef0", @"/Views/Employee/ChildrenReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ChildrenReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ExportChildrenReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
  
    ViewData["Title"] = "ChildrenReport";
    Layout = "~/Views/Shared/_LayoutData.cshtml";

#line default
#line hidden
            BeginContext(140, 83, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\" style=\"padding-top:10px;\">\r\n        ");
            EndContext();
            BeginContext(223, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040734054828487ab6d8293ac74d9ff0", async() => {
                BeginContext(271, 6, true);
                WriteLiteral("Export");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(286, 66, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<p>Tổng số <span class=\"badge badge-info\">");
            EndContext();
            BeginContext(353, 13, false);
#line 14 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                                     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(366, 155, true);
            WriteLiteral("</span></p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                STT\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(522, 44, false);
#line 22 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(566, 182, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Chức vụ\r\n            </th>\r\n            <th>\r\n                Điện thoại\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(749, 41, false);
#line 31 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(790, 114, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Con</th>\r\n            <th>Số</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
          
            int No = 1;
            foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(997, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1044, 2, false);
#line 43 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                   Write(No);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1104, 43, false);
#line 45 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1227, 45, false);
#line 48 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ChucVuName));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 51 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                          
                            if (item.Mobiles != null && item.Mobiles.Count > 0)
                            {
                                foreach (var mobile in item.Mobiles)
                                {
                                    if (!string.IsNullOrEmpty(mobile.Number))
                                    {

#line default
#line hidden
            BeginContext(1690, 45, true);
            WriteLiteral("                                        <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1735, "\"", 1760, 2);
            WriteAttributeValue("", 1742, "tel:", 1742, 4, true);
#line 58 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
WriteAttributeValue("", 1746, mobile.Number, 1746, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1761, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1763, 13, false);
#line 58 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                                                                   Write(mobile.Number);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 59 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                                    }
                                }
                            }
                        

#line default
#line hidden
            BeginContext(1918, 77, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1996, 40, false);
#line 65 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 68 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                          
                            int numChild = 0;
                            foreach (var children in item.EmployeeFamilys)
                            {
                                if (children.Relation == 3)
                                {
                                    var birthday = string.Empty;
                                    if (children.Birthday.HasValue)
                                    {
                                        birthday = " - " + children.Birthday.Value.ToString("dd/MM/yyyy");
                                    }

#line default
#line hidden
            BeginContext(2690, 39, true);
            WriteLiteral("                                    <p>");
            EndContext();
            BeginContext(2730, 17, false);
#line 79 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                                  Write(children.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2747, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2749, 8, false);
#line 79 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                                                     Write(birthday);

#line default
#line hidden
            EndContext();
            BeginContext(2757, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 80 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                                    ++numChild;
                                }
                            }
                        

#line default
#line hidden
            BeginContext(2905, 77, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2983, 8, false);
#line 86 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                   Write(numChild);

#line default
#line hidden
            EndContext();
            BeginContext(2991, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 89 "D:\Projects\Sgx\sourcecode\sgx\erp\Views\Employee\ChildrenReport.cshtml"
                ++No;
            }
        

#line default
#line hidden
            BeginContext(3092, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
