#pragma checksum "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f4edf2ecc6f54fb813dccabcf479f2d0b2e7e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Core_Index), @"mvc.1.0.view", @"/Views/Core/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Core/Index.cshtml", typeof(AspNetCore.Views_Core_Index))]
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
#line 1 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Index.cshtml"
using Common.Utilities;

#line default
#line hidden
#line 2 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Index.cshtml"
using Helpers;

#line default
#line hidden
#line 3 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Index.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78f4edf2ecc6f54fb813dccabcf479f2d0b2e7e0", @"/Views/Core/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f7d09cb6699920b8416cd86872bb94362cdab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Core_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Projects\Tribat\sourcecode\tribatvn\Views\Core\Index.cshtml"
  
    Layout = "~/Views/Shared/_Core.cshtml";
    var language = ViewData["Language"].ToString();

#line default
#line hidden
            BeginContext(192, 1671, true);
            WriteLiteral(@"
<div class=""main-container"">
    <section>
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-12 col-md-10"">
                    <h4 class=""mb-4"">Core</h4>
                    <div class=""card mb-5"">
                        <ul class=""list-group list-group-lg list-group-flush"">

                            <li class=""list-group-item d-flex justify-content-between"">
                                <a href=""/core/product"">Product</a>
                                <span>Manage product, service,...</span>
                            </li>

                            <li class=""list-group-item d-flex justify-content-between"">
                                <a href=""/core/news"">News</a>
                                <span>News, category news,...</span>
                            </li>

                            <li class=""list-group-item d-flex justify-content-between"">
                                <a href=""/core/job");
            WriteLiteral(@""">Job</a>
                                <span>Job, category job,...</span>
                            </li>

                            <li class=""list-group-item d-flex justify-content-between"">
                                <a href=""/core/content"">Content</a>
                                <span>about, contact,...</span>
                            </li>
                        </ul>
                    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
