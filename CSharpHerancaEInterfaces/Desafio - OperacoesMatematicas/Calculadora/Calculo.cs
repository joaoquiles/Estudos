using Desafio___OperacoesMatematicas.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___OperacoesMatematicas.Calculadora
{
    public class Calculo
    {
        public double Resultado { get; set; }

        public void Somar(Soma soma)
        {
            this.Resultado = soma.Valor1 + soma.Valor2;
        }
        public void Subtrair(Subtracao subitrai)
        {
            this.Resultado = subitrai.Valor1 - subitrai.Valor2;
        }
        public void Multiplicar(Multiplicacao multipica)
        {
            this.Resultado = multipica.Valor1 * multipica.Valor2;
        }
        public void Dividir(Divisao dividi)
        {
            this.Resultado = dividi.Valor1 / dividi.Valor2;
        }
    }
}
