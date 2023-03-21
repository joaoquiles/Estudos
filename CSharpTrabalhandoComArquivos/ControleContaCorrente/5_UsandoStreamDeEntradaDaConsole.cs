using ByteBankIO;
using System.Text;
using System.IO;

partial class Program 
{
    static void UsandoStramDeEntrada()
    {
        using(var fluxoDeEntrada = Console.OpenStandardInput())
        using(var fs = new FileStream("entradaConsole.txt",FileMode.Create))
        {
            var buffer = new byte[1024];

            

            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                fs.Write(buffer,0,bytesLidos);
                fs.Flush();
                Console.WriteLine($"BytesLidos na console: {bytesLidos}");
            }
            
        }
    }
}