using Application.Bases;
using Application.Features.Photos.Commands.Models;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using SApplication.Bases;

namespace Application.Features.Photos.Commands.Handler
{
    public class PhotoCommandHandler : ResponseHandler,
                                      IRequestHandler<CreatePhotoCommand, Response<Photo>>,
                                      IRequestHandler<CreatePhotoListCommand, Response<List<Photo>>>
    {
        private readonly IPhotoService _service;
        private readonly IMapper _mapper;
        public PhotoCommandHandler(IMapper mapper, IPhotoService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<Response<Photo>> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {
            var url = await _service.UplaodPhotoAsync(request.ImageFile);
            request.ImageUrl = url;
            var photoMapping = _mapper.Map<Photo>(request);

            var result = await _service.CreatePhotoAsync(photoMapping);

            if (result != null) return Created(result, $"The Iamges Is Added Success");
            else return BadRequest<Photo>("The Iamges Is Not Added. Please Try again...");
        }

        public async Task<Response<List<Photo>>> Handle(CreatePhotoListCommand request, CancellationToken cancellationToken)
        {
            var urls = await _service.UplaodPhotosListAsync(request.ImageFile);

            List<Photo> photos = new List<Photo>();

            foreach (var url in urls)
            {
                request.ImageUrl = url;

                var photoMapping = _mapper.Map<Photo>(request);
                photos.Add(photoMapping);
            }

            var result = await _service.CreatePhotosListAsync(photos.ToList());

            if (result != null) return Created(result, $"The Iamges Is Added Success");
            else return BadRequest<List<Photo>>("The Iamges Is Not Added. Please Try again...");


        }
    }
}
