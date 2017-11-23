namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btDeposita = new System.Windows.Forms.Button();
            this.btSaca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btTransferir = new System.Windows.Forms.Button();
            this.comboContaTrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btNovaConta = new System.Windows.Forms.Button();
            this.btImpostos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeTitular = new System.Windows.Forms.TextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(60, 26);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(125, 20);
            this.txtTitular.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(60, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(125, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(60, 78);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(125, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(60, 104);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btDeposita
            // 
            this.btDeposita.Location = new System.Drawing.Point(26, 130);
            this.btDeposita.Name = "btDeposita";
            this.btDeposita.Size = new System.Drawing.Size(75, 23);
            this.btDeposita.TabIndex = 4;
            this.btDeposita.Text = "Depositar";
            this.btDeposita.UseVisualStyleBackColor = true;
            this.btDeposita.Click += new System.EventHandler(this.btDeposita_Click);
            // 
            // btSaca
            // 
            this.btSaca.Location = new System.Drawing.Point(107, 130);
            this.btSaca.Name = "btSaca";
            this.btSaca.Size = new System.Drawing.Size(75, 23);
            this.btSaca.TabIndex = 5;
            this.btSaca.Text = "Sacar";
            this.btSaca.UseVisualStyleBackColor = true;
            this.btSaca.Click += new System.EventHandler(this.btSaca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSaca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btDeposita);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtTitular);
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBusca);
            this.groupBox2.Controls.Add(this.txtNomeTitular);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(59, 28);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(125, 21);
            this.comboContas.TabIndex = 1;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Conta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btTransferir);
            this.groupBox3.Controls.Add(this.comboContaTrans);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(14, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 93);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta Destino";
            // 
            // btTransferir
            // 
            this.btTransferir.Location = new System.Drawing.Point(60, 61);
            this.btTransferir.Name = "btTransferir";
            this.btTransferir.Size = new System.Drawing.Size(75, 23);
            this.btTransferir.TabIndex = 2;
            this.btTransferir.Text = "Transferir";
            this.btTransferir.UseVisualStyleBackColor = true;
            this.btTransferir.Click += new System.EventHandler(this.btTransferir_Click);
            // 
            // comboContaTrans
            // 
            this.comboContaTrans.FormattingEnabled = true;
            this.comboContaTrans.Location = new System.Drawing.Point(60, 27);
            this.comboContaTrans.Name = "comboContaTrans";
            this.comboContaTrans.Size = new System.Drawing.Size(121, 21);
            this.comboContaTrans.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Conta:";
            // 
            // btNovaConta
            // 
            this.btNovaConta.Location = new System.Drawing.Point(39, 414);
            this.btNovaConta.Name = "btNovaConta";
            this.btNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btNovaConta.TabIndex = 13;
            this.btNovaConta.Text = "Nova Conta";
            this.btNovaConta.UseVisualStyleBackColor = true;
            this.btNovaConta.Click += new System.EventHandler(this.btNovaConta_Click);
            // 
            // btImpostos
            // 
            this.btImpostos.Location = new System.Drawing.Point(120, 414);
            this.btImpostos.Name = "btImpostos";
            this.btImpostos.Size = new System.Drawing.Size(75, 23);
            this.btImpostos.TabIndex = 14;
            this.btImpostos.Text = "Impostos";
            this.btImpostos.UseVisualStyleBackColor = true;
            this.btImpostos.Click += new System.EventHandler(this.btImpostos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Busca por Titular:";
            // 
            // txtNomeTitular
            // 
            this.txtNomeTitular.Location = new System.Drawing.Point(9, 78);
            this.txtNomeTitular.Name = "txtNomeTitular";
            this.txtNomeTitular.Size = new System.Drawing.Size(119, 20);
            this.txtNomeTitular.TabIndex = 3;
            // 
            // btBusca
            // 
            this.btBusca.Location = new System.Drawing.Point(134, 76);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(50, 23);
            this.btBusca.TabIndex = 4;
            this.btBusca.Text = "Buscar";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 448);
            this.Controls.Add(this.btImpostos);
            this.Controls.Add(this.btNovaConta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btDeposita;
        private System.Windows.Forms.Button btSaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btTransferir;
        private System.Windows.Forms.ComboBox comboContaTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btNovaConta;
        private System.Windows.Forms.Button btImpostos;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.TextBox txtNomeTitular;
        private System.Windows.Forms.Label label7;
    }
}

