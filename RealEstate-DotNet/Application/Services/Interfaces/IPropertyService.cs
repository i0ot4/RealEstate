

using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IPropertyService
    {
        Task<Property> CreatePropertyAsync(Property property);
        public Task<List<Property>> GetPropertyListAsync();
    }
}
