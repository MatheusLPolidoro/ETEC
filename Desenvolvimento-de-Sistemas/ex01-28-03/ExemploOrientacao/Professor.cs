using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOrientacao
{
    internal class Professor
    {
        //Atributos (Caracteristicas)

        private string nome;
        private int idade;
        private double salario;
        private string formacao;

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

        public double Salario
        {
            get { return salario; }
            set 
            {
                if (value > 0)
                {
                    salario = value;
                }
                else
                {
                    salario = 0;
                }

            }
        }

        public string Formacao
        {
            get { return formacao; }
            set { formacao = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ DADOS ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("NOME → "         + nome);
            Console.WriteLine("IDADE → "        + idade);
            Console.WriteLine("SALARIO → R$ "   + salario);
            Console.WriteLine("FORMAÇÃO → "     + formacao);
        }
    }
}
