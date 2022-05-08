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

        [HttpGet("{id}")]
        public IActionResult GetProdutos([FromRoute] int id)
        {
            var produto = repos.Read(id);
            return Ok(produto);
        }

        [HttpPost]
        public IActionResult PostProdutos([FromBody] PostProdutos produto)
        {
            if(repos.Create(produto))
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult PutProdutos([FromBody] PutProdutos produto)
        {
            if (repos.Update(produto))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProdutos([FromRoute] int id)
        {
            if (repos.Delete(id))
                return Ok();

            return BadRequest();
        }

    }
}
