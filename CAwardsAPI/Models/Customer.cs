using System.ComponentModel.DataAnnotations;

namespace CAwardsAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public List<Transaction>? Transactions { get; set; }

        // We can add several other properties for customer information like
        // FirstBuyDate, Loyality, Credit, ....


    }
}
