namespace SalesManagement
    {
        public class ProdutoModel
        {
            public long? Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public double Preco { get; set; }
            public long Estoque { get; set; }
            public CategoriaModel Categoria { get; set; }
            public static readonly List<ProdutoModel> produtos = new List<ProdutoModel>();
        }
    }