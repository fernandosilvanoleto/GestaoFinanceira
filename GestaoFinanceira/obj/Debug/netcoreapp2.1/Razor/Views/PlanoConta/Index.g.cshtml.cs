#pragma checksum "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b07bd3b005d1062ef9065385b9a7fe21e65ae5a"
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
#line 1 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\_ViewImports.cshtml"
using GestaoFinanceira;

#line default
#line hidden
#line 2 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\_ViewImports.cshtml"
using GestaoFinanceira.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b07bd3b005d1062ef9065385b9a7fe21e65ae5a", @"/Views/PlanoConta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04392c20631624878faf5e1bca0ef8c465d85149", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoConta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
  
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
#line 18 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
      
        foreach (var item in (List<PlanoContaModel>)ViewBag.ListaPlanoContasController)
        {

#line default
#line hidden
            BeginContext(427, 111, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 576, 3);
            WriteAttributeValue("", 548, "Excluir(", 548, 8, true);
#line 23 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
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
#line 24 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 687, item.Id.ToString(), 687, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 706, ")", 706, 1, true);
            EndWriteAttribute();
            BeginContext(708, 47, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(756, 18, false);
#line 25 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
                   Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(774, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(806, 25, false);
#line 26 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
                   Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(831, 34, true);
            WriteLiteral("</td>\r\n                    <td>R$ ");
            EndContext();
            BeginContext(866, 20, false);
#line 27 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
                      Write(item.Tipo.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(886, 52, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n");
            EndContext();
#line 30 "C:\Users\fernando.sn\Documents\Visual Studio 2017\Projetos\GestaoFinanceira\GestaoFinanceira\Views\PlanoConta\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(956, 454, true);
            WriteLiteral(@"</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarPlanoConta()"">Criar Conta</button>

<script>
    function CriarConta() {
        window.location.href = ""../Conta/CriarConta"";
    }

    function Excluir(idConta) {
        window.location.href = ""../Conta/ExcluirConta/"" + idConta;
    }

    function Editar(idConta) {
        window.location.href = ""../Conta/EditarConta/"" + idConta;
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
