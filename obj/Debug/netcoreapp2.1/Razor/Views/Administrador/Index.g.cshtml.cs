#pragma checksum "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9887fef02a122b8cee730d6f4fe554d639808bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Index.cshtml", typeof(AspNetCore.Views_Administrador_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9887fef02a122b8cee730d6f4fe554d639808bf7", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a18bbdda5bee1a9586dbbc95400b6b6e2de7f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 127, true);
            WriteLiteral("\r\n<nav class=\"nav\">\r\n    <div id=\"logo\">\r\n        <img src=\"img/logo.png\" alt=\"logotipo\">\r\n    </div>\r\n    <ul>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 159, "\'", 206, 1);
#line 10 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 166, Url.Action("Usuarios", "Administrador"), 166, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(207, 43, true);
            WriteLiteral(">Lista de Usuários</a></li>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 250, "\'", 300, 1);
#line 11 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 257, Url.Action("Comentarios", "Administrador"), 257, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(301, 44, true);
            WriteLiteral(">Lista de Comentários</a></li>\r\n        <li>");
            EndContext();
            BeginContext(345, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f23c7637914c452882e2bf1aa9cd2761", async() => {
                BeginContext(406, 6, true);
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
            BeginContext(416, 180, true);
            WriteLiteral("</li>\r\n    </ul>\r\n</nav>\r\n\r\n<div class=\"linha_amr\"></div>  \r\n\r\n<section>\r\n    <div class=\"dashboard\">\r\n\r\n        <div id=\"usuarios\">\r\n            <p>Total de usuários cadastrados: ");
            EndContext();
            BeginContext(597, 32, false);
#line 22 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Index.cshtml"
                                         Write(ViewData["quantidadeDeUsuarios"]);

#line default
#line hidden
            EndContext();
            BeginContext(629, 93, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div id=\"comentarios\">\r\n            <p>Total de comentários: ");
            EndContext();
            BeginContext(723, 35, false);
#line 26 "c:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Administrador\Index.cshtml"
                                Write(ViewData["quantidadeDeComentarios"]);

#line default
#line hidden
            EndContext();
            BeginContext(758, 274, true);
            WriteLiteral(@"</p>
        </div>

        <div id=""comentarios_aprovados"">
            <p>Total de comentários aprovados: </p>
        </div>

        <div id=""comentarios_rejeitados"">
            <p>Total de comentários reprovados: </p>
        </div>

    </div>
</section>");
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
