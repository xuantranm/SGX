#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a815733c4123ffe93ac5cbc4514ffb8153775d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Core_Job), @"mvc.1.0.view", @"/Views/Core/Job.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Core/Job.cshtml", typeof(AspNetCore.Views_Core_Job))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a815733c4123ffe93ac5cbc4514ffb8153775d26", @"/Views/Core/Job.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Core_Job : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JobCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
  
    Layout = "~/Views/Shared/_Core.cshtml";

#line default
#line hidden
            BeginContext(88, 896, true);
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
                        <li class=""breadcrumb-item active"" aria-current=""page"">Collection Job</li>
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
            BeginContext(985, 17, false);
#line 30 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 365, true);
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
            BeginContext(1367, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5749c4818f48999a78f9f813aa37ca", async() => {
                BeginContext(1393, 10, true);
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
            BeginContext(1407, 354, true);
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
            BeginContext(1761, 574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b8ffc3dbb894f099a9bc621c04b91b1", async() => {
                BeginContext(1801, 192, true);
                WriteLiteral("\r\n                            <span class=\"mr-2 text-muted text-small text-nowrap\">Sort by:</span>\r\n                            <select class=\"custom-select\">\r\n                                ");
                EndContext();
                BeginContext(1993, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94260e300edd4e8cafb543646623f74e", async() => {
                    BeginContext(2015, 12, true);
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
                BeginContext(2036, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2070, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6eea61b05b44bb9dde2907bd59a689", async() => {
                    BeginContext(2103, 6, true);
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
                BeginContext(2118, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2152, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0771100aaaf43c68e120ca3fd50becb", async() => {
                    BeginContext(2176, 6, true);
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
                BeginContext(2191, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2225, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfe36dfb8114a15bcb4052f86fee5c5", async() => {
                    BeginContext(2248, 6, true);
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
                BeginContext(2263, 65, true);
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
            BeginContext(2335, 505, true);
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
            BeginContext(2841, 40, false);
#line 72 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2881, 127, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th scope=\"col\">\r\n                                    ");
            EndContext();
            BeginContext(3009, 47, false);
#line 75 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3056, 198, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th scope=\"col\"></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 81 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(3343, 196, true);
            WriteLiteral("                                <tr class=\"bg-white\">\r\n                                    <th scope=\"row\">\r\n                                        <a class=\"media align-items-center\" href=\"#\">\r\n");
            EndContext();
#line 86 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                             if (item.Images != null && item.Images.Count > 0)
                                            {

#line default
#line hidden
            BeginContext(3682, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(3730, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f38a11f18bc4d1f88d0965ed714b12c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3773, "~/", 3773, 2, true);
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
AddHtmlAttributeValue("", 3775, item.Images[0].Path, 3775, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3795, "/", 3795, 1, true);
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
AddHtmlAttributeValue("", 3796, item.Images[0].FileName, 3796, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
AddHtmlAttributeValue("", 3827, item.Name, 3827, 10, false);

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
            BeginContext(3841, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 89 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3987, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(4035, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b50839779ebc4ed794833ca4101f6c30", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 92 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
AddHtmlAttributeValue("", 4114, item.Name, 4114, 10, false);

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
            BeginContext(4128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4177, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4312, 146, true);
            WriteLiteral("\r\n                                            <div class=\"media-body\">\r\n                                                <span class=\"h6 mb-0\">Mã: ");
            EndContext();
            BeginContext(4459, 39, false);
#line 96 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(4498, 317, true);
            WriteLiteral(@"</span>
                                                <span class=""text-muted"">...</span>
                                            </div>
                                        </a>
                                    </th>
                                    <td>
                                        ");
            EndContext();
            BeginContext(4816, 39, false);
#line 102 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4855, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4983, 46, false);
#line 105 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5029, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
            BeginContext(5296, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5379, 56, false);
#line 111 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                   Write(Html.ActionLink("Edit", "JobEdit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(5435, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(5480, 60, false);
#line 112 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                                   Write(Html.ActionLink("Delete", "JobDelete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(5540, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5751, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6943, 147, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n                                <tr class=\"table-divider\"></tr>\r\n");
            EndContext();
#line 132 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Job.cshtml"
                            }

#line default
#line hidden
            BeginContext(7121, 276, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
