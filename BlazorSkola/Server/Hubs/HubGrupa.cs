using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using BlazorSkola.Shared;

namespace BlazorSkola.Server.Hubs
{
    public class HubGrupa : Hub
    {
        public async Task GrupaKaSrv(Grupa g)
        {
            Baza db = new Baza();
            var GrupaTr = db.Grupas.Find(g.ID);
            if (GrupaTr == null)
                db.Grupas.Add(g);
            else
            {
                db.Grupas.Remove(GrupaTr);
                db.Grupas.Add(g);
            }
            await db.SaveChangesAsync();
        }

        public async Task UcitajGrupe()
        {
            Baza db = new Baza();
            db.Grupas.ToList(); // zbog pretrage
            await Clients.Caller.SendAsync("GrupaKaKlijentu", db.Grupas.ToList());

        }

        public void BrisiGrupu(Grupa g)
        {
            Baza db = new Baza();
            db.Grupas.Remove(g);
            db.SaveChanges();
            UcitajGrupe();
        }

        public async Task PretraziGrupe(string _pretraga)
        {
            Baza db = new Baza();
            db.Grupas.ToList();
            await Clients.Caller.SendAsync("GrupaKaKlijentu", db.Grupas.Where(g => g.NazivGrupe.ToLower().Contains(_pretraga.ToLower())));
        }
    }
}
