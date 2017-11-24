using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormResultados : Form
    {
        private List<Conta> contas;
        public FormResultados(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo > 5000
                            orderby c.Titular.Nome, c.Numero descending
                            select c;
            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c);
            }

            double saldoTotal = resultado.Sum(conta => conta.Saldo);

            lbST.Text = Convert.ToString(saldoTotal);
        }

        private void btContasAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Numero < 10 && c.Saldo > 1000
                            select c;
            foreach(var c in resultado)
            {
                listaResultado.Items.Add("Cliente antingo: " + c);
            }
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {

        }
    }
}
