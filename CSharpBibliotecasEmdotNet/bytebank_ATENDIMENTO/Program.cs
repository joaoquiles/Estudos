using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using GeradorDeChavePIX;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPIX.GetChavePIX());

var listaDeChaves = GeradorPIX.GetChavesPIX(10);

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}