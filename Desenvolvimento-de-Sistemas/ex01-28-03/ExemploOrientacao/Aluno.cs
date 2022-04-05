using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOrientacao
{
    class Aluno
    {
        //Atributos (Caracteristicas)

        private string nome;
        private int idade;
        private string curso;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }    
        }

        public int Idade 
        {
            get{ return idade; }
            set 
            {
                if (value > 0)
                {
                    idade = value;
                }
                else
                {
                    idade = 0;
                }
            }
        }

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
