using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PropertyRepositoryAsync : GenericRepositoryAsync<Property>, IPropertyRepository
    {
        private readonly DbSet<Property> _properties;

        public PropertyRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _properties = context.Set<Property>();
        }

        public async Task<List<Property>> GetPropertyListAsync()
        {
            return await _properties.ToListAsync();
        }

        /*
                public async Task<IEnumerable<Property>> GetInvestmentPropertiesAsync()
                {
                    return await _context.Properties
                        .Where(p => p.Status == "Investment")
                        .Include(p => p.Photos)
                        .Include(p => p.VirtualTour)
                        .ToListAsync();
                }

                public async Task<Property> GetByIdAsync(int id)
                {
                    return await _context.Properties
                        .Include(p => p.Photos)
                        .Include(p => p.VirtualTour)
                        .Include(p => p.FinancialDetails)
                        .FirstOrDefaultAsync(p => p.PropertyId == id);
                }

                public async Task<Property> UpdateAsync(Property property)
                {
                    _context.Properties.Update(property);
                    await _context.SaveChangesAsync();
                    return property;
                }

                public async Task<Investment> AddInvestmentAsync(Investment investment)
                {
                    await _context.Investments.AddAsync(investment);
                    await _context.SaveChangesAsync();
                    return investment;
                }

                public async Task<IEnumerable<Investment>> GetUserInvestmentsAsync(int userId)
                {
                    return await _context.Investments
                        .Where(i => i.UserID == userId)
                        .Include(i => i.Property)
                        .ToListAsync();
                }

                public async Task<FinancialDetail> GetPropertyFinancialDetailsAsync(int propertyId)
                {
                    return await _context.FinancialDetails
                        .FirstOrDefaultAsync(fd => fd.PropertyId == propertyId);
                }

                public async Task<IEnumerable<Property>> GetRentalPropertiesAsync()
                {
                    return await _context.Properties
                        .Where(p => p.Status == "Rental")
                        .Include(p => p.Photos)
                        .Include(p => p.VirtualTour)
                        .ToListAsync();
                }

                public async Task<IEnumerable<Property>> GetPropertiesForSaleAsync()
                {
                    return await _context.Properties
                        .Where(p => p.Status == "ForSale")
                        .Include(p => p.Photos)
                        .Include(p => p.VirtualTour)
                        .Include(p => p.MarketData)
                        .ToListAsync();
                }

                public async Task<Property> AddPropertyAsync(Property property)
                {
                    await _context.Properties.AddAsync(property);
                    await _context.SaveChangesAsync();
                    return property;
                }

                public async Task<bool> DeletePropertyAsync(int id)
                {
                    var property = await _context.Properties.FindAsync(id);
                    if (property == null)
                    {
                        return false;
                    }

                    _context.Properties.Remove(property);
                    await _context.SaveChangesAsync();
                    return true;
                }*/
    }
}
