using System;
using System.Globalization;

namespace Exercicio_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();


            

            Console.Write("Entre o número da conta: ");
            int NumConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string NomeTitular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double ValorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(NumConta, NomeTitular, ValorDepositoInicial);
            }
            else
            {
                c = new Conta(NumConta, NomeTitular);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            double ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(ValorDeposito);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            double ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(ValorSaque);
            Console.WriteLine(c.ToString());
            Console.ReadLine();
        }
    }
}
