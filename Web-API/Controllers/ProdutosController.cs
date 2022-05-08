using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        [HttpGet]
        public IActionResult GetProdutos()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProdutos()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult PutProdutos()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProdutos()
        {
            return Ok();
        }

    }
}
