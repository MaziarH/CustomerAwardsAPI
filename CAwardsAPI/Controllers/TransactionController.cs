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
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(DataContext context, 
                                    ILogger<TransactionController> logger)
        {
            _context = context;
            _context.Database.EnsureCreated();

            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetMonthlyCustomersRewards()
        {
            try
            {
                _logger.LogInformation("Getting All Customer Rewards");

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

                return Ok(await total.ToArrayAsync());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest("Internal Server error");
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetOneCustomerRewards(int id)
        {
            try
            {
                _logger.LogInformation($"Getting Customer {id} Rewards");
                if (id <= 0)
                {
                    _logger.LogInformation($"Invalid Customer ID: {id}");

                }
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
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest("Internal Server error");
            }
        }

        [HttpGet]
        [Route("Total")]
        public async Task<ActionResult> GetTotalCustomersRewards()
        {
            try
            {
                _logger.LogInformation("Getting All Customer Total Rewards");

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
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest("Internal Server error");
            }
        }

    }


}
