#pragma checksum "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001e1b4f4654feb1f4fbdcc2488af0dcf945893b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Lista), @"mvc.1.0.view", @"/Views/Pedido/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001e1b4f4654feb1f4fbdcc2488af0dcf945893b", @"/Views/Pedido/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6109094f4dfe9e25f004429c59163c13e3993432", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
  
    ViewData["Title"] = "Lista de pedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Lista de pedidos</h2>\r\n\r\n<table>\r\n    <thead>\r\n        <th>Id</th>\r\n        <th>Data</th>\r\n        <th>Clínica</th>\r\n        <th></th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
         foreach (Pedido item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
               Write(item.DataPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
               Write(item.Clinica.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 457, "\"", 491, 2);
            WriteAttributeValue("", 464, "/Pedido/Detalhe?id=", 464, 19, true);
#nullable restore
#line 23 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
WriteAttributeValue("", 483, item.Id, 483, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhes</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Engenharia\Desktop\Maro\Farmacia\Views\Pedido\Lista.cshtml"
        }        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
