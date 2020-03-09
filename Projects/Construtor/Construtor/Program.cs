using System;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            EstoqueProduto produto = new EstoqueProduto("TV", 500.00, 5);

            produto.NomeDoProduto = "Notebook";
            Console.WriteLine(produto.NomeDoProduto);

            /*Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nomeDoProduto = Console.ReadLine();
            Console.Write("Preco: ");
            double precoDoProduto = double.Parse(Console.ReadLine());

            EstoqueProduto dados = new EstoqueProduto(nomeDoProduto, precoDoProduto);

            Console.WriteLine($"Dados do produto: {dados}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            dados.AdicionarProduto(quantidade);
            Console.WriteLine($"Dados Atualizados: {dados}");

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            dados.RemoverProduto(quantidade);
            Console.WriteLine($"Dados atualizados: {dados}");*/

        }
    }
}
