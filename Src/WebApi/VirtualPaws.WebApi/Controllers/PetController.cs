using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualPaws.Application.Interfaces.Repository;

namespace VirtualPaws.WebApi.Controllers
{
    [Route("api/v1/VirtualPaws/[controller]s")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository repository;

        public PetController(IPetRepository repository)
        {
            repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
    }
}
