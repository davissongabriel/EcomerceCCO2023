using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Produto
    {
        public Produto()
        {
            Categorias = new HashSet<Categoria>();
        }

        // atributos = propriedades
        public int IdProduto { get; set; }
        public string NomeProd { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string UrlImagem { get; set; }
        public int Status { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }
}
