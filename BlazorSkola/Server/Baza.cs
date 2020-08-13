using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSkola.Shared;

namespace BlazorSkola.Server
{
    public class Baza : DbContext
    {
        public DbSet<Radnik> Radniks { get; set; }
        public DbSet<Kurs> Kurses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grupa> Grupas { get; set; }
        public DbSet<Uloga> Ulogas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Radnik>().HasKey(r => r.ID);
            modelBuilder.Entity<Kurs>().HasKey(ks => ks.ID);
            modelBuilder.Entity<Kurs>().HasMany(k => k.listaStudenata); // kurs moze pohadjati vise studenata
            modelBuilder.Entity<Student>().HasKey(s => s.ID);
            modelBuilder.Entity<Grupa>().HasKey(g => g.ID);
            modelBuilder.Entity<Grupa>().HasMany(g => g.listaStudenata);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-N7M44EU;Initial Catalog=SkolaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
    }
}
