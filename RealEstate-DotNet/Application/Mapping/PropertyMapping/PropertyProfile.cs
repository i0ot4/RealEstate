using AutoMapper;

namespace Application.Mapping.PropertyMapping
{
    public partial class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            AddPropertyMapping();
            GetPropertyListMapping();
        }
    }
}
