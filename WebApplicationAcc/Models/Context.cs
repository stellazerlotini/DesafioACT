using Microsoft.EntityFrameworkCore;

namespace WebApplicationAcc.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<CompanySupplier> CompanySupplier { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<CompanySupplier>().HasKey(x => new { x.CompanyId, x.SupplierId });
            base.OnModelCreating(modelBuilder);
        }





    }
}
