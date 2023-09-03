//Raphael Honorato e Silva - Sistemas para Internet

namespace senac
{
    class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Tamanho { get; set; }
        public string Categoria { get; set; }
        public string Cor { get; set; }

        private static int proximoId = 1;

        public Produto(string nome, double preco, string tamanho, string categoria, string cor)
        {
            Id = proximoId++;
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = 0;
            Tamanho = tamanho;
            Categoria = categoria;
            Cor = cor;
        }
    }
}

