using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    class Conta
    {
        public static long _contaMaiorSaldo;
        public static double _maiorSaldo;
        public static double _saldoTotalGeral=0;
        public long Numero { get; private set; }
        public double Saldo { get; protected set; }
        public Cliente Cliente { get; set; }
        public Agencia Agencia { get; set; }

        public Conta(long numero, Agencia agencia, Cliente cliente, double saldo)
        {
            Numero = numero;
            Cliente = cliente;
            Agencia = agencia;
            if (saldo < 10)
                throw new ArgumentOutOfRangeException("O saldo obrigatóriamente deve ser maior ou igual a 10 reais");
            Saldo = saldo;
        }

        public override string ToString()
        {
            return $"Número da Agencia: {this.Agencia.Numero}; Conta: {this.Numero}; Cliente: {this.Cliente.Nome}; Saldo: {this.Saldo}";
        }

        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor invalido!!");
            }
            else
            {
                Saldo += valor;
            }

            AtualizaMaiorSaldo();
        }

        protected void Saque(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor inválido!!");
            }
            else if (valor > Saldo)
            {
                throw new ArgumentOutOfRangeException("Valor de saque maior que saldo!!");
            }
            else
            {
                Saldo -= valor;
            }
            AtualizaMaiorSaldo();
        }

        protected void Transferencia(double valor, Conta destino)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor inválido!!");
            }
            else if (valor > Saldo)
            {
                throw new ArgumentOutOfRangeException("Valor da transferência maior que saldo!!");
            }
            else
            {
                this.Saque(valor);
                destino.Deposito(valor);
            }
        }

        protected void AtualizaMaiorSaldo()
        {
            if (this.Saldo > _maiorSaldo)
            {
                _contaMaiorSaldo = this.Numero;
                _maiorSaldo = this.Saldo;
            }
        }
      
    }
}
