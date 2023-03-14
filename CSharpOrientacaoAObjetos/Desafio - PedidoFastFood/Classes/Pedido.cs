namespace Desafio___PedidoFastFood
{
    public class Pedido
    {
        public int numeroPedido;
        public Cliente cliente;
        public double valorTotal;
        public ItemPedido item;

        public void ExibirDetalhesDoPedido()
        {
            Console.WriteLine("Nº do Pedido:  " + this.numeroPedido);
            Console.WriteLine("Valor Total:  " + this.valorTotal);
            cliente.ExibirDadosDoCliente();
            item.ExibirItensPedidos();

        }
    }
}
