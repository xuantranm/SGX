#pragma checksum "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b8a99199ecfc856705a9fbeebab4329ec98bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeKeeper_Manage), @"mvc.1.0.view", @"/Views/TimeKeeper/Manage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimeKeeper/Manage.cshtml", typeof(AspNetCore.Views_TimeKeeper_Manage))]
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
#line 1 "C:\Projects\Tribat\sourcecode\erp\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#line 1 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
using System.Globalization;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
using Common.Utilities;

#line default
#line hidden
#line 3 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b8a99199ecfc856705a9fbeebab4329ec98bc8", @"/Views/TimeKeeper/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeKeeper_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeKeeperViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "old-new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/leave.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
  
    Layout = "~/Views/Shared/_LayoutSocialFb.cshtml";

#line default
#line hidden
            BeginContext(167, 220, true);
            WriteLiteral("\r\n<section>\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center align-items-center\">\r\n            <div class=\"col\">\r\n                <div class=\"media align-items-center\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 387, "\"", 434, 2);
            WriteAttributeValue("", 394, "/hr/nhan-su/thong-tin/", 394, 22, true);
#line 15 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
WriteAttributeValue("", 416, Model.Employee.Id, 416, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(435, 16, true);
            WriteLiteral(" class=\"mr-4\">\r\n");
            EndContext();
#line 16 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                         if (Model.Employee.Avatar != null)
                        {

#line default
#line hidden
            BeginContext(539, 47, true);
            WriteLiteral("                            <img class=\"avatar\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 586, "\"", 650, 2);
#line 18 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
WriteAttributeValue("", 592, Model.Employee.Avatar.Path, 592, 27, false);

#line default
#line hidden
#line 18 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
WriteAttributeValue("", 619, Model.Employee.Avatar.FileName, 619, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 651, "\"", 681, 1);
#line 18 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
WriteAttributeValue("", 657, Model.Employee.FullName, 657, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 19 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(771, 32, true);
            WriteLiteral("                            <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 803, "\"", 833, 1);
#line 22 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
WriteAttributeValue("", 809, Model.Employee.FullName, 809, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(834, 66, true);
            WriteLiteral(" src=\"holder.js/120x120\" class=\"avatar avatar-lg avatar-square\">\r\n");
            EndContext();
#line 23 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                        }

#line default
#line hidden
            BeginContext(927, 164, true);
            WriteLiteral("                    </a>\r\n                    <div class=\"media-body\">\r\n                        <div class=\"mb-3\">\r\n                            <h1 class=\"h2 mb-2\">");
            EndContext();
            BeginContext(1092, 23, false);
#line 27 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                           Write(Model.Employee.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 69, true);
            WriteLiteral("</h1>\r\n                            <span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(1185, 19, false);
#line 28 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                                         Write(Model.Employee.Code);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 70, true);
            WriteLiteral("</span>\r\n                            <span class=\"badge badge-danger\">");
            EndContext();
            BeginContext(1275, 20, false);
#line 29 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                                        Write(Model.Employee.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1295, 280, true);
            WriteLiteral(@"</span>
                        </div>
                        <div>
                            <ul class=""list-inline text-small d-inline-block"">
                                <li class=""list-inline-item"">
                                    <i class=""icon-link""></i>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1575, "\"", 1622, 2);
            WriteAttributeValue("", 1582, "/hr/nhan-su/thong-tin/", 1582, 22, true);
#line 34 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
WriteAttributeValue("", 1604, Model.Employee.Id, 1604, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1623, 33, true);
            WriteLiteral(">https://tribat.vn/erp/thong-tin/");
            EndContext();
            BeginContext(1657, 17, false);
#line 34 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                                                                                                                             Write(Model.Employee.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1674, 410, true);
            WriteLiteral(@"</a>
                                </li>
                                <li class=""list-inline-item""><i class=""icon-users""></i> 12</li>
                                <li class=""list-inline-item""><i class=""icon-message""></i> 6</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!--end of col-->
");
            EndContext();
            BeginContext(2251, 234, true);
            WriteLiteral("            <!--end of col-->\r\n        </div>\r\n        <!--end of row-->\r\n    </div>\r\n    <!--end of container-->\r\n</section>\r\n\r\n<h5 class=\"mb-4\">Tổng quan</h5>\r\n<div class=\"card\">\r\n    <span class=\"text-small\"> Dữ liệu tính tới ngày ");
            EndContext();
            BeginContext(2486, 47, false);
#line 56 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                               Write(DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2533, 291, true);
            WriteLiteral(@" 02:00 AM</span>
    <ul class=""list-group list-group-flush"">
        <li class=""list-group-item"">
            <div class=""d-flex justify-content-between"">
                <div><i class=""icon-calculator mr-1""></i> Số ngày làm việc:</div>
                <span class=""badge badge-light"">");
            EndContext();
            BeginContext(2825, 22, false);
#line 61 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                           Write(ViewData["DayWorking"]);

#line default
#line hidden
            EndContext();
            BeginContext(2847, 275, true);
            WriteLiteral(@"</span>
            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""d-flex justify-content-between"">
                <div><i class=""icon-calculator mr-1""></i> Số ngày đã chấm công:</div>
                <span class=""badge badge-light"">");
            EndContext();
            BeginContext(3123, 21, false);
#line 67 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                           Write(ViewData["DayFinger"]);

#line default
#line hidden
            EndContext();
            BeginContext(3144, 277, true);
            WriteLiteral(@"</span>
            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""d-flex justify-content-between"">
                <div><i class=""icon-calculator mr-1""></i> Số ngày chưa chấm công:</div>
                <span class=""badge badge-light"">");
            EndContext();
            BeginContext(3422, 25, false);
#line 73 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                           Write(ViewData["DayFingerMiss"]);

#line default
#line hidden
            EndContext();
            BeginContext(3447, 266, true);
            WriteLiteral(@"</span>
            </div>
        </li>
    </ul>
</div>

<div class=""card card-sm"">
    <div class=""card-header bg-secondary d-flex justify-content-between align-items-center"">
        <div>
            <h6>Lịch sử chấm công</h6>
        </div>
        ");
            EndContext();
            BeginContext(3713, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ee3a4655104ccc9e2c2ce7afa9365e", async() => {
                BeginContext(3753, 144, true);
                WriteLiteral("\r\n            <span class=\"mr-2 text-muted text-small text-nowrap\">Sắp xếp:</span>\r\n            <select class=\"custom-select\">\r\n                ");
                EndContext();
                BeginContext(3897, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ce893d4b62d4925a2d5a3094a5cbfd8", async() => {
                    BeginContext(3930, 8, true);
                    WriteLiteral("Mới nhất");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3947, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3965, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "837314baec504d4883cfa02f21ccd0a8", async() => {
                    BeginContext(3988, 10, true);
                    WriteLiteral("Trạng thái");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4007, 33, true);
                WriteLiteral("\r\n            </select>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4047, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
#line 95 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
 if (Model.EmployeeWorkTimeLogs.Count > 0)
{

#line default
#line hidden
            BeginContext(4120, 475, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col"">
            <table class=""table table-borderless table-hover align-items-center"">
                <thead>
                    <tr>
                        <th scope=""col"">Ngày</th>
                        <th scope=""col"">Vào</th>
                        <th scope=""col"">Ra</th>
                        <th scope=""col"">Số lần chấm công</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 109 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                     foreach (var group in Model.EmployeeWorkTimeLogs.OrderByDescending(m=>m.Date).GroupBy(m => m.DateOnlyRecord))
                    {

#line default
#line hidden
            BeginContext(4750, 279, true);
            WriteLiteral(@"                    <tr class=""bg-white"">
                        <th scope=""row"">
                            <a class=""media align-items-center"" href=""#"">
                                <div class=""media-body"">
                                    <span class=""text-muted"">");
            EndContext();
            BeginContext(5030, 32, false);
#line 115 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                                        Write(group.Key.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5062, 166, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                            </a>\r\n                        </th>\r\n                        <!--Get first and last -->\r\n");
            EndContext();
#line 120 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                          
                            var number = group.Count();
                            var first = group.First().TimeOnlyRecord;
                            var last = group.Last().TimeOnlyRecord.ToString();
                            if (number > 1)
                            {

#line default
#line hidden
            BeginContext(5540, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(5577, 4, false);
#line 126 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                               Write(last);

#line default
#line hidden
            EndContext();
            BeginContext(5581, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5625, 5, false);
#line 127 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                               Write(first);

#line default
#line hidden
            EndContext();
            BeginContext(5630, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 128 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                            }
                            else
                            {
                                if (first.Hours > 12)
                                {

#line default
#line hidden
            BeginContext(5823, 243, true);
            WriteLiteral("                                    <td>\r\n                                        Không dữ liệu <span class=\"badge badge-indicator badge-danger\">&nbsp;</span>\r\n                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(6067, 5, false);
#line 136 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                   Write(first);

#line default
#line hidden
            EndContext();
            BeginContext(6072, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 137 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(6187, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(6228, 5, false);
#line 140 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                   Write(first);

#line default
#line hidden
            EndContext();
            BeginContext(6233, 210, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        Không dữ liệu <span class=\"badge badge-indicator badge-danger\">&nbsp;</span>\r\n                                    </td>\r\n");
            EndContext();
#line 144 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                                }
                            }
                        

#line default
#line hidden
            BeginContext(6536, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(6565, 6, false);
#line 147 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                       Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(6571, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 149 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
                    }

#line default
#line hidden
            BeginContext(6628, 126, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!--end of col-->\r\n    </div>\r\n    <!--end of row-->\r\n");
            EndContext();
#line 156 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(6766, 88, true);
            WriteLiteral("    <div class=\"alert alert-light\" role=\"alert\">\r\n        Không có dữ liệu\r\n    </div>\r\n");
            EndContext();
#line 162 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
}

#line default
#line hidden
            BeginContext(6857, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6879, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 166 "C:\Projects\Tribat\sourcecode\erp\Views\TimeKeeper\Manage.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(6958, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(6966, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55186a1ccd0b4f2da3d1bbb90ecb92c0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7026, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(7038, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeKeeperViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
