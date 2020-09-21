using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Console.WriteLine("Entre os dados do produto");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preco: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade em estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto();

            Console.WriteLine();

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);
        }
    }
}
