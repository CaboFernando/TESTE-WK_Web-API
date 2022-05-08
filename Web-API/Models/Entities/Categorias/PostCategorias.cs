using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Entities.Categorias
{
    public class PostCategorias
    {
        [Required, MaxLength(200)]
        public string? Nome { get; set; }
    }
}
