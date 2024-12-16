using Application.Bases;
using Application.Features.Properties.Commands.Models;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using SApplication.Bases;

namespace Application.Features.Properties.Commands.Handlers
{
    public class PropertyCommandHandler : ResponseHandler, IRequestHandler<CreatePropertyCommand, Response<Property>>
    {
        private readonly IPropertyService _service;
        private readonly IMapper _mapper;

        public PropertyCommandHandler(IPropertyService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response<Property>> Handle(CreatePropertyCommand request, CancellationToken cancellationToken)
        {
            var propretyMapping = _mapper.Map<Property>(request);

            var result = await _service.CreatePropertyAsync(propretyMapping);

            if (result != null) return Created<Property>(result, $"The Property {result.Name} Is Created Success");
            else return BadRequest<Property>($"The Property {request.Name} Is Not Created. Please Try again...");
        }
    }
}
