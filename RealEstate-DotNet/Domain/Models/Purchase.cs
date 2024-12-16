using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public int PropertyId { get; set; } // Foreign Key
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
