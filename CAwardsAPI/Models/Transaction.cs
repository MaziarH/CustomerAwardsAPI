using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CAwardsAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        //public string Month => Date.ToString("MMM");

        [Required]
        public double Amount { get; set; } = 0;
        //public double Award => Amount <= 50 ? 0 : (Amount - 50 + (Amount <= 100 ? 0 : Amount - 100));
          

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }

        //
        // We can add other properties like TerminalNo, TransactionStatus, ...
        //


    }


}
