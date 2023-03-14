using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuições de Variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);
        // idadeAna apresenta-se como 30
        idade = 25;
        //Não altera o resultado apresentado
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
