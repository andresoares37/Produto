using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500, 10);

            produto.Nome = "T";
            
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco); 
            Console.WriteLine(produto.Quantidade);
            Console.WriteLine(produto);
        }
    }
}
