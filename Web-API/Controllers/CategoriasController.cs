using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : Controller
    {
        [HttpGet]
        public IActionResult GetCategorias()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostCategorias()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult PutCategorias()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCategorias()
        {
            return Ok();
        }
    }
}
