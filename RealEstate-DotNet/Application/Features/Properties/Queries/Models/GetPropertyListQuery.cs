using Application.Features.Properties.Queries.Results;
using MediatR;

namespace Application.Features.Properties.Queries.Models
{
    public class GetPropertyListQuery : IRequest<List<GetPropertyListResponse>>
    {
    }
}
