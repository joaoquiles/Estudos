using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o porjeto 11 - Calcula Poupança 2");

        double investimento = 1000;
        //Rendimento de 0.5% ao mes
        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);

            mes++;
        }
        */

        for (int mes = 1;mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
