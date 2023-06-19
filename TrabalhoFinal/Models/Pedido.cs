namespace SalesManagement.Models
{
    public class Pedido
    {
        public long? Id { get; set; }
        public DateTime Data { get; set; }
        public long ClienteId { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
    }
}