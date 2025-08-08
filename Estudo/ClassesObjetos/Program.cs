using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forma 1  de usar o objeto e usar os atributos.
            Pessoa User = new Pessoa();
            Console.WriteLine("Cadastre-se: ");
            Console.WriteLine("Nome: "); 
            User.name = Console.ReadLine();
            Console.WriteLine("Sobrenome: ");
            User.sobrenome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            User.idade = Convert.ToInt32(Console.ReadLine());

            /* forma 1  de usar o objeto e usar os atributos.
            Pessoa UserADM = new Pessoa()
            {
                name = Console.ReadLine(),
                sobrenome = Console.ReadLine(),
                idade = Convert.ToInt32(Console.ReadLine())
            };
            */
            Console.Clear();

            Console.WriteLine("Usuário cadastrado : ");
            Console.WriteLine($"Nome : {User.name}");
            Console.WriteLine($"Sobrenome : {User.sobrenome}");
            Console.WriteLine($"Idade : {User.idade}");

            /* Console.WriteLine("Usuário ADM cadastrado : ");
            Console.WriteLine($"Nome : {UserADM.name}");
            Console.WriteLine($"Sobrenome : {UserADM.sobrenome}");
            Console.WriteLine($"Idade : {UserADM.idade}"); */

            Console.WriteLine("");
            User.Cumprimentar();
        }
    }
}
