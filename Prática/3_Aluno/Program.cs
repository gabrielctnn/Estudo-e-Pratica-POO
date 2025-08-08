using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            aluno1.nome = "pedro";
            aluno1.nota1 = 5;
            aluno1.nota2 = 10;

            aluno1.CalcularMedia();
            aluno1.VerificarAprovacao();

        }

    }

    class Aluno
    {
        public string nome;
        public double nota1, nota2;
        double notaFinal;

        public double CalcularMedia()
        {
            notaFinal = (nota1 + nota2) / 2;
            return notaFinal;
        }

        public void VerificarAprovacao()
        {
            if (notaFinal >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado!");
            } else
            {
                Console.WriteLine("reprovado!");
            }
        }
    }

}
