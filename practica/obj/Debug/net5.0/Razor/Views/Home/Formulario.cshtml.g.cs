#pragma checksum "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb44814b5cd40ce45c7f27dae6feca5698a3ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Formulario), @"mvc.1.0.view", @"/Views/Home/Formulario.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Enzo\source\repos\practica\practica\Views\_ViewImports.cshtml"
using practica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enzo\source\repos\practica\practica\Views\_ViewImports.cshtml"
using practica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb44814b5cd40ce45c7f27dae6feca5698a3ff8", @"/Views/Home/Formulario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d21adaea82f239cdce02d04acd88aa9dc3021b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Formulario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<practica.Models.CargarEmpleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml"
   ViewData["Title"] = "Show Employee"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">");
#nullable restore
#line 9 "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml"
                       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
#nullable restore
#line 10 "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml"
                       Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
#nullable restore
#line 11 "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml"
                       Write(Model.AnioIngreso.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
#nullable restore
#line 12 "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml"
                       Write(Model.Nacimiento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
#nullable restore
#line 13 "C:\Users\Enzo\source\repos\practica\practica\Views\Home\Formulario.cshtml"
                       Write(Model.Sueldo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<practica.Models.CargarEmpleado> Html { get; private set; }
    }
}
#pragma warning restore 1591