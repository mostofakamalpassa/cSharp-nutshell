using Microsoft.EntityFrameworkCore;
using QueryExpression.Models;


namespace QueryExpression.DBConnect
{
    public class NutshellContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
          optionsBuilder.UseSqlServer(@"Server=Server;Database=Nutshell;Trusted_Connection=True");

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
                entity.Property(e => e.Name).IsRequired(); // Column is not nullable
            });
        }
    }
}
