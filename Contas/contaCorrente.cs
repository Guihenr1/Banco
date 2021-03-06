﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    //Herança
    public class contaCorrente : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            Saldo += (valor - 0.10);
        }

        public override void Saca(double valor)
        {
            Saldo -= valor + 0.05;
        }
        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
