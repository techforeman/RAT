using Microsoft.EntityFrameworkCore;
using RAT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RAT.EntityFramework
{
    public class RatDbContext : DbContext
    {
        

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        public RatDbContext(DbContextOptions options) : base(options) { }

        // DbSet<Stock> Stocks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock);
            base.OnModelCreating(modelBuilder);
         }

    }
}
