using Application.Interfaces.Repositories;
using Application.Services.Interfaces;
using Domain.Entities;

namespace Application.Services.Implementations
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _repository;

        public PropertyService(IPropertyRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Property>> GetPropertyListAsync()
        {
            return await _repository.GetPropertyListAsync();
        }

        public async Task<Property> CreatePropertyAsync(Property property)
        {
            await _repository.AddAsync(property);
            return property;
        }
    }
}
