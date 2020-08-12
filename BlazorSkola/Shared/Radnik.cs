using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSkola.Shared
{
    public class Radnik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string KontaktTel { get; set; }
        public string Email { get; set; }
        //public DateTime? DatumPocetka { get; set; }
        public Radnik(int id, string ime, string prezime, string adresa, string grad, string kontaktTel, string email)
        {
            ID = id;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Grad = grad;
            KontaktTel = kontaktTel;
            Email = email;
        }
        public Radnik() { }
    }
}
