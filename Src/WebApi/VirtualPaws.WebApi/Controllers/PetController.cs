using MediatR;
using Microsoft.AspNetCore.Mvc;
using VirtualPaws.Application.Features.Pets.Queries.GetAll;
using VirtualPaws.Application.Features.Pets.Queries.GetById;

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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllPetsQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdPetQuery();
            query.Id = id;
            return Ok(await _mediator.Send(query));
        }
    }
}
