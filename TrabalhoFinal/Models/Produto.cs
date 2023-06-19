namespace SalesManagement.Models
    {
        public class Produto
        {
            public long? Id { get; set; }
            public string Nome { get; set; }
            public double Preco { get; set; }
            public long Estoque { get; set; }
            public long CategoriaId { get; set; }
        }
    }