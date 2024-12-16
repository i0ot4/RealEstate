using Application.Bases;
using Application.Features.Photos.Queries.Result;
using MediatR;

namespace Application.Features.Photos.Queries.Models
{
    public class GetPhotoListQuery : IRequest<Response<List<GetPhotoListResponse>>>
    {
    }
}
