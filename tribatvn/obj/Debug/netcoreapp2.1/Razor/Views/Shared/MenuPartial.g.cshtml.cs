#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aec512bf5e75bb3045df30ec20f02d35e7dd8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MenuPartial), @"mvc.1.0.view", @"/Views/Shared/MenuPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MenuPartial.cshtml", typeof(AspNetCore.Views_Shared_MenuPartial))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
using Helpers;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aec512bf5e75bb3045df30ec20f02d35e7dd8a7", @"/Views/Shared/MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("tribat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/en.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("English"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/vi.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Tiếng Việt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
  
    var language = ViewData["Language"].ToString();

#line default
#line hidden
            BeginContext(120, 225, true);
            WriteLiteral("\r\n<div class=\"nav-container\">\r\n    <div class=\"bg-white navbar-light\" data-sticky=\"top\">\r\n        <div class=\"container\">\r\n            <nav class=\"navbar navbar-expand-lg\">\r\n                <a class=\"navbar-brand\" href=\"/\">\r\n");
            EndContext();
            BeginContext(431, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(451, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22128e6a15d44df7be952d05bcc4d469", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(495, 616, true);
            WriteLiteral(@"
                </a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <i class=""icon-menu h4""></i>
                </button>
                <div class=""collapse navbar-collapse justify-content-between"" id=""navbarNav"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""pagesDropdown"" role=""button"" data-toggle=""dropdown"">");
            EndContext();
            BeginContext(1112, 43, false);
#line 22 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                                                                            Write(Html.Raw(TextHelper.GetText(501, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 95, true);
            WriteLiteral("</a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"pagesDropdown\">\r\n");
            EndContext();
#line 24 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                  
                                    var last = Model.MenusProduct.Last();
                                    foreach (var menu in Model.MenusProduct)
                                    {

#line default
#line hidden
            BeginContext(1478, 64, true);
            WriteLiteral("                                        <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1558, 1);
#line 28 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
WriteAttributeValue("", 1549, menu.Url, 1549, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1559, 69, true);
            WriteLiteral(">\r\n                                            <span class=\"h6 mb-0\">");
            EndContext();
            BeginContext(1629, 10, false);
#line 29 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                             Write(menu.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1639, 86, true);
            WriteLiteral("</span>\r\n                                            <p class=\"text-small text-muted\">");
            EndContext();
            BeginContext(1726, 16, false);
#line 30 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                        Write(menu.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 52, true);
            WriteLiteral("</p>\r\n                                        </a>\r\n");
            EndContext();
#line 32 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"

                                        if (!menu.Equals(last))
                                        {

#line default
#line hidden
            BeginContext(1904, 82, true);
            WriteLiteral("                                            <div class=\"dropdown-divider\"></div>\r\n");
            EndContext();
#line 36 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                        }
                                    } 

#line default
#line hidden
            BeginContext(2070, 252, true);
            WriteLiteral("                            </div>\r\n                        </li>\r\n                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"pagesDropdown\" role=\"button\" data-toggle=\"dropdown\">");
            EndContext();
            BeginContext(2323, 43, false);
#line 41 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                                                                            Write(Html.Raw(TextHelper.GetText(506, language)));

#line default
#line hidden
            EndContext();
            BeginContext(2366, 95, true);
            WriteLiteral("</a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"pagesDropdown\">\r\n");
            EndContext();
#line 43 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                  
                                    last = Model.MenusProccess.Last();
                                    foreach (var menu in Model.MenusProccess)
                                    {

#line default
#line hidden
            BeginContext(2687, 64, true);
            WriteLiteral("                                        <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2751, "\"", 2767, 1);
#line 47 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
WriteAttributeValue("", 2758, menu.Url, 2758, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2768, 69, true);
            WriteLiteral(">\r\n                                            <span class=\"h6 mb-0\">");
            EndContext();
            BeginContext(2838, 10, false);
#line 48 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                             Write(menu.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2848, 86, true);
            WriteLiteral("</span>\r\n                                            <p class=\"text-small text-muted\">");
            EndContext();
            BeginContext(2935, 16, false);
#line 49 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                        Write(menu.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2951, 52, true);
            WriteLiteral("</p>\r\n                                        </a>\r\n");
            EndContext();
#line 51 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                        if (!menu.Equals(last))
                                        {

#line default
#line hidden
            BeginContext(3111, 82, true);
            WriteLiteral("                                            <div class=\"dropdown-divider\"></div>\r\n");
            EndContext();
#line 54 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                        }
                                    } 

#line default
#line hidden
            BeginContext(3277, 252, true);
            WriteLiteral("                            </div>\r\n                        </li>\r\n                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"pagesDropdown\" role=\"button\" data-toggle=\"dropdown\">");
            EndContext();
            BeginContext(3530, 43, false);
#line 59 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                                                                            Write(Html.Raw(TextHelper.GetText(510, language)));

#line default
#line hidden
            EndContext();
            BeginContext(3573, 95, true);
            WriteLiteral("</a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"pagesDropdown\">\r\n");
            EndContext();
#line 61 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                  
                                    last = Model.MenusService.Last();
                                    foreach (var menu in Model.MenusService)
                                    {

#line default
#line hidden
            BeginContext(3892, 64, true);
            WriteLiteral("                                        <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3956, "\"", 3972, 1);
#line 65 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
WriteAttributeValue("", 3963, menu.Url, 3963, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3973, 69, true);
            WriteLiteral(">\r\n                                            <span class=\"h6 mb-0\">");
            EndContext();
            BeginContext(4043, 10, false);
#line 66 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                             Write(menu.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4053, 86, true);
            WriteLiteral("</span>\r\n                                            <p class=\"text-small text-muted\">");
            EndContext();
            BeginContext(4140, 16, false);
#line 67 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                        Write(menu.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4156, 52, true);
            WriteLiteral("</p>\r\n                                        </a>\r\n");
            EndContext();
#line 69 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                        if (!menu.Equals(last))
                                        {

#line default
#line hidden
            BeginContext(4316, 82, true);
            WriteLiteral("                                            <div class=\"dropdown-divider\"></div>\r\n");
            EndContext();
#line 72 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(4481, 67, true);
            WriteLiteral("                            </div>\r\n                        </li>\r\n");
            EndContext();
#line 76 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                          
                            var news = Model.MenusContent.Where(m => m.Code.Equals("news")).First();

#line default
#line hidden
            BeginContext(4678, 85, true);
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4763, "\"", 4782, 2);
            WriteAttributeValue("", 4770, "/n/", 4770, 3, true);
#line 79 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
WriteAttributeValue("", 4773, news.Url, 4773, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4783, 18, true);
            WriteLiteral(" class=\"nav-link\">");
            EndContext();
            BeginContext(4802, 10, false);
#line 79 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                   Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4812, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 81 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                            var contact = Model.MenusContent.Where(m => m.Code.Equals("contact")).First();

#line default
#line hidden
            BeginContext(4961, 85, true);
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5046, "\"", 5068, 2);
            WriteAttributeValue("", 5053, "/c/", 5053, 3, true);
#line 83 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
WriteAttributeValue("", 5056, contact.Url, 5056, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5069, 18, true);
            WriteLiteral(" class=\"nav-link\">");
            EndContext();
            BeginContext(5088, 13, false);
#line 83 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                      Write(contact.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5101, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 85 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                            var about = Model.MenusContent.Where(m => m.Code.Equals("about")).First();

#line default
#line hidden
            BeginContext(5246, 85, true);
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5331, "\"", 5351, 2);
            WriteAttributeValue("", 5338, "/a/", 5338, 3, true);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
WriteAttributeValue("", 5341, about.Url, 5341, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5352, 18, true);
            WriteLiteral(" class=\"nav-link\">");
            EndContext();
            BeginContext(5371, 11, false);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                    Write(about.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5382, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
            BeginContext(5450, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5824, 187, true);
            WriteLiteral("\r\n                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"pagesDropdown\" role=\"button\" data-toggle=\"dropdown\">");
            EndContext();
            BeginContext(6012, 43, false);
#line 97 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                                                                                            Write(Html.Raw(TextHelper.GetText(514, language)));

#line default
#line hidden
            EndContext();
            BeginContext(6055, 238, true);
            WriteLiteral("</a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"pagesDropdown\">\r\n                                <a class=\"dropdown-item\" target=\"_blank\" href=\"/2\">\r\n                                    <span class=\"h6 mb-0\">");
            EndContext();
            BeginContext(6294, 43, false);
#line 100 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                     Write(Html.Raw(TextHelper.GetText(514, language)));

#line default
#line hidden
            EndContext();
            BeginContext(6337, 262, true);
            WriteLiteral(@" 2</span>
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" target=""_blank"" href=""/3"">
                                    <span class=""h6 mb-0"">");
            EndContext();
            BeginContext(6600, 43, false);
#line 104 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                     Write(Html.Raw(TextHelper.GetText(514, language)));

#line default
#line hidden
            EndContext();
            BeginContext(6643, 333, true);
            WriteLiteral(@" 3</span>
                                </a>
                            </div>
                        </li>
                    </ul>

                    <ul class=""navbar-nav"">
                        <li class=""nav-item toplink"">
                            <a href=""tel:0942464745"" class=""hotline"">0942 46 47 45</a>
");
            EndContext();
            BeginContext(7037, 98, true);
            WriteLiteral("                        </li>\r\n                        <li class=\"nav-item toplink li-language\">\r\n");
            EndContext();
#line 116 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                             if (language == "vi-VN")
                            {

#line default
#line hidden
            BeginContext(7221, 109, true);
            WriteLiteral("                                <a href=\"javascript:;\" class=\"btn-language\" data-value=\"en-US\" alt=\"English\">");
            EndContext();
            BeginContext(7330, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb98864430924394bfc4cc8acb859eb3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7373, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 119 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7475, 112, true);
            WriteLiteral("                                <a href=\"javascript:;\" class=\"btn-language\" data-value=\"vi-VN\" alt=\"Tiếng Việt\">");
            EndContext();
            BeginContext(7587, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "926ded16e43f478fad2eb4a593654ab0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7633, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 123 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(7670, 1374, true);
            WriteLiteral(@"                        </li>
                    </ul>
                </div>
                <!--end nav collapse-->
            </nav>
        </div>
        <!--end of container-->
    </div>
</div>

<div class=""container"">
    <div class=""row d-sm-none menu-mobile"">
        <div class=""col"">
            <div class=""flex flex-column justify-center relative shadow-hover default hover-bg-white br2 hide-child"">
                <a href=""/"" class=""flex flex-column items-center justify-center color-inherit w-100 pa2 br2 br--top no-underline hover-bg-blue4 hover-white"">
                    <i class=""fab fa-product-hunt"" style=""font-size: 60px;""></i>
                </a>
                <div class=""w-100 ph1 pv2 tc f2"">
                    <span class=""db select-all gray5 hover-gray7 text"">product</span>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""flex flex-column justify-center relative shadow-hover default hover-bg-white br2 h");
            WriteLiteral(@"ide-child"">
                <a href=""/"" class=""flex flex-column items-center justify-center color-inherit w-100 pa2 br2 br--top no-underline hover-bg-blue4 hover-white"">
                    <i class=""fas fa-recycle text-center"" style=""font-size: 60px;""></i>
                </a>
                <span class=""db select-all gray5 hover-gray7 text"">");
            EndContext();
            BeginContext(9045, 43, false);
#line 151 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\MenuPartial.cshtml"
                                                              Write(Html.Raw(TextHelper.GetText(506, language)));

#line default
#line hidden
            EndContext();
            BeginContext(9088, 664, true);
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""col"">
            <div class=""flex flex-column justify-center relative shadow-hover default hover-bg-white br2 hide-child"">
                <a href=""/"" class=""flex flex-column items-center justify-center color-inherit w-100 pa2 br2 br--top no-underline hover-bg-blue4 hover-white"">
                    <i class=""fas fa-truck"" style=""font-size: 60px;""></i>
                </a>
                <div class=""w-100 ph1 pv2 tc f2"">
                    <span class=""db select-all gray5 hover-gray7 text"">SERVICES</span>
                </div>
            </div>
        </div>
    </div>
</div>");
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
