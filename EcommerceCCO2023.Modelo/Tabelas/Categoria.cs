using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceCCO2023.Models.Tabelas
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoria { get; set; }

        [Required]
        [MaxLength(30)]
        public string CategoriaNome { get; set; }
    }
}
