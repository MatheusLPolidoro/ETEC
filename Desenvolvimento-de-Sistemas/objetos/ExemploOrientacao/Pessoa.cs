using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOrientacao
{
    class Pessoa
    {
        //Atributos (Caracteristicas)

        protected string nome;
        protected int idade;

        // Atributo privado + Medoto de acesso publico → Propriedade

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
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
    }
}
