using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IApartmentsRepositoryAsync : IGenericRepositoryAsync<Apartment>
    {
        Task<List<Apartment>> GetApartmentsListPropertyAsync(Guid Id);
        Task<List<Apartment>> GetApartmentsListAsync();
    }
}
