using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa Pedro = new Pessoa();
            Pedro.nome = "Pedro";
            Pedro.idade = 17;

            Pedro.Envelhecer(13);
        }
    }

    class Pessoa
    {
        public string nome;
        public int idade;

        public void Envelhecer(int anos)
        {
           
            idade += anos;
            Console.WriteLine($"Envelheceu {anos} anos e está com {idade} anos ");
        }

    }
}
