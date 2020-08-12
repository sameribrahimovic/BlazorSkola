using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSkola.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSkola.Server.Hubs
{
    public class HubStudenti : Hub
    {
        public async Task StudKaSrv(Student stu)
        {
            Baza db = new Baza();
            var StuTr = db.Students.Find(stu.ID);
            if (StuTr == null)
            {
                stu.kurs = db.Kurses.Find(stu.kurs.ID); //ucitavanje kurseva u padajucu listu u strani Studenti
                db.Students.Add(stu);
            }

            else
            {
                stu.kurs = db.Kurses.Find(stu.kurs.ID); //ucitavanje kurseva u padajucu listu u strani Studenti
                db.Students.Remove(StuTr);
                db.Students.Add(stu);
            }
            await db.SaveChangesAsync();
        }

        public async Task UcitajStudente()
        {
            Baza db = new Baza();
            List<Student> ls = new List<Student>();

            List<Student> lol = db.Students.ToList();

            lol.ForEach(s => Console.WriteLine(s.ID));
            db.Kurses.ToList(); // ucitavanje kurseva u listu - page Student gde treba u padajucu listu ucitati kurseve
            await Clients.Caller.SendAsync("StuKaKlijentu", ls);
        }

        public void BrisiStudenta(Student stu)
        {
            Baza db = new Baza();
            db.Students.Remove(stu);
            db.SaveChanges();
            UcitajStudente();
        }
        public async Task PretraziStudente(string _pretraga)
        {
            Baza db = new Baza();
            db.Students.ToList();
            await Clients.Caller.SendAsync("StuKaKlijentu", db.Students.Where(s => s.Ime.ToLower().Contains(_pretraga.ToLower())));
        }
    }
}
