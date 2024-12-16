using Application.Bases;
using Application.Features.Apartments.Commands.Models;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using SApplication.Bases;

namespace Application.Features.Apartments.Commands.Handlers
{
    public class ApartmentCommandHandler : ResponseHandler, IRequestHandler<CreateApartmentCommand, Response<Apartment>>
    {
        private readonly IApartmentService _service;
        private readonly IMapper _mapper;

        public ApartmentCommandHandler(IApartmentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response<Apartment>> Handle(CreateApartmentCommand request, CancellationToken cancellationToken)
        {
            var apartmentMapping = _mapper.Map<Apartment>(request);

            var result = await _service.CreateApartmentAsync(apartmentMapping);

            if (result != null) return Created<Apartment>(result, $"The Property {result.Description} Is Created Success");
            else return BadRequest<Apartment>($"The Property {request.Description} Is Not Created. Please Try again...");
        }
    }
}
