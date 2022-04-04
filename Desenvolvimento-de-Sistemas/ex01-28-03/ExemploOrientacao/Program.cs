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

            Console.ReadKey();

            Console.Clear();

            // Instancia do objeto da classe professor
            Professor p = new Professor();

            Console.WriteLine("Cadastro de professor");

            Console.Write("Nome: ");
            p.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p.idade = int.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            p.salario = double.Parse(Console.ReadLine());

            Console.Write("Formação: ");
            p.formacao = Console.ReadLine();


            Console.ReadKey();//Pausa final
        }
    }
}
