using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System;
using System.Xml.Serialization;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


//TestaArrayInt();
//TestaBuscarPalavra();


void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 22;
    idades[2] = 17;
    idades[3] = 40;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"índice [{i}] = {idade}");
        acumulador += idade;


    }

    int media = acumulador/idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string item in arrayDePalavras)
    {
        if (item.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
        
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(1.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.8, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaMediana(amostra);
void TestaMediana(Array array)
{
    if((array == null)|| (array.Length == 0))
    {
        Console.WriteLine("Array vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

//int[] valores = { 10, 58, 86, 47 };
//for (int i = 0; i < valores.Length; i++) 
//{
//    Console.WriteLine(valores[i]);
//}

TestaArrayDeContasCorrentes();
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-C"));

    var contaDoJoao = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoJoao);

    listaDeContas.ExibeLista();
    Console.WriteLine("===================");

    listaDeContas.Remover(contaDoJoao);
    listaDeContas.ExibeLista();
}