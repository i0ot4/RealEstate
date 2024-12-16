using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Application.Services.Interfaces
{
    public interface IVirtualTourService
    {
        Task<VirtualTour> CreateVirtualTourAsync(VirtualTour virtualTour);
        Task<List<VirtualTour>> GetVirtualTourByApartmentAsync(Guid Id);
        Task<List<VirtualTour>> GetVirtualTourByPropertyAsync(Guid Id);
        Task<List<VirtualTour>> GetVirtualTourListAsync();
        Task<string> UplaodVirtualTourAsync(IFormFile formFile);
    }
}
