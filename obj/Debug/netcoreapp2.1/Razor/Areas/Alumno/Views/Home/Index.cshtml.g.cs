#pragma checksum "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74f14bf575efbdb8026b56d43719764e95464d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Alumno_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Alumno/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Alumno/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Alumno_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74f14bf575efbdb8026b56d43719764e95464d7", @"/Areas/Alumno/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Alumno/Views/_ViewImports.cshtml")]
    public class Areas_Alumno_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tutorias.Models.Alumno>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_LayoutAlumno";


#line default
#line hidden
            BeginContext(149, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(184, 404, true);
            WriteLiteral(@"<header class=""cabecera"">
    <div class=""container"">
        <h1>Cuenta</h1>
    </div>
</header>

<!--#######################   Formulario Alumnos  #######################-->
<div class=""formReadAl bg-light align-lg-center | mt-2 mx-auto mb-3"">
    <div class=""containerDatosPersonales"">
        <h3 id=""eDatosPersonales "">Datos personales</h3>
        <div class=""btn-group"">

            ");
            EndContext();
            BeginContext(588, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6e528af63da4219adea3e767c8a2d02", async() => {
                BeginContext(662, 58, true);
                WriteLiteral("\r\n                <i class=\"fas fa-pen\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 619, "~/Alumno/Home/Editar/", 619, 21, true);
#line 24 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 640, Model.NumeroControl, 640, 20, false);

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
            BeginContext(724, 384, true);
            WriteLiteral(@"
            <button type=""button"" href=""#"" class=""btn btn-light"">
                <i class=""far fa-trash-alt""></i>
            </button>

        </div>
    </div>

    <div class=""container my-2 bg-light"">
        <div id=""contenedorForm"">
            <label type=""text"" name=""Rol"" id=""txtIdRoll"" class=""form-control"" aria-describedby=""basic-addon1"" value=""Alumno"" hidden>");
            EndContext();
            BeginContext(1109, 9, false);
#line 36 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                               Write(Model.Rol);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 384, true);
            WriteLiteral(@"</label>

            <div class=""input-group mb-3 "">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""NumeroControl"">Numero de Control</span>
                </div>
                <label type=""text"" name=""txtNumControl"" id=""txtNumControl"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(1503, 19, false);
#line 42 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                                    Write(Model.NumeroControl);

#line default
#line hidden
            EndContext();
            BeginContext(1522, 389, true);
            WriteLiteral(@"</label>

            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""Nombre"" Nombres"">Nombre</span>
                </div>
                <label type=""text"" name=""Nombre"" id=""txtNombre"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(1912, 12, false);
#line 49 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                         Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1924, 396, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""ApPaterno"">Apellido Paterno</span>
                </div>
                <label type=""text"" name=""ApPaterno"" id=""txtApPaterno"" class=""form-control"" aria-describedby=""basic-addon1"" disable>");
            EndContext();
            BeginContext(2321, 15, false);
#line 55 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                              Write(Model.ApPaterno);

#line default
#line hidden
            EndContext();
            BeginContext(2336, 397, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""ApMaterno"">Apellido Materno</span>
                </div>
                <label type=""text"" name=""ApMaterno"" id=""txtApMaterno"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(2734, 15, false);
#line 61 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                               Write(Model.ApMaterno);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 377, true);
            WriteLiteral(@"</label>
            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Semestre</span>
                </div>
                <label type=""text""  name=""IdSemestre"" id=""txtIdSemestre"" class=""form-control"" aria-describedby=""basic-addon1"" disabled >");
            EndContext();
            BeginContext(3127, 32, false);
#line 67 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                                   Write(Model.IdSemestreNavigation.NoSem);

#line default
#line hidden
            EndContext();
            BeginContext(3159, 378, true);
            WriteLiteral(@"</label>


            </div>

            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"">Carrera</span>
                </div>
                <label type=""text"" name=""IdCarrera"" id=""txtIdCarrera"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(3538, 34, false);
#line 76 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                               Write(Model.IdCarreraNavigation.Carrera1);

#line default
#line hidden
            EndContext();
            BeginContext(3572, 377, true);
            WriteLiteral(@"</label>

            </div>
            <div class=""input-group mb-3 w-100"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1"" for=""Email"">Email</span>
                </div>
                <label type=""email"" name=""Email"" id=""txtEmail"" class=""form-control"" aria-describedby=""basic-addon1"" disabled>");
            EndContext();
            BeginContext(3950, 11, false);
#line 83 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Index.cshtml"
                                                                                                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3961, 77, true);
            WriteLiteral("</label>\r\n            </div>\r\n\r\n         </div>\r\n\r\n        </div>\r\n  </div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Tutorias.Services.MenuService ms { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tutorias.Models.Alumno> Html { get; private set; }
    }
}
#pragma warning restore 1591
