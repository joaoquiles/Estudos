using Desafio___EstoqueSupermercado;
using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Desafio - Estoque de Supermercado");

        Produto produto = new Produto();
        produto.nome = "Desodorante";
        produto.quantidadeEmEstoque = 100;

        Console.WriteLine("Nome do produto: "+produto.nome);
        Console.WriteLine("Quantidade do produto: "+produto.quantidadeEmEstoque+" unidades");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
