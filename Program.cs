using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentarios Lineares
            /*
             Comentarios
             em
             blocos
            */
            /*
             Tipos de dados Primitivos:
             String (Ex: a / A / b / B / 1 / 2 / ...) Armezana valores não números (Textos)
             Int (Ex: 1 / 2 / 3 / 4 / 5) Armezana valores númericos inteiros
             Float/Double (Ex: 1.1 / 1.556 / 256.3 / 5) Armazena valores númericos fracionados
             Bool (Ex: True / False) Armazena valor verdeiro ou falso
             */

            int v1, v2, r;

            Console.Write("Informe o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            r = v1 + v2;

            // Conversao implicita (AUTOMATICA) <> conversão explicita ()
            Console.Write("Resultado: " + r.ToString());
            Console.ReadKey();
        }
    }
}
