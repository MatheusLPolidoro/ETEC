using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOrientacao
{
    class Aluno : Pessoa
    {
        //Atributos (Caracteristicas)

        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        //Metodos (Acoes)
        public void ResponderChamada()
        {
            Console.WriteLine("Presente !");
        }
    }
}
