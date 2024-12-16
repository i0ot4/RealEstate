using Application.Features.Apartments.Queries.Models;
using Application.Features.Apartments.Queries.Results;
using Application.Services.Interfaces;
using AutoMapper;
using MediatR;
using SApplication.Bases;

namespace Application.Features.Apartments.Queries.Handlers
{
    public class ApartmentQueryHandler : ResponseHandler, IRequestHandler<GetApartmentsListQuery, List<GetApartmentsListResponse>>,
                                                          IRequestHandler<GetApartmentsListPropertyQuery, List<GetApartmentsListPropertyResponse>>
    {
        private readonly IApartmentService _service;
        private readonly IMapper _mapper;

        public ApartmentQueryHandler(IApartmentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<GetApartmentsListResponse>> Handle(GetApartmentsListQuery request, CancellationToken cancellationToken)
        {
            var apartmentsData = await _service.GetApartmentsListAsync();

            var apartmentMapping = _mapper.Map<List<GetApartmentsListResponse>>(apartmentsData);

            return apartmentMapping.ToList();
        }

        public async Task<List<GetApartmentsListPropertyResponse>> Handle(GetApartmentsListPropertyQuery request, CancellationToken cancellationToken)
        {
            var apartmentsData = await _service.GetApartmentsListPropertyAsync(request.PropertyId);

            //if (apartmentsData.Count <= 0) return NotFound<List<GetApartmentsListPropertyResponse>>($"There is no Apartments in Property {request.PropertyId}");

            var apartmentMapping = _mapper.Map<List<GetApartmentsListPropertyResponse>>(apartmentsData);

            return apartmentMapping.ToList();
        }
    }
}
