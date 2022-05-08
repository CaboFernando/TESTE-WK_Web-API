using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Entities.Produtos
{
    public class PostProdutos
    {
        [Required, MaxLength(200)]
        public string? Nome { get; set; }
    }
}
