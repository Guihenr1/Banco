using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Busca;

namespace Banco
{
    public partial class addConta : Form
    {
        private ICollection<string> devedores;
        private Form1 formPrincipal;
        public addConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string titular = txtTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);
            if (!ehDevedor)
            {
                contaCorrente novaConta = new contaCorrente();
                novaConta.Titular = new Cliente(txtTitular.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                MessageBox.Show("devedor");
            }
        }

        private void addConta_Load(object sender, EventArgs e)
        {
            txtNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
}
