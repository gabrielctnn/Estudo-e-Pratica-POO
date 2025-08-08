using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        // metodo simples
        public void Cumprimentar() {
            Console.WriteLine("Olá, seja bem vindo!");
        }

        // metodo com parametro
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine($"O resultado é {resultado}");
        }

        // Passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor Final (por valor) é " + valor);
        }


        // passagem de parametros por referencia
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor Final (por referencia) é " + valor);
        }

        public string MontaNome (string nome, string sobrenome)
        {
            //  string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }
    }
}
  
