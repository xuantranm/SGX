#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0a7c56422ba70cffef3dde1f3e84aa875e46ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Category.cshtml", typeof(AspNetCore.Views_Home_Category))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
using Common.Utilities;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
using Helpers;

#line default
#line hidden
#line 3 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0a7c56422ba70cffef3dde1f3e84aa875e46ae", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top card-img-top-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1449046872no-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
  
    Layout = "~/Views/Shared/_Wingman.cshtml";
    var language = ViewData["Language"].ToString();

#line default
#line hidden
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(203, 50, false);
#line 11 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
Write(await Html.PartialAsync("MenuPartial", Model.Menu));

#line default
#line hidden
            EndContext();
            BeginContext(253, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 13 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
 if (Model.Entities != null && Model.Entities.Count > 0)
{

#line default
#line hidden
            BeginContext(318, 34, true);
            WriteLiteral("    <div class=\"main-container\">\r\n");
            EndContext();
            BeginContext(1706, 374, true);
            WriteLiteral(@"
        <nav aria-label=""breadcrumb"" role=""navigation"" class=""bg-primary text-white"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item"">
                                <a href=""/"">");
            EndContext();
            BeginContext(2081, 43, false);
#line 44 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                       Write(Html.Raw(TextHelper.GetText(525, language)));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 124, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(2249, 17, false);
#line 46 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                                                              Write(Model.Entity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2266, 331, true);
            WriteLiteral(@"</li>
                        </ol>
                    </div>
                    <!--end of col-->
                </div>
                <!--end of row-->
            </div>
            <!--end of container-->
        </nav>


        <section class=""space-sm flush-with-above"">
            <div class=""container"">
");
            EndContext();
            BeginContext(3593, 100, true);
            WriteLiteral("                <!--end of row-->\r\n\r\n                <ul class=\"row feature-list feature-list-sm\">\r\n");
            EndContext();
#line 78 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                     foreach (var entity in Model.Entities)
                    {
                        var link = "/" + Constants.Link.Product + "/" + ViewData["Category"] + "/" + @entity.Alias;
                        

#line default
#line hidden
            BeginContext(3918, 189, true);
            WriteLiteral("<li class=\"col-12 col-md-6 col-lg-4\">\r\n                            <div class=\"card card-lg\">\r\n                                <div class=\"card-img\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4107, "\"", 4119, 1);
#line 84 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
WriteAttributeValue("", 4114, link, 4114, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4120, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 85 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                         if (entity.Images != null && entity.Images.Count > 0)
                                        {

#line default
#line hidden
            BeginContext(4262, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4306, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5acd74d2374841ab8bf11fe4968dba8d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4357, "~/", 4357, 2, true);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
AddHtmlAttributeValue("", 4359, entity.Images[0].Path, 4359, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4381, "/", 4381, 1, true);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
AddHtmlAttributeValue("", 4382, entity.Images[0].FileName, 4382, 26, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 87 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
AddHtmlAttributeValue("", 4415, entity.Name, 4415, 12, false);

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
            BeginContext(4431, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(4565, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4609, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fca0c4e4ff940a1b61d872557353547", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 91 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
AddHtmlAttributeValue("", 4696, entity.Name, 4696, 12, false);

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
            BeginContext(4712, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 92 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4757, 179, true);
            WriteLiteral("                                    </a>\r\n                                </div>\r\n\r\n                                <div class=\"card-body\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4936, "\"", 4948, 1);
#line 97 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
WriteAttributeValue("", 4943, link, 4943, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4949, 71, true);
            WriteLiteral(">\r\n                                        <h4 class=\"card-title mb-3\">");
            EndContext();
            BeginContext(5021, 11, false);
#line 98 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                                               Write(entity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5032, 106, true);
            WriteLiteral("</h4>\r\n                                    </a>\r\n                                    <p class=\"card-text\">");
            EndContext();
            BeginContext(5139, 18, false);
#line 100 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                                    Write(entity.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5157, 1784, true);
            WriteLiteral(@"</p>
                                </div>
                                <div class=""card-footer card-footer-borderless d-flex justify-content-between"">
                                    <div class=""text-small"">
                                        <ul class=""list-inline"">
                                            <li class=""list-inline-item""><i class=""icon-heart""></i> 221</li>
                                            <li class=""list-inline-item""><i class=""icon-message""></i> 14</li>
                                        </ul>
                                    </div>
                                    <div class=""dropup"">
                                        <button class=""btn btn-sm btn-outline-primary dropdown-toggle dropdown-toggle-no-arrow"" type=""button"" id=""SidekickButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""icon-dots-three-horizontal""></i>
                                        </button>");
            WriteLiteral(@"
                                        <div class=""dropdown-menu dropdown-menu-sm"" aria-labelledby=""SidekickButton"">
                                            <a class=""dropdown-item"" href=""#"">Save</a>
                                            <a class=""dropdown-item"" href=""#"">Share</a>
                                            <a class=""dropdown-item"" href=""#"">Comment</a>
                                            <div class=""dropdown-divider""></div>
                                            <a class=""dropdown-item"" href=""#"">Report</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
");
            EndContext();
#line 124 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                    }

#line default
#line hidden
            BeginContext(6964, 2303, true);
            WriteLiteral(@"                </ul>
                <!--end of row-->
                <div class=""row justify-content-center display-none"">
                    <div class=""col-auto"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination"">
                                <li class=""page-item disabled"">
                                    <a class=""page-link"" href=""#"" aria-label=""Previous"">
                                        <span aria-hidden=""true"">
                                            <i class=""icon-chevron-left""></i>
                                        </span>
                                        <span class=""sr-only"">Previous</span>
                                    </a>
                                </li>
                                <li class=""page-item active"">
                                    <a class=""page-link"" href=""#"">1</a>
                                </li>
                                <li class=""pa");
            WriteLiteral(@"ge-item"">
                                    <a class=""page-link"" href=""#"">2</a>
                                </li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">3</a>
                                </li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"" aria-label=""Next"">
                                        <span aria-hidden=""true"">
                                            <i class=""icon-chevron-right""></i>
                                        </span>
                                        <span class=""sr-only"">Next</span>
                                    </a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                    <!--end of col-->
                </div>
                <!--end of row-->
            </div>
            <!--end of con");
            WriteLiteral("tainer-->\r\n        </section>\r\n        <!--end of section-->\r\n\r\n        <section class=\"space-sm\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <div class=\"mb-3\">\r\n");
            EndContext();
#line 172 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                             foreach (var keyword in Model.Entity.KeyWords.Split(","))
                            {

#line default
#line hidden
            BeginContext(9386, 75, true);
            WriteLiteral("                                <a href=\"#\" class=\"btn btn-secondary mb-1\">");
            EndContext();
            BeginContext(9462, 7, false);
#line 174 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                                                      Write(keyword);

#line default
#line hidden
            EndContext();
            BeginContext(9469, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 175 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                            }

#line default
#line hidden
            BeginContext(9506, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
            BeginContext(9634, 215, true);
            WriteLiteral("                    </div>\r\n                    <!--end of col-->\r\n                </div>\r\n                <!--end of row-->\r\n            </div>\r\n            <!--end of container-->\r\n        </section>\r\n    </div>\r\n");
            EndContext();
            BeginContext(9851, 61, true);
            WriteLiteral("    <div class=\"link-languages display-none\">\r\n        <ul>\r\n");
            EndContext();
#line 189 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
             foreach (var link in Model.Links)
            {

#line default
#line hidden
            BeginContext(9975, 32, true);
            WriteLiteral("                <li data-value=\"");
            EndContext();
            BeginContext(10008, 8, false);
#line 191 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                           Write(link.Url);

#line default
#line hidden
            EndContext();
            BeginContext(10016, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 10017, "\"", 10039, 1);
#line 191 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
WriteAttributeValue("", 10025, link.Language, 10025, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10040, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(10042, 8, false);
#line 191 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                                             Write(link.Url);

#line default
#line hidden
            EndContext();
            BeginContext(10050, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 192 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
            }

#line default
#line hidden
            BeginContext(10072, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 195 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
}
else
{
    

#line default
#line hidden
            BeginContext(10116, 40, false);
#line 198 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
Write(await Html.PartialAsync("UpdatePartial"));

#line default
#line hidden
            EndContext();
#line 198 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
                                             
}

#line default
#line hidden
            BeginContext(10161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10164, 52, false);
#line 201 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Category.cshtml"
Write(await Html.PartialAsync("FooterPartial", Model.Menu));

#line default
#line hidden
            EndContext();
            BeginContext(10216, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
