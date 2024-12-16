
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IPropertyRepository : IGenericRepositoryAsync<Property>
    {

        public Task<List<Property>> GetPropertyListAsync();
        /*
        Task<IEnumerable<Property>> GetInvestmentPropertiesAsync();
        Task<Property> GetByIdAsync(int id);
        Task<Property> UpdateAsync(Property property);
        Task<Investment> AddInvestmentAsync(Investment investment);
        Task<IEnumerable<Investment>> GetUserInvestmentsAsync(int userId);
        Task<FinancialDetail> GetPropertyFinancialDetailsAsync(int propertyId);
        Task<IEnumerable<Property>> GetRentalPropertiesAsync();
        Task<IEnumerable<Property>> GetPropertiesForSaleAsync();
        Task<Property> AddPropertyAsync(Property property);
        Task<bool> DeletePropertyAsync(int id);*/
    }
}
