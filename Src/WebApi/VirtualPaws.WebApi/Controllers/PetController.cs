using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualPaws.Application.Interfaces.Repository;

namespace VirtualPaws.WebApi.Controllers
{
    [Route("api/v1/VirtualPaws/[controller]s")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository repo;

        public PetController(IPetRepository repository)
        {
            repo = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = repo.GetAll();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = repo.GetById(id);
            if(item is null) return NotFound();
            return Ok(item);
        }
    }
}
