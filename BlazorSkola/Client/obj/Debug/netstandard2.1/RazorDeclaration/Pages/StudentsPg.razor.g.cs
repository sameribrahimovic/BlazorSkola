#pragma checksum "C:\Users\Asus\Desktop\AspSkola\BlazorSkola\BlazorSkola\Client\Pages\StudentsPg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce3f0b24aa1cd9247207054557bfd5adc6c60bb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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