using Application.Interfaces.Repositories;
using Application.Services.Interfaces;
using Domain.Entities;

namespace Application.Services.Implementations
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentsRepositoryAsync _repository;

        public ApartmentService(IApartmentsRepositoryAsync repository)
        {
            _repository = repository;
        }

        public async Task<Apartment> CreateApartmentAsync(Apartment property)
        {
            var entity = await _repository.AddAsync(property);
            return entity;
        }

        public async Task<List<Apartment>> GetApartmentsListAsync()
        {
            return await _repository.GetApartmentsListAsync();
        }

        public async Task<List<Apartment>> GetApartmentsListPropertyAsync(Guid Id)
        {
            return await _repository.GetApartmentsListPropertyAsync(Id);
        }
    }
}
