using Application.Features.Apartments.Queries.Results;
using MediatR;

namespace Application.Features.Apartments.Queries.Models
{
    public class GetApartmentsListPropertyQuery : IRequest<List<GetApartmentsListPropertyResponse>>
    {
        public Guid PropertyId { get; set; }
    }
}
