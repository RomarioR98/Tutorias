#pragma checksum "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "144c35aac4f37e4c4a034c41ec654e534f92e177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Maestro_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Maestro/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Maestro/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Maestro_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144c35aac4f37e4c4a034c41ec654e534f92e177", @"/Areas/Maestro/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Maestro/Views/_ViewImports.cshtml")]
    public class Areas_Maestro_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tutorias.Models.Maestro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(103, 469, true);
            WriteLiteral(@"<!--#######################  Header    #######################-->
<header class=""cabecera"">
    <div class=""container"">
        <h1>Cuenta</h1>
    </div>
</header>

<!--#######################   Formulario Docentes  #######################-->
<div class=""formReadDoc bg-light align-lg-center mt-2 mx-auto mb-3"">
    <div class=""containerDatosPersonales"">
        <h3 id=""eDatosPersonales "">Datos personales</h3>
        <div class=""btn-group"">
            ");
            EndContext();
            BeginContext(572, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bb098a788b48d1a60b2ead51b5ed17", async() => {
                BeginContext(647, 58, true);
                WriteLiteral("\r\n                <i class=\"fas fa-pen\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 603, "~/Maestro/Home/Editar/", 603, 22, true);
#line 18 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 625, Model.NumeroControl, 625, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(709, 749, true);
            WriteLiteral(@"
            <button type=""button"" href=""#"" class=""btn btn-light"">
                <i class=""far fa-trash-alt""></i>
            </button>


        </div>
    </div>

    <div class=""container my-2 bg-light"">
        <div>
            <label type=""text"" name=""Rol"" id=""txtIdRoll"" class=""form-control"" aria-describedby=""basic-addon1"" value=""Maestro"" hidden></label>
            <div class=""input-group mb-3 "">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" for=""NumeroControl"" id=""basic-addon1"">Numero de Control</span>
                </div>
                <label type=""text"" name=""txtNumControl"" id=""txtNumControl"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(1459, 19, false);
#line 36 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
                                                                                                                                    Write(Model.NumeroControl);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 381, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""Nombre"">Nombre</span>
                </div>
                <label type=""text"" name=""txtNombre"" id=""txtNombre"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(1860, 12, false);
#line 42 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 399, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" for=""ApPaterno"" id=""basic-addon1"">Apelido Paterno</span>
                </div>
                <label type=""text"" name=""txtApPaterno"" id=""txtApPaterno"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(2272, 15, false);
#line 48 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
                                                                                                                                  Write(Model.ApPaterno);

#line default
#line hidden
            EndContext();
            BeginContext(2287, 400, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""ApMaterno"">Apellido Materno</span>
                </div>
                <label type=""text"" name=""txtApMaterno"" id=""txtApMaterno"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(2688, 15, false);
#line 54 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
                                                                                                                                  Write(Model.ApMaterno);

#line default
#line hidden
            EndContext();
            BeginContext(2703, 378, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""Email"">Email</span>
                </div>
                <label type=""email"" name=""txtEmail"" id=""txtEmail"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(3082, 11, false);
#line 60 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Maestro\Views\Home\Index.cshtml"
                                                                                                                           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3093, 66, true);
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tutorias.Models.Maestro> Html { get; private set; }
    }
}
#pragma warning restore 1591
