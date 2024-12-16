using Application.Bases;
using Domain.Entities;
using MediatR;

namespace Application.Features.Apartments.Commands.Models
{
    public class CreateApartmentCommand : IRequest<Response<Apartment>>
    {
        public int ApartmentNumber { get; set; }
        public string Description { get; set; }
        public string Floor { get; set; }
        public float Area { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public decimal? Price { get; set; }
        public int Status { get; set; } // متاح 0 - مؤجر 1
    }
}
