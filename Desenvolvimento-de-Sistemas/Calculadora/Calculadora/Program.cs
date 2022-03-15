using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            float n1, n2;
            n1 = n2 = 0;
            do
            {
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");

                op = int.Parse(Console.ReadLine());

                if (op > 0 && op < 5)
                {
                    Console.WriteLine("Informe um número: ");
                    n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe outro número: ");
                    n2 = float.Parse(Console.ReadLine());
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{n1.ToString("n")} + {n2.ToString("n")} = {(n1 + n2).ToString("n")}");
                        break;
                    case 2:
                        Console.WriteLine($"{n1.ToString("n")} - {n2.ToString("n")} = {(n1 - n2).ToString("n")}");
                        break;
                    case 3:
                        Console.WriteLine($"{n1.ToString("n")} x {n2.ToString("n")} = {(n1 * n2).ToString("n")}");
                        break;
                    case 4:
                        Console.WriteLine($"{n1.ToString("n")} ÷ {n2.ToString("n")} = {(n1 / n2).ToString("n")}");
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!Digite novamente");                        
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (op != 5);
        }
    }
}
