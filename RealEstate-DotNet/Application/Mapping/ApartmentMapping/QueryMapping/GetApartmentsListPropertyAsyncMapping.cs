using Application.Features.Apartments.Queries.Results;
using Domain.Entities;

namespace Application.Mapping.ApartmentMapping
{
    public partial class ApartmentProfile
    {
        public void GetApartmentsListPropertyAsyncMapping()
        {
            CreateMap<Apartment, GetApartmentsListPropertyResponse>();
        }
    }
}
