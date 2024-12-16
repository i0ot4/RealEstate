using Application.Bases;
using Application.Features.VirtualTours.Commands.Models;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using SApplication.Bases;

namespace Application.Features.VirtualTours.Commands.Handler
{
    public class VirtualTourCommandHandler : ResponseHandler,
                                             IRequestHandler<CreateVirtualTourCommand, Response<VirtualTour>>
    {

        private readonly IVirtualTourService _service;
        private readonly IMapper _mapper;

        public VirtualTourCommandHandler(IVirtualTourService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response<VirtualTour>> Handle(CreateVirtualTourCommand request, CancellationToken cancellationToken)
        {
            var virtualTourUrl = await _service.UplaodVirtualTourAsync(request.VirtualTourFile);
            request.VirtualUrl = virtualTourUrl;
            var virtualTourMapping = _mapper.Map<VirtualTour>(request);

            var result = await _service.CreateVirtualTourAsync(virtualTourMapping);

            if (result == null) return BadRequest<VirtualTour>("Something went worng!! Plaese try again later.");
            else return Success(result, "The VirtualTour Added successfuly.");

        }
    }
}
