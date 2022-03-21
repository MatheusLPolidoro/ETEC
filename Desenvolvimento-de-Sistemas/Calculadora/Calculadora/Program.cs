using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            double n1, n2;
            n1 = n2 = 0;
            Console.BackgroundColor = ConsoleColor.Red;//trocar cor do fundo
            Console.Clear();//aplica a toda a tela
            Console.ForegroundColor = ConsoleColor.Green;//cor da fonte
            do
            {
                do
                {
                    Console.WriteLine("1 - Somar");
                    Console.WriteLine("2 - Subtrair");
                    Console.WriteLine("3 - Multiplicar");
                    Console.WriteLine("4 - Dividir");
                    Console.WriteLine("5 - Sair");

                    op = Console.ReadLine();

                    if (Regex.IsMatch(op, @"^[0-9]+$"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida...Pressione enter.");
                        Console.ReadKey();
                    }

                    Console.Clear();

                } while (true);



                if (int.Parse(op) > 0 && int.Parse(op) < 5)
                {

                    do
                    {
                        Console.WriteLine("Informe um número: ");

                        if (Regex.IsMatch(op, @"^[0-9]+$"))
                        {
                            n1 = double.Parse(Console.ReadLine());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida...Pressione enter.");
                            Console.ReadKey();
                        }

                        Console.Clear();

                    } while (true);

                    do
                    {
                        Console.WriteLine("Informe outro número: ");

                        if (Regex.IsMatch(op, @"^[0-9]+$"))
                        {
                            n1 = double.Parse(Console.ReadLine());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida...Pressione enter.");
                            Console.ReadKey();
                        }

                        Console.Clear();

                    } while (true);
                }

                switch (int.Parse(op))
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
                    default:
                        Console.WriteLine("Opção inválida!Digite novamente");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (int.Parse(op) != 9);
        }
    }
}
