using ControleDeContaCorrente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Titular;

namespace Contas
{
    public class ContaCorrente //Classe
    {
        public static int TotalDeContasCriadas { get; private set; } //Membro Estático

        public static float TaxaOperacao { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return numero_agencia; }
            private set {
                    if (value > 0) {
                        this.numero_agencia = value;
                    }                    
                }
        }
        private string conta;
        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente Titular { get; set; }
        public void Depositar(double valor) //Método
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para a operação");
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para a operação");
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Número da agência: " + numero_agencia);
            Console.WriteLine("Número da conta: " + conta);
            Console.WriteLine("Número da saldo: " + saldo);
        }

        public void SetSaldo(double valor) 
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta) //Construtor
        {
            
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            if (numero_agencia <= 0)
            {
                throw new ArgumentException("Numero de agência menor ou igual a zero!", nameof(numero_agencia));
            }
            /*
            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Ocorreu um erro! Não é possivel fazer uma divisão por zero");
            }
            */
            TotalDeContasCriadas++;
        }

    }
}
