using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o desafio - Múltiplos de 3");

        for (int contador = 0; contador <= 100; contador++)
        {
            if(contador % 3 == 0)
            {
                Console.WriteLine(contador + " é multiplo de 3");
            }
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
