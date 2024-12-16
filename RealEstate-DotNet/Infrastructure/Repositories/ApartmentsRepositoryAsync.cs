using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ApartmentsRepositoryAsync : GenericRepositoryAsync<Apartment>, IApartmentsRepositoryAsync
    {
        private readonly DbSet<Apartment> _entities;

        public ApartmentsRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _entities = context.Set<Apartment>();
        }

        public async Task<List<Apartment>> GetApartmentsListAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<List<Apartment>> GetApartmentsListPropertyAsync(Guid Id)
        {
            return await _entities.Where(x => x.PropertyId == Id).ToListAsync();
        }
    }
}
