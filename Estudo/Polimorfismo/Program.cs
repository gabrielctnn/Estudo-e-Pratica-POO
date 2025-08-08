using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma a = new Circulo();
            Forma b = new Retangulo();
            Forma c = new Triangulo();

            a.Desenhar();
            a.Area();

            b.Desenhar();
            b.Area();

            c.Desenhar();
            c.Area();

        }
    }
}
