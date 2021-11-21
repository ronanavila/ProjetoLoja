using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Models;


namespace ProjetoLoja
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasKey(k => k.Id);
            modelBuilder.Entity<Customer>().HasOne(k => k.Status).WithMany().HasForeignKey(k => k.StatusForeignKey);

            modelBuilder.Entity<Status>().HasKey(t => t.Id);
            modelBuilder.Entity<Status>().HasIndex(t => t.Code).IsUnique();

            modelBuilder.Entity<Products>().HasKey(t => t.Id);
            modelBuilder.Entity<Products>().HasIndex(t => t.Code).IsUnique();

            modelBuilder.Entity<Offer>().HasKey(k => k.Id);
            modelBuilder.Entity<Offer>().HasOne(k => k.Products).WithMany().HasForeignKey(k => k.Id);
            modelBuilder.Entity<Offer>().HasOne(k => k.Customer).WithMany().HasForeignKey(k => k.Id);


            modelBuilder.Entity<User>().HasKey(k => k.Id);

        }
    }
}
