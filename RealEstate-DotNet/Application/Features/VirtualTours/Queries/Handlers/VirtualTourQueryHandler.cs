using Application.Bases;
using Application.Features.VirtualTours.Queries.Models;
using Application.Features.VirtualTours.Queries.Results;
using Application.Services.Interfaces;
using AutoMapper;
using MediatR;
using SApplication.Bases;

namespace Application.Features.VirtualTours.Queries.Handlers
{
    public class VirtualTourQueryHandler : ResponseHandler,
                                           IRequestHandler<GetVirtualTourListQuery, Response<List<GetVirtualTourListResponse>>>,
                                           IRequestHandler<GetVirtualTourListByApartmentQuery, Response<List<GetVirtualTourListByApartmentResponse>>>,
                                           IRequestHandler<GetVirtualTourListByPropertyQuery, Response<List<GetVirtualTourListByPropertyResponse>>>
    {
        private readonly IVirtualTourService _service;
        private readonly IMapper _mapper;

        public VirtualTourQueryHandler(IVirtualTourService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response<List<GetVirtualTourListResponse>>> Handle(GetVirtualTourListQuery request, CancellationToken cancellationToken)
        {
            var virtualTours = await _service.GetVirtualTourListAsync();

            if (virtualTours == null) return NotFound<List<GetVirtualTourListResponse>>("There isn`t any virtualTours Found!! Please try again later.");

            var virtualToursMapping = _mapper.Map<List<GetVirtualTourListResponse>>(virtualTours);

            if (virtualToursMapping == null) return BadRequest<List<GetVirtualTourListResponse>>("SomeThing Went worng!! Please Try again later.");
            else return Success(virtualToursMapping, $"We Get {virtualToursMapping.Count} VirtualTour Successfuly.");
        }

        public async Task<Response<List<GetVirtualTourListByApartmentResponse>>> Handle(GetVirtualTourListByApartmentQuery request, CancellationToken cancellationToken)
        {
            var virtualTours = await _service.GetVirtualTourByApartmentAsync(request.ApartmentId);

            if (virtualTours == null) return NotFound<List<GetVirtualTourListByApartmentResponse>>("There isn`t any virtualTours Found!! Please try again later.");

            var virtualToursMapping = _mapper.Map<List<GetVirtualTourListByApartmentResponse>>(virtualTours);

            if (virtualToursMapping == null) return BadRequest<List<GetVirtualTourListByApartmentResponse>>("SomeThing Went worng!! Please Try again later.");
            else return Success(virtualToursMapping, $"We Get {virtualToursMapping.Count} VirtualTour Successfuly.");
        }

        public async Task<Response<List<GetVirtualTourListByPropertyResponse>>> Handle(GetVirtualTourListByPropertyQuery request, CancellationToken cancellationToken)
        {
            var virtualTours = await _service.GetVirtualTourByPropertyAsync(request.PropertyId);

            if (virtualTours == null) return NotFound<List<GetVirtualTourListByPropertyResponse>>("There isn`t any virtualTours Found!! Please try again later.");

            var virtualToursMapping = _mapper.Map<List<GetVirtualTourListByPropertyResponse>>(virtualTours);

            if (virtualToursMapping == null) return BadRequest<List<GetVirtualTourListByPropertyResponse>>("SomeThing Went worng!! Please Try again later.");
            else return Success(virtualToursMapping, $"We Get {virtualToursMapping.Count} VirtualTour Successfuly.");
        }
    }
}
