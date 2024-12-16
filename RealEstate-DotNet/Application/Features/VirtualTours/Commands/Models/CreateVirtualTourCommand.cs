using Application.Bases;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.VirtualTours.Commands.Models
{
    public class CreateVirtualTourCommand : IRequest<Response<VirtualTour>>
    {
        public Guid? PropertyId { get; set; }
        public Guid? ApartmentId { get; set; }
        public IFormFile VirtualTourFile { get; set; }
        public string? VirtualUrl { get; set; }
    }
}
