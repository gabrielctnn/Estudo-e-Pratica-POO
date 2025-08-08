using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            // t.nome = ""; como é private só pode ser usado na propria classe
            t.sobrenome = "";

            //t.Metodo1(); private!
            t.Executar();

            Homem h = new Homem();
            h.idade = 18;
        }
    }
}
