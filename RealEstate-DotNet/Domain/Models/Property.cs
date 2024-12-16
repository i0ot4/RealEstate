using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public float Area { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public decimal Price { get; set; }
        public decimal TotalSales { get; set; }
        public decimal AvailablePercentage { get; set; }
        public decimal FiveYearReturn { get; set; }
        public decimal AnnualExpectedReturn { get; set; }
        /*
        public ICollection<Photo> Photos { get; set; }
        public VirtualTour? VirtualTour { get; set; }
        public FinancialDetail FinancialDetails { get; set; }
        public MarketData MarketData { get; set; }*/
    }

}
