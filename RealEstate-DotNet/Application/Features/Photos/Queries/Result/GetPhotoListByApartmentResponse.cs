namespace Application.Features.Photos.Queries.Result
{
    public class GetPhotoListByApartmentResponse
    {
        public Guid PhotoId { get; set; }
        public Guid? PropertyId { get; set; }
        public Guid? ApartmentId { get; set; }
        public string ImageUrl { get; set; }
    }
}
