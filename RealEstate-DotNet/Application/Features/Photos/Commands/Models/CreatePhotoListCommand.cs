using Application.Bases;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Photos.Commands.Models
{
    public class CreatePhotoListCommand : IRequest<Response<List<Photo>>>
    {
        public Guid? PropertyId { get; set; }
        public Guid? ApartmentId { get; set; }
        public List<IFormFile> ImageFile { get; set; }
        public string? ImageUrl { get; set; }
    }
}
