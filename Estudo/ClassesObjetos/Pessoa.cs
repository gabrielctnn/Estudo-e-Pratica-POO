using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        public string name;
        public string sobrenome;
        public int idade;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá muito prazer! Me chamo {name} {sobrenome} tenho {idade} anos, e estou feliz em me cadastrar.");
        }
    }
}
