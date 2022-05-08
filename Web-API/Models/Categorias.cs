using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    [Table(name:"Categorias")]
    public class Categorias
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string? Nome { get; set; }
    }
}
