using Desafio___Sistema_Médico;
using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Desafio - Sistema Médico");

        Pessoa pacienteJoao = new Pessoa();
        pacienteJoao.nome = "João";
        pacienteJoao.idade = 25;
        pacienteJoao.altura = 1.87;
        pacienteJoao.peso = 73;

        pacienteJoao.ExibirNome();
        pacienteJoao.ExibirIdade();
        pacienteJoao.ExibirAltura();   
        pacienteJoao.ExibirPeso();

        Console.WriteLine();

        Pessoa pacienteMaria = new Pessoa();
        pacienteMaria.nome = "Maria";
        pacienteMaria.idade = 20;
        pacienteMaria.altura = 1.79;
        pacienteMaria.peso = 65;

        pacienteMaria.ExibirNome();
        pacienteMaria.ExibirIdade();
        pacienteMaria.ExibirAltura();
        pacienteMaria.ExibirPeso();

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

