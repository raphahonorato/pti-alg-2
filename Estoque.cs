//Raphael Honorato e Silva - Sistemas para Internet

namespace senac
{
    class Estoque
    {
        private List<Produto> produtos;

        //declara as propriedades do produto
        public Estoque()
        {
            produtos = new List<Produto>();
        }

        //armazena os produtos em uma lista
        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        //verifica se o produto existe e remove
        public void RemoverProduto(int id)
        {
            Produto? produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        //lista os produtos
        public void ListarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"\nID: {produto.Id}\nNome: {produto.Nome}\nPreço: {produto.Preco.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}\nQuantidade em Estoque: {produto.QuantidadeEstoque}\nTamanho: {produto.Tamanho}\nCategoria: {produto.Categoria}\nCor: {produto.Cor}");

            }
        }

        //verifica se o produto existe e adiciona a quantidade
        public void EntradaEstoque(int id, int quantidade)
        {
            Produto? produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto != null)
            {
                produto.QuantidadeEstoque += quantidade;
                Console.WriteLine($"Entrada de {quantidade} unidades no estoque do produto {produto.Nome}.");
            }

            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }


        public void SaidaEstoque(int id, int quantidade)
        {
            Produto? produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto != null)
            {
                if (produto.QuantidadeEstoque >= quantidade)
                {
                    produto.QuantidadeEstoque -= quantidade;
                    Console.WriteLine($"Saída de {quantidade} unidades do estoque do produto {produto.Nome}.");
                }
                else
                {
                    Console.WriteLine($"Não há quantidade suficiente do produto {produto.Nome} em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }
    }
}