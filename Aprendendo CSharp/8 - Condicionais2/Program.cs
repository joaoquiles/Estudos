using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        if (idadeJoao >= 18 || acompanhado) {
            Console.WriteLine("Liberado");
        }
        else
        {
            Console.WriteLine("Barrado!!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
