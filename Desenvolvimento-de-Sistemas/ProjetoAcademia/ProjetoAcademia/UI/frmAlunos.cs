using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.UI
{
    public partial class frmAlunos : Form
    {
        BLL.AlunoBLL alunoBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();

        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            alunoBLL.Nome           = txtNome.Text;
            alunoBLL.Cpf            = txtCPF.Text;
            alunoBLL.Rg             = lblRG.Text;
            alunoBLL.Email          = txtEmail.Text;
            alunoBLL.Datanascimento = txtNascimento.Value;
            alunoDAL.Cadastrar(alunoBLL);
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");

        }
    }
}
