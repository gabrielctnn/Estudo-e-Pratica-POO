using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte1
            //Carro c = new Carro();
            //c.Cor = "Vermelho";
            //c.LigarMotor();
            //Bicicleta b = new Bicicleta();
            //b.Marca = "marca famosa ai";
            //b.Pedalar();

            #endregion 

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("Humano");
            a.Olhos();
            a.Cabelos();
            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();
            Console.WriteLine("\nHomem");
            c.Olhos();
            c.Cabelos();

        }
    }
}
