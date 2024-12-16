using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public int PropertyId { get; set; }
        public string Url { get; set; }
    }
}
