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
            a.Nome = Console.ReadLine();

            Console.WriteLine("O professor chama: ");
            Console.WriteLine(a.Nome + " esta presente ?!");

            Console.WriteLine("E o aluno responde:");
            a.ResponderChamada();

            Console.ReadKey();

            Console.Clear();

            // Instancia do objeto da classe professor
            Professor p = new Professor();

            Console.WriteLine("Cadastro de professor");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            p.Idade = int.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            p.Salario = double.Parse(Console.ReadLine());

            Console.Write("Formação: ");
            p.Formacao = Console.ReadLine();

            Console.ReadKey();

            Console.WriteLine("▬▬▬ DADOS ▬▬▬");
            Console.WriteLine(p.ExibirDados());

            Console.ReadKey();//Pausa final
        }
    }
}
