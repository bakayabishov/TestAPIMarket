using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using TestAPIMarket.Data.Entities;

namespace TestAPIMarket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=market;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
