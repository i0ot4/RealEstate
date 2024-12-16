using Application.Bases;
using Application.Features.VirtualTours.Queries.Results;
using MediatR;

namespace Application.Features.VirtualTours.Queries.Models
{
    public class GetVirtualTourListByPropertyQuery : IRequest<Response<List<GetVirtualTourListByPropertyResponse>>>
    {
        public Guid PropertyId { get; set; }
    }
}
