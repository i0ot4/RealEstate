using Application.Bases;
using Application.Features.Photos.Queries.Models;
using Application.Features.Photos.Queries.Result;
using Application.Services.Interfaces;
using AutoMapper;
using MediatR;
using SApplication.Bases;

namespace Application.Features.Photos.Queries.Handler
{
    public class PhotoQueryHandler : ResponseHandler,
                                     IRequestHandler<GetPhotoListQuery, Response<List<GetPhotoListResponse>>>,
                                     IRequestHandler<GetPhotoListByApartmentQuery, Response<List<GetPhotoListByApartmentResponse>>>
    {
        private readonly IPhotoService _service;
        private readonly IMapper _mapper;

        public PhotoQueryHandler(IPhotoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response<List<GetPhotoListResponse>>> Handle(GetPhotoListQuery request, CancellationToken cancellationToken)
        {
            var photoData = await _service.GetPhotosListAsync();


            if (photoData == null) return NotFound<List<GetPhotoListResponse>>("There isn`t Data. Please Try again..");

            var photoMapping = _mapper.Map<List<GetPhotoListResponse>>(photoData);

            if (photoMapping == null) return BadRequest<List<GetPhotoListResponse>>("SomeThing on Mapping Went worng.Please Try again later..");
            else return Success(photoMapping, "We Have Get the Data Successfuly..");

        }

        public async Task<Response<List<GetPhotoListByApartmentResponse>>> Handle(GetPhotoListByApartmentQuery request, CancellationToken cancellationToken)
        {
            var photoData = await _service.GetPhotoListByApartmentAsync(request.ApartmentId);

            if (photoData == null) return NotFound<List<GetPhotoListByApartmentResponse>>("There isn`t Data. Please Try again..");

            var photoMapping = _mapper.Map<List<GetPhotoListByApartmentResponse>>(photoData);

            if (photoMapping == null) return BadRequest<List<GetPhotoListByApartmentResponse>>("SomeThing on Mapping Went worng.Please Try again later..");
            else return Success(photoMapping, "We Have Get the Data Successfuly..");
        }
    }
}
