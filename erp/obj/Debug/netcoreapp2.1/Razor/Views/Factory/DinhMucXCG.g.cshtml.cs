#pragma checksum "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21973af1b40bf56f66e0ad441b98472068e7c5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factory_DinhMucXCG), @"mvc.1.0.view", @"/Views/Factory/DinhMucXCG.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factory/DinhMucXCG.cshtml", typeof(AspNetCore.Views_Factory_DinhMucXCG))]
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
#line 1 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
using Common.Utilities;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21973af1b40bf56f66e0ad441b98472068e7c5d1", @"/Views/Factory/DinhMucXCG.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Factory_DinhMucXCG : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DinhMucViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-lg js-select2-basic-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
  
    ViewData["Title"] = "Định mức xe cơ giới";
    Layout = "~/Views/Shared/_LayoutData.cshtml";

#line default
#line hidden
            BeginContext(180, 61, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 241, "\"", 340, 6);
            WriteAttributeValue("", 248, "/", 248, 1, true);
#line 12 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
WriteAttributeValue("", 249, Constants.LinkFactory.Main, 249, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 276, "/", 276, 1, true);
#line 12 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
WriteAttributeValue("", 277, Constants.LinkFactory.DinhMucXCG, 277, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 310, "/", 310, 1, true);
#line 12 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
WriteAttributeValue("", 311, Constants.LinkFactory.Create, 311, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(341, 79, true);
            WriteLiteral("><i class=\"icon-add-to-list mr-1\"></i> Nhập số liệu</a>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(420, 935, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab57a0c35d1e4b399d6b1a322fcfe0df", async() => {
                BeginContext(526, 149, true);
                WriteLiteral("\r\n    <div class=\"form-row mb-3\">\r\n        <div class=\"col-md-6 col-xs-12\">\r\n            <label class=\"control-label\">Công đoạn</label>\r\n            ");
                EndContext();
                BeginContext(675, 369, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83738d47f6c43bb889ab1f634676d17", async() => {
                    BeginContext(757, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(775, 32, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "724dce60e8b64499b70b20619e9ce97a", async() => {
                        BeginContext(792, 6, true);
                        WriteLiteral("Tất cả");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(807, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 22 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                  
                    foreach (var item in Model.Stages)
                    {

#line default
#line hidden
                    BeginContext(908, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(932, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2749579a722d4430924da0f95c875534", async() => {
                        BeginContext(961, 9, false);
#line 25 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                                               Write(item.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 25 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                           WriteLiteral(item.Alias);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(979, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 26 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                    }
                

#line default
#line hidden
                    BeginContext(1023, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 20 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cd);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1044, 304, true);
                WriteLiteral(@"
        </div>
        <div class=""col-md-6 col-xs-12"">
            <label class=""control-label""><small>Bấm nút hoặc Enter</small></label>
            <button class=""btn btn-lg btn-info form-control"" type=""submit""><i class=""icon-magnifying-glass""></i> Tìm kiếm</button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 447, "/", 447, 1, true);
#line 16 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
AddHtmlAttributeValue("", 448, Constants.LinkFactory.Main, 448, 27, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 475, "/", 475, 1, true);
#line 16 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
AddHtmlAttributeValue("", 476, Constants.LinkFactory.DinhMucXCG, 476, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1355, 1554, true);
            WriteLiteral(@"

<div class=""table-responsive"">
    <table class=""table table-sm table-bordered table-striped table-hover"">
        <thead>
            <tr>
                <th></th>
                <th></th>
                <th colspan=""4"">Điểm công đoạn vận hành</th>
                <th colspan=""4"">Điểm Năng suất /1h</th>
                <th colspan=""6"">Chi phí</th>
            </tr>
            <tr>
                <th></th>
                <th>Công đoạn</th>
                <th>
                    Xe cuốc
                </th>
                <th>
                    Xe ben
                </th>
                <th>
                    Xe ủi
                </th>
                <th>
                    Xe xúc
                </th>
                <th>
                    Xe cuốc
                </th>
                <th>
                    Xe ben
                </th>
                <th>
                    Xe ủi
                </th>
                <th>
                    Xe x");
            WriteLiteral(@"úc
                </th>
                <th>
                    Xe cuốc 07
                </th>
                <th>
                    Xe cuốc 05
                </th>
                <th>
                    Xe cuốc 03
                </th>
                <th>
                    Xe ben
                </th>
                <th>
                    Xe ủi
                </th>
                <th>
                    Xe xúc
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 95 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
             foreach (var item in Model.List)
            {

#line default
#line hidden
            BeginContext(2971, 77, true);
            WriteLiteral("                <tr>\r\n                    <td></td>\r\n                    <td>");
            EndContext();
            BeginContext(3049, 13, false);
#line 99 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(item.CongDoan);

#line default
#line hidden
            EndContext();
            BeginContext(3062, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3094, 66, false);
#line 100 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemCongDoanVanHanh.XeCuoc));

#line default
#line hidden
            EndContext();
            BeginContext(3160, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3192, 65, false);
#line 101 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemCongDoanVanHanh.XeBen));

#line default
#line hidden
            EndContext();
            BeginContext(3257, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3289, 64, false);
#line 102 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemCongDoanVanHanh.XeUi));

#line default
#line hidden
            EndContext();
            BeginContext(3353, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3385, 65, false);
#line 103 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemCongDoanVanHanh.XeXuc));

#line default
#line hidden
            EndContext();
            BeginContext(3450, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3482, 61, false);
#line 104 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemNangSuan1h.XeCuoc));

#line default
#line hidden
            EndContext();
            BeginContext(3543, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3575, 60, false);
#line 105 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemNangSuan1h.XeBen));

#line default
#line hidden
            EndContext();
            BeginContext(3635, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3667, 59, false);
#line 106 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemNangSuan1h.XeUi));

#line default
#line hidden
            EndContext();
            BeginContext(3726, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3758, 60, false);
#line 107 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###.##}", item.DiemNangSuan1h.XeXuc));

#line default
#line hidden
            EndContext();
            BeginContext(3818, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3850, 59, false);
#line 108 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###}", item.DinhMucChiPhi.XeCuoc07));

#line default
#line hidden
            EndContext();
            BeginContext(3909, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3941, 59, false);
#line 109 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###}", item.DinhMucChiPhi.XeCuoc05));

#line default
#line hidden
            EndContext();
            BeginContext(4000, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4032, 59, false);
#line 110 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###}", item.DinhMucChiPhi.XeCuoc03));

#line default
#line hidden
            EndContext();
            BeginContext(4091, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4123, 56, false);
#line 111 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###}", item.DinhMucChiPhi.XeBen));

#line default
#line hidden
            EndContext();
            BeginContext(4179, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4211, 55, false);
#line 112 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###}", item.DinhMucChiPhi.XeUi));

#line default
#line hidden
            EndContext();
            BeginContext(4266, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4298, 56, false);
#line 113 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
                   Write(String.Format("{0:#,###,###}", item.DinhMucChiPhi.XeXuc));

#line default
#line hidden
            EndContext();
            BeginContext(4354, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 115 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
            }

#line default
#line hidden
            BeginContext(4399, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4459, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4465, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a20cb14152c471680f18968c8c64642", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4501, "~/js/factory-dinh-muc-xcg.js?", 4501, 29, true);
#line 121 "C:\Projects\Tribat\sourcecode\erp\Views\Factory\DinhMucXCG.cshtml"
AddHtmlAttributeValue("", 4530, DateTime.Now.Ticks, 4530, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4560, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DinhMucViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
