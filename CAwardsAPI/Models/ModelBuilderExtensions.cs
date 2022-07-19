using CAwardsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CAwardsAPI.API.Models
{
    // Build sample data for customers and their transactions
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Maziar Hassanzadeh" },
                new Customer { Id = 2, Name = "Sara Moghadam" },
                new Customer { Id = 3, Name = "John Smith" },
                new Customer { Id = 4, Name = "Parsa Anderson" },
                new Customer { Id = 5, Name = "Nima Grooman" });

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { Id = 1, CustomerId = 1, Date = new DateTime(2022, 01, 10, 09, 15, 0), Amount = 30.50 },
                new Transaction { Id = 2, CustomerId = 1, Date = new DateTime(2022, 01, 25, 10, 25, 0), Amount = 52.49 },
                new Transaction { Id = 3, CustomerId = 1, Date = new DateTime(2022, 02, 11, 19, 05, 0), Amount = 60.00 },
                new Transaction { Id = 4, CustomerId = 1, Date = new DateTime(2022, 02, 16, 12, 15, 0), Amount = 49.99 },
                new Transaction { Id = 5, CustomerId = 1, Date = new DateTime(2022, 03, 14, 07, 35, 0), Amount = 112.25 },
                new Transaction { Id = 6, CustomerId = 1, Date = new DateTime(2022, 03, 27, 16, 45, 0), Amount = 95.99 },

                new Transaction { Id = 7, CustomerId = 2, Date = new DateTime(2022, 01, 10, 09, 30, 0), Amount = 120.00 },
                new Transaction { Id = 8, CustomerId = 2, Date = new DateTime(2022, 02, 10, 10, 30, 0), Amount = 45.00 },
                new Transaction { Id = 9, CustomerId = 2, Date = new DateTime(2022, 02, 28, 11, 30, 0), Amount = 55.25 },
                new Transaction { Id = 10, CustomerId = 2, Date = new DateTime(2022, 03, 11, 12, 30, 0), Amount = 60.00 },
                new Transaction { Id = 11, CustomerId = 2, Date = new DateTime(2022, 03, 19, 13, 30, 0), Amount = 111.00 },

                new Transaction { Id = 12, CustomerId = 3, Date = new DateTime(2022, 01, 13, 14, 15, 0), Amount = 35.00 },
                new Transaction { Id = 13, CustomerId = 3, Date = new DateTime(2022, 01, 23, 19, 24, 0), Amount = 135.00 },
                new Transaction { Id = 14, CustomerId = 3, Date = new DateTime(2022, 02, 10, 09, 15, 0), Amount = 240.63 },
                new Transaction { Id = 15, CustomerId = 3, Date = new DateTime(2022, 02, 15, 13, 05, 0), Amount = 23.50 },
                new Transaction { Id = 16, CustomerId = 3, Date = new DateTime(2022, 02, 27, 17, 33, 0), Amount = 115.30 },
                new Transaction { Id = 17, CustomerId = 3, Date = new DateTime(2022, 03, 05, 08, 49, 0), Amount = 400.00 },
                new Transaction { Id = 18, CustomerId = 3, Date = new DateTime(2022, 03, 10, 07, 59, 0), Amount = 90.25 },
                new Transaction { Id = 19, CustomerId = 3, Date = new DateTime(2022, 03, 15, 10, 15, 0), Amount = 35.25 },
                new Transaction { Id = 20, CustomerId = 3, Date = new DateTime(2022, 03, 22, 19, 05, 0), Amount = 10.00 },

                new Transaction { Id = 21, CustomerId = 4, Date = new DateTime(2022, 01, 01, 10, 10, 0), Amount = 25.00 },
                new Transaction { Id = 22, CustomerId = 4, Date = new DateTime(2022, 02, 05, 09, 15, 0), Amount = 50.00 },
                new Transaction { Id = 23, CustomerId = 4, Date = new DateTime(2022, 02, 15, 15, 34, 0), Amount = 100.00 },
                new Transaction { Id = 24, CustomerId = 4, Date = new DateTime(2022, 03, 10, 09, 43, 0), Amount = 99.99 },
                new Transaction { Id = 25, CustomerId = 4, Date = new DateTime(2022, 03, 25, 18, 08, 0), Amount = 49.99 },

                new Transaction { Id = 26, CustomerId = 5, Date = new DateTime(2022, 01, 19, 9, 15, 0), Amount = 50.00 },
                new Transaction { Id = 27, CustomerId = 5, Date = new DateTime(2022, 01, 29, 9, 17, 0), Amount = 100.00 },
                new Transaction { Id = 28, CustomerId = 5, Date = new DateTime(2022, 02, 02, 9, 10, 0), Amount = 49.99 },
                new Transaction { Id = 29, CustomerId = 5, Date = new DateTime(2022, 02, 22, 9, 30, 0), Amount = 131.35 },
                new Transaction { Id = 30, CustomerId = 5, Date = new DateTime(2022, 03, 15, 9, 24, 0), Amount = 00.25 });
        }
    }
}
