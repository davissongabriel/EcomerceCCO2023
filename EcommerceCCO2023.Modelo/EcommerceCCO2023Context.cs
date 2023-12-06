using EcommerceCCO2023.Models.Tabelas;
using Microsoft.EntityFrameworkCore;

namespace EcommerceCCO2023
{
    public class EcommerceCCO2023Context : DbContext {
        public EcommerceCCO2023Context(DbContextOptions<EcommerceCCO2023Context> options) : base(options) {}
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Produto>()
            .HasOne(p => p.Categoria)
            .WithMany()
            .HasForeignKey(p => p.CategoriaId);

            base.OnModelCreating(modelBuilder);
        }
    }


}
