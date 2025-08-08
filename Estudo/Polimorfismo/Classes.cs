using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     abstract class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar () 
        {
            Console.WriteLine("Preparando para desenhar...");
        }

        public virtual void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine($"Área: {area}");
        }

      
    }
    class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um circulo!");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            base.Area();
        }
    }
    class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um triangulo!");
        }
        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            base.Area();
            
        }
    }
    class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retangulo!");
        }

        public override void Area()
        {

            base.Area();

        }
    }
}
