#pragma checksum "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79c459b5bd37f742a4894bd969a623e0f35e83f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
#line 1 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\_ViewImports.cshtml"
using PontoDigitalMVC;

#line default
#line hidden
#line 2 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\_ViewImports.cshtml"
using PontoDigitalMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79c459b5bd37f742a4894bd969a623e0f35e83f", @"/Views/Shared/_HeaderNavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a18bbdda5bee1a9586dbbc95400b6b6e2de7f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
  
    var user = (string) ViewData["User"];
    var adm = (string) ViewData["Adm"];

#line default
#line hidden
            BeginContext(91, 127, true);
            WriteLiteral("\r\n<nav class=\"nav\">\r\n    <div id=\"logo\">\r\n        <img src=\"img/logo.png\" alt=\"logotipo\">\r\n    </div>\r\n    <ul>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 218, "\'", 261, 2);
#line 11 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 225, Url.Action("Index", "Home"), 225, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 253, "#produto", 253, 8, true);
            EndWriteAttribute();
            BeginContext(262, 33, true);
            WriteLiteral(">Produto</a></li>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 295, "\'", 339, 2);
#line 12 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 302, Url.Action("Index", "Home"), 302, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 330, "#historia", 330, 9, true);
            EndWriteAttribute();
            BeginContext(340, 34, true);
            WriteLiteral(">História</a></li>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 374, "\'", 416, 2);
#line 13 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 381, Url.Action("Index", "Home"), 381, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 409, "#planos", 409, 7, true);
            EndWriteAttribute();
            BeginContext(417, 32, true);
            WriteLiteral(">Planos</a></li>\r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 449, "\'", 492, 2);
#line 14 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 456, Url.Action("Index", "Home"), 456, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 484, "#contato", 484, 8, true);
            EndWriteAttribute();
            BeginContext(493, 21, true);
            WriteLiteral(">Suporte</a></li>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
         if(string.IsNullOrEmpty(user) && string.IsNullOrEmpty(adm))
            {

#line default
#line hidden
            BeginContext(599, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(619, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1498f26e53e14ec79dfe145b0b6a43ca", async() => {
                BeginContext(678, 5, true);
                WriteLiteral("Login");
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
            BeginContext(687, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
            } else 
            {

#line default
#line hidden
            BeginContext(730, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 752, "\'", 793, 1);
#line 21 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 759, Url.Action("Index", "Comentario"), 759, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(794, 42, true);
            WriteLiteral(">Comentário</a></li>\r\n                <li>");
            EndContext();
            BeginContext(836, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74628b03f9ed40cdb84bb2b0be460a5b", async() => {
                BeginContext(897, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(907, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 23 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
            }

#line default
#line hidden
            BeginContext(929, 20, true);
            WriteLiteral("    \r\n        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 949, "\'", 988, 1);
#line 25 "C:\Users\46309932829\Documents\Projetos\SENAI\PontoDigitalMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 956, Url.Action("Index", "Cadastro"), 956, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(989, 73, true);
            WriteLiteral(">Cadastrar</a></li>\r\n    </ul>\r\n</nav>\r\n<div class=\"linha_amr\"></div>  \r\n");
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
