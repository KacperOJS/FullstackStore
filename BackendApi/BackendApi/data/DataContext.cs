using BackendApi.models;
using BackendApi.Models;
using BackendApi.SeedData;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ApprovalPayment> ApprovalPayment { get; set; }
        public DbSet<Sponsors> Sponsors { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<LogsOfPaymentCustomer> PaymentLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call the base method
            base.OnModelCreating(modelBuilder);

            // Seed data for products
            ProductSeed.Seed(modelBuilder);

            // Configure the relationship between LogsOfPaymentCustomer and Customer
            modelBuilder.Entity<LogsOfPaymentCustomer>()
                .HasOne(log => log.Customer)
                .WithMany() // No navigation property on Customer
                .OnDelete(DeleteBehavior.Cascade); // Enable cascading deletes
        }
    }
}
