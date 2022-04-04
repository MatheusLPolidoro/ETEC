using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOrientacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto aos "moldes" da classe (fazer o pudim)
            //Instanciar --> Criar em Mem. Ram o objeto
            //Sintaxe: NomeDaClasse nomeDoObjeto = new MetodoConstrutor();
            Aluno a = new Aluno();

            Console.Write("Informe o nome do aluno: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("O professor chama: ");
            Console.WriteLine(a.nome + " esta presente ?!");

            Console.WriteLine("E o aluno responde:");
            a.ResponderChamada();

            Console.ReadKey();//Pausa final
        }
    }
}
