using Application.Features.Apartments.Queries.Results;
using MediatR;

namespace Application.Features.Apartments.Queries.Models
{
    public class GetApartmentsListQuery : IRequest<List<GetApartmentsListResponse>>
    {
    }
}
