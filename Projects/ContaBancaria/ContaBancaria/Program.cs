using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Incira os dados para abertura de Conta:");
            Console.Write("Número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            string nomeDoTitular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroDaConta, nomeDoTitular, depositoInicial);
            }
            else 
            {
                conta = new ContaBancaria(numeroDaConta, nomeDoTitular);
            }
            

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("Valor do saque:");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
