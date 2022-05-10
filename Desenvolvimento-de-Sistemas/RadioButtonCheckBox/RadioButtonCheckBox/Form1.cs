using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            List<RadioButton> sabores = new List<RadioButton> { rdbMussarela, rdbNapolitana, rdbQuatroQueijos, rdbMarguerita };
            List<RadioButton> bordas = new List<RadioButton> { rdbSemBorda, rdbCatupiry, rdbCheddar };
            List<CheckBox> bebidas = new List<CheckBox> { chkRefrigerante, chkSuco, chkAgua };

            string pedido = "";

            foreach (RadioButton sabor in sabores)
            {
                if (sabor.Checked)
                    pedido = $"Pizza de {sabor.Text}";
            }

            foreach (RadioButton borda in bordas)
            {
                if (borda.Checked)
                    pedido += ($"\nBorda: {borda.Text}");
            }

            foreach (CheckBox bebida in bebidas)
            {
                if (bebida.Checked)
                    pedido += $"\nBebida: {bebida.Text}";
            }

            MessageBox.Show(pedido);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbMussarela.Checked = true;
            rdbSemBorda.Checked = true;
            chkRefrigerante.Checked = false;
            chkRefrigerante.Checked = false;
            chkRefrigerante.Checked = false;
        }
    }
}
