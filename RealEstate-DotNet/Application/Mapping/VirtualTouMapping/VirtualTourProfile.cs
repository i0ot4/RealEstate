using AutoMapper;

namespace Application.Mapping.VirtualTouMapping
{
    public partial class VirtualTourProfile : Profile
    {
        public VirtualTourProfile()
        {
            CreateVirtualTourMapping();


            GetVirtualTourListMapping();
            GetVirtualTourListByProPertyMapping();
            GetVirtualTourListByApartmentMapping();
        }
    }
}
