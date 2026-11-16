using Microsoft.EntityFrameworkCore;
using ShopSystem.Models;

namespace ShopSystem.Data
{
    public class App_DbContext : DbContext
    {
        public App_DbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(App_DbContext).Assembly);
        }
        public DbSet<Team>  teams { get; set; }
        public DbSet<Seller> sellers { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Card> cards { get; set; }
    }
}
