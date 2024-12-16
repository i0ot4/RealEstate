using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Investment
    {
        [Key]
        public int InvestmentID { get; set; }
        public int UserID { get; set; } // Foreign Key
        public int PropertyID { get; set; } // Foreign Key
        public decimal Amount { get; set; }
        public DateTime InvestmentDate { get; set; }

        public User User { get; set; } // Navigation Property
        public Property Property { get; set; } // Navigation Property
    }
}
