using Application.Bases;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Photos.Commands.Models
{
    public class CreatePhotoCommand : IRequest<Response<Photo>>
    {
        public Guid? PropertyId { get; set; }
        public Guid? ApartmentId { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
