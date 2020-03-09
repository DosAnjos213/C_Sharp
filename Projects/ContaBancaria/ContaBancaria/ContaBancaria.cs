using System;
namespace ContaBancaria
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double SaldoDaConta { get; private set; }
        

        public ContaBancaria(int numeroDaConta, string nomeDoTitula, double saldoDaConta)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitula;
            SaldoDaConta = saldoDaConta;
        }

        public ContaBancaria(int numeroDaConta, string nomeDoTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
        }

        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            SaldoDaConta -= quantia + 5.00;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroDaConta}, Titular: {NomeDoTitular}, Saldo: $ {SaldoDaConta.ToString("f2")}";
        }
    }
}
