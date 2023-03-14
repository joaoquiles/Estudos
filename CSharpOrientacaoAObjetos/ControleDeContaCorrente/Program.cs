/*Praticando: - Criação de projeto
              - Criação de classes
              - Trabalhando com objetos de uma classe
              - Tipos por valor e por referência
              - Visibilidade de campos e propriedades e encapsulamento
              - Métodos Construtores
              - Membros estáticos
*/
using Contas;
using Titular;

class Programa
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Executando o projeto - Controle de conta corrente");


        //ContaCorrente contaDoAndre = new ContaCorrente(); //Objeto
        //contaDoAndre.titular = "André Silva";
        //contaDoAndre.numero_agencia = 15;
        //contaDoAndre.conta = "1010-X";
        //contaDoAndre.saldo = 100;

        //Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

        //ContaCorrente contaDoAndre2 = new ContaCorrente(); //Objeto
        //contaDoAndre2.titular = "André Silva";
        //contaDoAndre2.numero_agencia = 15;
        //contaDoAndre2.conta = "1010-X";
        //contaDoAndre2.saldo = 100;

        //Console.WriteLine("Saldo da conta do André 2 = " + contaDoAndre2.saldo);
        //Console.WriteLine(contaDoAndre==contaDoAndre2);

        //ContaCorrente contaDaMaria = new ContaCorrente();
        //contaDaMaria.titular = "Maria";
        //contaDaMaria.numero_agencia = 17;
        //contaDaMaria.conta = "1010-5";
        //contaDaMaria.saldo = 350;

        //Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

        //contaDoAndre.Transferir(50, contaDaMaria);

        //Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
        //Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

        //ContaCorrente contaDoPedro = new ContaCorrente();
        //contaDoPedro.titular = "Pedro";
        //Console.WriteLine(contaDoPedro.titular);
        //Console.WriteLine(contaDoPedro.saldo);
        //Console.WriteLine(contaDoPedro.numero_agencia);
        //Console.WriteLine(contaDoPedro.conta);

        //contaDaMaria.ExibirDadosDaConta();

        ////Composição de classes
        //Cliente cliente = new Cliente();
        //cliente.nome = "André Silva";
        //cliente.cpf = "123456789";
        //cliente.profissao = "Analista";

        //ContaCorrente conta = new ContaCorrente();

        //conta.titular = cliente;
        //conta.conta = "1010-X";
        //conta.numero_agencia = 15;
        //conta.saldo = 100;

        //Console.WriteLine("Titular = " + conta.titular.nome);
        //Console.WriteLine("Cpf = " + conta.titular.cpf);
        //Console.WriteLine("Profissão = " + conta.titular.profissao);
        //Console.WriteLine("Número da Conta = " + conta.conta);
        //Console.WriteLine("Número da Agência = " + conta.numero_agencia);
        //Console.WriteLine("Saldo = " + conta.saldo);

        //ContaCorrente conta2 = new ContaCorrente();
        //conta2.titular = new Cliente();
        //conta2.titular.nome = "José Souza";
        //conta2.titular.profissao = "Tester";
        //conta2.titular.cpf = "987456123";
        //conta2.conta = "9999-X";
        //conta.numero_agencia = 18;
        //conta2.saldo = 200;

        //Console.WriteLine("Titular: "+conta2.titular.nome);

        //ContaCorrente conta3 = new ContaCorrente();
        //conta3.Numero_agencia = 18;
        //conta3.Conta = "1011-H";
        //conta3.SetSaldo(150);
        //Console.WriteLine(conta3.GetSaldo());
        //Console.WriteLine(conta3.Numero_agencia);
        //Console.WriteLine(conta3.Conta);

        //ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
        //conta4.SetSaldo(500);
        //conta4.Titular = new Cliente();

        //Console.WriteLine(conta4.GetSaldo());
        //Console.WriteLine(conta4.Numero_agencia);

        //ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
        //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        //ContaCorrente conta6 = new ContaCorrente(284, "9876-Z");
        //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        //ContaCorrente conta7 = new ContaCorrente(284, "1111-X");
        //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        //Cliente cliente1 = new Cliente();
        //Console.WriteLine(Cliente.TotalClientes);
        //Cliente cliente3 = new Cliente();
        //Console.WriteLine(Cliente.TotalClientes);
        //Cliente cliente2 = new Cliente();
        //Console.WriteLine(Cliente.TotalClientes);

        Cliente cliente1 = new Cliente("Joao", "123456", "Desenvolvedor");
        ContaCorrente conta1 = new ContaCorrente(cliente1, 18, "XXXX-X") ;

        Console.WriteLine("Total de clientes: "+Cliente.TotalClientes);
        Console.WriteLine("Total de contas: "+ContaCorrente.TotalDeContasCriadas);

        Cliente cliente2 = new Cliente("Joao", "123456", "Desenvolvedor");
        ContaCorrente conta2 = new ContaCorrente(cliente1, 18, "XXXX-X");

        Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);
        Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

        Cliente cliente3 = new Cliente("Joao", "123456", "Desenvolvedor");
        ContaCorrente conta3 = new ContaCorrente(cliente1, 18, "XXXX-X");

        Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);
        Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

    }
}