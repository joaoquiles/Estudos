using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textAdicional;

        if (acompanhado == true) {
            textAdicional = "João esta acompanhado";
        }
        else
        {
            if (idadeJoao >= 18)
            {
                textAdicional = "João não esta acompanhado, porém é maior de idade";
            }
            else
            {
                textAdicional = "João não esta acompanhado e não é maior de idade";
            }
            
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textAdicional);
            Console.WriteLine("Liberado");
        }
        else
        {
            Console.WriteLine(textAdicional);
            Console.WriteLine("Barrado!!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
