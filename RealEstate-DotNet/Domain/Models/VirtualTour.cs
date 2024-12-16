using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class VirtualTour
    {
        [Key]
        public int TourId { get; set; }
        public int PropertyId { get; set; }
        public string Url { get; set; }
    }
}
