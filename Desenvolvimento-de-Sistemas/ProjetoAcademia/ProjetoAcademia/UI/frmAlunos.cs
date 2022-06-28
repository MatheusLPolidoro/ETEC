using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //botão gravar
            alunoBLL.Nome   = txtNome.Text;
            alunoBLL.Cpf    = txtCPF.Text;
            alunoBLL.Rg     = txtRG.Text;
            alunoBLL.Email  = txtEmail.Text;
            alunoBLL.Datanascimento = txtNascimento.Value;
            if (btnGravar.Text == "GRAVAR") { 
                alunoDAL.Cadastrar(alunoBLL);
            }
            else
            {
                alunoDAL.Atualizar(alunoBLL);
            }
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");
            dgvConsulta.DataSource = alunoDAL.ConsultarTodos();//atualizar consulta

            // limpar dados
            txtNome.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            txtNascimento.Value = DateTime.Now;
            btnGravar.Text = "GRAVAR";
            txtNome.Focus();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            //executa a consulta automaticamente ao abrir o formulário
            dgvConsulta.DataSource = alunoDAL.ConsultarTodos();

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            alunoBLL.Nome = txtPesquisar.Text;//preenche o nome na BLL
            //preencher DataGridView com o método da DAL
            dgvConsulta.DataSource = alunoDAL.ConsultarPorNome(alunoBLL);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount == 0){return;}
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                alunoBLL.Codaluno = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value); // localizar o index selecionado
                alunoDAL.Excluir(alunoBLL); //excluir o aluno do banco
                dgvConsulta.DataSource = alunoDAL.ConsultarTodos();//atualizar consulta
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount == 0) { return; }
            alunoBLL.Codaluno = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value); // localizar o index selecionado
            alunoDAL.Retornar(alunoBLL);
            txtNome.Text = alunoBLL.Nome;
            txtCPF.Text = alunoBLL.Cpf;
            txtRG.Text = alunoBLL.Rg;
            txtEmail.Text = alunoBLL.Email;
            txtNascimento.Value = alunoBLL.Datanascimento;
            btnGravar.Text = "ATUALIZAR";
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
