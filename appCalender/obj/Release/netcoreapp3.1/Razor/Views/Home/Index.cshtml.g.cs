#pragma checksum "/Users/nattapa/Desktop/dotnet/GitHub/appCalender/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5b8387ebf9afc9900ef6be80e8206a31d7e6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/nattapa/Desktop/dotnet/GitHub/appCalender/Views/_ViewImports.cshtml"
using appCalender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nattapa/Desktop/dotnet/GitHub/appCalender/Views/_ViewImports.cshtml"
using appCalender.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5b8387ebf9afc9900ef6be80e8206a31d7e6c0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e4fc236a1de14e53eaa82faa51b27929c98d440", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nattapa/Desktop/dotnet/GitHub/appCalender/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Calender";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id='calendar'></div>

<!-- Button trigger modal -->

<!-- Modal -->
<div id=""myModal"" class=""modal"">

  <!-- Modal content -->
  <div class=""modal-content"">
    <div class=""header-modal d-flex justify-content-between"">
      <h2>Events</h3>
      <span class=""close"">&times;</span>
    </div>
    <p>Some text in the Modal..</p>
  </div>
</div>
");
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
