#pragma checksum "C:\Users\anton\Gest-oPedidos\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4b597d8780a2641a77fcdece46e1bdc1beb4ada97c2b1bd421d2abe0d8da8f41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4b597d8780a2641a77fcdece46e1bdc1beb4ada97c2b1bd421d2abe0d8da8f41", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"47c463c094f3ea4cc8d03af4f3b3b3bed5e1d7b86d14ebe4ff83e77502842a35", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
#nullable restore
#line 3 "C:\Users\anton\Gest-oPedidos\Views\Home\Index.cshtml"
      
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b597d8780a2641a77fcdece46e1bdc1beb4ada97c2b1bd421d2abe0d8da8f413598", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Redeflex - Gestão de Pedidos</title>
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

        .main-title {
            position: relative;
            display: inline-block;
            margin-bottom: 2rem;
            color: #000;
        }

        .main-title::after {
            content: '';
            position: absolute;
            bottom: -10px;
            left: 0;
            width: 50px;
            height: 4px;");
                WriteLiteral(@"
            background-color: #8b1c1d;
        }

        .bg-gradient-red {
            background: linear-gradient(135deg, #501211, #8b1c1d);
        }

        .card {
            transition: all 0.3s ease;
            border: none;
            border-radius: 15px;
            overflow: hidden;
        }

        h1 {
            font-family: 'Space Grotesk', sans-serif;
        }

        h3 {
            font-family: 'Space Grotesk', sans-serif;
        }

        .card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 20px rgba(0, 0, 0, 0.1);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b597d8780a2641a77fcdece46e1bdc1beb4ada97c2b1bd421d2abe0d8da8f416308", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h1 class=""font-space-grotesk fw-bold main-title"">
                Gestão de Pedidos
            </h1>
            <p class=""text-redeflex-dark"">Sistema de gerenciamento de pedidos Redeflex</p>
        </div>
        <div class=""row g-4 justify-content-center"">
            <div class=""col-md-6"">
                <a");
                BeginWriteAttribute("href", " href=\"", 2175, "\"", 2213, 1);
                WriteAttributeValue("", 2182, 
#nullable restore
#line 75 "C:\Users\anton\Gest-oPedidos\Views\Home\Index.cshtml"
                          Url.Action("Index", "Pedidos")

#line default
#line hidden
#nullable disable
                , 2182, 31, false);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <div class=""card bg-gradient-red text-white h-100"">
                        <div class=""card-body text-center p-4"">
                            <div class=""icon-circle rounded-circle p-3 d-inline-block mb-3"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" fill=""currentColor""
                                    class=""bi bi-cart text-redeflex-light"" viewBox=""0 0 16 16"">
                                    <path
                                        d=""M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5zM3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm-7 1a1 1 0 1 1 0 2 1 1 0 0 1 0-2zm7 0a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"" />
                                </svg>
                            </div>
                            <h3 class=""card-tit");
                WriteLiteral(@"le mb-2 font-space-grotesk"">Ver Pedidos</h3>
                            <p class=""card-text text-redeflex-light"">Visualize e gerencie todos os pedidos em um só
                                lugar</p>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-md-6"">
                <a");
                BeginWriteAttribute("href", " href=\"", 3600, "\"", 3639, 1);
                WriteAttributeValue("", 3607, 
#nullable restore
#line 93 "C:\Users\anton\Gest-oPedidos\Views\Home\Index.cshtml"
                          Url.Action("Create", "Pedidos")

#line default
#line hidden
#nullable disable
                , 3607, 32, false);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <div class=""card bg-gradient-red text-white h-100"">
                        <div class=""card-body text-center p-4"">
                            <div class=""icon-circle rounded-circle p-3 d-inline-block mb-3"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" fill=""currentColor""
                                    class=""bi bi-plus-circle text-redeflex-light"" viewBox=""0 0 16 16"">
                                    <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                                    <path
                                        d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"" />
                                </svg>
                            </div>
                            <h3 class=""card-title mb-2 font-space-grotesk"">Criar Novo Pedido</h3>
                            <p class=""card-text text");
                WriteLiteral(@"-redeflex-light"">Adicione novos pedidos ao sistema de forma rápida
                            </p>
                        </div>
                    </div>
                </a>
            </div>

            <div class=""col-md-6"">
                <a");
                BeginWriteAttribute("href", " href=\"", 4924, "\"", 4963, 1);
                WriteAttributeValue("", 4931, 
#nullable restore
#line 113 "C:\Users\anton\Gest-oPedidos\Views\Home\Index.cshtml"
                          Url.Action("Index", "Clientes")

#line default
#line hidden
#nullable disable
                , 4931, 32, false);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <div class=""card bg-gradient-red text-white h-100"">
                        <div class=""card-body text-center p-4"">
                            <div class=""icon-circle rounded-circle p-3 d-inline-block mb-3"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" fill=""currentColor""
                                    class=""bi bi-people text-redeflex-light"" viewBox=""0 0 16 16"">
                                    <path
                                        d=""M15 14s1 0 1-1-1-4-5-4-5 3-5 4 1 1 1 1h8Zm-7.978-1A.261.261 0 0 1 7 12.996c.001-.264.167-1.03.76-1.72C8.312 10.629 9.282 10 11 10c1.717 0 2.687.63 3.24 1.276.593.69.758 1.457.76 1.72l-.008.002a.274.274 0 0 1-.014.002H7.022ZM11 7a2 2 0 1 0 0-4 2 2 0 0 0 0 4Zm3-2a3 3 0 1 1-6 0 3 3 0 0 1 6 0ZM6.936 9.28a5.88 5.88 0 0 0-1.23-.247A7.35 7.35 0 0 0 5 9c-4 0-5 3-5 4 0 .667.333 1 1 1h4.216A2.238 2.238 0 0 1 5 13c0-1.01.377-2.042 1.09-2.904.243-.294.526-.569.846-.8");
                WriteLiteral(@"16ZM4.92 10A5.493 5.493 0 0 0 4 13H1c0-.26.164-1.03.76-1.724.545-.636 1.492-1.256 3.16-1.275ZM1.5 5.5a3 3 0 1 1 6 0 3 3 0 0 1-6 0Zm3-2a2 2 0 1 0 0 4 2 2 0 0 0 0-4Z"" />
                                </svg>
                            </div>
                            <h3 class=""card-title mb-2 font-space-grotesk"">Ver Clientes</h3>
                            <p class=""card-text text-redeflex-light"">Acesse e gerencie sua base de clientes</p>
                        </div>
                    </div>
                </a>
            </div>

            <div class=""col-md-6"">
                <a");
                BeginWriteAttribute("href", " href=\"", 6598, "\"", 6637, 1);
                WriteAttributeValue("", 6605, 
#nullable restore
#line 131 "C:\Users\anton\Gest-oPedidos\Views\Home\Index.cshtml"
                          Url.Action("Index", "Produtos")

#line default
#line hidden
#nullable disable
                , 6605, 32, false);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <div class=""card bg-gradient-red text-white h-100"">
                        <div class=""card-body text-center p-4"">
                            <div class=""icon-circle rounded-circle p-3 d-inline-block mb-3"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" fill=""currentColor""
                                    class=""bi bi-grid text-redeflex-light"" viewBox=""0 0 16 16"">
                                    <path
                                        d=""M1 2.5A1.5 1.5 0 0 1 2.5 1h3A1.5 1.5 0 0 1 7 2.5v3A1.5 1.5 0 0 1 5.5 7h-3A1.5 1.5 0 0 1 1 5.5v-3zM2.5 2a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zm6.5.5A1.5 1.5 0 0 1 10.5 1h3A1.5 1.5 0 0 1 15 2.5v3A1.5 1.5 0 0 1 13.5 7h-3A1.5 1.5 0 0 1 9 5.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zM1 10.5A1.5 1.5 0 0 1 2.5 9h3A1.5 1.5 0 0 1 7 10.5v3A1.5 1.5 0 0 1 5.5 15h-3A1.5 1.5 0 0 1 1 13.5");
                WriteLiteral(@"v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zm6.5.5A1.5 1.5 0 0 1 10.5 9h3a1.5 1.5 0 0 1 1.5 1.5v3a1.5 1.5 0 0 1-1.5 1.5h-3A1.5 1.5 0 0 1 9 13.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3z"" />
                                </svg>
                            </div>
                            <h3 class=""card-title mb-2 font-space-grotesk"">Ver Produtos</h3>
                            <p class=""card-text text-redeflex-light"">Controle seu catálogo de produtos</p>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>
");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
