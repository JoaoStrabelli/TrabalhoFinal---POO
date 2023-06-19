namespace SalesManagement
{
    public class PedidoProdutoModel
    {
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public double Subtotal
        {
            get { return Quantidade * Produto.Preco; }
        }
    }
}
