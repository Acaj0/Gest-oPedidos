#pragma checksum "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "405def7c70a0e8e871947573edf32b70bebebc8afc5c17e5c531965c58eb99f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\anton\Gest-oPedidos\Views\_ViewImports.cshtml"
using GestaoPedidos

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\anton\Gest-oPedidos\Views\_ViewImports.cshtml"
using GestaoPedidos.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"405def7c70a0e8e871947573edf32b70bebebc8afc5c17e5c531965c58eb99f8", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"47c463c094f3ea4cc8d03af4f3b3b3bed5e1d7b86d14ebe4ff83e77502842a35", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
       IEnumerable<GestaoPedidos.Models.Pedido>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
  
    ViewData["Title"] = "Lista de Pedidos";

#line default
#line hidden
#nullable disable

            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405def7c70a0e8e871947573edf32b70bebebc8afc5c17e5c531965c58eb99f83814", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Gestão de Pedidos</title>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Inter:wght@400;700&family=Space+Grotesk&display=swap""
        rel=""stylesheet"">
    <style>
        body {
            font-family: 'Inter', sans-serif;
            background-color: #f8f9fa;
        }

        .bg-gradient-red {
            background: linear-gradient(135deg, #501211, #8b1c1d) !important;
        }

        h1 {
            font-family: 'Space Grotesk', sans-serif;
            color: #501211;
            text-align: center;
        }

        h3 {
            font-family: 'Space Grotesk', sans-serif;
            color: #501211;
   ");
                WriteLiteral(@"     }

        .font-space-grotesk {
            font-family: 'Space Grotesk', sans-serif;
        }

        .table-wrapper {
            background-color: white;
            border: 2px solid #501211;
            border-radius: 0.5rem;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            padding: 2rem;
            margin-top: 2rem;
        }

        .table th,
        .table td {
            vertical-align: middle;
        }

        .table thead {
            background: linear-gradient(135deg, #501211, #8b1c1d) !important;
            color: linear-gradient(135deg, #501211, #8b1c1d);
        }


        .table-striped tbody tr:nth-child(odd) {
            background-color: #f8f9fa;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405def7c70a0e8e871947573edf32b70bebebc8afc5c17e5c531965c58eb99f86650", async() => {
                WriteLiteral(@"

    <h1 class=""font-space-grotesk fw-bold mb-4"">Pedidos</h1>

    <div class=""table-wrapper"">
        <table class=""table table-bordered table-striped"">
            <thead class=""table thead"">
                <tr>
                    <th>Pedido ID</th>
                    <th>Cliente</th>
                    <th>Produto</th>
                    <th>Data</th>
                    <th>Quantidade</th>
                    <th>Valor Total</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 87 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                 foreach (var pedido in Model)
                {

#line default
#line hidden
#nullable disable

                WriteLiteral("                    <tr>\r\n                        <td>");
                Write(
#nullable restore
#line 90 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                             pedido.PedidoId

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n                        <td>");
                Write(
#nullable restore
#line 91 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                             pedido.Cliente.Nome

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n                        <td>");
                Write(
#nullable restore
#line 92 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                             pedido.Produto.Nome

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n                        <td>");
                Write(
#nullable restore
#line 93 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                             pedido.DataPedido.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n                        <td>");
                Write(
#nullable restore
#line 94 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                             pedido.Quantidade

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n                        <td>");
                Write(
#nullable restore
#line 95 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                             pedido.ValorTotal.ToString("C")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\anton\Gest-oPedidos\Views\Pedidos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestaoPedidos.Models.Pedido>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
