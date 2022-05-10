namespace ExemplorFormularios
{
    partial class frmCliente
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnFecharEste = new System.Windows.Forms.Button();
            this.btnFecharAplicacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(28, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(144, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cadastrar Clientes:";
            // 
            // btnFecharEste
            // 
            this.btnFecharEste.Location = new System.Drawing.Point(137, 192);
            this.btnFecharEste.Name = "btnFecharEste";
            this.btnFecharEste.Size = new System.Drawing.Size(229, 40);
            this.btnFecharEste.TabIndex = 1;
            this.btnFecharEste.Text = "Fechar este formulário";
            this.btnFecharEste.UseVisualStyleBackColor = true;
            this.btnFecharEste.Click += new System.EventHandler(this.btnFecharEste_Click);
            // 
            // btnFecharAplicacao
            // 
            this.btnFecharAplicacao.Location = new System.Drawing.Point(137, 240);
            this.btnFecharAplicacao.Name = "btnFecharAplicacao";
            this.btnFecharAplicacao.Size = new System.Drawing.Size(229, 40);
            this.btnFecharAplicacao.TabIndex = 1;
            this.btnFecharAplicacao.Text = "Fechar TODA A APLICAÇÃO";
            this.btnFecharAplicacao.UseVisualStyleBackColor = true;
            this.btnFecharAplicacao.Click += new System.EventHandler(this.btnFecharAplicacao_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 303);
            this.Controls.Add(this.btnFecharAplicacao);
            this.Controls.Add(this.btnFecharEste);
            this.Controls.Add(this.lblCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnFecharEste;
        private System.Windows.Forms.Button btnFecharAplicacao;
    }
}