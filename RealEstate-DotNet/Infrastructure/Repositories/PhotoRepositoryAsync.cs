using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PhotoRepositoryAsync : GenericRepositoryAsync<Photo>, IPhotoRepositoryAsync
    {
        private readonly DbSet<Photo> _photos;
        public PhotoRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _photos = context.Set<Photo>();
        }

    }
}
