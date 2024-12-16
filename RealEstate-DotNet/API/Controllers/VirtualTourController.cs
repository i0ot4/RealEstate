using API.Base;
using Application.Features.VirtualTours.Commands.Models;
using Application.Features.VirtualTours.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VirtualTourController : AppControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<CreateVirtualTourCommand>> CareteVirtualTourAsync([FromForm] CreateVirtualTourCommand command)
        {
            return NewResult(await _mediator.Send(command));
        }

        [HttpGet("GetVirtualTourListAsync")]
        public async Task<ActionResult<List<GetVirtualTourListQuery>>> GetVirtualTourListAsync()
        {
            return NewResult(await _mediator.Send(new GetVirtualTourListQuery()));
        }

        [HttpGet("GetVirtualTourListByApartmentAsync")]
        public async Task<ActionResult<GetVirtualTourListByApartmentQuery>> GetVirtualTourListByApartmentAsync([FromQuery] GetVirtualTourListByApartmentQuery query)
        {
            return NewResult(await _mediator.Send(query));
        }

        [HttpGet("GetVirtualTourListByPropertyAsync")]
        public async Task<ActionResult<GetVirtualTourListByPropertyQuery>> GetVirtualTourListByPropertyAsync([FromQuery] GetVirtualTourListByPropertyQuery query)
        {
            return NewResult(await _mediator.Send(query));
        }
    }
}
