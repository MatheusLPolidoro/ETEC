using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplorFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto da classe frmCliente
            frmCliente tela = new frmCliente();

            tela.ShowDialog();
        }

        private void btnSDI_Click(object sender, EventArgs e)
        {
            // Single Design Interface

            if (Application.OpenForms["frmcliente"] == null) {
                frmCliente tela = new frmCliente();
                tela.Show();
            }
            else
            {

                Application.OpenForms["frmcliente"].WindowState = FormWindowState.Normal;
            }
        }

    }
}
