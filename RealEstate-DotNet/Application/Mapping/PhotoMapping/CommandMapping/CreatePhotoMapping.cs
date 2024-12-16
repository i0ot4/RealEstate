using Application.Features.Photos.Commands.Models;
using Domain.Entities;

namespace Application.Mapping.PhotoMapping
{
    public partial class PhotoProfile
    {
        public void CreatePhotoMapping()
        {
            CreateMap<CreatePhotoCommand, Photo>();
        }
    }
}
