namespace Banco
{
    partial class FormResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btContasAntigas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSaldoTotal = new System.Windows.Forms.Label();
            this.lbST = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(260, 121);
            this.listaResultado.TabIndex = 0;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(145, 196);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(107, 23);
            this.btFiltrar.TabIndex = 1;
            this.btFiltrar.Text = "Saldo > 5000";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btContasAntigas
            // 
            this.btContasAntigas.Location = new System.Drawing.Point(21, 196);
            this.btContasAntigas.Name = "btContasAntigas";
            this.btContasAntigas.Size = new System.Drawing.Size(118, 23);
            this.btContasAntigas.TabIndex = 2;
            this.btContasAntigas.Text = "Contas Antigas";
            this.btContasAntigas.UseVisualStyleBackColor = true;
            this.btContasAntigas.Click += new System.EventHandler(this.btContasAntigas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbST);
            this.groupBox1.Controls.Add(this.lbSaldoTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // lbSaldoTotal
            // 
            this.lbSaldoTotal.AutoSize = true;
            this.lbSaldoTotal.Location = new System.Drawing.Point(6, 22);
            this.lbSaldoTotal.Name = "lbSaldoTotal";
            this.lbSaldoTotal.Size = new System.Drawing.Size(61, 13);
            this.lbSaldoTotal.TabIndex = 0;
            this.lbSaldoTotal.Text = "Saldo Total";
            // 
            // lbST
            // 
            this.lbST.AutoSize = true;
            this.lbST.Location = new System.Drawing.Point(148, 22);
            this.lbST.Name = "lbST";
            this.lbST.Size = new System.Drawing.Size(0, 13);
            this.lbST.TabIndex = 4;
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btContasAntigas);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormResultados";
            this.Text = "FormResultados";
            this.Load += new System.EventHandler(this.FormResultados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btContasAntigas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSaldoTotal;
        private System.Windows.Forms.Label lbST;
    }
}