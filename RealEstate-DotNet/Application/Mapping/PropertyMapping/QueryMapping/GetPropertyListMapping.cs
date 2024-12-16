using Application.Features.Properties.Queries.Results;
using Domain.Entities;

namespace Application.Mapping.PropertyMapping
{
    public partial class PropertyProfile
    {
        public void GetPropertyListMapping()
        {
            CreateMap<Property, GetPropertyListResponse>();
        }
    }
}
