#pragma checksum "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3602eec47eb97a78b7ee895843591ebc6cd68f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factory_ReportXCG), @"mvc.1.0.view", @"/Views/Factory/ReportXCG.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factory/ReportXCG.cshtml", typeof(AspNetCore.Views_Factory_ReportXCG))]
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
#line 1 "D:\projects\sgx\erp\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#line 1 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
using Common.Utilities;

#line default
#line hidden
#line 2 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3602eec47eb97a78b7ee895843591ebc6cd68f4", @"/Views/Factory/ReportXCG.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Factory_ReportXCG : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VanHanhViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hidedatepicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-lg js-select2-basic-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
  
    ViewData["Title"] = "Báo cáo xe cơ giới";

#line default
#line hidden
            BeginContext(128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 2656, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40751e6a99a648949c9fc27140695d83", async() => {
                BeginContext(230, 140, true);
                WriteLiteral("\r\n    <div class=\"form-row mb-3\">\r\n        <div class=\"col-md-3 col-xs-12 date-area\">\r\n            <label class=\"control-label\">Từ</label>\r\n");
                EndContext();
#line 13 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
              
                if (Model.From.HasValue)
                {

#line default
#line hidden
                BeginContext(447, 88, true);
                WriteLiteral("                    <input class=\"form-control form-control-lg datepicker datepicker-lg\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 535, "\"", 583, 1);
#line 16 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
WriteAttributeValue("", 543, Model.From.Value.ToString("dd/MM/yyyy"), 543, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(584, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 17 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(649, 93, true);
                WriteLiteral("                    <input class=\"form-control form-control-lg datepicker datepicker-lg\" />\r\n");
                EndContext();
#line 21 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                }
            

#line default
#line hidden
                BeginContext(776, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(788, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e29cae25fc1a4fb1bd5de54ef03681f8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 23 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.From);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(849, 124, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3 col-xs-12 date-area\">\r\n            <label class=\"control-label\">Đến</label>\r\n");
                EndContext();
#line 27 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
              
                if (Model.To.HasValue)
                {

#line default
#line hidden
                BeginContext(1048, 88, true);
                WriteLiteral("                    <input class=\"form-control form-control-lg datepicker datepicker-lg\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1182, 1);
#line 30 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
WriteAttributeValue("", 1144, Model.To.Value.ToString("dd/MM/yyyy"), 1144, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1183, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 31 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1248, 93, true);
                WriteLiteral("                    <input class=\"form-control form-control-lg datepicker datepicker-lg\" />\r\n");
                EndContext();
#line 35 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                }
            

#line default
#line hidden
                BeginContext(1375, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1387, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6f4611d5f884e46972edc230aa38e9a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 37 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.To);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1446, 138, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6 col-xs-12 \">\r\n            <label class=\"control-label\">Mảng công việc</label>\r\n            ");
                EndContext();
                BeginContext(1584, 345, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9604b8348e844104a8dbba95b0cd082b", async() => {
                    BeginContext(1642, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(1660, 32, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009c6491b0a2497d9617f1ba71238423", async() => {
                        BeginContext(1677, 6, true);
                        WriteLiteral("Tất cả");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1692, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 43 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                  
                    foreach (var item in Model.Stages)
                    {

#line default
#line hidden
                    BeginContext(1793, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(1817, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "006e488bfd09499b9f79dfdec56127cf", async() => {
                        BeginContext(1846, 9, false);
#line 46 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                                               Write(item.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 46 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
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
                    BeginContext(1864, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 47 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                    }
                

#line default
#line hidden
                    BeginContext(1908, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 41 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Cv);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1929, 142, true);
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-6 col-xs-12 \">\r\n            <label class=\"control-label\">Xe cơ giới/máy</label>\r\n            ");
                EndContext();
                BeginContext(2071, 371, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9d19bf6440426e865b9d059d713781", async() => {
                    BeginContext(2153, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(2171, 32, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd241b90b992489fb6db6548dc4ef807", async() => {
                        BeginContext(2188, 6, true);
                        WriteLiteral("Tất cả");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2203, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 57 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                  
                    foreach (var item in Model.Vehicles)
                    {

#line default
#line hidden
                    BeginContext(2306, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(2330, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "687c3a60c0e84dbb9b857191a66a043f", async() => {
                        BeginContext(2359, 9, false);
#line 60 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                                               Write(item.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 60 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
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
                    BeginContext(2377, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 61 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                    }
                

#line default
#line hidden
                    BeginContext(2421, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 55 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Xm);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2442, 337, true);
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-row mb-3"">
        <div class=""col-12"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 157, "/", 157, 1, true);
#line 9 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
AddHtmlAttributeValue("", 158, Constants.LinkFactory.XCG, 158, 26, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 184, "/", 184, 1, true);
#line 9 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
AddHtmlAttributeValue("", 185, Constants.ActionLink.Report, 185, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2786, 1207, true);
            WriteLiteral(@"

<p><small><span class=""badge badge-light"">Ghi chú:</span> Thời gian tính theo giờ:phút.</small></p>
<div class=""table-responsive"">
    <table class=""table table-sm table-bordered table-striped table-hover"">
        <thead>
            <tr>
                <th></th>
                <th>
                    Xe cơ giới/Máy
                </th>
                <th>
                    Công đoạn
                </th>
                <th>
                    Thời gian bắt đầu
                </th>
                <th>
                    Thời gian kết thúc
                </th>
                <th>
                    Thời gian BTTQ
                </th>
                <th>
                    Thời gian xe hư
                </th>
                <th>
                    Thời gian làm việc
                </th>
                <th>
                    Số lượng thực hiện
                </th>
                <th>
                    Dầu
                </th>
                <th");
            WriteLiteral(">\r\n                    Nhớt 10\r\n                </th>\r\n                <th>\r\n                    Nhớt 50\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 116 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
              
                var groups = (from p in Model.FactoryVanHanhs
                              group p by new
                              {
                                  p.XeCoGioiMayName,
                                  p.CongDoanName,
                                  p.Start,
                                  p.End
                              }
                              into d
                              select new
                              {
                                  xeCoGioiMay = d.Key.XeCoGioiMayName,
                                  congDoan = d.Key.CongDoanName,
                                  start = d.Key.Start,
                                  end = d.Key.End,
                                  reports = d.ToList(),
                              }).ToList();

                var exists = new List<string>();
                foreach (var group in groups)
                {

#line default
#line hidden
            BeginContext(4952, 91, true);
            WriteLiteral("                    <tr>\r\n                        <td></td>\r\n                        <td>\r\n");
            EndContext();
#line 141 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                             if (!exists.Contains(group.xeCoGioiMay))
                            {
                                exists.Add(@group.xeCoGioiMay);

#line default
#line hidden
            BeginContext(5210, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(5249, 17, false);
#line 144 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                                 Write(group.xeCoGioiMay);

#line default
#line hidden
            EndContext();
            BeginContext(5266, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 145 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                            }

#line default
#line hidden
            BeginContext(5306, 89, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5396, 14, false);
#line 148 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(group.congDoan);

#line default
#line hidden
            EndContext();
            BeginContext(5410, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5502, 31, false);
#line 151 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(group.start.ToString(@"hh\:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(5533, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5625, 29, false);
#line 154 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(group.end.ToString(@"hh\:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(5654, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5746, 80, false);
#line 157 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(Constants.GetHHMMFromSecond(group.reports.Sum(x => x.ThoiGianBTTQ.TotalSeconds)));

#line default
#line hidden
            EndContext();
            BeginContext(5826, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5918, 80, false);
#line 160 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(Constants.GetHHMMFromSecond(group.reports.Sum(x => x.ThoiGianXeHu.TotalSeconds)));

#line default
#line hidden
            EndContext();
            BeginContext(5998, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6090, 83, false);
#line 163 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(Constants.GetHHMMFromSecond(group.reports.Sum(x => x.ThoiGianLamViec.TotalSeconds)));

#line default
#line hidden
            EndContext();
            BeginContext(6173, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6265, 76, false);
#line 166 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(String.Format("{0:#,###,###.##}", group.reports.Sum(x => x.SoLuongThucHien)));

#line default
#line hidden
            EndContext();
            BeginContext(6341, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6433, 64, false);
#line 169 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(String.Format("{0:#,###,###.##}", group.reports.Sum(x => x.Dau)));

#line default
#line hidden
            EndContext();
            BeginContext(6497, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6589, 67, false);
#line 172 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(String.Format("{0:#,###,###.##}", group.reports.Sum(x => x.Nhot10)));

#line default
#line hidden
            EndContext();
            BeginContext(6656, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(6748, 67, false);
#line 175 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                       Write(String.Format("{0:#,###,###.##}", group.reports.Sum(x => x.Nhot50)));

#line default
#line hidden
            EndContext();
            BeginContext(6815, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 178 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
                }
            

#line default
#line hidden
            BeginContext(6909, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6969, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6975, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5409c97adb374958b200cd76fb00081f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7011, "~/js/factory-van-hanh.js?", 7011, 25, true);
#line 185 "D:\projects\sgx\erp\Views\Factory\ReportXCG.cshtml"
AddHtmlAttributeValue("", 7036, DateTime.Now.Ticks, 7036, 19, false);

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
                BeginContext(7066, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VanHanhViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
