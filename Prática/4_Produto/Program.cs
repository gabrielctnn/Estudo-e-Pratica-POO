using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            prod.nomeProduto = Console.ReadLine();
            prod.precoProduto = int.Parse(Console.ReadLine());
            prod.quantidadeProduto = int.Parse(Console.ReadLine());

            prod.ExibirDetalhes();
            prod.AdicionarEstoque(10);
            prod.CalcularValorTotal();
        }


    }

    class Produto {
        public string nomeProduto;
        public double precoProduto;
        public int quantidadeProduto;
        

        public void ExibirDetalhes()
        {
            Console.Clear();
            Console.WriteLine($"{nomeProduto} -> R${precoProduto} ({quantidadeProduto} unidades)");
        }

        public void AdicionarEstoque(int qtdADD)
        {
            Console.WriteLine($"Quanto deseja adicionar ao estoque do produto {nomeProduto} (quantidade atual : {quantidadeProduto}) : ");
            qtdADD = int.Parse(Console.ReadLine());
            quantidadeProduto += qtdADD;
            Console.WriteLine($"Quantidade adicionada : {qtdADD}");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirDetalhes();
        }

        public double CalcularValorTotal()
        {
            double valorTotal = precoProduto * quantidadeProduto;
            Console.WriteLine($"Valor total do produto {nomeProduto} é {valorTotal}");
            return valorTotal;
        }
    }


}
