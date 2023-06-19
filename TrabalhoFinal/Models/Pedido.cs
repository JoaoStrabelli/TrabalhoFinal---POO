namespace SalesManagement
{
    public class PedidoModel
    {
        public long? PedidoID { get; set; }
        public DateTime Data { get; set; }
        public ClienteModel? Cliente { get; set; }
        public StatusPedido Status { get; set; } = StatusPedido.Processando;
        public double Total { get; set; }
    }
}