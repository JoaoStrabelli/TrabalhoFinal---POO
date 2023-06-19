namespace SalesManagement
{
    public class PedidoProduto
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Subtotal
        {
            get { return Quantidade * Produto.Preco; }
        }
    }
}
