using BlazorSkola.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSkola.Server.Hubs
{
    public class HubKursevi : Hub
    {
        public async Task KursKaSrv(Kurs k)
        {
            Baza db = new Baza();
            var KursTr = db.Kurses.Find(k.ID);
            if (KursTr == null)
                db.Kurses.Add(k);
            else
            {
                db.Kurses.Remove(KursTr);
                db.Kurses.Add(k);
            }
            await db.SaveChangesAsync();
        }

        public async Task UcitajKurseve()
        {
            Baza db = new Baza();
            db.Kurses.ToList(); // zbog pretrage
            await Clients.Caller.SendAsync("KursKaKlijentu", db.Kurses.ToList());

        }

        public void BrisiKurs(Kurs k)
        {
            Baza db = new Baza();
            db.Kurses.Remove(k);
            db.SaveChanges();
            UcitajKurseve();
        }

        public async Task PretraziKurseve(string _pretraga)
        {
            Baza db = new Baza();
            db.Kurses.ToList();
            await Clients.Caller.SendAsync("KursKaKlijentu", db.Kurses.Where(k => k.NazivKursa.ToLower().Contains(_pretraga.ToLower())));
        }
    }
}
