using Application.Bases;
using Application.Features.Photos.Queries.Result;
using MediatR;

namespace Application.Features.Photos.Queries.Models
{
    public class GetPhotoListByApartmentQuery : IRequest<Response<List<GetPhotoListByApartmentResponse>>>
    {
        public Guid? ApartmentId { get; set; }
    }
}
