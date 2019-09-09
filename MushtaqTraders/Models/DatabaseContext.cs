using MushtaqTraders.Models.DomainObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MushtaqTraders.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("dbconn")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseProduct> PurchaseProducts { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }


    }
}