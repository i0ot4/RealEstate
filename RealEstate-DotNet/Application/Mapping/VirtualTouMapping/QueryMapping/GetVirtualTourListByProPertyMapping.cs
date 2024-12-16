using Application.Features.VirtualTours.Queries.Results;
using Domain.Entities;

namespace Application.Mapping.VirtualTouMapping
{
    public partial class VirtualTourProfile
    {
        public void GetVirtualTourListByProPertyMapping()
        {
            CreateMap<VirtualTour, GetVirtualTourListByPropertyResponse>();
        }
    }
}
