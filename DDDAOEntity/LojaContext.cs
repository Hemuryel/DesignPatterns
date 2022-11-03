using Microsoft.EntityFrameworkCore;

namespace AluraLoja
{
    internal class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DTI-HEMURYEL\\SQLEXPRESS;Database=db_alura_loja;User=sa;Password=2*7nDj3MhgFGCt6iJyYdSFzpHJs*cQ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });

            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos");

            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId"); // shadown property

            modelBuilder
                .Entity<Endereco>()
                .HasKey("ClienteId");
        }
    }
}