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
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("Guilherme");
            c.Titular = cliente;

            this.c = new Conta();

            txtTitular.Text = c.Titular.nome;
            txtNumero.Text = Convert.ToString(c.Numero);
            txtSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void btDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void btSaca_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Saca(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso!");
        }
    }
}
