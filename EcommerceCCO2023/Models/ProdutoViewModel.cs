using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceCCO2023.Models
{
    public class ProdutoViewModel
    {
        public int IdProduto { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int QtdProd { get; set; }

        public decimal Valor { get; set; }
        public string UrlImg { get; set; }

        public int? Status { get; set; }

        public virtual CategoriaViewModel CategoriaViewModel { get; set; }
    }
}
