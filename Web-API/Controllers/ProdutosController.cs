using Microsoft.AspNetCore.Mvc;
using Web_API.Models.Entities.Produtos;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository repos;

        public ProdutosController(IProdutoRepository _repos)
        {
            repos = _repos;
        }

        [HttpGet]
        public IActionResult GetProdutos()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProdutos([FromBody] PostProdutos produto)
        {
            if(repos.Create(produto))
                return Ok();

            return BadRequest();
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
