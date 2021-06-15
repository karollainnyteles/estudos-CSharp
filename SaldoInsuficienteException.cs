using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get;  }
        public double ValorSaque { get;}
        public SaldoInsuficienteException()
        {
            

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
          : this("Tentativa de saque no valor de: " + valorSaque + "Em conta com saldo de: " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;

        }
        public SaldoInsuficienteException(string menssagem):base(menssagem)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception ExcecaoInterna):base(mensagem,ExcecaoInterna)
        {

        }
    }
}
