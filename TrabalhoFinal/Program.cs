using MySql.Data.MySqlClient;

namespace SalesManagement
{
    public class Program
    {

        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Gerenciar produtos");
                Console.WriteLine("2 - Gerenciar categorias");
                Console.WriteLine("3 - Gerenciar clientes");
                Console.WriteLine("4 - Gerenciar pedido");
                Console.WriteLine("5 - Mostrar relatório de pedidos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    // case "1":
                    //     ProdutoUI produtoUI = new();
                    //     produtoUI.GerenciarProdutos();
                    //     break;
                    // case "2":
                    //     CategoriaUI categoriaUI = new();
                    //     categoriaUI.MenuDeFuncionalidades();
                    //     break;
                    // case "3":
                    //     ClientesUI clienteUI = new();
                    //     clienteUI.GerenciarClientes();
                    //     break;
                    // case "4":
                    //     PedidoUI vendaUI = new();
                    //     vendaUI.GerenciarPedido();
                    //     break;
                    // case "5":
                    //     RelatorioUI relatorioUI = new();
                    //     relatorioUI.MostrarRelatorioPedidos();
                    //     break;
                    // case "0":
                    //     continuar = false;
                    //     break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (continuar);
        }




    }
}