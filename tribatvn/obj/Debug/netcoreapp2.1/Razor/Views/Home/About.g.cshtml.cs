#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567867cc9202eb7421b043f2bf001433d3af4e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\About.cshtml"
using Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567867cc9202eb7421b043f2bf001433d3af4e2f", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/tempo/background/banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\About.cshtml"
  
    Layout = "~/Views/Shared/_Wingman.cshtml";
    var language = ViewData["Language"].ToString();

#line default
#line hidden
            BeginContext(125, 1653, true);
            WriteLiteral(@"
<div class=""main-container"">
    <nav aria-label=""breadcrumb"" role=""navigation"" class=""bg-primary text-white"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">
                            <a href=""/"">Trang chủ</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">
                            Giới thiệu
                        </li>
                    </ol>
                </div>
            </div>
        </div>
    </nav>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-2 col-md-4 col-sm-6 d-none d-sm-block"">
                <p></p>
                <div class=""list-group"">
                    <button type=""button"" class=""list-group-item list-group-item-action active"">
                        Cras justo odio
               ");
            WriteLiteral(@"     </button>
                    <button type=""button"" class=""list-group-item list-group-item-action"">Dapibus ac facilisis in</button>
                    <button type=""button"" class=""list-group-item list-group-item-action"">Morbi leo risus</button>
                    <button type=""button"" class=""list-group-item list-group-item-action"">Porta ac consectetur ac</button>
                    <button type=""button"" class=""list-group-item list-group-item-action"" disabled>Vestibulum at eros</button>
                </div>
            </div>
            <div class=""col-lg-10 col-md-8 col-sm-6 col-xs-12"">
                ");
            EndContext();
            BeginContext(1778, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33dfea8bf18a4e73ad2df39acbe8b342", async() => {
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
            BeginContext(1865, 963, true);
            WriteLiteral(@"
                <section>
                    <article class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-12 col-md-8 col-lg-6"">
                                <p>
                                    Thực hiện chủ trương xã hội hóa trong việc xử lý bùn thải từ các nhà máy xử lý nước thải,
                                    nhà máy cấp nước cũng như bùn thải (không nguy hại) từ công tác duy tu, nạo vét hệ thống cống rãnh,
                                    kênh rạch trên địa bàn thành phố… công ty Sài Gòn Xanh được thành phố chỉ đạo làm đơn vị đầu tiên
                                    (và duy nhất được chọn đến hiện tại) thực hiện dự án xây dựng Nhà máy Xử lý bùn thải Sài Gòn Xanh tại
                                    Khu liên hợp xử lý chất thải rắn và nghĩa trang Đa Phước, thuộc Ấp 1, xã Đa Phước, huyện Bình Chánh.
                                </p>
");
            EndContext();
            BeginContext(5536, 4680, true);
            WriteLiteral(@"                            </div>
                            <!--end of col-->
                            <figure class=""figure text-center col-12 col-md-10 col-lg-8"">
                                <img alt=""Image"" class=""img-fluid figure-img rounded"" src=""assets/wingman/img/photo-woman-laptop.jpg"" />
                                <figcaption class=""figure-caption"">Photo credit: Death To The Stock Photo</figcaption>
                            </figure>
                            <div class=""col-12 col-md-8 col-lg-6"">
                                <p>
                                    Omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente.
                                </p>
                                <p>
                                    Et harum quidem rerum facilis est et expedita dis");
            WriteLiteral(@"tinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus
                                    autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus
                                    maiores alias consequatur aut perferendis doloribus asperiores repellat.
                                </p>
                                <h4>Couldn't have wanted more</h4>
                                <p>
                                    Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus.
                                </p>
                            </div>
             ");
            WriteLiteral(@"               <!--end of col-->
                        </div>
                        <!--end of row-->
                    </article>
                    <!--end of container-->
                </section>
                <!--end of section-->
                <section>
                    <div class=""container"">
                        <div class=""row mb-5 justify-content-center"">
                            <div class=""col-auto"">
                                <h4>Another success story</h4>
                            </div>
                            <!--end of col-->
                        </div>
                        <!--end of row-->
                        <div class=""row"">

                            <div class=""col-12"">
                                <a href=""#"" class=""case-study"">
                                    <div class=""card card-lg bg-dark text-white"">
                                        <img alt=""Image"" src=""assets/wingman/img/photo-man-book.jpg"" class=""bg-");
            WriteLiteral(@"image opacity-40"" />
                                        <div class=""card-body"">
                                            <div>
                                                <img alt=""Image"" src=""assets/wingman/img/logo-bench.svg"" />
                                            </div>
                                            <span class=""h2"">“Having tried multiple template solutions in the past - we were skeptical...”</span>
                                            <span>Bench built their business-facing invoicing system with Wingman.</span>
                                        </div>
                                    </div>
                                </a>
                                <div class=""text-center mt-4"">
                                    <a href=""#"">View all Case Studies &rsaquo;</a>
                                </div>
                            </div>
                            <!--end of col-->

                        </div>
                    ");
            WriteLiteral(@"    <!--end of row-->
                    </div>
                    <!--end of container-->
                </section>
                <!--end of section-->
            </div>
        </div>
    </div>

    <section class=""bg-dark"">
        <div class=""container"">
            <div class=""row section-intro"">
                <div class=""col-12 text-center"">
                    <h3 class=""h1"">Don’t even wait, sign up now for a 30 day trial.</h3>
                </div>
                <!--end of col-->
            </div>
            <!--end of row-->
            ");
            EndContext();
            BeginContext(10216, 1699, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af995901cad647f5815c6a79fd081c96", async() => {
                BeginContext(10222, 1686, true);
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-12 col-sm-6 col-lg-3"">
                        <div class=""form-group"">
                            <label for=""username"">Username</label>
                            <input id=""username"" type=""text"" class=""form-control form-control-lg"" placeholder=""Pick a username"">
                        </div>
                    </div>
                    <div class=""col-12 col-sm-6 col-lg-3"">
                        <div class=""form-group"">
                            <label for=""email"">Email Address</label>
                            <input id=""email"" type=""email"" class=""form-control form-control-lg"" placeholder=""you@domain.com"">
                        </div>
                    </div>
                    <div class=""col-12 col-sm-6 col-lg-3"">
                        <div class=""form-group"">
                            <label for=""password"">Password</label>
                            <input id=""password"" type=""password"" class=""fo");
                WriteLiteral(@"rm-control form-control-lg"" placeholder=""Choose a password"">
                            <small class=""form-text"">At least seven letters with one numeral</small>
                        </div>
                    </div>
                    <div class=""col-12 col-sm-6 col-lg-3"">
                        <div class=""form-group"">
                            <label for=""button"">&nbsp;</label>
                            <button id=""button"" type=""submit"" class=""btn btn-lg btn-block btn-success"">Sign up for Wingman</button>
                        </div>
                    </div>
                </div>
                <!--end of row-->
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11915, 77, true);
            WriteLiteral("\r\n        </div>\r\n        <!--end of container-->\r\n    </section>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
