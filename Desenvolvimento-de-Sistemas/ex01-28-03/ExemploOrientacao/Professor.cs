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

        public string nome;
        public int idade;
        public double salario;
        public string formacao;

        public void ExibirDados()
        {
            Console.WriteLine("NOME → " + nome);
            Console.WriteLine("IDADE → " + idade);
            Console.WriteLine("SALARIO → " + salario);
            Console.WriteLine("FORMAÇÃO → " + formacao);
        }
    }
}
