using Application.Features.VirtualTours.Commands.Models;
using Domain.Entities;

namespace Application.Mapping.VirtualTouMapping
{
    public partial class VirtualTourProfile
    {
        public void CreateVirtualTourMapping()
        {
            CreateMap<CreateVirtualTourCommand, VirtualTour>();
        }
    }
}
