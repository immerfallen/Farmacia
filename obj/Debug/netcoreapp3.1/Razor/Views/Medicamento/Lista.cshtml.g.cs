#pragma checksum "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff693d605c038941cac39a1a4b3bbe396a69429c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicamento_Lista), @"mvc.1.0.view", @"/Views/Medicamento/Lista.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\_ViewImports.cshtml"
using Farmacia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff693d605c038941cac39a1a4b3bbe396a69429c", @"/Views/Medicamento/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6109094f4dfe9e25f004429c59163c13e3993432", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicamento_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Medicamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionaSacola", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml"
  
 ViewData["Title"] = "Lista de Medicamentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Adicione os medicamento ao pedido</h2>\r\n<table>\r\n        <thead>\r\n            <tr>\r\n                <th>Nome</th> <th>Valor</th> <th>Quantidade</th> <th>A????o</th>\r\n            </tr>\r\n        </thead>\r\n    \r\n");
#nullable restore
#line 14 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml"
         foreach(Medicamento medicamento in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml"
           Write(medicamento.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>    \r\n            <td>");
#nullable restore
#line 17 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml"
           Write(medicamento.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td> \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff693d605c038941cac39a1a4b3bbe396a69429c5696", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Medicamento.Id\"");
                BeginWriteAttribute("value", " value=\"", 572, "\"", 595, 1);
#nullable restore
#line 19 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml"
WriteAttributeValue("", 580, medicamento.Id, 580, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <td><input type=\"number\" name=\"Quantidade\"></td>\r\n                <td><input type=\"submit\" name=\"Adicionar\"></td>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n                \r\n            </tr>    \r\n");
#nullable restore
#line 25 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Medicamento\Lista.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Medicamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
