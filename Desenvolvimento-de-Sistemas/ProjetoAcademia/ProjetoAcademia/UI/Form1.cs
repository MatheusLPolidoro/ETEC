using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();//fechar o form
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            //abrir o formulário
            UI.frmAlunos alunos = new UI.frmAlunos();
            alunos.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (Opacity == 1) timer1.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
