using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class contaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new Exception();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }
        }
        public override void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
    public class SaldoInsuficienteException : Exception
    {
        
    }
}
