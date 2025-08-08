using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Civic = new Car();
            Civic.marca = "Honda";
            Civic.modelo = "Civic";
            Civic.ano = 2020;

            Civic.ExibirInformacoes();
            Civic.AlterarAno(2022);
        }
    }

    class Car
    {
        public string marca;
        public string modelo;
        public int ano;

        public void ExibirInformacoes()
        {
            Console.Clear();
            Console.WriteLine("O seu carro é um :");
            Console.WriteLine($"{marca} {modelo} de {ano}!");
            Console.ReadKey();

        }

        public void AlterarAno(int novoAno)
        {
            ano = novoAno;
            ExibirInformacoes();
        }
    }
}
