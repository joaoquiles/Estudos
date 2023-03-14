using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___Sistema_Médico
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public double peso;

        public void ExibirPeso()
        {
            Console.WriteLine("Peso: " + this.peso);
        }
        public void ExibirNome()
        {
            Console.WriteLine("Nome: " + this.nome);
        }
        public void ExibirIdade()
        {
            Console.WriteLine("Idade: " + this.idade);
        }
        public void ExibirAltura()
        {
            Console.WriteLine("Altura: " + this.altura);
        }
    }

    
}
