namespace Domain.Entities
{
    public class VirtualTour
    {
        public int Id { get; set; }
        public Guid? PropertyId { get; set; }
        public Guid? ApartmentId { get; set; }
        public string VirtualUrl { get; set; }
    }
}
