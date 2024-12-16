using Application.Features.Properties.Queries.Models;
using Application.Features.Properties.Queries.Results;
using Application.Services.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Properties.Queries.Handlers
{
    public class PropertyQueryHandler : IRequestHandler<GetPropertyListQuery, List<GetPropertyListResponse>>
    {
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;

        public PropertyQueryHandler(IMapper mapper, IPropertyService propertyService)
        {
            _mapper = mapper;
            _propertyService = propertyService;
        }

        public async Task<List<GetPropertyListResponse>> Handle(GetPropertyListQuery request, CancellationToken cancellationToken)
        {
            var properties = await _propertyService.GetPropertyListAsync();
            var propertiesMapping = _mapper.Map<List<GetPropertyListResponse>>(properties);

            return propertiesMapping.ToList();
        }
    }
}
