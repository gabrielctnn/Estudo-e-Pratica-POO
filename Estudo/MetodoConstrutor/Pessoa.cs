using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        public Pessoa() {
            nome = "Usuário";
            sobreNome = "Novo";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobreNome, int anoNascimento)
        {
            this.nome = nome; //usamos o this para pegar a variavel da CLASSE pessoa e nao do parametro
            this.sobreNome= sobreNome;
            this.anoNascimento= anoNascimento;
            idade = Idade();
        }

        public Pessoa(string nome, string sobreNome)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
        }

        private int Idade()
        {
            return 2025 - anoNascimento;
        }
    }
}
