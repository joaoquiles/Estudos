using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___PedidoFastFood
{
    public class Produto
    {
        public string nomeProduto;
        public double valorUnitario;
        public int quantidade;
        public string descricao;

        public void ExibirDetalhesDoProduto()
        {
            Console.WriteLine("Nome do Produto:  " + this.nomeProduto);
            Console.WriteLine("Valor Unitário:  " + this.valorUnitario);
            Console.WriteLine("Quantidade:  " + this.quantidade);
            Console.WriteLine("Descirção:  " + this.descricao);
        }
    }
}
