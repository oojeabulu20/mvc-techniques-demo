#pragma checksum "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ViewBagDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bb51f96072090c24e49e22a6d1c4e6bfdbb8705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataExamples_ViewBagDemo), @"mvc.1.0.view", @"/Views/DataExamples/ViewBagDemo.cshtml")]
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
#nullable restore
#line 1 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\_ViewImports.cshtml"
using justAPlayMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\_ViewImports.cshtml"
using justAPlayMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb51f96072090c24e49e22a6d1c4e6bfdbb8705", @"/Views/DataExamples/ViewBagDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3970c8783e66ba9e19e6f841a11ba7ce50d43a", @"/Views/_ViewImports.cshtml")]
    public class Views_DataExamples_ViewBagDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ViewBagDemo.cshtml"
  
    ViewData["Title"] = "View Bag Example";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ViewBagDemo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h2>Data Retrieved from ViewBag</h2>\r\n\r\n<p class=\"msg\">");
#nullable restore
#line 9 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ViewBagDemo.cshtml"
          Write(ViewBag.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ViewBagDemo.cshtml"
                            Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p></p>\r\n");
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
