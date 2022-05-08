using Microsoft.AspNetCore.Mvc;
using Web_API.Models.Entities.Categorias;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepository repos;

        public CategoriasController(ICategoriaRepository _repos)
        {
            repos = _repos;
        }

        [HttpGet("{id}")]
        public IActionResult GetCategorias([FromRoute] int id)
        {
            var categoria = repos.Read(id);
            return Ok(categoria);
        }

        [HttpPost]
        public IActionResult PostCategorias([FromBody] PostCategorias categoria)
        {
            if (repos.Create(categoria))
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult PutCategorias([FromBody] PutCategorias categoria)
        {
            if (repos.Update(categoria))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategorias([FromRoute] int id)
        {
            if (repos.Delete(id))
                return Ok();

            return BadRequest();
        }
    }
}
