using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
     class Aluno
    {
        public string Nome { get; private set; } //privando podemos só capturar/receber para imprimir e para atribuir somento no constructor aluno, porque nao podemos alterar o nome 

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        // Constructor, exige que seja criado com esses parametros definidos para que funcione
        public Aluno(string nome, int provas) {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++) //for vai rodar até atingir o tamanho do array definido acima, ou seja o numero de provas
            {
                Console.Write($"Nota #{i + 1} : ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }
        
    }
}
