#pragma checksum "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e14eaf89852ed8dda3947886833b4dd05e8facf2f7d19ff08087cb0fc0917d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Curriculo_Form), @"mvc.1.0.view", @"/Views/Curriculo/Form.cshtml")]
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
#line 1 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\_ViewImports.cshtml"
using Curriculos

#nullable disable
    ;
#nullable restore
#line 2 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\_ViewImports.cshtml"
using Curriculos.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e14eaf89852ed8dda3947886833b4dd05e8facf2f7d19ff08087cb0fc0917d38", @"/Views/Curriculo/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"af85817d79f2ac3a62984e42096722a0167fe95e734a1ef3e2c2bda1c909d7c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Curriculo_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
       CurriculoViewModel

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            DefineSection("EstilosExtras", async() => {
                WriteLiteral("\r\n    <link href=\"/css/Form.css\" rel=\"stylesheet\" />\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Tektur:wght@400..900&display=swap\" rel=\"stylesheet\"><!--fonte Tektur-->\r\n");
            }
            );
            WriteLiteral("<h2>Cadastro de Curriculo</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e14eaf89852ed8dda3947886833b4dd05e8facf2f7d19ff08087cb0fc0917d384702", async() => {
                WriteLiteral("\r\n    <label for=\"CurriculoId\" class=\"control-label\">Id do Curriculo</label>\r\n    <input type=\"number\" Name=\"CurriculoId\"");
                BeginWriteAttribute("value", " value=\"", 483, "\"", 509, 1);
                WriteAttributeValue("", 491, 
#nullable restore
#line 12 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                    Model.CurriculoId

#line default
#line hidden
#nullable disable
                , 491, 18, false);
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n    <br />\r\n    <label for=\"Nome\" class=\"control-label\">Nome</label>\r\n    <input type=\"text\" Name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 628, "\"", 647, 1);
                WriteAttributeValue("", 636, 
#nullable restore
#line 15 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                           Model.Nome

#line default
#line hidden
#nullable disable
                , 636, 11, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"CPF\" class=\"control-label\">CPF</label>\r\n    <input type=\"text\" Name=\"CPF\"");
                BeginWriteAttribute("value", " value=\"", 763, "\"", 781, 1);
                WriteAttributeValue("", 771, 
#nullable restore
#line 18 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                          Model.CPF

#line default
#line hidden
#nullable disable
                , 771, 10, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"Endereco\" class=\"control-label\">Endereço</label>\r\n    <input type=\"text\" Name=\"Endereco\"");
                BeginWriteAttribute("value", " value=\"", 912, "\"", 935, 1);
                WriteAttributeValue("", 920, 
#nullable restore
#line 21 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                               Model.Endereco

#line default
#line hidden
#nullable disable
                , 920, 15, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"Telefone\" class=\"control-label\">Telefone</label>\r\n    <input type=\"text\" Name=\"Telefone\"");
                BeginWriteAttribute("value", " value=\"", 1066, "\"", 1089, 1);
                WriteAttributeValue("", 1074, 
#nullable restore
#line 24 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                               Model.Telefone

#line default
#line hidden
#nullable disable
                , 1074, 15, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"Email\" class=\"control-label\">Email</label>\r\n    <input type=\"text\" Name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 1211, "\"", 1231, 1);
                WriteAttributeValue("", 1219, 
#nullable restore
#line 27 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                            Model.Email

#line default
#line hidden
#nullable disable
                , 1219, 12, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"PretensaoSalarial\" class=\"control-label\">Pretensão Salarial</label>\r\n    <input type=\"text\" Name=\"PretensaoSalarial\"");
                BeginWriteAttribute("value", " value=\"", 1390, "\"", 1422, 1);
                WriteAttributeValue("", 1398, 
#nullable restore
#line 30 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                        Model.PretensaoSalarial

#line default
#line hidden
#nullable disable
                , 1398, 24, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"CargoPretendido\" class=\"control-label\">Cargo Pretendido</label>\r\n    <input type=\"text\" Name=\"CargoPretendido\"");
                BeginWriteAttribute("value", " value=\"", 1575, "\"", 1605, 1);
                WriteAttributeValue("", 1583, 
#nullable restore
#line 33 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                      Model.CargoPretendido

#line default
#line hidden
#nullable disable
                , 1583, 22, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"Formacao1\" class=\"control-label\">1 - Formacao</label>\r\n    <input type=\"text\" Name=\"Formacao1\"");
                BeginWriteAttribute("value", " value=\"", 1742, "\"", 1766, 1);
                WriteAttributeValue("", 1750, 
#nullable restore
#line 36 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                Model.Formacao1

#line default
#line hidden
#nullable disable
                , 1750, 16, false);
                EndWriteAttribute();
                WriteLiteral(" required/>\r\n    <br />\r\n    <label for=\"Formacao2\" class=\"control-label\">2 - Formacao</label>\r\n    <input type=\"text\" Name=\"Formacao2\"");
                BeginWriteAttribute("value", " value=\"", 1902, "\"", 1926, 1);
                WriteAttributeValue("", 1910, 
#nullable restore
#line 39 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                Model.Formacao2

#line default
#line hidden
#nullable disable
                , 1910, 16, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Formacao3\" class=\"control-label\">3 - Formacao</label>\r\n    <input type=\"text\" Name=\"Formacao3\"");
                BeginWriteAttribute("value", " value=\"", 2054, "\"", 2078, 1);
                WriteAttributeValue("", 2062, 
#nullable restore
#line 42 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                Model.Formacao3

#line default
#line hidden
#nullable disable
                , 2062, 16, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Formacao4\" class=\"control-label\">4 - Formacao</label>\r\n    <input type=\"text\" Name=\"Formacao4\"");
                BeginWriteAttribute("value", " value=\"", 2206, "\"", 2230, 1);
                WriteAttributeValue("", 2214, 
#nullable restore
#line 45 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                Model.Formacao4

#line default
#line hidden
#nullable disable
                , 2214, 16, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Formacao5\" class=\"control-label\">5 - Formacao</label>\r\n    <input type=\"text\" Name=\"Formacao5\"");
                BeginWriteAttribute("value", " value=\"", 2358, "\"", 2382, 1);
                WriteAttributeValue("", 2366, 
#nullable restore
#line 48 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                Model.Formacao5

#line default
#line hidden
#nullable disable
                , 2366, 16, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Experiencia1\" class=\"control-label\">1 - Experiencia</label>\r\n    <input type=\"text\" Name=\"Experiencia1\"");
                BeginWriteAttribute("value", " value=\"", 2519, "\"", 2546, 1);
                WriteAttributeValue("", 2527, 
#nullable restore
#line 51 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                   Model.Experiencia1

#line default
#line hidden
#nullable disable
                , 2527, 19, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Experiencia2\" class=\"control-label\">2 - Experiencia</label>\r\n    <input type=\"text\" Name=\"Experiencia2\"");
                BeginWriteAttribute("value", " value=\"", 2683, "\"", 2710, 1);
                WriteAttributeValue("", 2691, 
#nullable restore
#line 54 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                   Model.Experiencia2

#line default
#line hidden
#nullable disable
                , 2691, 19, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Experiencia3\" class=\"control-label\">3 - Experiencia</label>\r\n    <input type=\"text\" Name=\"Experiencia3\"");
                BeginWriteAttribute("value", " value=\"", 2847, "\"", 2874, 1);
                WriteAttributeValue("", 2855, 
#nullable restore
#line 57 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                                   Model.Experiencia3

#line default
#line hidden
#nullable disable
                , 2855, 19, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Idioma1\" class=\"control-label\">1 - Idioma</label>\r\n    <input type=\"text\" Name=\"Idioma1\"");
                BeginWriteAttribute("value", " value=\"", 2996, "\"", 3018, 1);
                WriteAttributeValue("", 3004, 
#nullable restore
#line 60 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                              Model.Idioma1

#line default
#line hidden
#nullable disable
                , 3004, 14, false);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n    <br />\r\n    <label for=\"Idioma2\" class=\"control-label\">2 - Idioma</label>\r\n    <input type=\"text\" Name=\"Idioma2\"");
                BeginWriteAttribute("value", " value=\"", 3149, "\"", 3171, 1);
                WriteAttributeValue("", 3157, 
#nullable restore
#line 63 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                              Model.Idioma2

#line default
#line hidden
#nullable disable
                , 3157, 14, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Idioma3\" class=\"control-label\">3 - Idioma</label>\r\n    <input type=\"text\" Name=\"Idioma3\"");
                BeginWriteAttribute("value", " value=\"", 3293, "\"", 3315, 1);
                WriteAttributeValue("", 3301, 
#nullable restore
#line 66 "C:\ProjetosTI\C#\ASP.NET\Curriculos\Views\Curriculo\Form.cshtml"
                                              Model.Idioma3

#line default
#line hidden
#nullable disable
                , 3301, 14, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <input type=\"submit\" value=\"Salvar dados\" />\r\n    <br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurriculoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
