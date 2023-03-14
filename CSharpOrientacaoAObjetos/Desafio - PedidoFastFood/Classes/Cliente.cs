using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___PedidoFastFood
{
    public class Cliente
    {
        public string nomeCliente;
        public Endereco endereco;
        public string cpf;
        public string email;

        public void ExibirDadosDoCliente()
        {
            Console.WriteLine("Nome: " + this.nomeCliente);
            Console.WriteLine("CPF: " + this.cpf);
            Console.WriteLine("Email: " + this.email);
            endereco.ExibirEndereco();
        }
    }
}
