#pragma checksum "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce3f0b24aa1cd9247207054557bfd5adc6c60bb"
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
#line 2 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
using BlazorSkola.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentis")]
    public partial class StudentsPg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MENADZMENT STUDENATA</h3>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-3 mb-3");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<label class=\"control-label\">PRETRAGA STUDENATA</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Pretraga ");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                        Pretraga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pretraga = __value, Pretraga));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-block btn-success");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                        PretraziS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "Pretraži");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-block btn-success col-md-3");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                            OpenDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Dodaj Studenta");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n\r\n\r\n");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, "<thead>\r\n        <tr>\r\n            <th>Ime</th>\r\n            <th>Prezime</th>\r\n            <th>Kurs</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(26, "tbody");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 29 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
         foreach (Student st in ListaStudenata)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 32 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                 st.Ime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 33 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                 st.Prezime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 34 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                 st.kurs.NazivKursa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-outline-info oi oi-pencil");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                                            () => Izmeni(st)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(45, " |\r\n                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn btn-outline-danger oi oi-trash");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                                                 () => Brisi(st)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 40 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(55);
            __builder.AddAttribute(56, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(60);
                __builder2.AddAttribute(61, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 46 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                      studenti

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 46 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                Sacuvaj

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatDialogTitle>(65);
                    __builder3.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(67, "Dodavanje/Izmena");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatDialogContent>(69);
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(71, "\r\n            ");
                        __builder4.OpenElement(72, "div");
                        __builder4.AddAttribute(73, "class", "form-group");
                        __builder4.AddMarkupContent(74, "\r\n                ");
                        __builder4.AddMarkupContent(75, "<label>Ime</label>\r\n                ");
                        __builder4.OpenElement(76, "input");
                        __builder4.AddAttribute(77, "class", "form-control");
                        __builder4.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                         studenti.Ime

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => studenti.Ime = __value, studenti.Ime));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(80, "\r\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(81, "\r\n            ");
                        __builder4.OpenElement(82, "div");
                        __builder4.AddAttribute(83, "class", "form-group");
                        __builder4.AddMarkupContent(84, "\r\n                ");
                        __builder4.AddMarkupContent(85, "<label>Prezime</label>\r\n                ");
                        __builder4.OpenElement(86, "input");
                        __builder4.AddAttribute(87, "class", "form-control");
                        __builder4.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                         studenti.Prezime

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => studenti.Prezime = __value, studenti.Prezime));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(90, "\r\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(91, "\r\n            ");
                        __builder4.OpenElement(92, "div");
                        __builder4.AddAttribute(93, "class", "form-group");
                        __builder4.AddMarkupContent(94, "\r\n                ");
                        __builder4.AddMarkupContent(95, "<label>Kurs</label>\r\n");
#nullable restore
#line 59 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                 if (ListaKurseva.Count > 0)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(96, "                    ");
                        __builder4.OpenElement(97, "select");
                        __builder4.AddAttribute(98, "class", "form-control");
                        __builder4.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                        TKurs

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TKurs = __value, TKurs));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.AddMarkupContent(101, "\r\n\r\n");
#nullable restore
#line 63 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                         foreach (Kurs k in ListaKurseva)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(102, "                            ");
                        __builder4.OpenElement(103, "option");
                        __builder4.AddAttribute(104, "value", 
#nullable restore
#line 65 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                           k.ID

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(105, 
#nullable restore
#line 65 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                 k.NazivKursa

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(106, "\r\n");
#nullable restore
#line 66 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                        }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(107, "                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(108, "\r\n");
#nullable restore
#line 68 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(109, "            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(110, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\r\n        ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "modal-footer");
                    __builder3.AddMarkupContent(114, "\r\n            ");
                    __builder3.OpenElement(115, "button");
                    __builder3.AddAttribute(116, "type", "button");
                    __builder3.AddAttribute(117, "class", "btn btn-secondary");
                    __builder3.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
                                                                      CancelDialog

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(119, "Zatvori");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n            ");
                    __builder3.AddMarkupContent(121, "<button type=\"submit\" class=\"btn btn-primary\" data-dismiss=\"modal\">Sacuvaj</button>\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(122, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor"
       
    public HubConnection HCS;
    public HubConnection HCC;

    public Student studenti = new Student();

    public List<Student> ListaStudenata = new List<Student>();
    public List<Kurs> ListaKurseva = new List<Kurs>();

    protected override async Task OnInitializedAsync()
    {
        HCS = new HubConnectionBuilder().WithUrl(NM.ToAbsoluteUri("HubStudenti")).Build();
        await HCS.StartAsync();

        studenti.kurs = new Kurs();

        HCS.On<List<Student>>("StuKaKlijentu", ls =>
        {
            ListaStudenata = ls;
            Console.WriteLine(ListaStudenata.Count);
            StateHasChanged();
        });
        await HCS.SendAsync("UcitajStudente");

        //Hub konekcija ka habu Kurs
        HCC = new HubConnectionBuilder().WithUrl(NM.ToAbsoluteUri("HubKursevi")).Build();
        await HCC.StartAsync();

        HCC.On<List<Kurs>>("KursKaKlijentu", lk =>
        {
            ListaKurseva = lk;
            StateHasChanged();
        });
        await HCC.SendAsync("UcitajKurseve");
    }

    public async Task Sacuvaj()
    {
        HCS.StartAsync();
        await HCS.SendAsync("StudKaSrv", studenti);
        studenti = new Student();
        studenti.kurs = new Kurs();
        await HCS.SendAsync("UcitajStudente");
    }
    public void Izmeni(Student s)
    {
        dialogIsOpen = true;
        studenti = s;
        StateHasChanged();
        //ZatvoriDijalog();
        //dialogJeOtvoren = false;

    }
    public async Task Brisi(Student s)
    {
        await HCS.SendAsync("BrisiStudenta", s);
        studenti = new Student();
        await HCS.SendAsync("UcitajStudente");
    }
    private string Pretraga;

    public void PretraziS()
    {

        HCS.SendAsync("PretraziStudente", Pretraga);
    }
    public string TKurs
    {
        get => studenti.kurs.ID.ToString();
        set
        {
            studenti.kurs = ListaKurseva.Find(a => a.ID.ToString() == value);
            Console.WriteLine(studenti.kurs.ID + "Proba");
            StateHasChanged();
            //Console.WriteLine(PrimalacU.Adresa.Ulica);
        }
    }

    bool dialogIsOpen = false;
    public void OpenDialog()
    {

        dialogIsOpen = true;
    }

    public void CancelDialog()
    {
        dialogIsOpen = false;
        // studenti = new Student();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NM { get; set; }
    }
}
#pragma warning restore 1591
