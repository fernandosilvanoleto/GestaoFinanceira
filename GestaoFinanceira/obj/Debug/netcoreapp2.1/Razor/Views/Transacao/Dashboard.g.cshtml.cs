#pragma checksum "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e3bd1a0aa31ded1d42c2ed75f0cdc6addfc6195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Dashboard), @"mvc.1.0.view", @"/Views/Transacao/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Dashboard.cshtml", typeof(AspNetCore.Views_Transacao_Dashboard))]
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
#line 1 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\_ViewImports.cshtml"
using GestaoFinanceira;

#line default
#line hidden
#line 2 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\_ViewImports.cshtml"
using GestaoFinanceira.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e3bd1a0aa31ded1d42c2ed75f0cdc6addfc6195", @"/Views/Transacao/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04392c20631624878faf5e1bca0ef8c465d85149", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacao_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Dashboard.cshtml"
  
    ViewData["Title"] = "Meu Dashboard";

#line default
#line hidden
            BeginContext(51, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(58, 17, false);
#line 6 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Dashboard.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(75, 449, true);
            WriteLiteral(@"</h2>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js""></script>



<div id=""canvas-holder"" style=""width:60%"">
    <canvas id=""chart-area""></canvas>
</div>

<script>
    var randomScalingFactor = function () {
        return Math.round(Math.random() * 100);
    };

    var config = {
        type: 'doughnut',
        data: {
            datasets: [{
                data: [
                    ");
            EndContext();
            BeginContext(525, 30, false);
#line 26 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Dashboard.cshtml"
               Write(Html.Raw(@ViewBag.ValoresData));

#line default
#line hidden
            EndContext();
            BeginContext(555, 56, true);
            WriteLiteral("\r\n                ],\r\n                backgroundColor: [");
            EndContext();
            BeginContext(612, 30, false);
#line 28 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Dashboard.cshtml"
                             Write(Html.Raw(ViewBag.ValoresCores));

#line default
#line hidden
            EndContext();
            BeginContext(642, 78, true);
            WriteLiteral("],\r\n                label: \'Dataset 1\'\r\n            }],\r\n            labels: [");
            EndContext();
            BeginContext(721, 31, false);
#line 31 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Dashboard.cshtml"
                Write(Html.Raw(ViewBag.ValoresLabels));

#line default
#line hidden
            EndContext();
            BeginContext(752, 271, true);
            WriteLiteral(@"]
        },
        options: {
            responsive: true
        }
    };

    window.onload = function () {
        var ctx = document.getElementById('chart-area').getContext('2d');
        window.myPie = new Chart(ctx, config);
    };

</script>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
