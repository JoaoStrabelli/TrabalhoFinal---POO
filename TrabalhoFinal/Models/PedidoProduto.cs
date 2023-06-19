namespace SalesManagement
{
    public class PedidoProdutoModel
    {
        public PedidoProdutoModel(ProdutoModel produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        } 
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public double Subtotal
        {
            get { return Quantidade * Produto.Preco; }
        }
    }
}
