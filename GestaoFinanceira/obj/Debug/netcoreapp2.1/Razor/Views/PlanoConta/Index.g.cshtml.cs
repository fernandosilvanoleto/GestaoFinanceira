#pragma checksum "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae303bd25a2b34302b455876dd92a6dca6fd7bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlanoConta_Index), @"mvc.1.0.view", @"/Views/PlanoConta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlanoConta/Index.cshtml", typeof(AspNetCore.Views_PlanoConta_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae303bd25a2b34302b455876dd92a6dca6fd7bbb", @"/Views/PlanoConta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04392c20631624878faf5e1bca0ef8c465d85149", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoConta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
  
    ViewData["Title"] = "Plano de Conta - ";

#line default
#line hidden
            BeginContext(55, 264, true);
            WriteLiteral(@"
<h2>Index - Plano de Contas</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Descricao</th>
            <th>Tipo</th>
        </tr>
    </thead>
");
            EndContext();
#line 18 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
      
        foreach (var item in (List<PlanoContaModel>)ViewBag.ListaPlanoContasController)
        {

#line default
#line hidden
            BeginContext(427, 111, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 576, 3);
            WriteAttributeValue("", 548, "Excluir(", 548, 8, true);
#line 23 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 556, item.Id.ToString(), 556, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 575, ")", 575, 1, true);
            EndWriteAttribute();
            BeginContext(577, 93, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 670, "\"", 707, 3);
            WriteAttributeValue("", 680, "Editar(", 680, 7, true);
#line 24 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 687, item.Id.ToString(), 687, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 706, ")", 706, 1, true);
            EndWriteAttribute();
            BeginContext(708, 47, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(756, 18, false);
#line 25 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
                   Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(774, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(806, 25, false);
#line 26 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
                   Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(831, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(863, 69, false);
#line 27 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
                   Write(item.Tipo.ToString().Replace("R", "Receita").Replace("D", "Despesas"));

#line default
#line hidden
            EndContext();
            BeginContext(932, 52, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n");
            EndContext();
#line 30 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1002, 495, true);
            WriteLiteral(@"</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarPlanoConta()"">Criar Plano Conta</button>

<script>
    function CriarPlanoConta() {
        window.location.href = ""../PlanoConta/CriarPlanoConta"";
    }

    function Excluir(idConta) {
        window.location.href = ""../PlanoConta/ExcluirPlanoConta/"" + idConta;
    }

    function Editar(idConta) {
        window.location.href = ""../PlanoConta/EditarPlanoConta/"" + idConta;
    }
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
