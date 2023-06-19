namespace SalesManagement
{
    public class PedidoModel
    {
        public PedidoModel(ClienteModel cliente)
        {
            PedidoID = (pedidos.Max(x => x.PedidoID)) ?? 1;
            PedidoIDGUID = Guid.NewGuid();
            Data = DateTime.Now;
            Cliente = cliente;
        }

        public long? PedidoID { get; set; }
        public Guid PedidoIDGUID { get; set; }
        public DateTime Data { get; set; }
        public ClienteModel? Cliente { get; set; }
        public StatusPedido Status { get; set; } = StatusPedido.Processando;
        public List<PedidoProdutoModel> ProdutosPedido { get; set; } = new List<PedidoProdutoModel>();
        public static readonly List<PedidoModel> pedidos = new List<PedidoModel>();
        public double Total
        {
            get
            {//LINQ
                try
                {
                    return ProdutosPedido!.Sum(p => p.Subtotal);
                }
                catch (NullReferenceException nrfe)
                {
                    throw new Exception($"Nota sem venda: {nrfe.Message}");
                }
            }
        }
    }
}