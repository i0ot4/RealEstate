using AutoMapper;

namespace Application.Mapping.ApartmentMapping
{
    public partial class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateApartmentMapping();

            GetApartmentsListAsyncMapping();
            GetApartmentsListPropertyAsyncMapping();
        }
    }
}
