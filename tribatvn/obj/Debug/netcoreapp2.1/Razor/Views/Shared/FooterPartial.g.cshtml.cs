#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da011f4917eb1ae11626597eb058207e4f5fb1ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/FooterPartial.cshtml", typeof(AspNetCore.Views_Shared_FooterPartial))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
using Helpers;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da011f4917eb1ae11626597eb058207e4f5fb1ae", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Tribat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/saigonxanhtrans.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
  
    var language = ViewData["Language"].ToString();
    var about = Model.MenusContent.Where(m => m.Code.Equals("about")).First();
    var news = Model.MenusContent.Where(m => m.Code.Equals("news")).First();
    var contact = Model.MenusContent.Where(m => m.Code.Equals("contact")).First();

#line default
#line hidden
            BeginContext(362, 150, true);
            WriteLiteral("\r\n<footer class=\"bg-gray text-light footer-long\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-md-4\">\r\n");
            EndContext();
            BeginContext(606, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(622, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "957be0e724f2499d942d4ccdf2910c21", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(690, 108, true);
            WriteLiteral("\r\n                <p class=\"text-muted\">\r\n                    &copy; 2018 Tribat\r\n                    <br />");
            EndContext();
            BeginContext(799, 43, false);
#line 19 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                     Write(Html.Raw(TextHelper.GetText(521, language)));

#line default
#line hidden
            EndContext();
            BeginContext(842, 28, true);
            WriteLiteral("\r\n                    <br />");
            EndContext();
            BeginContext(871, 43, false);
#line 20 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                     Write(Html.Raw(TextHelper.GetText(522, language)));

#line default
#line hidden
            EndContext();
            BeginContext(914, 28, true);
            WriteLiteral("\r\n                    <br />");
            EndContext();
            BeginContext(943, 43, false);
#line 21 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                     Write(Html.Raw(TextHelper.GetText(523, language)));

#line default
#line hidden
            EndContext();
            BeginContext(986, 362, true);
            WriteLiteral(@" <a href=""tel:02839971869"" class=""hotline"">(028)-39971869</a> − <a href=""tel:02838442457"" class=""hotline"">(028)-38442457</a>
                    <br />Fax: 08-39971869
                    <br />MST: 0302519810
                </p>
            </div>
            <!--end of col-->
            <div class=""col-12 col-md-8"">
                <span class=""h5"">");
            EndContext();
            BeginContext(1349, 43, false);
#line 28 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                            Write(Html.Raw(TextHelper.GetText(520, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 133, true);
            WriteLiteral("</span>\r\n                <div class=\"row no-gutters\">\r\n                    <div class=\"col-6 col-lg-3\">\r\n                        <h6>");
            EndContext();
            BeginContext(1526, 43, false);
#line 31 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                       Write(Html.Raw(TextHelper.GetText(524, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 137, true);
            WriteLiteral("</h6>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <a href=\"/\">");
            EndContext();
            BeginContext(1707, 43, false);
#line 34 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                       Write(Html.Raw(TextHelper.GetText(525, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 109, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1859, "\"", 1881, 2);
            WriteAttributeValue("", 1866, "/c/", 1866, 3, true);
#line 37 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
WriteAttributeValue("", 1869, contact.Url, 1869, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1882, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1884, 13, false);
#line 37 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                                     Write(contact.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1897, 234, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"/faq\">FAQ</a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2131, "\"", 2150, 2);
            WriteAttributeValue("", 2138, "/n/", 2138, 3, true);
#line 43 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
WriteAttributeValue("", 2141, news.Url, 2141, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2151, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2153, 10, false);
#line 43 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                                  Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 217, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    <!--end of col-->\r\n                    <div class=\"col-6 col-lg-3\">\r\n                        <h6>");
            EndContext();
            BeginContext(2381, 43, false);
#line 49 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                       Write(Html.Raw(TextHelper.GetText(501, language)));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 59, true);
            WriteLiteral("</h6>\r\n                        <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 51 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                             foreach (var menu in Model.MenusProduct)
                            {

#line default
#line hidden
            BeginContext(2585, 68, true);
            WriteLiteral("                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2653, "\"", 2669, 1);
#line 54 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
WriteAttributeValue("", 2660, menu.Url, 2660, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2670, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2672, 10, false);
#line 54 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                               Write(menu.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 56 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(2754, 176, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <!--end of col-->\r\n                    <div class=\"col-6 col-lg-3\">\r\n                        <h6>");
            EndContext();
            BeginContext(2931, 43, false);
#line 61 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                       Write(Html.Raw(TextHelper.GetText(506, language)));

#line default
#line hidden
            EndContext();
            BeginContext(2974, 59, true);
            WriteLiteral("</h6>\r\n                        <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 63 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                             foreach (var menu in Model.MenusProccess)
                            {

#line default
#line hidden
            BeginContext(3136, 68, true);
            WriteLiteral("                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3204, "\"", 3220, 1);
#line 66 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
WriteAttributeValue("", 3211, menu.Url, 3211, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3221, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3223, 10, false);
#line 66 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                               Write(menu.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3233, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 68 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(3305, 176, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <!--end of col-->\r\n                    <div class=\"col-6 col-lg-3\">\r\n                        <h6>");
            EndContext();
            BeginContext(3482, 43, false);
#line 73 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                       Write(Html.Raw(TextHelper.GetText(527, language)));

#line default
#line hidden
            EndContext();
            BeginContext(3525, 127, true);
            WriteLiteral("</h6>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3652, "\"", 3672, 2);
            WriteAttributeValue("", 3659, "/a/", 3659, 3, true);
#line 76 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
WriteAttributeValue("", 3662, about.Url, 3662, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3673, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3675, 11, false);
#line 76 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                                   Write(about.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3686, 119, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"/\">");
            EndContext();
            BeginContext(3806, 43, false);
#line 79 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                       Write(Html.Raw(TextHelper.GetText(528, language)));

#line default
#line hidden
            EndContext();
            BeginContext(3849, 119, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                            <li>\r\n                                <a href=\"/\">");
            EndContext();
            BeginContext(3969, 43, false);
#line 82 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterPartial.cshtml"
                                       Write(Html.Raw(TextHelper.GetText(529, language)));

#line default
#line hidden
            EndContext();
            BeginContext(4012, 342, true);
            WriteLiteral(@"</a>
                            </li>
                        </ul>
                    </div>
                    <!--end of col-->
                </div>
                <!--end of row-->
            </div>
            <!--end of col-->
        </div>
        <!--end of row-->
    </div>
    <!--end of container-->
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
