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
        private int numeroDeContas;

        private Conta[] contas; 

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
            comboContaTrans.Items.Add("titular: " + conta.Titular.Nome);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[10];

            Conta c1 = new contaPoupanca();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);
            Conta c2 = new contaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);
            Conta c3 = new contaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);
        }

        private void btDeposita_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            int valor = Convert.ToInt32(txtValor.Text);
            selecionada.Deposita(valor);
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void btSaca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            int valor = Convert.ToInt32(txtValor.Text);
            selecionada.Saca(valor);
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            txtTitular.Text = selecionada.Titular.Nome;
            txtNumero.Text = Convert.ToString(selecionada.Numero);
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            int indiceEnv = Convert.ToInt32(comboContas.SelectedIndex);
            int indiceRec = Convert.ToInt32(comboContaTrans.SelectedIndex);
            Conta selecEnv = this.contas[indiceEnv];
            Conta selecRec = this.contas[indiceRec];

            int valor = Convert.ToInt32(txtValor.Text);
            selecEnv.Saca(valor);
            selecRec.Deposita(valor);
            txtSaldo.Text = Convert.ToString(selecEnv.Saldo);
        }

        private void btNovaConta_Click(object sender, EventArgs e)
        {
            addConta formAdd = new addConta(this);
            formAdd.ShowDialog();
        }

        private void btImpostos_Click(object sender, EventArgs e)
        {
            contaCorrente conta = new contaCorrente();
            conta.Deposita(100);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.adiciona(conta);
            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.adiciona(sv);
            MessageBox.Show("Total: " + totalizador.Total);
        }
    }
}
