using API.Base;
using Application.Features.Properties.Commands.Models;
using Application.Features.Properties.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : AppControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<CreatePropertyCommand>> CreateProperty(CreatePropertyCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetPropertiesList()
        {
            var response = await _mediator.Send(new GetPropertyListQuery());
            return Ok(response);
        }


    }
}
