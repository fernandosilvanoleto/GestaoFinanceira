#pragma checksum "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea4c3d1a49eeec76a5bb282c3e4a2357cc6dda9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Extrato), @"mvc.1.0.view", @"/Views/Transacao/Extrato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Extrato.cshtml", typeof(AspNetCore.Views_Transacao_Extrato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea4c3d1a49eeec76a5bb282c3e4a2357cc6dda9", @"/Views/Transacao/Extrato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04392c20631624878faf5e1bca0ef8c465d85149", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacao_Extrato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TransacaoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "R", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "D", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Extrato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
  
    ViewData["Title"] = "Meu Extrato";

#line default
#line hidden
            BeginContext(72, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(79, 17, false);
#line 7 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 38, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(134, 1378, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3676558a78245b5aa883f5e21286e91", async() => {
                BeginContext(188, 102, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Data Transação (Inicio): </label>\r\n            ");
                EndContext();
                BeginContext(290, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "443d5965aefd4096b9a4ae9be656cf2e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Data);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(347, 117, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Data Transação (Final): </label>\r\n            ");
                EndContext();
                BeginContext(464, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4469e12cbdf2423394dc0fe17c883238", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DataFinal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(526, 133, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Tipo Transação</label>\r\n            <div class=\"radio\"><label>");
                EndContext();
                BeginContext(659, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48922a235e4248f587b6414129b3c6ce", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 21 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("checked", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(714, 73, true);
                WriteLiteral("Receitas e Despesas</label></div>\r\n            <div class=\"radio\"><label>");
                EndContext();
                BeginContext(787, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa2b231f7e30429dbdc6854649520aa9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 22 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(834, 61, true);
                WriteLiteral("Receita</label></div>\r\n            <div class=\"radio\"><label>");
                EndContext();
                BeginContext(895, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9e69670ffbc4fd58790e2c30d9b1f7c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 23 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(942, 120, true);
                WriteLiteral("Despesas</label></div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Conta</label>\r\n            ");
                EndContext();
                BeginContext(1062, 337, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a070f01dee4017920190da3e988e13", async() => {
                    BeginContext(1110, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 28 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   
                    foreach (var item in (List<ContaModel>)ViewBag.ListaConta)
                    {

#line default
#line hidden
                    BeginContext(1236, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                    BeginContext(1268, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6ee4ef32f84ab2a4a87cb9ee0b6df2", async() => {
                        BeginContext(1305, 20, false);
#line 31 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                                                               Write(item.Nome.ToString());

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 31 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                                   WriteLiteral(item.Id.ToString());

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1334, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 32 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                    }
                

#line default
#line hidden
                    BeginContext(1378, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 27 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Conta_Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1399, 106, true);
                WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-block btn-success\">Pesquisar</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1512, 355, true);
            WriteLiteral(@"
</div>
<br />
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>Data</th>
            <th>Tipo</th>
            <th>Valor</th>
            <th>Histórico</th>
            <th>Nome Conta</th>
            <th>Plano Conta</th>
            <th>Usuario</th>
        </tr>
    </thead>
");
            EndContext();
#line 54 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
      
                    var TotalReceita = 0.0;
                    var TotalDespesas = 0.0;
                    var Saldo = 0.0;
                    foreach (var item in (List<TransacaoModel>)ViewBag.ListaTransacao)
                    {

#line default
#line hidden
            BeginContext(2115, 112, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2227, "\"", 2264, 3);
            WriteAttributeValue("", 2237, "Editar(", 2237, 7, true);
#line 62 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
WriteAttributeValue("", 2244, item.Id.ToString(), 2244, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2263, ")", 2263, 1, true);
            EndWriteAttribute();
            BeginContext(2265, 47, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(2313, 20, false);
#line 63 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.Data.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2333, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2365, 69, false);
#line 64 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.Tipo.ToString().Replace("R", "Receita").Replace("D", "Despesas"));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2466, 10, false);
#line 65 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(2476, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2508, 25, false);
#line 66 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2533, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2565, 25, false);
#line 67 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.NomeConta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2590, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2622, 26, false);
#line 68 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.PlanoConta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2648, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2680, 27, false);
#line 69 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   Write(item.NomeUsuario.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2707, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                   
                    if (item.Tipo == "D")
                    {
                        TotalDespesas += double.Parse(item.Valor.ToString());
            }
                    else
                    {
                        TotalReceita += double.Parse(item.Valor.ToString());
        }
                

#line default
#line hidden
            BeginContext(3075, 22, true);
            WriteLiteral("            </tbody>\r\n");
            EndContext();
#line 82 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
        }
                    Saldo = TotalReceita - TotalDespesas;
    

#line default
#line hidden
            BeginContext(3174, 43, true);
            WriteLiteral("</table>\r\n\r\n<h3><strong>Saldo: </strong>R$ ");
            EndContext();
            BeginContext(3218, 5, false);
#line 87 "G:\Programação_Udemy\C#\GestaoFinanceira\GestaoFinanceira\Views\Transacao\Extrato.cshtml"
                          Write(Saldo);

#line default
#line hidden
            EndContext();
            BeginContext(3223, 134, true);
            WriteLiteral("</h3>\r\n\r\n<script>\r\n    function Editar(id) {\r\n        window.location.href = \"../Transacao/EditarTransacao/\" + id;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TransacaoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
