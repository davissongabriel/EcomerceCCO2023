using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcommerceCCO2023.Models.Tabelas
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required]
        public int QtdProd { get; set; }

        public decimal Valor { get; set; }

        [MaxLength(150)]
        public string UrlImg { get; set; }

        public int? Status { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }
    }
}
