namespace SalesManagement
    {
        public class ProdutoModel
        {

            public ProdutoModel(string nome, double preco, long estoque, CategoriaModel categoria)
            {
                ProdutoID = (ProdutoModel.produtos.Max((e) => e.ProdutoID) + 1) ?? 1;
                ProdutoIDGUID = Guid.NewGuid();
                Nome = nome;
                Preco = preco;
                Estoque = estoque;
                Categoria = categoria;
            }
            public long? ProdutoID { get; set; }
            public Guid ProdutoIDGUID { get; set; }
            public string Nome { get; set; } = string.Empty;
            public double Preco { get; set; }
            public long Estoque { get; set; }
            public CategoriaModel Categoria { get; set; }
            public static readonly List<ProdutoModel> produtos = new List<ProdutoModel>();
        }
    }