using Application.Features.Properties.Commands.Models;
using Domain.Entities;

namespace Application.Mapping.PropertyMapping
{
    public partial class PropertyProfile
    {
        public void AddPropertyMapping()
        {
            CreateMap<CreatePropertyCommand, Property>();
        }
    }
}
