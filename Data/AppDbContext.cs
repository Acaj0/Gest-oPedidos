using Microsoft.EntityFrameworkCore;
using GestaoPedidos.Models;

namespace GestaoPedidos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("clientes");
            modelBuilder.Entity<Produto>().ToTable("produtos");
            modelBuilder.Entity<Pedido>().ToTable("pedidos");

            modelBuilder.Entity<Cliente>()
                .Property(c => c.ClienteId)
                .HasColumnName("clienteid");
            
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Nome)
                .HasColumnName("nome");
            
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Email)
                .HasColumnName("email");
            
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Telefone)
                .HasColumnName("telefone");

            modelBuilder.Entity<Produto>()
                .Property(p => p.ProdutoId)
                .HasColumnName("produtoid");

            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                .HasColumnName("nome");
            
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnName("preco");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.PedidoId)
                .HasColumnName("pedidoid");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.ClienteId)
                .HasColumnName("clienteid");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.ProdutoId)
                .HasColumnName("produtoid");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.DataPedido)
                .HasColumnName("datapedido");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.Quantidade)
                .HasColumnName("quantidade");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.ValorTotal)
                .HasColumnName("valortotal");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=db.iatzleyljainvtyfhrwi.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=Acaj951753258@");
            }
        }
    }
}
