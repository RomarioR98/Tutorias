#pragma checksum "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Views\Home\RegistroMaestros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a32f9e6f3322946b4f70b7a1aaf7317bffac206f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegistroMaestros), @"mvc.1.0.view", @"/Views/Home/RegistroMaestros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RegistroMaestros.cshtml", typeof(AspNetCore.Views_Home_RegistroMaestros))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32f9e6f3322946b4f70b7a1aaf7317bffac206f", @"/Views/Home/RegistroMaestros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegistroMaestros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Views\Home\RegistroMaestros.cshtml"
  
    ViewData["Title"] = "RegistroMaestros";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(79, 496, true);
            WriteLiteral(@"<!--#######################  Header    #######################-->
<header class=""cabecera"">
    <div class=""container"">
        <h1> Registro Maestros</h1>
    </div>
</header>

<!--#######################  Registro Maestros   #######################-->
<div class=""formAgDoc bg-light align-lg-center mt-2 mx-auto mb-3"">
    <div class=""containerDatosPersonales"">
        <h3 id=""eDatosPersonales"">Datos personales</h3>
    </div>

    <div class=""container my-2 bg-light"">
        ");
            EndContext();
            BeginContext(575, 2356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c19d92bf3fee41b6b7c0bb638faa592e", async() => {
                BeginContext(598, 2187, true);
                WriteLiteral(@"
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Numero de Control</span>
                </div>
                <input type=""text"" name=""txtNumControl"" id=""txtNumControl"" class=""form-control"" aria-describedby=""basic-addon1"">
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Nombre</span>
                </div>
                <input type=""text"" name=""txtNombre"" id=""txtNombre"" class=""form-control"" aria-describedby=""basic-addon1"">
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Apellido Paterno</span>
                </div>
                <input type=""text"" name=""txtApPaterno"" id=""txtApPaterno"" class=""fo");
                WriteLiteral(@"rm-control"" aria-describedby=""basic-addon1"">
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Apellido Materno</span>
                </div>
                <input type=""text"" name=""txtApMaterno"" id=""txtApMaterno"" class=""form-control"" aria-describedby=""basic-addon1"">
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Email</span>
                </div>
                <input type=""email"" name=""txtEmail"" id=""txtEmail"" class=""form-control"" aria-describedby=""basic-addon1"">
            </div>

            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Contraseña</span>
                </div>
                <input type");
                WriteLiteral("=\"password\" name=\"txtContraseña\" id=\"txtContraseña\" class=\"form-control\" aria-describedby=\"basic-addon1\">\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(2786, 24, false);
#line 58 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Views\Home\RegistroMaestros.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(2810, 114, true);
                WriteLiteral("\r\n            <input class=\"btn btn-secondary btn-md float-right mb-3\" type=\"submit\" value=\"Registar\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2931, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
