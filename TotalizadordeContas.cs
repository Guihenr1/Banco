using Banco.Contas;

namespace Banco
{
    public class TotalizadordeContas
    {
        public double ValorTotal { get; private set; }
        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
}