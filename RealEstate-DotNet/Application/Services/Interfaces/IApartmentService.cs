using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IApartmentService
    {

        Task<Apartment> CreateApartmentAsync(Apartment property);
        public Task<List<Apartment>> GetApartmentsListPropertyAsync(Guid Id);
        public Task<List<Apartment>> GetApartmentsListAsync();
    }
}
