using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using GeradorDeChavePIX;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPIX.GetChavePIX());