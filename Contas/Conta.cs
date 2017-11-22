using System;

namespace Banco.Contas
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


        //Modificação de metodos

        public override bool Equals(object outro)
        {
            if(!(outro is Conta))
            {
                return false;
            }
            Conta outraConta = (Conta)outro;
            return this.Numero == outraConta.Numero;
        }

        public override string ToString()
        {
            return "Titular " + this.Titular.Nome;
        }
    }  
}