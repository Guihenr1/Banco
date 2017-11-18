using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
    }

    //Exemplo de herança
    public class contaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor + 0.10);
        }
    }
}