using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_CalcSomaOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            Console.WriteLine(Calc.Somar(10, 10));
            Console.WriteLine(Calc.Somar(5.5, 4.99));
            Console.WriteLine(Calc.Somar(10, 5, 15));
            Console.WriteLine(Calc.Somar("Gabriel", "Caetano"));
        }
    }

    class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public double Somar(double a, double b)
        {
            return a + b;
        }
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }
        public string Somar(string a, string b)
        {
            return a + b;
        }
    }
}
