using Application.Features.Apartments.Commands.Models;
using Domain.Entities;

namespace Application.Mapping.ApartmentMapping
{
    public partial class ApartmentProfile
    {
        public void CreateApartmentMapping()
        {
            CreateMap<CreateApartmentCommand, Apartment>();
        }
    }
}
