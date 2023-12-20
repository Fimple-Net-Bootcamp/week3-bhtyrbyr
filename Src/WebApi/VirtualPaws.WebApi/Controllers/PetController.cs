using MediatR;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Application.Features.Entities.Pets.Commands.Create;
using VirtualPaws.Application.Features.Entities.Pets.Commands.Delete;
using VirtualPaws.Application.Features.Entities.Pets.Commands.Update;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(UInt16 id)
        {
            var query = new GetByIdQuery(id);
            return Ok(await _mediator.Send(query));
        }

        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] PetCreateDTO model)
        {
            var command = new CreateCommand(model);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = command.newId }, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(UInt16 id)
        {
            var command = new DeleteCommand(id);
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePut(UInt16 id, [FromBody] PetUpdateDTO model)
        {
            var command = new UpdatePutCommand(id, model);
            return Ok(await _mediator.Send(command));
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePatch(UInt16 id, [FromBody] JsonPatchDocument<PetUpdateDTO> model)
        {
            var updateDTOModel = new PetUpdateDTO();
            model.ApplyTo(updateDTOModel);
            var command = new UpdatePutCommand(id, updateDTOModel);
            return Ok(await _mediator.Send(command));

        }
    }
}
