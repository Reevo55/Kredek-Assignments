#pragma checksum "C:\Users\Radek\Documents\GitHub\radoslaw_karbowiak\RadoslawKarbowiakLab6Zadanie\RadoslawKarbowiakLab6Zadanie\Views\Home\ShowDelietedClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f30272afd3bbd35f56b572791bb4db05d6b4e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowDelietedClient), @"mvc.1.0.view", @"/Views/Home/ShowDelietedClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowDelietedClient.cshtml", typeof(AspNetCore.Views_Home_ShowDelietedClient))]
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
#line 1 "C:\Users\Radek\Documents\GitHub\radoslaw_karbowiak\RadoslawKarbowiakLab6Zadanie\RadoslawKarbowiakLab6Zadanie\Views\_ViewImports.cshtml"
using RadoslawKarbowiakLab6Zadanie;

#line default
#line hidden
#line 2 "C:\Users\Radek\Documents\GitHub\radoslaw_karbowiak\RadoslawKarbowiakLab6Zadanie\RadoslawKarbowiakLab6Zadanie\Views\_ViewImports.cshtml"
using RadoslawKarbowiakLab6Zadanie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f30272afd3bbd35f56b572791bb4db05d6b4e30", @"/Views/Home/ShowDelietedClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17d45e49ce59cc81fe175c0e07c8b5fdd9e1bc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDelietedClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Radek\Documents\GitHub\radoslaw_karbowiak\RadoslawKarbowiakLab6Zadanie\RadoslawKarbowiakLab6Zadanie\Views\Home\ShowDelietedClient.cshtml"
  
    ViewData["Title"] = "Usuniety klient: ";

#line default
#line hidden
            BeginContext(55, 107, true);
            WriteLiteral("\r\n<h2>ShowAddedClient</h2>\r\n\r\n<div>\r\n    <h1 style=\"position: fixed center; top:50%; left: 50%\">\r\n         ");
            EndContext();
            BeginContext(163, 12, false);
#line 10 "C:\Users\Radek\Documents\GitHub\radoslaw_karbowiak\RadoslawKarbowiakLab6Zadanie\RadoslawKarbowiakLab6Zadanie\Views\Home\ShowDelietedClient.cshtml"
    Write(ViewBag.Data);

#line default
#line hidden
            EndContext();
            BeginContext(175, 23, true);
            WriteLiteral("\r\n    </h1>\r\n\r\n    <h3>");
            EndContext();
            BeginContext(199, 69, false);
#line 13 "C:\Users\Radek\Documents\GitHub\radoslaw_karbowiak\RadoslawKarbowiakLab6Zadanie\RadoslawKarbowiakLab6Zadanie\Views\Home\ShowDelietedClient.cshtml"
   Write(Html.ActionLink("Lista wszystkich klientów", "GetAllClients", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(268, 15, true);
            WriteLiteral("</h3>\r\n\r\n</div>");
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
