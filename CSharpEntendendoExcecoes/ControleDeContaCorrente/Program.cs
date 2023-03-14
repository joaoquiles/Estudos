/*Praticando: - Criação de projeto
              - Criação de classes
              - Trabalhando com objetos de uma classe
              - Tipos por valor e por referência
              - Visibilidade de campos e propriedades e encapsulamento
              - Métodos Construtores
              - Membros estáticos
              - Tratamento de exceções Try, Catch e Throw
              - Utilização do ParamName e NameOf
              - Bloco finally
              - StackTrace e InnerException
              - Exceções na leitura de arquivos
              - Using
*/
using Contas;
using ControleDeContaCorrente;
using System.Numerics;
using Titular;

class Programa
{
    static void Main(string[] args)
    {

        /*
        LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
        try
        {            
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            
        }
        catch (IOException) 
        {
            Console.WriteLine("Leitura de arquivo interrompida");
        }
        finally
        {
            leitor.Fechar();
        }
        */

        using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
        {
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            
        }



        /*
        try
        {
            ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
            
            //conta1.Sacar(50);
            //Console.WriteLine(conta1.GetSaldo());
            //conta1.Sacar(150);
            //Console.WriteLine(conta1.GetSaldo());
            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Parametro com erro: " + ex.ParamName);
            Console.WriteLine("Não é possivel criar uma conta com o numero de agência menor ou igual a zero");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Message);
        }
        catch(SaldoInsuficienteException ex)
        {
            Console.WriteLine("Operação negada! Saldo insuficiente");
            Console.WriteLine(ex.Message);
        }
        */


    }
}