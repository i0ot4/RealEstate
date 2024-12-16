using Application.Interfaces.Repositories;
using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepositoryAsync _repository;

        public PhotoService(IPhotoRepositoryAsync repository)
        {
            _repository = repository;
        }

        public async Task<List<Photo>> GetPhotoListByApartmentAsync(Guid? Id)
        {
            var result = await _repository.GetTableNoTracking().Where(x => x.ApartmentId.Equals(Id)).ToListAsync();
            return result;
        }


        public async Task<List<Photo>> GetPhotosListAsync()
        {
            var result = await _repository.GetTableNoTracking().ToListAsync();
            return result;
        }


        public async Task<string> UplaodPhotoAsync(IFormFile formFile)
        {
            if (formFile == null && formFile.Length > 0)
            {
                throw new ArgumentNullException(nameof(formFile));
            }
            //var fileName = Path.GetFileName(photo.ImageFile.FileName);
            var filePath = Path.Combine("wwwroot/images/", $"{Guid.NewGuid()}_{formFile.FileName}");

            using (var fileSrteam = new FileStream(filePath, FileMode.Create))
            {
                await formFile.CopyToAsync(fileSrteam);
            }

            return filePath;
        }


        public async Task<Photo> CreatePhotoAsync(Photo photo)
        {
            return await _repository.AddAsync(photo);
        }

        public async Task<List<string>> UplaodPhotosListAsync(List<IFormFile> images)
        {
            if (images == null || images.Any(image => image == null || image.Length == 0))
            {
                throw new ArgumentException("Invalid image files");
            }
            var files = new List<string>();
            foreach (var image in images)
            {
                var filePath = Path.Combine("wwwroot/images/", $"{Guid.NewGuid()}_{image.FileName}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                files.Add(filePath);
            }
            return files;
        }

        public Task<List<Photo>> CreatePhotosListAsync(List<Photo> images)
        {
            var result = _repository.AddRangeListAsync(images);

            return result;
        }

        /*
                public async Task<Photo> CreatePhotoAsync(Photo photo)
                {
                    if (photo.ImageFile != null && photo.ImageFile.Length > 0)
                    {
                        //var fileName = Path.GetFileName(photo.ImageFile.FileName);
                        var filePath = Path.Combine("wwwroot/images/", $"{Guid.NewGuid()}_{photo.ImageFile.FileName}");

                        using (var fileSrteam = new FileStream(filePath, FileMode.Create))
                        {
                            await photo.ImageFile.CopyToAsync(fileSrteam);
                        }
                    }
                    return await _repository.AddAsync(photo);
                }*/

        /*public async Task<string> CreatePhotosListAsync(List<Photo> images)
        {
            if (images == null || images.Any(image => image.ImageFile == null || image.ImageFile.Length == 0))
            {
                throw new ArgumentException("Invalid image files");
            }

            foreach (var image in images)
            {
                var filePath = Path.Combine("wwwroot/images/", $"{Guid.NewGuid()}_{image.ImageFile.FileName}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.ImageFile.CopyToAsync(stream);
                }
            }
            var result = _repository.AddRangeAsync(images);
            if (!result.IsCompleted) return "Images Added Failed. Plaese Try again";
            return "Images Added Successfuly.";
        }*/

        /*public async Task AddImage(Photo image)
        {
            // Validate input (replace with your own validation logic)
            if (image.ImageFile == null || image.ImageFile.Length == 0)
            {
                throw new ArgumentException("Invalid image file");
            }

            // Save the image file to a specific location
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", $"{Guid.NewGuid()}_{image.ImageFile.FileName}");
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.ImageFile.CopyToAsync(stream);
            }

            await _repository.AddAsync(image);
        }



        public async Task AddImages(List<ImageModel> images)
        {
            // Validate input (replace with your own validation logic)
            if (images == null || images.Any(image => image.File == null || image.File.Length == 0))
            {
                throw new ArgumentException("Invalid image files");
            }

            // Save the image files to specific locations
            foreach (var image in images)
            {
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", $"{Guid.NewGuid()}_{image.File.FileName}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.File.CopyToAsync(stream);
                }

                // Update the image model with the file path or URL
                image.Url = filePath;
            }

            _imageRepository.AddImages(images);
        }*/


    }
}
