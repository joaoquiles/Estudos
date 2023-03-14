using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___PedidoFastFood
{
    public class ItemPedido
    {
        public int quantidadeTotal;
        public int numeroPedido;
        public Produto produto1;
        public Produto produto2;
        public Produto produto3;

        public void ExibirItensPedidos()
        {
            Console.WriteLine("Quantidade Total: " + this.quantidadeTotal);
            produto1.ExibirDetalhesDoProduto();
            produto2.ExibirDetalhesDoProduto();
            produto3.ExibirDetalhesDoProduto();
        }
    }
}
