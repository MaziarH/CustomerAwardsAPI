using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAwardsAPI.Models;
using CAwardsAPI;

namespace CAward.API.Controllers
{
    [Route("api/[controller]")]
    //[Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly DataContext _context;

        public TransactionController(DataContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetMonthlyCustomersRewards()
        {
            var total = from customers in _context.Customers
                        join transactions in _context.Transactions on customers.Id equals transactions.CustomerId
                        group transactions by new { customers.Id, customers.Name, Month = transactions.Date.ToString("MMM") } into s
                        select new
                        {
                            Id = s.Key.Id,
                            Name = s.Key.Name,
                            Month = s.Key.Month,
                            SumInMonth = s.Sum(s => new CalculateRewards().GetRewards(s.Amount))
                        };
           //SumInMonth = s.Sum(new(s => Math.Round(s.Amount)))
           // Math.Round(s.Sum(s => s.Amount <= 50 ? 0 : (s.Amount - 50 + (s.Amount <= 100 ? 0 : s.Amount - 100))))

            return Ok(await total.ToArrayAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetOneCustomerRewards(int id)
        {
            var total = from customers in _context.Customers
                        join transactions in _context.Transactions on customers.Id equals transactions.CustomerId
                        where customers.Id == id
                        group transactions by new { customers.Id, customers.Name, Month = transactions.Date.ToString("MMM") } into s
                        select new
                        {
                            Id = s.Key.Id,
                            Name = s.Key.Name,
                            Month = s.Key.Month,
                            SumInMonth = s.Sum(s => new CalculateRewards().GetRewards(s.Amount))
                        };

            return Ok(await total.ToArrayAsync());
        }

        [HttpGet]
        [Route("Total")]
        public async Task<ActionResult> GetTotalCustomersRewards()
        {
            var total = from customers in _context.Customers
                        join transactions in _context.Transactions on customers.Id equals transactions.CustomerId
                        group transactions by new { customers.Id, customers.Name } into s
                        select new
                        {
                            Id = s.Key.Id,
                            Name = s.Key.Name,
                            SumInMonth = s.Sum(s => new CalculateRewards().GetRewards(s.Amount))
                        };

            return Ok(await total.ToArrayAsync());
        }

    }


}
