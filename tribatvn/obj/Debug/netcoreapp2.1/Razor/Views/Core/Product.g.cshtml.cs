#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3696d52fb8e1e7bab6919c0dfedcab70884ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Core_Product), @"mvc.1.0.view", @"/Views/Core/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Core/Product.cshtml", typeof(AspNetCore.Views_Core_Product))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3696d52fb8e1e7bab6919c0dfedcab70884ffa", @"/Views/Core/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Core_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.ProductSale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "alpha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "old-new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "new-old", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar rounded avatar-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1449046872no-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
  
    Layout = "~/Views/Shared/_Core.cshtml";

#line default
#line hidden
            BeginContext(96, 900, true);
            WriteLiteral(@"
<div class=""main-container"">
    <nav aria-label=""breadcrumb"" role=""navigation"" class=""bg-primary text-white"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">
                            <a href=""/core"">Home</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Collection Product</li>
                    </ol>
                </div>
                <!--end of col-->
            </div>
            <!--end of row-->
        </div>
        <!--end of container-->
    </nav>
    <section>
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col"">
                    <h1 class=""h2 mb-2"">");
            EndContext();
            BeginContext(997, 17, false);
#line 30 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 365, true);
            WriteLiteral(@"</h1>
                    <span>Description....</span>
                </div>
                <!--end of col-->
            </div>
            <!--end of row-->
        </div>
        <!--end of container-->
    </section>
    <!--end of section-->
    <section class=""flush-with-above"">
        <div class=""container"">
            <p>
                ");
            EndContext();
            BeginContext(1379, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d56625929d147a49a5b36bd37cf784a", async() => {
                BeginContext(1409, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1423, 354, true);
            WriteLiteral(@"
            </p>
            <div class=""row"">
                <div class=""col"">
                    <div class=""d-flex justify-content-between align-items-center mb-4"">
                        <div>
                            <span class=""text-muted text-small"">Results 1 - 8 of 8</span>
                        </div>
                        ");
            EndContext();
            BeginContext(1777, 574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bbec69e2ea749bea50a5de70ebc159e", async() => {
                BeginContext(1817, 192, true);
                WriteLiteral("\r\n                            <span class=\"mr-2 text-muted text-small text-nowrap\">Sort by:</span>\r\n                            <select class=\"custom-select\">\r\n                                ");
                EndContext();
                BeginContext(2009, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "243dd66785ad4709b66b32ffa8ff01b9", async() => {
                    BeginContext(2031, 12, true);
                    WriteLiteral("Alphabetical");
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
                BeginContext(2052, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2086, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c0fbf81212a44248460dea606d494b8", async() => {
                    BeginContext(2119, 6, true);
                    WriteLiteral("Newest");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                BeginContext(2134, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2168, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80e5f332fa2d47358e05991da9253cba", async() => {
                    BeginContext(2192, 6, true);
                    WriteLiteral("Oldest");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2207, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2241, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a3dcdd9f8a425cbeb25dd2f51e34be", async() => {
                    BeginContext(2264, 6, true);
                    WriteLiteral("Status");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2279, 65, true);
                WriteLiteral("\r\n                            </select>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2351, 505, true);
            WriteLiteral(@"
                    </div>
                </div>
                <!--end of col-->
            </div>
            <!--end of row-->
            <div class=""row"">
                <div class=""col"">
                    <table class=""table table-borderless table-hover align-items-center"">
                        <thead>
                            <tr>
                                <th scope=""col""></th>
                                <th scope=""col"">
                                    ");
            EndContext();
            BeginContext(2857, 40, false);
#line 72 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 127, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th scope=\"col\">\r\n                                    ");
            EndContext();
            BeginContext(3025, 47, false);
#line 75 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3072, 198, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th scope=\"col\"></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 81 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(3359, 196, true);
            WriteLiteral("                                <tr class=\"bg-white\">\r\n                                    <th scope=\"row\">\r\n                                        <a class=\"media align-items-center\" href=\"#\">\r\n");
            EndContext();
#line 86 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                             if (item.Images != null && item.Images.Count > 0)
                                            {

#line default
#line hidden
            BeginContext(3698, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(3746, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea73ff0943ce4ffaa4eec30e5a1ea61a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3789, "~/", 3789, 2, true);
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
AddHtmlAttributeValue("", 3791, item.Images[0].Path, 3791, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3811, "/", 3811, 1, true);
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
AddHtmlAttributeValue("", 3812, item.Images[0].FileName, 3812, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
AddHtmlAttributeValue("", 3843, item.Name, 3843, 10, false);

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
            BeginContext(3857, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 89 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4003, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(4051, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb2058b8d4174efd93c2aa7c3699835d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 92 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
AddHtmlAttributeValue("", 4130, item.Name, 4130, 10, false);

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
            BeginContext(4144, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4193, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4328, 146, true);
            WriteLiteral("\r\n                                            <div class=\"media-body\">\r\n                                                <span class=\"h6 mb-0\">Mã: ");
            EndContext();
            BeginContext(4475, 39, false);
#line 96 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(4514, 317, true);
            WriteLiteral(@"</span>
                                                <span class=""text-muted"">...</span>
                                            </div>
                                        </a>
                                    </th>
                                    <td>
                                        ");
            EndContext();
            BeginContext(4832, 39, false);
#line 102 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4871, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4999, 46, false);
#line 105 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5045, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
            BeginContext(5312, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5395, 64, false);
#line 111 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                   Write(Html.ActionLink("Edit", "ProductEdit", new { code = item.Code }));

#line default
#line hidden
            EndContext();
            BeginContext(5459, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(5504, 68, false);
#line 112 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                                   Write(Html.ActionLink("Delete", "ProductDelete", new { code = item.Code }));

#line default
#line hidden
            EndContext();
            BeginContext(5572, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5751, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6547, 147, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n                                <tr class=\"table-divider\"></tr>\r\n");
            EndContext();
#line 132 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Product.cshtml"
                            }

#line default
#line hidden
            BeginContext(6725, 276, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!--end of col-->
            </div>
            <!--end of row-->
        </div>
        <!--end of container-->
    </section>
    <!--end of section-->
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.ProductSale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
