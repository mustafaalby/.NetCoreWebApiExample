using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectRestaurant.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant.Data.Context
{
    public class RestoranDbContext:IdentityDbContext<Restoran>
    {
        public RestoranDbContext(DbContextOptions<RestoranDbContext> options): base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<Restoran>().
                HasOne(x => x.RestoranAdres).
                WithOne(y => y.Restoran).
                HasForeignKey<RestoranAdres>(z => z.RestoranId);
            builder.Entity<Restoran>()
                .HasMany(x => x.Masa).
                WithOne(y => y.Restoran).
                HasForeignKey(z => z.RestoranId);
            builder.Entity<Masa>().
                HasMany(x => x.Oturum).
                WithOne(y => y.Masa).
                HasForeignKey(z => z.MasaId);
            builder.Entity<Oturum>().
                HasMany(x => x.Siparis).
                WithOne(y => y.Oturum).
                HasForeignKey(z => z.OturumId);
            builder.Entity<Menu>().
                HasOne(x => x.UrunTur).
                WithOne(y => y.Menu).
                HasForeignKey<Menu>(z => z.UrunTurId);
            base.OnModelCreating(builder);
        }

        public Masa Masa { get; set; }
        public Menu Menu { get; set; }
        public Oturum Oturum { get; set; }
        
        public RestoranAdres RestoranAdres { get; set; }
        public Siparis Siparis { get; set; }
        public UrunTur UrunTur { get; set; }
    }
}
