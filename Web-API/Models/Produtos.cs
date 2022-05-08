using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    [Table(name:"Produtos")]
    public class Produtos
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string? Nome { get; set; }
    }
}
