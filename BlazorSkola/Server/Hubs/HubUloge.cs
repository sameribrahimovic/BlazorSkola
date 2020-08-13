using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSkola.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSkola.Server.Hubs
{
    public class HubUloge : Hub
    {
        public async Task UlogaKaSrv(Uloga u)
        {
            Baza db = new Baza();
            var UlogaTr = db.Ulogas.Find(u.ID);
            if (UlogaTr == null)
                db.Ulogas.Add(u);
            else
            {
                db.Ulogas.Remove(UlogaTr);
                db.Ulogas.Add(u);
            }
            await db.SaveChangesAsync();
        }

        public async Task UcitajUloge()
        {
            Baza db = new Baza();
            db.Ulogas.ToList(); // zbog pretrage
            await Clients.Caller.SendAsync("UlogaKaKlijentu", db.Ulogas.ToList());

        }

        public void BrisiUlogu(Uloga u)
        {
            Baza db = new Baza();
            db.Ulogas.Remove(u);
            db.SaveChanges();
            UcitajUloge();
        }

        public async Task PretraziUloge(string _pretraga)
        {
            Baza db = new Baza();
            db.Ulogas.ToList();
            await Clients.Caller.SendAsync("UlogaKaKlijentu", db.Ulogas.Where(u => u.NazivUloge.ToLower().Contains(_pretraga.ToLower())));
        }
    }
}
