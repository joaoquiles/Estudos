using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o desafio - Fatorial");

        for (int numero = 1; numero <= 10; numero++)
        {
            int resultado = numero;
            for (int fatorial = 1; fatorial < numero ; fatorial++)
            {
                resultado = resultado * fatorial;
            }
            Console.WriteLine("O fatorial de "+numero+" é "+resultado);
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
