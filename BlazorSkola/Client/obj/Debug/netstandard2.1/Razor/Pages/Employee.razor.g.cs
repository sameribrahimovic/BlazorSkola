#pragma checksum "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcadd981d7e3929a6cd646d0aa555c9bd0c046e5"
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
#line 2 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
using BlazorSkola.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MENADZMENT ZAPOSLENIH</h3>\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-3 mb-3");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<label class=\"control-label\">PRETRAGA ZAPOSLENIH</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Pretraga ");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                        Pretraga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pretraga = __value, Pretraga));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    <br>\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-block btn-success");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                        PretraziZ

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "Pretraži");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-block btn-success col-md-3");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                            OpenDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, " Dodaj Zaposlenog ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, @"<thead>
        <tr>
            <th>ID</th>
            <th>Ime</th>
            <th>Prezime</th>
            <th>Adresa</th>
            <th>Grad</th>
            <th>Kontakt Tel.</th>
            <th>Email</th>
            <th>Izmeni/Brisi</th>
        </tr>
    </thead>

    ");
            __builder.OpenElement(26, "tbody");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 39 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
         foreach (Radnik rad in ListaRadnika)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "            ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 42 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 43 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.Ime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 44 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.Prezime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 45 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.Adresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 46 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.Grad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 47 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.KontaktTel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 48 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                     rad.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-outline-info oi oi-pencil");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                                () => Izmeni(rad)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(57, " |\r\n                    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn btn-outline-danger oi oi-trash");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                                     () => Brisi(rad)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 54 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n<br>\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(67);
            __builder.AddAttribute(68, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(72);
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(74, "Dodaj / Izmeni Korisnika");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorSkola.Client.Pages.Employee.TypeInference.CreateMatTextField_0(__builder3, 78, 79, "Ime Korisnika", 80, 
#nullable restore
#line 65 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                       radnici.Ime

#line default
#line hidden
#nullable disable
                    , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => radnici.Ime = __value, radnici.Ime)), 82, () => radnici.Ime);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(84);
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorSkola.Client.Pages.Employee.TypeInference.CreateMatTextField_1(__builder3, 86, 87, "Prezime Korisnika", 88, 
#nullable restore
#line 66 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                           radnici.Prezime

#line default
#line hidden
#nullable disable
                    , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => radnici.Prezime = __value, radnici.Prezime)), 90, () => radnici.Prezime);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(92);
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorSkola.Client.Pages.Employee.TypeInference.CreateMatTextField_2(__builder3, 94, 95, "Adresa Korisnika", 96, 
#nullable restore
#line 67 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                          radnici.Adresa

#line default
#line hidden
#nullable disable
                    , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => radnici.Adresa = __value, radnici.Adresa)), 98, () => radnici.Adresa);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(100);
                __builder2.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorSkola.Client.Pages.Employee.TypeInference.CreateMatTextField_3(__builder3, 102, 103, "Grad Korisnika", 104, 
#nullable restore
#line 68 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                        radnici.Grad

#line default
#line hidden
#nullable disable
                    , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => radnici.Grad = __value, radnici.Grad)), 106, () => radnici.Grad);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(108);
                __builder2.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorSkola.Client.Pages.Employee.TypeInference.CreateMatTextField_4(__builder3, 110, 111, "Kontakt Korisnika", 112, 
#nullable restore
#line 69 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                           radnici.KontaktTel

#line default
#line hidden
#nullable disable
                    , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => radnici.KontaktTel = __value, radnici.KontaktTel)), 114, () => radnici.KontaktTel);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(116);
                __builder2.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorSkola.Client.Pages.Employee.TypeInference.CreateMatTextField_5(__builder3, 118, 119, "Email Korisnika", 120, 
#nullable restore
#line 70 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                                                                         radnici.Email

#line default
#line hidden
#nullable disable
                    , 121, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => radnici.Email = __value, radnici.Email)), 122, () => radnici.Email);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(124);
                __builder2.AddAttribute(125, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(126, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(127);
                    __builder3.AddAttribute(128, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                            Sacuvaj

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(130, "Dodaj");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(132);
                    __builder3.AddAttribute(133, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
                            CancelDialog

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(135, "Zatvori");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(136, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\Employee.razor"
       

    public HubConnection HC;
    public Radnik radnici = new Radnik();
    public List<Radnik> ListaRadnika = new List<Radnik>();

    protected override async Task OnInitializedAsync()
    {
        HC = new HubConnectionBuilder().WithUrl(NM.ToAbsoluteUri("HubRadnici")).Build();
        await HC.StartAsync();

        HC.On<List<Radnik>>("KaKlijentu", lr =>
        {
            ListaRadnika = lr;
            StateHasChanged();
        });
        await HC.SendAsync("UcitajZaposlene");
    }

    public async Task Sacuvaj()
    {
        await HC.SendAsync("RadKaSrv", radnici);
        //radnici.ID = ListaRadnika.Count + 1; // stavljeno radi provere.
        radnici = new Radnik();
        await HC.SendAsync("UcitajZaposlene");
    }
    public void Izmeni(Radnik rad)
    {
        dialogIsOpen = true;
        radnici = rad;
        StateHasChanged();
        //ZatvoriDijalog();
        //dialogJeOtvoren = false;

    }
    public async Task Brisi(Radnik rad)
    {
        await HC.SendAsync("BrisiRadnika", rad);
        radnici = new Radnik();
    }


    private string Pretraga;

    public void PretraziZ()
    {

        HC.SendAsync("PretraziZaposlene", Pretraga);
    }

    bool dialogIsOpen = false;
    public void OpenDialog()
    {

        dialogIsOpen = true;
    }

    public void CancelDialog()
    {
        dialogIsOpen = false;
        radnici = new Radnik();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NM { get; set; }
    }
}
namespace __Blazor.BlazorSkola.Client.Pages.Employee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591