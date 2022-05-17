using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploFormularioMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString();
        }

        private void somarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSomar tela = new frmSomar();
            tela.MdiParent = this;
            tela.Show();

        }

        private void subtrairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubtrair tela = new frmSubtrair();
            tela.MdiParent = this;
            tela.Show();
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultiplicar tela = new frmMultiplicar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDividir tela = new frmDividir();
            tela.MdiParent = this;
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por...",
                            "Titulo",
                            0,
                            (MessageBoxIcon)Int32.Parse("64")
                            );

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resp = MessageBox.Show("Deseja realmente sair ?",
                                                "Confirmação",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2
                                                );

            if (resp == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
