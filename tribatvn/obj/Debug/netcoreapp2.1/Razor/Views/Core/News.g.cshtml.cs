#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c0a16fa7818d1ebdf1fc181e502ae493b65b06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Core_News), @"mvc.1.0.view", @"/Views/Core/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Core/News.cshtml", typeof(AspNetCore.Views_Core_News))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c0a16fa7818d1ebdf1fc181e502ae493b65b06", @"/Views/Core/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Core_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewsCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
  
    Layout = "~/Views/Shared/_Core.cshtml";

#line default
#line hidden
            BeginContext(87, 900, true);
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
            BeginContext(988, 17, false);
#line 29 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1005, 365, true);
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
            BeginContext(1370, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f724d0235464af6a37cbdb1d73537a5", async() => {
                BeginContext(1397, 10, true);
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
            BeginContext(1411, 354, true);
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
            BeginContext(1765, 574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef135302731b4a35887add082209ae5d", async() => {
                BeginContext(1805, 192, true);
                WriteLiteral("\r\n                            <span class=\"mr-2 text-muted text-small text-nowrap\">Sort by:</span>\r\n                            <select class=\"custom-select\">\r\n                                ");
                EndContext();
                BeginContext(1997, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df580b3402cf41eab46116ff23e96f84", async() => {
                    BeginContext(2019, 12, true);
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
                BeginContext(2040, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2074, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7d455288c64f5685ffba3a69b61b60", async() => {
                    BeginContext(2107, 6, true);
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
                BeginContext(2122, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2156, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9befcb857f974768baaa3aab7551e03e", async() => {
                    BeginContext(2180, 6, true);
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
                BeginContext(2195, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2229, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dda25f82acc4b61b5220c951c7c0c14", async() => {
                    BeginContext(2252, 6, true);
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
                BeginContext(2267, 65, true);
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
            BeginContext(2339, 505, true);
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
            BeginContext(2845, 40, false);
#line 71 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2885, 127, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th scope=\"col\">\r\n                                    ");
            EndContext();
            BeginContext(3013, 47, false);
#line 74 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3060, 198, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th scope=\"col\"></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 80 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(3347, 196, true);
            WriteLiteral("                                <tr class=\"bg-white\">\r\n                                    <th scope=\"row\">\r\n                                        <a class=\"media align-items-center\" href=\"#\">\r\n");
            EndContext();
#line 85 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                             if (item.Images != null && item.Images.Count > 0)
                                            {

#line default
#line hidden
            BeginContext(3686, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(3734, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1126c870ca094ab68a543412c7e464d8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3777, "~/", 3777, 2, true);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
AddHtmlAttributeValue("", 3779, item.Images[0].Path, 3779, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3799, "/", 3799, 1, true);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
AddHtmlAttributeValue("", 3800, item.Images[0].FileName, 3800, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
AddHtmlAttributeValue("", 3831, item.Name, 3831, 10, false);

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
            BeginContext(3845, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3991, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(4039, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "080b39b133ca4daf9e93c3e43ce112a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 91 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
AddHtmlAttributeValue("", 4118, item.Name, 4118, 10, false);

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
            BeginContext(4132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 92 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4181, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4316, 146, true);
            WriteLiteral("\r\n                                            <div class=\"media-body\">\r\n                                                <span class=\"h6 mb-0\">Mã: ");
            EndContext();
            BeginContext(4463, 39, false);
#line 95 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(4502, 322, true);
            WriteLiteral(@"</span>
                                                <span class=""text-muted"">Đất sạch</span>
                                            </div>
                                        </a>
                                    </th>
                                    <td>
                                        ");
            EndContext();
            BeginContext(4825, 39, false);
#line 101 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4864, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4992, 46, false);
#line 104 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5038, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
            BeginContext(5305, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5388, 57, false);
#line 110 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                                   Write(Html.ActionLink("Edit", "NewsEdit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(5445, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5687, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(6881, 147, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n                                <tr class=\"table-divider\"></tr>\r\n");
            EndContext();
#line 129 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\News.cshtml"
                            }

#line default
#line hidden
            BeginContext(7059, 276, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
