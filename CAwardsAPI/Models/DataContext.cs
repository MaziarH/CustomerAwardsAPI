using CAwardsAPI.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CAwardsAPI.Models
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Make a virtual dataset of 2 tables Customer and related Transaction
        // Then run seed to add data to them
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Transactions)
                .WithOne(a => a.Customer)
                .HasForeignKey(a => a.CustomerId);

            modelBuilder.Seed();
        }

        // Create dataset objects
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
