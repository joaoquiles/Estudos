using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___PedidoFastFood
{
    public class Endereco
    {
        public string rua;
        public string bairro;
        public int numeroDaCasa;
        public string complemento;

        public void ExibirEndereco()
        {
            Console.WriteLine("Rua: " + this.rua);
            Console.WriteLine("Bairro: " + this.bairro);
            Console.WriteLine("Nº: : " + this.numeroDaCasa);
            Console.WriteLine("Complemento: " + this.complemento);
        }
    }
}
