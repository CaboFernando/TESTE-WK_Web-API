using Web_API.Models;
using Web_API.Models.Entities.Produtos;

namespace Web_API.Repositories
{
    public interface IProdutoRepository
    {
        public bool Create(PostProdutos produto);
    }

    public class ProdutoRepository : IProdutoRepository
    {
        private readonly _DbContext db;

        public ProdutoRepository(_DbContext _db)
        {
            db = _db;
        }

        public bool Create(PostProdutos produto)
        {
            try
            {
                var novo_produto = new Produtos
                {
                    Nome = produto.Nome
                };
                db.Produtos.Add(novo_produto);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
