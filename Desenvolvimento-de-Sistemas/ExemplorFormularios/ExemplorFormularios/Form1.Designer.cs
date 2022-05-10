namespace ExemplorFormularios
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
            this.btnDialog = new System.Windows.Forms.Button();
            this.btnSDI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(71, 45);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(345, 54);
            this.btnDialog.TabIndex = 0;
            this.btnDialog.Text = "Exemplo Forulário DIALOG";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnSDI
            // 
            this.btnSDI.Location = new System.Drawing.Point(71, 139);
            this.btnSDI.Name = "btnSDI";
            this.btnSDI.Size = new System.Drawing.Size(345, 54);
            this.btnSDI.TabIndex = 0;
            this.btnSDI.Text = "Exemplo formulário SDI";
            this.btnSDI.UseVisualStyleBackColor = true;
            this.btnSDI.Click += new System.EventHandler(this.btnSDI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 240);
            this.Controls.Add(this.btnSDI);
            this.Controls.Add(this.btnDialog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Button btnSDI;
    }
}

