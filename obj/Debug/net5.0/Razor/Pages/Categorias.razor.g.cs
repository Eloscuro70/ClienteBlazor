#pragma checksum "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ff5ff4a50795f29f5471d7e7d3756cae1159fb"
// <auto-generated/>
#pragma warning disable 1591
namespace Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Pages
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
#nullable restore
#line 2 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categorias")]
    public partial class Categorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
               Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Categoria");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 9 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
     foreach (var item in instrumentos)
    {
        string clasificacion = "";

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudItem>(7);
                __builder2.AddAttribute(8, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                             10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                     6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "lg", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                            4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(13);
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardHeader>(15);
                        __builder4.AddAttribute(16, "Class", "blue darken-1");
                        __builder4.AddAttribute(17, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(18);
                            __builder5.AddAttribute(19, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                       Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 16 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
__builder6.AddContent(21, item.Nombre);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(23);
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 20 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                     switch (item.Clasificacion)
                    {
                        case 1:
                            clasificacion = "Primero";
                            break;
                        case 2:
                            clasificacion = "Segundo";
                            break;
                        case 3:
                            clasificacion = "Tercero";
                            break;

                    }

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<MudBlazor.MudText>(25);
                            __builder5.AddAttribute(26, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 33 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                   Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(28, "Clasificacion: ");
#nullable restore
#line 33 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
__builder6.AddContent(29, clasificacion);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(31);
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudButton>(33);
                            __builder5.AddAttribute(34, "Link", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                       $"/contaxInstrumentos/{item.Id}"

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(35, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 37 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 37 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
                                                                                                            Color.Tertiary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "Class", "text-center");
                            __builder5.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(39, "Ver Contacto");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 42 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Blazor.Proyecto\Tienda_De_Instrumentos_MUsicales.ClienteBlazor\Pages\Categorias.razor"
       
    IEnumerable<Categoria> instrumentos = new List<Categoria>();
    protected override async Task OnInitializedAsync()
    {
        instrumentos = await CategoriaService.GetAll();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriaService CategoriaService { get; set; }
    }
}
#pragma warning restore 1591
