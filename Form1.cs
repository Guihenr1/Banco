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
        private Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // criando o array para guardar as contas
            contas = new Conta[3];
            // vamos inicializar algumas instâncias de Conta.
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Guilherme");
            this.contas[0].Numero = 1;
            this.contas[1] = new contaPoupanca();
            this.contas[1].Titular = new Cliente("Henrique");
            this.contas[1].Numero = 2;
            this.contas[2] = new contaCorrente();
            this.contas[2].Titular = new Cliente("Pompilio");
            this.contas[2].Numero = 3;

            foreach(Conta contas in contas)
            {
                comboContas.Items.Add(contas.Titular.Nome);
            }
            foreach(Conta contas in contas)
            {
                comboContaTrans.Items.Add(contas.Titular.Nome);
            }
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
    }
}
