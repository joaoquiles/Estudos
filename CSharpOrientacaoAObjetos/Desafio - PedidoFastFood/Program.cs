using Desafio___PedidoFastFood;


Pedido pedido= new Pedido();
pedido.numeroPedido = 13;

pedido.cliente = new Cliente();
pedido.cliente.nomeCliente = "Joao";
pedido.cliente.cpf = "123456789";
pedido.cliente.email = "joaov@123";

pedido.cliente.endereco= new Endereco();
pedido.cliente.endereco.rua = "Rua Tihago Farto Brito";
pedido.cliente.endereco.bairro = "Vila Rica";
pedido.cliente.endereco.numeroDaCasa = 26;
pedido.cliente.endereco.complemento = "Fundos";

pedido.item = new ItemPedido();
pedido.item.quantidadeTotal = 3;
pedido.item.numeroPedido = pedido.numeroPedido;

pedido.item.produto1 = new Produto();
pedido.item.produto1.nomeProduto = "Desodorante";
pedido.item.produto1.valorUnitario = 2.75;
pedido.item.produto1.quantidade = 1;
pedido.item.produto1.descricao = "Desodorante corporal";

pedido.item.produto2= new Produto();
pedido.item.produto2.nomeProduto = "Coca-Cola";
pedido.item.produto2.valorUnitario = 8.75;
pedido.item.produto2.quantidade = 1;
pedido.item.produto2.descricao = "Refrigerante";

pedido.item.produto3= new Produto();
pedido.item.produto3.nomeProduto = "Monster";
pedido.item.produto3.valorUnitario = 8.75;
pedido.item.produto3.quantidade = 1;
pedido.item.produto3.descricao = "Energético";

pedido.valorTotal = (pedido.item.produto1.valorUnitario * (double)(pedido.item.produto1.quantidade)) + 
                    (pedido.item.produto2.valorUnitario * (double)(pedido.item.produto2.quantidade)) + 
                    (pedido.item.produto3.valorUnitario * (double)(pedido.item.produto3.quantidade));

pedido.ExibirDetalhesDoPedido();



