namespace SalesManagement.Models
{
    public class PedidoProduto
    {
        public long ProdutoId { get; set; }
        public long PedidoId { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
