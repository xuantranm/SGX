#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home21\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5989146c20e297d05361cc87bf290b8b98e9284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home21_About), @"mvc.1.0.view", @"/Views/Home21/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home21/About.cshtml", typeof(AspNetCore.Views_Home21_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5989146c20e297d05361cc87bf290b8b98e9284", @"/Views/Home21/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home21_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home21\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home21\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Home21\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 66, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n");
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
