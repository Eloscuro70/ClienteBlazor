#pragma checksum "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e033a6af8bd43359c56046f1e2b32f72d4494d4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Tienda_De_Instrumentos_MUsicales.ClienteBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 2 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                                                               Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Href", "/");
                __builder2.AddAttribute(6, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 2 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                                                                                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(10);
                __builder2.AddAttribute(11, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.Map

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Href", "/categorias");
                __builder2.AddAttribute(13, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 3 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                                                                                 Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                                                                                                    NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "Categorias");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(18);
                __builder2.AddAttribute(19, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.MapsHomeWork

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Href", "/contactos");
                __builder2.AddAttribute(21, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 4 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                                                                                         Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Shared\NavMenu.razor"
                                                                                                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "Contactos");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
