using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class VirtualTourRepositoryAsync : GenericRepositoryAsync<VirtualTour>, IVirtualTourRepositoryAsync
    {
        private readonly DbSet<VirtualTour> _virtualTours;
        public VirtualTourRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _virtualTours = context.Set<VirtualTour>();
        }
    }
}
