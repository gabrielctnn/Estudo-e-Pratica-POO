using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Kaique";
            // c.Saldo = 100; nao funciona pois só pode ser alterado na propriedade do  cliente

            // Deposito
            double valor = 100;
            c.Depositar(valor);

            // Sacar
            double valor2 = 50;
            c.Sacar(valor2);

            // Resultado saldo atual
            Console.WriteLine($"Cliente: {c.Cliente}");
            Console.WriteLine($"Saldo atual: {c.Saldo}");
        }
    }
}
