using MediatR;
using Microsoft.AspNetCore.Mvc;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Application.Features.Pets.Commands.Create;
using VirtualPaws.Application.Features.Pets.Queries.GetAll;
using VirtualPaws.Application.Features.Pets.Queries.GetById;
using VirtualPaws.Application.Features.Pets.Queries.GetEntity;

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

        [HttpGet("Entities/")]
        public async Task<IActionResult> GetAllEntity()
        {
            var query = new GetPetEntityQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> AddPet(PetCreateDTO dto)
        {
            var command = new CreatePetCommand();
            command.dto = dto;
            var item = _mediator.Send(command).Result;
            return CreatedAtAction(nameof(GetById), new { id =  item.Id}, item);
        }
    }
}
