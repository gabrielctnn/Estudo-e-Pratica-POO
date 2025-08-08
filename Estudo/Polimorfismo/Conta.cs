using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    interface IConta //obriga a classe que o herdar tenha obrigatoriedade de usar essas coisas como um contrato
     {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }

    class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {
     
        }

        public void Sacar()
        {
        
        }

        public void Saldo()
        {
           
        }

        // pode adicionar mais propriedades ou metodos, mas deve conter a estrutura PADRAO da interface
    }
}
