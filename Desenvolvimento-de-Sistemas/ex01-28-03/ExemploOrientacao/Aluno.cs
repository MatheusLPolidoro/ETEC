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

        public string nome;
        public int idade;
        public string curso;

        //Metodos (Acoes)
        public void ResponderChamada()
        {
            Console.WriteLine("Presente !");
        }
    }
}
