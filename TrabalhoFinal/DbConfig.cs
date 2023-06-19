using SalesManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesManagement.Migrations
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
                modelBuilder.Entity<PedidoProduto>().HasKey(ip => new { ip.PedidoId, ip.ProdutoId });
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; Database=salesmanagement; User id=root; Password=");
        }
    }
}