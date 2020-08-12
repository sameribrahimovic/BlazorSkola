using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSkola.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSkola.Server.Hubs
{
    public class HubRadnici : Hub
    {
        public async Task RadKaSrv(Radnik rad)
        {
            Baza db = new Baza();
            var RadTr = db.Radniks.Find(rad.ID);
            if (RadTr == null)
                db.Radniks.Add(rad);
            else
            {
                db.Radniks.Remove(RadTr);
                db.Radniks.Add(rad);
            }
            await db.SaveChangesAsync();
        }

        public async Task UcitajZaposlene()
        {
            Baza db = new Baza();
            await Clients.Caller.SendAsync("KaKlijentu", db.Radniks.ToList());

        }

        public void BrisiRadnika(Radnik rad)
        {
            Baza db = new Baza();
            db.Radniks.Remove(rad);
            db.SaveChanges();
            UcitajZaposlene();
        }
        public async Task PretraziZaposlene(string _pretraga)
        {
            Baza db = new Baza();
            db.Radniks.ToList();
            await Clients.Caller.SendAsync("KaKlijentu", db.Radniks.Where(r => r.Ime.ToLower().Contains(_pretraga.ToLower())));
        }
    }
}
