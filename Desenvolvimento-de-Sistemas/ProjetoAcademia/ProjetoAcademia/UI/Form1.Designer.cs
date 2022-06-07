namespace ProjetoAcademia
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnPlanos = new System.Windows.Forms.Button();
            this.btnMatriculas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoAcademia.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjetoAcademia.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(892, 1);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSair.Size = new System.Drawing.Size(71, 58);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnAlunos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.Color.White;
            this.btnAlunos.Image = global::ProjetoAcademia.Properties.Resources.aluno;
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.Location = new System.Drawing.Point(29, 141);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(189, 57);
            this.btnAlunos.TabIndex = 2;
            this.btnAlunos.Text = "ALUNOS";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnPlanos
            // 
            this.btnPlanos.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnPlanos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanos.ForeColor = System.Drawing.Color.White;
            this.btnPlanos.Image = global::ProjetoAcademia.Properties.Resources.dumbbell;
            this.btnPlanos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanos.Location = new System.Drawing.Point(29, 205);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(189, 57);
            this.btnPlanos.TabIndex = 3;
            this.btnPlanos.Text = "PLANOS";
            this.btnPlanos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlanos.UseVisualStyleBackColor = false;
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.BackColor = System.Drawing.Color.Transparent;
            this.btnMatriculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriculas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriculas.ForeColor = System.Drawing.Color.White;
            this.btnMatriculas.Image = global::ProjetoAcademia.Properties.Resources.matricula;
            this.btnMatriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatriculas.Location = new System.Drawing.Point(29, 270);
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Size = new System.Drawing.Size(189, 57);
            this.btnMatriculas.TabIndex = 4;
            this.btnMatriculas.Text = "MATRICULAS";
            this.btnMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatriculas.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::ProjetoAcademia.Properties.Resources.usuario;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(29, 335);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(189, 57);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "USUÁRIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProjetoAcademia.Properties.Resources.sair;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "SAIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAcademia.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnMatriculas);
            this.Controls.Add(this.btnPlanos);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnMatriculas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button button1;
    }
}

