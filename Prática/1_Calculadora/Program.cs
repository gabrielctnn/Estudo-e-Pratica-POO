using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Calculadora calculadora = new Calculadora();
            calculadora.Somar(10, 50);
            calculadora.Subtrair(190, 90);
            calculadora.Multiplicar(5, 5);
            calculadora.Dividir(4, 2);
        }
    }

    class Calculadora
    {
        public int Somar (int a , int b)
        {
            int resultado = a + b;
            Console.WriteLine($"O resultado da soma é {resultado}");
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            return resultado;
        }

        public int Multiplicar (int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            return resultado;
        }


        public double Dividir(int a, int b)
        {
            int resultado = a / b;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            return resultado;
        }
    }
    }

