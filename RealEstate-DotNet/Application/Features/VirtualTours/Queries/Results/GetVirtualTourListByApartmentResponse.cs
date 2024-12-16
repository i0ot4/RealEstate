namespace Application.Features.VirtualTours.Queries.Results
{
    public class GetVirtualTourListByApartmentResponse
    {
        public int Id { get; set; }
        public Guid? ApartmentId { get; set; }
        public string VirtualUrl { get; set; }
    }
}
