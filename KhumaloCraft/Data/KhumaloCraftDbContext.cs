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
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderRequest> OrderRequests { get; set; }
        public DbSet<Product> Product { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     var decimalProps = modelBuilder.Model
        //     .GetEntityTypes()
        //     .SelectMany(t => t.GetProperties())
        //     .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

        //     foreach (var property in decimalProps)
        //     {
        //         property.SetPrecision(18);
        //         property.SetScale(2);
        //     }
        // }
    }
}

