using Web_API.Models;
using Web_API.Models.Entities.Categorias;

namespace Web_API.Repositories
{
    public interface ICategoriaRepository
    {
        public bool Create(PostCategorias categoria);
        public Categorias Read(int id);
        public bool Update(PutCategorias categoria);
        public bool Delete(int id);
    }

    public class CategoriaRepository : ICategoriaRepository
    {


        private readonly _DbContext db;

        public CategoriaRepository(_DbContext _db)
        {
            db = _db;
        }

        public bool Create(PostCategorias categoria)
        {
            try
            {
                var nova_categoria = new Categorias
                {
                    Nome = categoria.Nome
                };
                db.Categorias.Add(nova_categoria);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Categorias Read(int id)
        {
            try
            {
                return db.Categorias.Find(id);
            }
            catch
            {
                return new Categorias();
            }
        }        

        public bool Update(PutCategorias categoria)
        {
            try
            {
                var db_categoria = db.Categorias.Find(categoria.Id);
                db_categoria.Nome = categoria.Nome;
                db.Categorias.Update(db_categoria);
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
                var db_categoria = db.Categorias.Find(id);
                db.Categorias.Remove(db_categoria);
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
