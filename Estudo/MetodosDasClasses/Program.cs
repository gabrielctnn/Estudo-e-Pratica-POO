using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Metodos H = new Metodos();
             H.Cumprimentar();

             Console.WriteLine("");
             Console.WriteLine("Digite um valor para somar com 10");
             H.Somar(Convert.ToInt32(Console.ReadLine()), 10);
            

            int valor1 = 100;
            int valor2 = 100;

            Metodos V = new Metodos();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            V.AumentarValor(valor1);
            V.AumentarRef(ref valor2);
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            */

            Metodos Nome = new Metodos();
            Console.WriteLine("Digite seu nome e sobrenome para organizar em uma linha só");
            string nomeCompleto = Nome.MontaNome (Console.ReadLine(), Console.ReadLine());
         
            Console.WriteLine(nomeCompleto);

        }
    }
}
