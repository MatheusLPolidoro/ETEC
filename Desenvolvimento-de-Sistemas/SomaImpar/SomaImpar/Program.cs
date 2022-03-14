using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int somaImpar;
            somaImpar = 0;

            for (num = 1; num <= 20; num += 2)
            {
                somaImpar += num;
                Console.Write(num);
                if (num < 19)
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(" = ");
                }
            }
            Console.WriteLine(somaImpar);
            Console.ReadKey();
        }
    }
}
