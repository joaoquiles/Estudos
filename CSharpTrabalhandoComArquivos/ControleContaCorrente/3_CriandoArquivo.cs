using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriandoArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using ( var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";
            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

        }
    }

    static void CriandoArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for(int i = 0; i<1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); // despeja o buffer para o Stream
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter... ");
                Console.ReadLine();
            }
            
        }
    }



}