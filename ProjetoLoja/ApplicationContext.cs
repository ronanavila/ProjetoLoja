using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoLoja
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasKey(k => k.Id);
            modelBuilder.Entity<Customer>().HasOne(k => k.Status).WithMany().HasForeignKey(k => k.StatusForeignKey);

            modelBuilder.Entity<Status>().HasKey(t => t.Id);
            //modelBuilder.Entity<Status>().HasOne(k => k.Customer).WithOne().HasForeignKey<Customer>(k => k.StatusId);

            modelBuilder.Entity<Products>().HasKey(t => t.Id);
            //modelBuilder.Entity<Products>().HasOne(k => k.Offer).WithOne().HasForeignKey<Products>(k => k.Id);

            modelBuilder.Entity<Offer>().HasKey(k => k.Id);
            //modelBuilder.Entity<Offer>().HasOne(k => k.Products).WithOne().HasForeignKey<Products>(k => k.Id);
            //modelBuilder.Entity<Offer>().HasOne(k => k.Customer).WithOne().HasForeignKey<Customer>(k => k.Id);

        }
    }
}
