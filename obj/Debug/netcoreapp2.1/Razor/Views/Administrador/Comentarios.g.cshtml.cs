#pragma checksum "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1082bac11891e720a16e3bad46d792c604c22190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Comentarios), @"mvc.1.0.view", @"/Views/Administrador/Comentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Comentarios.cshtml", typeof(AspNetCore.Views_Administrador_Comentarios))]
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
#line 1 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\_ViewImports.cshtml"
using PontoDigitalMVC;

#line default
#line hidden
#line 2 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\_ViewImports.cshtml"
using PontoDigitalMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1082bac11891e720a16e3bad46d792c604c22190", @"/Views/Administrador/Comentarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a18bbdda5bee1a9586dbbc95400b6b6e2de7f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Comentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigitalMVC.ViewModel.ListasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(82, 127, true);
            WriteLiteral("\r\n<nav class=\"nav\">\r\n    <div id=\"logo\">\r\n        <img src=\"img/logo.png\" alt=\"logotipo\">\r\n    </div>\r\n    <ul>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 209, "\'", 256, 1);
#line 11 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 216, Url.Action("Usuarios", "Administrador"), 216, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(257, 43, true);
            WriteLiteral(">Lista de Usuários</a></li>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 300, "\'", 350, 1);
#line 12 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 307, Url.Action("Comentarios", "Administrador"), 307, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(351, 46, true);
            WriteLiteral(">Lista de Comentários</a></li>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 397, "\'", 441, 1);
#line 13 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 404, Url.Action("Index", "Administrador"), 404, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(442, 30, true);
            WriteLiteral(">Voltar</a></li>\r\n        <li>");
            EndContext();
            BeginContext(472, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c76fcee782c44e83a393b1b36e1e914e", async() => {
                BeginContext(533, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(543, 320, true);
            WriteLiteral(@"</li>
    </ul>
</nav>

<div class=""linha_amr""></div>  

<div class=""container"">
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Texto</th>
            <th>Data da postagem</th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 32 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
         foreach(var c in Model.Comentarios)
            {

#line default
#line hidden
            BeginContext(924, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(945, 4, false);
#line 34 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
               Write(c.Id);

#line default
#line hidden
            EndContext();
            BeginContext(949, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(977, 14, false);
#line 35 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
               Write(c.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(991, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1019, 7, false);
#line 36 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
               Write(c.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1026, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1054, 13, false);
#line 37 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
               Write(c.DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 59, true);
            WriteLiteral("</td>\r\n                <td>\r\n                <td><button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1174, 2);
            WriteAttributeValue("", 1133, "/Administrador/AprovarComentario?id=", 1133, 36, true);
#line 39 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1169, c.Id, 1169, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1175, 62, true);
            WriteLiteral(">Aprovar</a></button></td>    \r\n                <td><button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1237, "\"", 1276, 2);
            WriteAttributeValue("", 1244, "/Administrador/Rejeitar?id=", 1244, 27, true);
#line 40 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1271, c.Id, 1271, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1277, 53, true);
            WriteLiteral(">Rejeitar</a></button></td> \r\n                </td>\r\n");
            EndContext();
#line 42 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Comentarios.cshtml"
            }

#line default
#line hidden
            BeginContext(1345, 32, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigitalMVC.ViewModel.ListasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
