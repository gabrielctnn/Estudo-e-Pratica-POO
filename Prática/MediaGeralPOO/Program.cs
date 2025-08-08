using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aplicação que cadastraremos a quantidade de alunos que queremos calcular a media,
            // dps cadastraremos quantas provas eles fizeram, dps a media de cada um e dps media geral de todos.
            Console.Title = "### MÉDIA GERAL DOS ALUNOS ###"; // define o titulo do programa

            Console.WriteLine("Quantos alunos?");
            int numAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Aluno[] alunos = new Aluno[numAlunos];

            //for pra pegar os nomes, total de provas e notas
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Digite o nome do aluno #{i+1}: ");
                string nome = Console.ReadLine();

                Console.WriteLine("");

                Console.Write($"Digite o números de provas feitas pelo  {nome}: ");
                int provas = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                alunos[i] = new Aluno(nome, provas);
                Console.WriteLine($"Insira as notas do aluno {nome}");
                alunos[i].InserirNotas();
            }
            Console.Clear();

            // apartir daqui mostra os resultados finais
            double mediaGeral = 0;

            foreach (Aluno aluno in alunos) { //ele vai passar por cada elemento do array alunos
                Console.WriteLine($"Aluno: {aluno.Nome}"); //exibe o nome
                Console.WriteLine($"Media: {aluno.Media}"); //e a sua media
                Console.WriteLine();

                mediaGeral += aluno.Media; //e aqui ele vai pegar a media e adicionar a media geral
            }

            double resultadoFinal = mediaGeral / alunos.Length; // vai pegar a media geral e dividir pela quantidade de alunos

            Console.WriteLine($"Média geral dos alunos: {resultadoFinal}"); //exibe a media geral

            Console.ReadKey();

        }
    }
}
