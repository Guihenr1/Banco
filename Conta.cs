using System;

namespace Banco
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get;  set; }
        public Cliente Titular { get; set; }

        public abstract void Deposita(double valorOperacao);

        public abstract void Saca(double valorOperacao);

        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        } 
    }  
}