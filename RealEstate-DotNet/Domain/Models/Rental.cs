using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public int PropertyId { get; set; } // Foreign Key
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MonthlyPrice { get; set; }
        public decimal TotalYearlyPrice { get; set; }
    }
}
