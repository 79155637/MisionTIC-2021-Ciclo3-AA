#pragma checksum "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "990fa86d6d5fca6c68ab04230a0f2d2f78f27ca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.FrontEnd.Pages.Pacientes.Pages_Pacientes_Details), @"mvc.1.0.razor-page", @"/Pages/Pacientes/Details.cshtml")]
namespace HospiEnCasa.App.FrontEnd.Pages.Pacientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990fa86d6d5fca6c68ab04230a0f2d2f78f27ca5", @"/Pages/Pacientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838d893bfb9edbc2070b3bf50586b3a2a49e3e05", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Pacientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Signos/List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
  
    int pacienteId=Model.Paciente.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h6>Datos Detallados del Paciente: ");
#nullable restore
#line 6 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
                              Write(Model.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
                                                     Write(Model.Paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<div>\r\n    IDENTIFICACION: ");
#nullable restore
#line 8 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
               Write(Model.Paciente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Nombre: ");
#nullable restore
#line 11 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Apellidos: ");
#nullable restore
#line 14 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
          Write(Model.Paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Telefono: ");
#nullable restore
#line 17 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
         Write(Model.Paciente.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Ciudad: ");
#nullable restore
#line 20 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
       Write(Model.Paciente.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Dirección: ");
#nullable restore
#line 23 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
          Write(Model.Paciente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Medico Id: ");
#nullable restore
#line 26 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
          Write(Model.Paciente.Medico.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Doctor: ");
#nullable restore
#line 26 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
                                            Write(Model.Paciente.Medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
                                                                          Write(Model.Paciente.Medico.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990fa86d6d5fca6c68ab04230a0f2d2f78f27ca58080", async() => {
                WriteLiteral("\r\n            <i aria-hidden=\"true\">Signos Vitales</i>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pacienteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\david\Documents\GitHub\MisionTIC-2021-Ciclo3-AA\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Details.cshtml"
                                                                          WriteLiteral(pacienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pacienteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pacienteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pacienteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990fa86d6d5fca6c68ab04230a0f2d2f78f27ca510481", async() => {
                WriteLiteral(" Volver a la Lista de Pacientes ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.FrontEnd.Pages.Pacientes.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.FrontEnd.Pages.Pacientes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.FrontEnd.Pages.Pacientes.DetailsModel>)PageContext?.ViewData;
        public HospiEnCasa.App.FrontEnd.Pages.Pacientes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
