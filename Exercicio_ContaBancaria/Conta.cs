using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_ContaBancaria
{
    internal class Conta
    {
        public int NumConta { get; private set; }
        public  string NomeTitular { get; set; }    
        //public double ValorDepositoInicial { get; set; } // Opcional

        //public double ValorDeposito { get; set; }

        //public double ValorSaque { get; set; }  
        public double SaldoConta   { get; private set; }

        //public char HaveraDeposito;

        private int Taxa = 5;


        public Conta()
        {
        }

        public Conta(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }

        public Conta(int numConta, string nomeTitular, double valorDepositoInicial) : this(numConta, nomeTitular)
        {
            Deposito(valorDepositoInicial);
            //NumConta = numConta;
            //NomeTitular = nomeTitular;
        }

        //public int NumConta
        //{
        //    get { return _numConta; }
        //    private set
        //    {
        //        _numConta = value;
        //    }
        //}




        //public void DepositoInicial(char resp)
        //{
        //    if (resp == 's' || resp == 'S')
        //    {
        //        Console.Write("Entre o valor de depósito inicial: ");
        //        ValorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //        SaldoConta = ValorDepositoInicial + SaldoConta;
                
        //    } 
        //}

        public void Deposito(double quantia)
        {
            SaldoConta += quantia;        
        }

        public void Saque(double quantia)
        {
             SaldoConta -= (quantia + Taxa);
        }




            public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular:  "
                + NomeTitular
                + ", Saldo: $ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
    }

