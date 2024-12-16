using Application.Features.Apartments.Queries.Results;
using Domain.Entities;

namespace Application.Mapping.ApartmentMapping
{
    public partial class ApartmentProfile
    {
        public void GetApartmentsListAsyncMapping()
        {
            CreateMap<Apartment, GetApartmentsListResponse>();
        }
    }
}
