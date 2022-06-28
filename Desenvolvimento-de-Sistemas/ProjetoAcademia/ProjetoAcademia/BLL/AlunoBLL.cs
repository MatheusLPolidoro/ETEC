using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoAcademia.BLL
{
    class AlunoBLL
    {
        private int codaluno;
        private string nome;
        private string cpf;
        private string rg;
        private string email;
        private DateTime datanascimento;

        //gerar métodos get/set (Ctrl + R + E)
        public int Codaluno 
        {
            get { return codaluno; }
            set { codaluno = value; }
        }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }

    }
}
