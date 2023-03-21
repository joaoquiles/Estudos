using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        /*
        foreach(var linha in linhas)
        {
            Console.WriteLine(linha);
        }
        */

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length}");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicação Finalizada");
        Console.ReadLine();

    }

   
    
}