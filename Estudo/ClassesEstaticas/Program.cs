using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes Estaticas
            Matematica.taxa = 10;
            int valor1 = Matematica.Adicionar(100);
            int valor2 = Matematica.Diminuir(100);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);


            #endregion


            Pessoa.maioridade = 18;

            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.idade = Pessoa.CalcularIdade(2007);

            p1.Apresentar();

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);
            Console.ReadKey();
        }
    }
}
