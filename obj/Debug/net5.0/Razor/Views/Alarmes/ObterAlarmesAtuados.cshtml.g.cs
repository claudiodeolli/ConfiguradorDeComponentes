#pragma checksum "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec318d8cbd37da947b24b62cab74bea049e72763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alarmes_ObterAlarmesAtuados), @"mvc.1.0.view", @"/Views/Alarmes/ObterAlarmesAtuados.cshtml")]
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
#line 1 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\_ViewImports.cshtml"
using ConfiguradorDeComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\_ViewImports.cshtml"
using ConfiguradorDeComponents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec318d8cbd37da947b24b62cab74bea049e72763", @"/Views/Alarmes/ObterAlarmesAtuados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cb066a80c88de4e74817b6bd947387a8ba1131", @"/Views/_ViewImports.cshtml")]
    public class Views_Alarmes_ObterAlarmesAtuados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConfiguradorDeComponents.Models.Alarmes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
  
    var listaAlarmesMaisAtuados = ViewBag.listaAlarmesMaisAtuados as List<Alarmes>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"topo\">\r\n    <h1 class=\"topo__aba\">\r\n        Alarmes mais atuados\r\n    </h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
Write(Html.Partial("_ObterAlarmesMaisAtuados", listaAlarmesMaisAtuados));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 

<div class=""topo"">
    <h1 class=""topo__aba"">
        Alarmes atuados
    </h1>
</div>

<table class=""tabela"" id=""tabela"">
    <thead class=""tabela__cabecalho"">
        <tr class=""tabela__cabecalho__items"">
            <th class=""tabela__cabecalho__items__item"">
                Equipamento relacionado
            </th>
            <th class=""tabela__cabecalho__items__item"">
                Descrição do alarme
            </th>
            <th class=""tabela__cabecalho__items__item"">
                Classificação do alarme
            </th>
            <th class=""tabela__cabecalho__items__item"">
                Data de cadastro
            </th>
        </tr>
    </thead>
    <tbody class=""tabela__corpo"">
");
#nullable restore
#line 38 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"tabela__corpo__items\">\r\n                <td class=\"tabela__corpo__items__item nome\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tabela__corpo__items__item\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
               Write(Html.DisplayFor(modelItem => item.DescricaoAlarme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tabela__corpo__items__item\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
               Write(Html.DisplayFor(modelItem => item.NomeClassificacaoAlarme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"tabela__corpo__items__item\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataDeCadastroAlarme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\claudio_natan\Documents\est\TreeTech\ConfiguradorDeComponents\Views\Alarmes\ObterAlarmesAtuados.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConfiguradorDeComponents.Models.Alarmes>> Html { get; private set; }
    }
}
#pragma warning restore 1591