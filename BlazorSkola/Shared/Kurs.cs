using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSkola.Shared
{
    public class Kurs
    {
        public int ID { get; set; }
        public string NazivKursa { get; set; }
        public List<Student> listaStudenata { get; set; } = new List<Student>(); // proba, jedan kurs moze pohadjati vise studenata

        public Kurs(int id, string nazivKursa)
        {
            ID = id;
            NazivKursa = nazivKursa;
        }
        public Kurs() { }
    }
}
