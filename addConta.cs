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
    public partial class addConta : Form
    {
        private Form1 formPrincipal;
        public addConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            contaCorrente novaConta = new contaCorrente();
            novaConta.Titular = new Cliente(txtTitular.Text);
            novaConta.Numero = Convert.ToInt32(txtNumero.Text);
            this.formPrincipal.AdicionaConta(novaConta);
        }
    }
}
