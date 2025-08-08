using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.saldo = 100;


            Console.WriteLine("Bem vindo a sua conta bancária!");
            Console.WriteLine("Por favor informe o titular da conta:");
            conta.titular = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Bem vindo de volta, {conta.titular}");
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Consultar Saldo");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");


            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: conta.Depositar(); break;
                case 2: conta.Sacar(); break;
                case 3: conta.ExibirSaldo(); break;
                case 0: Environment.Exit(0); break;
                default: Environment.Exit(0); break;

            }

        }
    }

    class ContaBancaria
    {
        public string titular;
        public double saldo;

        public void Depositar()
        {
            Console.Clear();

            Console.WriteLine("Quanto deseja depositar em sua conta?");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            saldo += valor;

            Console.WriteLine($"{valor} adicionado ao saldo.");
            ExibirSaldo();

        }

        public void Sacar()
        {
            Console.Clear();

            Console.WriteLine("Quanto deseja sacar em sua conta?");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            if (valor > saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
                Environment.Exit(0);
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"{valor} retirado do saldo.");
                


            }

        }

        public void ExibirSaldo()
        {
            Console.Clear();

            Console.WriteLine($"Saldo atual de {saldo}");
        }
    }
}

       
 