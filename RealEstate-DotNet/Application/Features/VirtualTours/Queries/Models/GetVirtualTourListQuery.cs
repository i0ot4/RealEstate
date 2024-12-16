using Application.Bases;
using Application.Features.VirtualTours.Queries.Results;
using MediatR;

namespace Application.Features.VirtualTours.Queries.Models
{
    public class GetVirtualTourListQuery : IRequest<Response<List<GetVirtualTourListResponse>>>
    {
    }
}
