using Web_API.Models;
using Web_API.Models.Entities.Produtos;

namespace Web_API.Repositories
{
    public interface IProdutoRepository
    {
        public bool Create(PostProdutos produto);
        public Produtos Read(int id);
        public bool Update(PutProdutos produto);
        public bool Delete(int id);
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

        public Produtos Read(int id)
        {
            try
            {
                return db.Produtos.Find(id);
            }
            catch
            {
                return new Produtos();
            }
        }

        public bool Update(PutProdutos produto)
        {
            try
            {
                var db_produto = db.Produtos.Find(produto.Id);
                db_produto.Nome = produto.Nome;
                db.Produtos.Update(db_produto);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var db_produto = db.Produtos.Find(id);                
                db.Produtos.Remove(db_produto);
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
