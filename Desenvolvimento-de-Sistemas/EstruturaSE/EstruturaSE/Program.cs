using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaSE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Operadores Logicos:
                > maior
                < menor
                >= maior igual
                <= menor igual
                =! diferente
             */
            int idade;

            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade > 17)
            {
                Console.Write("Maior de Idade");
            }
            else
            {
                Console.Write("Menor de idade");
            }
            Console.ReadKey();//pausa
        }
    }
}
