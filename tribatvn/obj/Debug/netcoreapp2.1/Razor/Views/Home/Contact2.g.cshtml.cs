#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Contact2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef661ade076172b6b90dd0c012019b8d7d058e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact2), @"mvc.1.0.view", @"/Views/Home/Contact2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact2.cshtml", typeof(AspNetCore.Views_Home_Contact2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef661ade076172b6b90dd0c012019b8d7d058e4", @"/Views/Home/Contact2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home\Contact2.cshtml"
  
    Layout = "~/Views/Shared/_Tempo.cshtml";

#line default
#line hidden
            BeginContext(53, 136, true);
            WriteLiteral("\r\n<!-- ******CONTACT MAIN****** -->\r\n<section id=\"contact-main\" class=\"contact-main section\">\r\n    <div class=\"container text-center\">\r\n");
            EndContext();
            BeginContext(355, 513, true);
            WriteLiteral(@"        <h2 class=""title"">Liên hệ</h2>
        <p class=""intro"">Chúng tôi rất muốn bạn liên hệ. We'd love to hear from you. </p>

        <div class=""row"">
            <div class=""item col-md-4 col-sm-12 col-xs-12"">
                <div class=""item-inner"">
                    <div class=""icon"">
                        <!--<i class=""fa fa-envelope""></i>-->
                        <span class=""pe-icon pe-7s-mail-open-file""></span>
                    </div>
                    <div class=""details"">
");
            EndContext();
            BeginContext(927, 126, true);
            WriteLiteral("                        <h4>Email:</h4>\r\n                        <p><a href=\"mailto:hotro@tribat.vn\">hotro@tribat.vn</a></p>\r\n");
            EndContext();
            BeginContext(1171, 1234, true);
            WriteLiteral(@"                    </div><!--details-->
                </div><!--//item-inner-->
            </div><!--//item-->
            <div class=""item col-md-4 col-sm-12 col-xs-12"">
                <div class=""item-inner"">
                    <div class=""icon"">
                        <!--<i class=""fa fa-phone""></i>-->
                        <span class=""pe-icon pe-7s-phone""></span>
                    </div>
                    <div class=""details"">
                        <h4>Gọi chúng tôi:</h4>
                        <p class=""phone""><a href=""tel:02839971869""> (028)-39971869 </a></p>
                        <p class=""phone""><a href=""tel:02838442457""> (028)-38442457 </a></p>
                        <p class=""day"">Thứ hai-bảy 8am-17pm (GMT)</p>
                    </div><!--details-->
                </div><!--//item-inner-->
            </div><!--//item-->
            <div class=""item col-md-4 col-sm-12 col-xs-12 last"">
                <div class=""item-inner"">
                    <div class=""i");
            WriteLiteral("con\">\r\n                        <!--<i class=\"fa fa-map-marker\"></i>-->\r\n                        <span class=\"pe-icon pe-7s-map-2\"></span>\r\n                    </div>\r\n                    <div class=\"details\">\r\n");
            EndContext();
            BeginContext(2455, 146, true);
            WriteLiteral("                        <h4>Gặp chúng tôi ở:</h4>\r\n                        <p class=\"address\">127 Nguyễn Trọng Tuyển<br />Phú Nhuận, HCM, VN</p>\r\n");
            EndContext();
            BeginContext(2687, 426, true);
            WriteLiteral(@"                    </div><!--details-->
                </div><!--//item-inner-->
            </div><!--//item-->
        </div><!--//row-->
    </div><!--//container-->
</section><!--//contact-->
<section class=""container contact-form-section"">
    <h3 class=""title text-center"">Thông tin liên hệ</h3>
    <p class=""intro text-center"">Cảm ơn bạn dành thời gian liên hệ, chúng tôi liên hệ bạn nhanh nhất có thể.</p>
");
            EndContext();
            BeginContext(3654, 162, true);
            WriteLiteral("\r\n    <div class=\"row text-center\">\r\n        <div class=\"contact-form col-md-6 col-sm-12 col-xs-12 col-md-offset-3 col-sm-offset-0 col-xs-offset-0\">\r\n            ");
            EndContext();
            BeginContext(3816, 993, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0f787e363254535b2a4e9fb42319695", async() => {
                BeginContext(3878, 924, true);
                WriteLiteral(@"
                <div class=""form-group name"">
                    <label class=""sr-only"" for=""name"">Họ và tên</label>
                    <input id=""name"" name=""name"" type=""text"" class=""form-control"" placeholder=""Họ và tên"">
                </div><!--//form-group-->
                <div class=""form-group email"">
                    <label class=""sr-only"" for=""email"">Email</label>
                    <input id=""email"" type=""email"" class=""form-control"" placeholder=""Email của bạn"">
                </div><!--//form-group-->
                <div class=""form-group message"">
                    <label class=""sr-only"" for=""message"">Tin nhắn</label>
                    <textarea id=""message"" class=""form-control"" rows=""8"" placeholder=""Tin nhắn""></textarea>
                </div><!--//form-group-->
                <button type=""submit"" class=""btn btn-block btn-cta-primary"">Gửi tin nhắn</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4809, 782, true);
            WriteLiteral(@"<!--//form-->
        </div><!--//contact-form-->
    </div><!--//row-->
</section>

<section class=""map-section"">
    <h3 class=""sr-only title"">Google Map</h3>
    <div class=""gmap-wrapper"" id=""map"">
        <!--//You need to embed your own google map below-->
        <!--//Ref: https://support.google.com/maps/answer/144361?co=GENIE.Platform%3DDesktop&hl=en -->
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3920.786550469851!2d106.65985715039199!3d10.67366946396319!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x317531bafb1027f3%3A0xa5bd84e6bd5fb945!2zTmjDoCBtw6F5IFjhu60gbMO9IGLDuW4gdGjhuqNpIFPDoGkgR8OybiBYYW5o!5e0!3m2!1sen!2sus!4v1524299311004"" width=""600"" height=""450"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
");
            EndContext();
            BeginContext(6003, 28, true);
            WriteLiteral("        <!--//Văn phòng-->\r\n");
            EndContext();
            BeginContext(6490, 57, true);
            WriteLiteral("    </div><!--//gmap-wrapper-->\r\n</section><!--//map-->\r\n");
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
