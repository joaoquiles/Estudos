using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titular;

namespace Contas
{
    public class ContaCorrente //Classe
    {
        public static int TotalDeContasCriadas { get; private set; } //Membro Estático
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
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
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

        public ContaCorrente(Cliente cliente, int numero_agencia, string numero_conta) //Construtor
        {
            this.Titular = cliente;
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

    }
}
