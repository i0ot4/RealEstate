using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class MarketData
    {
        [Key]
        public int MarketDataId { get; set; }
        public int PropertyId { get; set; }
        public decimal ProjectedPriceIncrease5Years { get; set; }
    }
}
