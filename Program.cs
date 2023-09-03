//Raphael Honorato e Silva - Sistemas para Internet

namespace senac
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\n  -----  \n");
                Console.WriteLine(" ## SISTEMA DE ESTOQUE LOJA DE ROUPAS ## \n [1] Novo Produto \n [2] Listar Produtos \n [3] Remover Produtos \n [4] Entrada Estoque \n [5] Saída Estoque \n [0] Sair");
                Console.WriteLine("\n");
                Console.Write("Escolha uma opção: ");

                string? opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Nome do produto: ");
                    string? nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Tamanho: ");
                    string? tamanho = Console.ReadLine();

                    Console.Write("Categoria: ");
                    string? categoria = Console.ReadLine();

                    Console.Write("Cor: ");
                    string? cor = Console.ReadLine();

                    Produto novoProduto = new Produto(nome!, preco, tamanho!, categoria!, cor!)
                    {
                        Tamanho = tamanho!,
                        Categoria = categoria!,
                        Cor = cor!
                    };

                    estoque.AdicionarProduto(novoProduto);
                    Console.WriteLine("Produto adicionado com sucesso!");
                }

                //listar produtos
                else if (opcao == "2")
                {
                    estoque.ListarProdutos();
                }

                //remover produto
                else if (opcao == "3")
                {

                    Console.Write("Digite o ID do produto: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    estoque.RemoverProduto(id);
                }

                //entrada no estoque
                else if (opcao == "4")
                {

                    Console.Write("Digite o ID do produto: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite a quantidade de entrada: ");
                    int quantidadeEntrada = Convert.ToInt32(Console.ReadLine());

                    estoque.EntradaEstoque(id, quantidadeEntrada);
                }

                //saída no estoque
                else if (opcao == "5")
                {

                    Console.Write("Digite o ID do produto: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite a quantidade de saída: ");
                    int quantidadeSaida = Convert.ToInt32(Console.ReadLine());

                    estoque.SaidaEstoque(id, quantidadeSaida);
                }

                //sai do programa
                else if (opcao == "0")
                {
                    sair = true;
                    Console.WriteLine("Saindo do programa...");
                }

                //verifica caso a opção seja inválida
                else
                {
                    Console.WriteLine("Opção inválida! Escolha uma opção válida.");
                }
            }
        }
    }
}