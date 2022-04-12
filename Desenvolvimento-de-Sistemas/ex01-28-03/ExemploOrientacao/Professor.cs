using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOrientacao
{
    class Professor : Pessoa
    {
        //Atributos (Caracteristicas)

        private double salario;
        private string formacao;

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

        public string ExibirDados()
        {
            string dados;

            dados =  "NOME → "           + nome;
            dados += "\nIDADE → "        + idade;
            dados += "\nSALARIO → R$ "   + salario;
            dados += "\nFORMAÇÃO → "     + formacao;

            return dados;
        }

        private int AnoNascimento()
        {
            int anoNascimento;

            anoNascimento = 2022 - idade;
            
            return anoNascimento;
        }


    }
}
