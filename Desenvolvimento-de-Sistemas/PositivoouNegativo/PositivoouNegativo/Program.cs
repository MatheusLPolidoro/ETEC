using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoouNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.Write("Seu número é positivo");
            }
            else if (numero < 0)
            {
                Console.Write("Seu número é negativo");
            }
            else
            {
                Console.Write("Seu número é neutro");
            }
            Console.ReadKey();
        }
    }
}
