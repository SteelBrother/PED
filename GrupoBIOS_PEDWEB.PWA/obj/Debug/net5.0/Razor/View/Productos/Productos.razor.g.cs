#pragma checksum "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\View\Productos\Productos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb35aa2583a850236f9a866f7f43d63ec84ac66a"
// <auto-generated/>
#pragma warning disable 1591
namespace GrupoBIOS_PEDWEB.PWA.View.Productos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.DT.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.PWA.View.Administracion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.PWA.Componentes.Administracion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\_Imports.razor"
using GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.Productos.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Productos")]
    public partial class Productos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\View\Productos\Productos.razor"
                 ConsultarProductos.portafolio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatAccordion>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatExpansionPanel>(5);
                    __builder3.AddAttribute(6, "Style", "box-shadow: none;");
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatExpansionPanelSummary>(8);
                        __builder4.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatExpansionPanelHeader>(10);
                            __builder5.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(12, "<div>\r\n                        PRIMERO\r\n                    </div>");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(13, "\r\n            ");
                        __builder4.OpenComponent<MatBlazor.MatExpansionPanelDetails>(14);
                        __builder4.AddAttribute(15, "Class", "detalles-acordeon");
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "<div class=\"content\"></div>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Admin\source\repos\GrupoBIOS_PEDWEB\GrupoBIOS_PEDWEB.PWA\View\Productos\Productos.razor"
  

    protected async override void OnInitialized()
    {
        await ConsultarProductos.CargarPortafolioPorCliente(1, "993",1);

    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConsultarPortafolio_ViewModel ConsultarProductos { get; set; }
    }
}
#pragma warning restore 1591
