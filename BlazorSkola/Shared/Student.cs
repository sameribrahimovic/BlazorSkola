using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSkola.Shared
{
    public class Student
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Kurs kurs { get; set; }
       
        public bool Pretraga(string p)
            => Ime.ToLower().Contains(p.ToLower()) ||
            Prezime.ToLower().Contains(p.ToLower());
    }
}
