using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o porjeto 10 - Calcula Poupança");

        double investimento = 1000;
        int mes = 1;
        //Rendimento de 0.5% ao mes
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês "+mes+" você tem " + investimento);

            mes++;
        }
       

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
