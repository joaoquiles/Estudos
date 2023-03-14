//Objetivo - Organização de classes em diretórios

using Desafio___OperacoesMatematicas.Calculadora;
using Desafio___OperacoesMatematicas.Operacoes;

Calculo calculadora = new Calculo();

Soma somar = new Soma();
somar.Valor1 = 2;
somar.Valor2 = 3;


calculadora.Somar(somar);
Console.WriteLine(calculadora.Resultado);

Subtracao subtrai = new Subtracao();
subtrai.Valor1 = 3;
subtrai.Valor2 = 5;

calculadora.Subtrair(subtrai);
Console.WriteLine(calculadora.Resultado);

Multiplicacao multiplicacao = new Multiplicacao();
multiplicacao.Valor1 = 4;
multiplicacao.Valor2 = 3;

calculadora.Multiplicar(multiplicacao);
Console.WriteLine(calculadora.Resultado);

Divisao divisao = new Divisao(); 
divisao.Valor1 = 5;
divisao.Valor2 = 2.5;

calculadora.Dividir(divisao);
Console.WriteLine(calculadora.Resultado);