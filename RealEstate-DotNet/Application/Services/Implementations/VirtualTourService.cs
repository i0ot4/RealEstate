using Application.Interfaces.Repositories;
using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations
{
    public class VirtualTourService : IVirtualTourService
    {
        private readonly IVirtualTourRepositoryAsync _repository;

        public VirtualTourService(IVirtualTourRepositoryAsync repository)
        {
            _repository = repository;
        }


        public async Task<string> UplaodVirtualTourAsync(IFormFile formFile)
        {
            if (formFile == null && formFile.Length > 0)
            {
                throw new ArgumentNullException(nameof(formFile));
            }
            //var fileName = Path.GetFileName(photo.ImageFile.FileName);
            var filePath = Path.Combine("wwwroot/images/VirtualTour/", $"{Guid.NewGuid()}_{formFile.FileName}");

            using (var fileSrteam = new FileStream(filePath, FileMode.Create))
            {
                await formFile.CopyToAsync(fileSrteam);
            }

            return filePath;
        }

        public async Task<List<VirtualTour>> GetVirtualTourListAsync()
        {
            return await _repository.GetTableNoTracking().ToListAsync();
        }

        public async Task<VirtualTour> CreateVirtualTourAsync(VirtualTour virtualTour)
        {
            if (virtualTour.VirtualUrl == null) throw new ArgumentNullException("The Url isn`t Uplaoded!. Please try again later.");

            var entity = await _repository.AddAsync(virtualTour);
            return entity;
        }

        public async Task<List<VirtualTour>> GetVirtualTourByApartmentAsync(Guid Id)
        {
            var virtualTour = await _repository.GetTableNoTracking().Where(x => x.ApartmentId == Id).ToListAsync();
            if (virtualTour == null) throw new ArgumentNullException("This Apartmen dosen`t have any VirtualTour. Please try again later.");

            return virtualTour;
        }

        public async Task<List<VirtualTour>> GetVirtualTourByPropertyAsync(Guid Id)
        {
            var virtualTour = await _repository.GetTableNoTracking().Where(x => x.PropertyId == Id).ToListAsync();
            if (virtualTour == null) throw new ArgumentNullException("This Property dosen`t have any VirtualTour. Please try again later.");

            return virtualTour;
        }
    }
}
