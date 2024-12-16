using API.Base;
using Application.Features.Photos.Commands.Models;
using Application.Features.Photos.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : AppControllerBase
    {

        [HttpPost("CreateImage")]
        public async Task<ActionResult<CreatePhotoCommand>> CreateImage([FromForm] CreatePhotoCommand command)
        {
            return NewResult(await _mediator.Send(command));
        }

        [HttpPost("CreateListImages")]
        public async Task<ActionResult<CreatePhotoListCommand>> CreateListImages([FromForm] CreatePhotoListCommand command)
        {
            return NewResult(await _mediator.Send(command));
        }

        [HttpGet("GetPhotosListAsync")]
        public async Task<ActionResult<GetPhotoListQuery>> GetPhotosListAsync([FromQuery] GetPhotoListQuery query)
        {
            return NewResult(await _mediator.Send(query));
        }

        [HttpGet("GetPhotoListByApartmentAsync")]
        public async Task<ActionResult<GetPhotoListByApartmentQuery>> GetPhotoListByApartmentAsync([FromQuery] GetPhotoListByApartmentQuery query)
        {
            return NewResult(await _mediator.Send(query));
        }
    }
}
