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
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new contaCorrente();
            conta.Numero = 1;
            Cliente cliente = new Cliente("Guilherme");
            conta.Titular = cliente;
            TotalizadordeContas t = new TotalizadordeContas();
            t.Soma(conta);

            txtTitular.Text = conta.Titular.Nome;
            txtNumero.Text = Convert.ToString(conta.Numero);
            txtSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void btDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Deposito realizado!");
        }

        private void btSaca_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Saca(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Saque realizado!");
        }
    }
}
