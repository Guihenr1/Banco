using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class SeguroDeVida : ITributavel
    {
        public double valor;
        public double CalculaTributos()
        {
            return valor = 42;
        }
    }
}
