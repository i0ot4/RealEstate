using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Application.Services.Interfaces
{
    public interface IPhotoService
    {
        Task<Photo> CreatePhotoAsync(Photo photo);
        Task<List<Photo>> CreatePhotosListAsync(List<Photo> images);
        Task<List<Photo>> GetPhotoListByApartmentAsync(Guid? Id);
        Task<List<Photo>> GetPhotosListAsync();
        Task<string> UplaodPhotoAsync(IFormFile formFile);
        Task<List<string>> UplaodPhotosListAsync(List<IFormFile> images);
    }
}
