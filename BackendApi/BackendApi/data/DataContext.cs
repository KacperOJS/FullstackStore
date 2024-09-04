using BackendApi.models;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ApprovalPayment> ApprovalPayment { get; set;}
        public DbSet<Sponsors> Sponsors { get; set;}
        
    }
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Customer>()
			.Property(c => c.IsAdmin)
			.HasDefaultValue(false);
	}
}
