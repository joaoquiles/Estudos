using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o porjeto 12 - Investimento a longo prazo");

        double investimento = 1000;
        double fatorDeRendimento = 1.005;

        for (int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes<=12;mes++)
            {
                investimento *= fatorDeRendimento;
                Console.WriteLine("No ano " + anos + " no mes " + mes + " o rendimento foi de " + investimento);
            }
            fatorDeRendimento += 0.01;

        }
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
