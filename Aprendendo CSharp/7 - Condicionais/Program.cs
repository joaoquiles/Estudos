using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18 || quantidadePessoas > 1) //Entra caso esteja acompanhado tbm
        {
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
