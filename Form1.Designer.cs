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
            this.SuspendLayout();
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(147, 59);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(147, 85);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(147, 111);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(86, 153);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btDeposita
            // 
            this.btDeposita.Location = new System.Drawing.Point(41, 179);
            this.btDeposita.Name = "btDeposita";
            this.btDeposita.Size = new System.Drawing.Size(75, 23);
            this.btDeposita.TabIndex = 4;
            this.btDeposita.Text = "Depositar";
            this.btDeposita.UseVisualStyleBackColor = true;
            this.btDeposita.Click += new System.EventHandler(this.btDeposita_Click);
            // 
            // btSaca
            // 
            this.btSaca.Location = new System.Drawing.Point(147, 179);
            this.btSaca.Name = "btSaca";
            this.btSaca.Size = new System.Drawing.Size(75, 23);
            this.btSaca.TabIndex = 5;
            this.btSaca.Text = "Sacar";
            this.btSaca.UseVisualStyleBackColor = true;
            this.btSaca.Click += new System.EventHandler(this.btSaca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btSaca);
            this.Controls.Add(this.btDeposita);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btDeposita;
        private System.Windows.Forms.Button btSaca;
    }
}

