namespace Application.Features.VirtualTours.Queries.Results
{
    public class GetVirtualTourListByPropertyResponse
    {
        public int Id { get; set; }
        public Guid? PropertyId { get; set; }
        public string VirtualUrl { get; set; }
    }
}
