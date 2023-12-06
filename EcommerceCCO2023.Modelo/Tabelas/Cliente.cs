using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EcommerceCCO2023.Modelo.Enums;

namespace EcommerceCCO2023.Models.Tabelas
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [Required]
        [MaxLength(50)]
        public string NomeCli { get; set; }

        [MaxLength(50)]
        public string Foto { get; set; }

        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Senha { get; set; }

        public StatusCliente Status { get; set; }
    }
}
