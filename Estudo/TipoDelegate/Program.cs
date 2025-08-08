using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate int Funcao(int num1, int num2);
        static void Main(string[] args)
        {
            int result;

            Funcao funcao = new Funcao(CalculoMedia);
            result = funcao(8, 7);
            Console.WriteLine(result);
        }

        static int CalculoMedia (int n1, int n2)
        {
            int resultado;
            resultado = (n1 + n2) / 2;
            return resultado;
        }
    }
}
