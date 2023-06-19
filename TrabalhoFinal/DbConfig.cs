using GerenciamentoPedidosComida.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoPedidosComida.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Pedido>? Pedidos { get; set; }
        public DbSet<PedidoProduto>? PedidoProdutos { get; set; }
        public DbSet<Produto>? Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<ItemPedido>().HasKey(ip => new { ip.PedidoId, ip.PratoId });
                modelBuilder.Entity<Avaliacao>().ToTable("Avaliacao");
                modelBuilder.Entity<Cliente>().ToTable("Cliente");
                modelBuilder.Entity<ItemPedido>().ToTable("ItemPedido");
                modelBuilder.Entity<Pedido>().ToTable("Pedido");
                modelBuilder.Entity<Prato>().ToTable("Prato");
                modelBuilder.Entity<Restaurante>().ToTable("Restaurante");
                
                modelBuilder.Entity<Avaliacao>().Property(c => c.Comentario).IsRequired(false); // Permite valores nulos
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; Database=gerenciamentopedidoscomida; User id=root; Password=");
        }
    }
}