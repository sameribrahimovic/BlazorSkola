#pragma checksum "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e8da70bdd96d8e3e64d42a87e9e15262cb998a5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSkola.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using BlazorSkola.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using BlazorSkola.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
using BlazorSkola.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/grupe")]
    public partial class Groups : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MENADZMENT KURSEVA</h3>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-3 mb-3");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<label class=\"control-label\">PRETRAGA GRUPA</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Pretraga ");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                            Pretraga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pretraga = __value, Pretraga));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        <br>\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-block btn-success");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                            PretraziG

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "Pretraži");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n    <br>\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-block btn-success col-md-3");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                                OpenDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, " Dodaj Grupu ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n\r\n\r\n    ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.AddMarkupContent(25, "<thead>\r\n            <tr>\r\n                <th>Naziv Grupe</th>\r\n                <th>Izmeni/Brisi</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(26, "tbody");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 31 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
             foreach (Grupa g in ListaGrupa)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 34 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                         g.NazivGrupe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-outline-info oi oi-pencil");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                                                    () => Izmeni(g)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, " |\r\n                        ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn btn-outline-danger oi oi-trash");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                                                         () => Brisi(g)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 40 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n    ");
            __builder.OpenComponent<MatBlazor.MatDialog>(49);
            __builder.AddAttribute(50, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                              dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(54);
                __builder2.AddAttribute(55, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 46 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                          grupa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 46 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                 Sacuvaj

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatDialogTitle>(59);
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(61, "Dodavanje/Izmena");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatDialogContent>(63);
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(65, "\r\n                ");
                        __builder4.OpenElement(66, "div");
                        __builder4.AddAttribute(67, "class", "form-group");
                        __builder4.AddMarkupContent(68, "\r\n                    ");
                        __builder4.AddMarkupContent(69, "<label>Naziv Grupe</label>\r\n                    ");
                        __builder4.OpenElement(70, "input");
                        __builder4.AddAttribute(71, "class", "form-control");
                        __builder4.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                             grupa.NazivGrupe

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => grupa.NazivGrupe = __value, grupa.NazivGrupe));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(74, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n            ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "modal-footer");
                    __builder3.AddMarkupContent(79, "\r\n                ");
                    __builder3.OpenElement(80, "button");
                    __builder3.AddAttribute(81, "type", "button");
                    __builder3.AddAttribute(82, "class", "btn btn-secondary");
                    __builder3.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
                                                                          CancelDialog

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(84, "Zatvori");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n                ");
                    __builder3.AddMarkupContent(86, "<button type=\"submit\" class=\"btn btn-primary\" data-dismiss=\"modal\">Sacuvaj</button>\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Groups.razor"
           
        public HubConnection HCG;
        public Grupa grupa = new Grupa();
        public List<Grupa> ListaGrupa = new List<Grupa>();

        protected override async Task OnInitializedAsync()
        {
            HCG = new HubConnectionBuilder().WithUrl(NM.ToAbsoluteUri("HubGrupa")).Build();
            await HCG.StartAsync();

            HCG.On<List<Grupa>>("GrupaKaKlijentu", lg =>
            {
                ListaGrupa = lg;
                StateHasChanged();
            });
            await HCG.SendAsync("UcitajGrupe");
        }

        public async Task Sacuvaj()
        {
            await HCG.SendAsync("GrupaKaSrv", grupa);
            grupa = new Grupa();
            await HCG.SendAsync("UcitajGrupe");
        }
        public void Izmeni(Grupa g)
        {
            OpenDialog();
            grupa = g;
            StateHasChanged();

        }
        public async Task Brisi(Grupa g)
        {
            await HCG.SendAsync("BrisiGrupu", g);
            grupa = new Grupa();
        }


        private string Pretraga;

        public void PretraziG()
        {

            HCG.SendAsync("PretraziGrupe", Pretraga);
        }



        bool dialogIsOpen = false;
        public void OpenDialog()
        {

            dialogIsOpen = true;
        }

        public void CancelDialog()
        {
            dialogIsOpen = false;
            grupa = new Grupa();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NM { get; set; }
    }
}
#pragma warning restore 1591
