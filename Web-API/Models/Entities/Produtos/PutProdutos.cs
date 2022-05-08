using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Entities.Produtos
{
    public class PutProdutos : PostProdutos
    {
        public int Id { get; set; }
    }
}
