#pragma checksum "C:\CodingDojo\FirstMVC\Views\Numbers\NumbersDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54ae92440abab6f5b766fddb3c98c3071ad82b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Numbers_NumbersDetails), @"mvc.1.0.view", @"/Views/Numbers/NumbersDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Numbers/NumbersDetails.cshtml", typeof(AspNetCore.Views_Numbers_NumbersDetails))]
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
#line 1 "C:\CodingDojo\FirstMVC\Views\_ViewImports.cshtml"
using FirstMVC;

#line default
#line hidden
#line 1 "C:\CodingDojo\FirstMVC\Views\Numbers\NumbersDetails.cshtml"
using FirstMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54ae92440abab6f5b766fddb3c98c3071ad82b9", @"/Views/Numbers/NumbersDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16234bafa6cf1be236f5c96bebbc3569c18019e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Numbers_NumbersDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Numbers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(28, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(48, 39, true);
            WriteLiteral("\r\n    <h1>Here are some numbers!</h1>\r\n");
            EndContext();
#line 5 "C:\CodingDojo\FirstMVC\Views\Numbers\NumbersDetails.cshtml"
     foreach (int i in @Model.SomeNumbers)
    {

#line default
#line hidden
            BeginContext(138, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(150, 1, false);
#line 7 "C:\CodingDojo\FirstMVC\Views\Numbers\NumbersDetails.cshtml"
      Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(151, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 8 "C:\CodingDojo\FirstMVC\Views\Numbers\NumbersDetails.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Numbers> Html { get; private set; }
    }
}
#pragma warning restore 1591
