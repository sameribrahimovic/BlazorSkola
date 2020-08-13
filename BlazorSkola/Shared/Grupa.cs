using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSkola.Shared
{
    public class Grupa
    {
        public int ID { get; set; }
        public string NazivGrupe { get; set; }
        public List<Student> listaStudenata { get; set; } = new List<Student>();
    }
}
