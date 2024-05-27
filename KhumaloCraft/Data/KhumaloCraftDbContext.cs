﻿using KhumaloCraft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft.Data
{


    public class KhumaloCraftDbContext : IdentityDbContext
    {
        public KhumaloCraftDbContext(DbContextOptions<KhumaloCraftDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var decimalProps = modelBuilder.Model
        //    .GetEntityTypes()
        //    .SelectMany(t => t.GetProperties())
        //    .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

        //    foreach (var property in decimalProps)
        //    {
        //        property.SetPrecision(18);
        //        property.SetScale(2);
        //    }
        //}
    }
}

