#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b4627f0335bebfd045e87646fae82e8ef23103b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterCanvasPartial), @"mvc.1.0.view", @"/Views/Shared/FooterCanvasPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/FooterCanvasPartial.cshtml", typeof(AspNetCore.Views_Shared_FooterCanvasPartial))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
using Helpers;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b4627f0335bebfd045e87646fae82e8ef23103b", @"/Views/Shared/FooterCanvasPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterCanvasPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Tribat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/saigonxanhtrans.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("footer-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("widget-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("include/subscribe.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nobottommargin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
  
    var language = ViewData["Language"].ToString();
    var about = Model.MenusContent.Where(m => m.Code.Equals("about")).First();
    var news = Model.MenusContent.Where(m => m.Code.Equals("news")).First();
    var contact = Model.MenusContent.Where(m => m.Code.Equals("contact")).First();

#line default
#line hidden
            BeginContext(362, 279, true);
            WriteLiteral(@"
    <footer id=""footer"" class=""dark"">
        <div class=""container"">
            <div class=""footer-widgets-wrap clearfix"">
                <div class=""col_two_third"">
                    <div class=""col_one_third"">
                        <div class=""widget clearfix"">
");
            EndContext();
            BeginContext(743, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(771, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45e01d4dbbec4d78b81ab99d63d24c75", async() => {
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
            BeginContext(846, 40, true);
            WriteLiteral("\r\n                            <p>&copy; ");
            EndContext();
            BeginContext(887, 17, false);
#line 19 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                 Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(904, 99, true);
            WriteLiteral(" <strong>Tribat</strong>, <strong>Sài Gòn Xanh</strong> &amp; <strong>Green Sai Gon</strong>.</p>\r\n");
            EndContext();
            BeginContext(1158, 233, true);
            WriteLiteral("                            <div style=\"background: url(\'/assets/canvas/images/world-map.png\') no-repeat center center; background-size: 100%;\">\r\n                                <address>\r\n                                    <strong>");
            EndContext();
            BeginContext(1392, 43, false);
#line 23 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                       Write(Html.Raw(TextHelper.GetText(521, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 52, true);
            WriteLiteral(":</strong><br>\r\n                                    ");
            EndContext();
            BeginContext(1488, 43, false);
#line 24 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                               Write(Html.Raw(TextHelper.GetText(522, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 87, true);
            WriteLiteral("<br>\r\n                                </address>\r\n                                <abbr");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1618, "\"", 1670, 1);
#line 26 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
WriteAttributeValue("", 1626, Html.Raw(TextHelper.GetText(523, language)), 1626, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1671, 47, true);
            WriteLiteral(">\r\n                                    <strong>");
            EndContext();
            BeginContext(1719, 43, false);
#line 27 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                       Write(Html.Raw(TextHelper.GetText(523, language)));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 368, true);
            WriteLiteral(@":</strong>
                                </abbr> <a href=""tel:02839971869"" class=""hotline"">(028)-39971869</a> − <a href=""tel:02838442457"" class=""hotline"">(028)-38442457</a><br>
                                <abbr title=""Fax""><strong>Fax:</strong></abbr> 08-39971869<br>
                                <abbr title=""Tax""><strong>MST:</strong></abbr> 0302519810
");
            EndContext();
            BeginContext(2272, 245, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col_one_third\">\r\n                        <div class=\"widget widget_links clearfix\">\r\n                            <h4>");
            EndContext();
            BeginContext(2518, 43, false);
#line 37 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                           Write(Html.Raw(TextHelper.GetText(524, language)));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 127, true);
            WriteLiteral("</h4>\r\n                            <ul>\r\n                                <li>\r\n                                    <a href=\"/\">");
            EndContext();
            BeginContext(2689, 43, false);
#line 40 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                           Write(Html.Raw(TextHelper.GetText(525, language)));

#line default
#line hidden
            EndContext();
            BeginContext(2732, 121, true);
            WriteLiteral("</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2853, "\"", 2875, 2);
            WriteAttributeValue("", 2860, "/c/", 2860, 3, true);
#line 43 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
WriteAttributeValue("", 2863, contact.Url, 2863, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2876, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2878, 13, false);
#line 43 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                                         Write(contact.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2891, 258, true);
            WriteLiteral(@"</a>
                                </li>
                                <li>
                                    <a href=""/faq"">FAQ</a>
                                </li>
                                <li>
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3149, "\"", 3168, 2);
            WriteAttributeValue("", 3156, "/n/", 3156, 3, true);
#line 49 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
WriteAttributeValue("", 3159, news.Url, 3159, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3169, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3171, 10, false);
#line 49 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                                      Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3181, 2420, true);
            WriteLiteral(@"</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col_one_third col_last"">
                        <div class=""widget clearfix"">
                            <h4>Recent Posts</h4>
                            <div id=""post-list-footer"">
                                <!--3 recent posts-->
                                <div class=""spost clearfix"">
                                    <div class=""entry-c"">
                                        <div class=""entry-title"">
                                            <h4><a href=""#"">Lorem ipsum dolor sit amet, consectetur</a></h4>
                                        </div>
                                        <ul class=""entry-meta"">
                                            <li>10th July 2014</li>
                                        </ul>
                                    </div>
                                </div");
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col_one_third col_last"">
                    <div class=""widget clearfix"" style=""margin-bottom: -20px;"">
                        <div class=""row"">
                            <div class=""col-lg-6 bottommargin-sm"">
                                <div class=""counter counter-small""><span data-from=""50"" data-to=""15065421"" data-refresh-interval=""80"" data-speed=""3000"" data-comma=""true""></span></div>
                                <h5 class=""nobottommargin"">Total Visitors</h5>
                            </div>
                            <div class=""col-lg-6 bottommargin-sm"">
                                <div class=""counter counter-small""><span data-from=""100"" data-to=""18465"" data-refresh-interval=""50"" data-speed=""2000"" data-comma=""true""></span></div>
                                <h5 class=""nobottommargin"">Clients</h5>
                            </");
            WriteLiteral(@"div>
                        </div>
                    </div>

                    <div class=""widget subscribe-widget clearfix"">
                        <h5><strong>Subscribe</strong> to Our Newsletter to get Important News, Amazing Offers &amp; Inside Scoops:</h5>
                        <div class=""widget-subscribe-form-result""></div>
                        ");
            EndContext();
            BeginContext(5601, 852, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba8f496f41ee4da89d504b225c792d85", async() => {
                BeginContext(5714, 732, true);
                WriteLiteral(@"
                            <div class=""input-group divcenter"">
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text""><i class=""icon-email2""></i></div>
                                </div>
                                <input type=""email"" id=""widget-subscribe-form-email"" name=""widget-subscribe-form-email"" class=""form-control required email"" placeholder=""Enter your Email"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-success"" type=""submit"">Subscribe</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6453, 1545, true);
            WriteLiteral(@"
                    </div>
                    <div class=""widget clearfix"" style=""margin-bottom: -20px;"">
                        <div class=""row"">
                            <div class=""col-lg-6 clearfix bottommargin-sm"">
                                <a href=""#"" class=""social-icon si-dark si-colored si-facebook nobottommargin"" style=""margin-right: 10px;"">
                                    <i class=""icon-facebook""></i>
                                    <i class=""icon-facebook""></i>
                                </a>
                                <a href=""#""><small style=""display: block; margin-top: 3px;""><strong>Like us</strong><br>on Facebook</small></a>
                            </div>
                            <div class=""col-lg-6 clearfix"">
                                <a href=""#"" class=""social-icon si-dark si-colored si-rss nobottommargin"" style=""margin-right: 10px;"">
                                    <i class=""icon-rss""></i>
                                    <i cla");
            WriteLiteral(@"ss=""icon-rss""></i>
                                </a>
                                <a href=""#""><small style=""display: block; margin-top: 3px;""><strong>Subscribe</strong><br>to RSS Feeds</small></a>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id=""copyrights"">
            <div class=""container clearfix"">
                <div class=""col_half"">
                    Copyrights &copy; ");
            EndContext();
            BeginContext(7999, 17, false);
#line 128 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Shared\FooterCanvasPartial.cshtml"
                                 Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(8016, 2778, true);
            WriteLiteral(@" All Rights Reserved by Tribat Ltd.<br>
                    <div class=""copyright-links""><a href=""#"">Terms of Use</a> / <a href=""#"">Privacy Policy</a></div>
                </div>
                <div class=""col_half col_last tright"">
                    <div class=""fright clearfix"">
                        <a href=""#"" class=""social-icon si-small si-borderless si-facebook"">
                            <i class=""icon-facebook""></i>
                            <i class=""icon-facebook""></i>
                        </a>
                        <a href=""#"" class=""social-icon si-small si-borderless si-twitter"">
                            <i class=""icon-twitter""></i>
                            <i class=""icon-twitter""></i>
                        </a>
                        <a href=""#"" class=""social-icon si-small si-borderless si-gplus"">
                            <i class=""icon-gplus""></i>
                            <i class=""icon-gplus""></i>
                        </a>
                       ");
            WriteLiteral(@" <a href=""#"" class=""social-icon si-small si-borderless si-pinterest"">
                            <i class=""icon-pinterest""></i>
                            <i class=""icon-pinterest""></i>
                        </a>
                        <a href=""#"" class=""social-icon si-small si-borderless si-vimeo"">
                            <i class=""icon-vimeo""></i>
                            <i class=""icon-vimeo""></i>
                        </a>
                        <a href=""#"" class=""social-icon si-small si-borderless si-github"">
                            <i class=""icon-github""></i>
                            <i class=""icon-github""></i>
                        </a>
                        <a href=""#"" class=""social-icon si-small si-borderless si-yahoo"">
                            <i class=""icon-yahoo""></i>
                            <i class=""icon-yahoo""></i>
                        </a>
                        <a href=""#"" class=""social-icon si-small si-borderless si-linkedin"">
           ");
            WriteLiteral(@"                 <i class=""icon-linkedin""></i>
                            <i class=""icon-linkedin""></i>
                        </a>
                    </div>
                    <div class=""clear""></div>
                    <i class=""icon-envelope2""></i>
                    <span class=""__cf_email__"" data-cfemail=""0f666169604f6c6e61796e7c216c6062"">[email&#160;protected]</span>
                    <span class=""middot"">&middot;</span> 
                    <i class=""icon-headphones""></i>  (028)-39971869 − (028)-38442457 
                    <span class=""middot"">&middot;</span>
                    <i class=""icon-skype2""></i> TribatOnSkype
                </div>
            </div>
        </div>
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
