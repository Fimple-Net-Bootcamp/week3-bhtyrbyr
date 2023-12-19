using MediatR;
using Microsoft.AspNetCore.Mvc;
using VirtualPaws.Application.Features.Entities.Pets.Queries;

namespace VirtualPaws.WebApi.Controllers
{
    [Route("api/v1/VirtualPaws/[controller]s")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllListQuery();
            return Ok(await _mediator.Send(query));
        }
    }
}
