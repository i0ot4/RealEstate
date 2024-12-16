using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Photo
    {
        [Key]
        public Guid PhotoId { get; set; }
        public Guid? PropertyId { get; set; }
        public Guid? ApartmentId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
