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
                    Console.WriteLine("5 - Exponenciação");
                    Console.WriteLine("6 - Raiz Quadrada");
                    Console.WriteLine("7 - Resto da divisão");
                    Console.WriteLine("8 - Porcentagem");
                    Console.WriteLine("9 - Sair");
                    op = Console.ReadLine();
                    if (Regex.IsMatch(op, @"^[0-9]+$"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, informe um número! ");
                        Console.ReadKey();
                    }
                    Console.Clear();
                } while (true);



                if (int.Parse(op) > 0 && int.Parse(op) < 9)
                {
                    Console.WriteLine("Informe um número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe outro número: ");
                    n2 = double.Parse(Console.ReadLine());
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
                    case 5:
                        Console.WriteLine($"{n1.ToString("n")} ^ {n2.ToString("n")} = {Math.Pow(n1, n2).ToString("n")}");
                        break;
                    case 6:
                        Console.WriteLine($"√{n1.ToString("n")} = {Math.Sqrt(n1).ToString("n")}\n√{n2.ToString("n")} = {Math.Sqrt(n2).ToString("n")}");
                        break;
                    case 7:
                        Console.WriteLine($"{n1.ToString("n")} : {n2.ToString("n")} = {(n1 % n2).ToString("n")}");
                        break;
                    case 8:
                        Console.WriteLine($"{n1.ToString("n")} % de {n2.ToString("n")} = {(n1 / 100 * n2).ToString("n")}");
                        break;
                    case 9:
                        Console.WriteLine("Saindo...");
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
