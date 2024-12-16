using API.Base;
using Application.Features.Apartments.Commands.Models;
using Application.Features.Apartments.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : AppControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<CreateApartmentCommand>> CreateApartment(CreateApartmentCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }

        [HttpGet("GetApartmentsList")]
        public async Task<IActionResult> GetApartmentsList()
        {
            var response = await _mediator.Send(new GetApartmentsListQuery());
            return Ok(response);
        }

        [HttpGet("GetApartmentsListProperty")]
        public async Task<IActionResult> GetApartmentsListProperty([FromQuery] GetApartmentsListPropertyQuery query)
        {
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
