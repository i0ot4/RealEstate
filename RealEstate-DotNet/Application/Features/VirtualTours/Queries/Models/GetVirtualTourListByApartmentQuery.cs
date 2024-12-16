using Application.Bases;
using Application.Features.VirtualTours.Queries.Results;
using MediatR;

namespace Application.Features.VirtualTours.Queries.Models
{
    public class GetVirtualTourListByApartmentQuery : IRequest<Response<List<GetVirtualTourListByApartmentResponse>>>
    {
        public Guid ApartmentId { get; set; }
    }
}
