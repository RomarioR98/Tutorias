#pragma checksum "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Materias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c35412a576832548657308c585e9185abe5f0258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Alumno_Views_Home_Materias), @"mvc.1.0.view", @"/Areas/Alumno/Views/Home/Materias.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Alumno/Views/Home/Materias.cshtml", typeof(AspNetCore.Areas_Alumno_Views_Home_Materias))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c35412a576832548657308c585e9185abe5f0258", @"/Areas/Alumno/Views/Home/Materias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Alumno/Views/_ViewImports.cshtml")]
    public class Areas_Alumno_Views_Home_Materias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tutorias.Models.AlumnosMateriaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AgregarMateriaAlum"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Materias.cshtml"
  
    ViewData["Title"] = "Materias";
    Layout = "~/Views/Shared/_LayoutAlumno.cshtml";

#line default
#line hidden
            BeginContext(158, 325, true);
            WriteLiteral(@"
<!--#######################  Header    #######################-->
<header class=""cabecera"">
    <div class=""container"">
        <h1> Mis materias</h1>
    </div>
</header>

<!--#######################   Contenedor materias   #######################-->
<div class=""contenedorMaterias"">
    <div class=""container"">
");
            EndContext();
#line 17 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Materias.cshtml"
         foreach (var Alumnosmateria in Model)
        {

#line default
#line hidden
            BeginContext(542, 271, true);
            WriteLiteral(@"            <div class=""card text-dark bg-light mb-3"" style=""max-width: 15rem;  max-height:12rem ;"">
                <a href=""../Publicaciones/index.html"" class=""badge badge-light"">
                    <div class=""card-header"" style=""font-size: 16px; font-weight:500;"">");
            EndContext();
            BeginContext(814, 43, false);
#line 21 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Materias.cshtml"
                                                                                  Write(Alumnosmateria.IdMateriaNavigation.Materia1);

#line default
#line hidden
            EndContext();
            BeginContext(857, 114, true);
            WriteLiteral("</div>\r\n                </a>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(972, 24, false);
#line 24 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Materias.cshtml"
                                      Write(Alumnosmateria.IdMateria);

#line default
#line hidden
            EndContext();
            BeginContext(996, 276, true);
            WriteLiteral(@"</h5>
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-light"">
                            <i class=""far fa-trash-alt""></i>
                        </a>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 32 "C:\Users\patty\Desktop\ProyectoTutorias\Tutorias\Areas\Alumno\Views\Home\Materias.cshtml"
        }

#line default
#line hidden
            BeginContext(1283, 271, true);
            WriteLiteral(@"

        <div id=""cardAg"" class=""card text-dark bg-light mb-3"" style=""max-width: 15rem; max-height:12rem ;"">
            <div class=""card-header"" style=""font-size: 16px; font-weight:500;"">Agregar materias</div>
            <div class=""card-body"">

                ");
            EndContext();
            BeginContext(1554, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ecfa242b16b407b902a218f5de63a46", async() => {
                BeginContext(1607, 67, true);
                WriteLiteral("\r\n                    <i class=\"fas fa-plus\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 74, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tutorias.Models.AlumnosMateriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
