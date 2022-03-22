using System;
using System.Text.RegularExpressions;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            double n1, n2;
            n1 = n2 = 0;

            do
            {
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");

                op = int.Parse(ScannerValue());

                if (op > 0 && op < 5)
                {
                    Console.WriteLine("Informe um número:");
                    n1 = double.Parse(ScannerValue());
                    Console.WriteLine("Informe outro número");
                    n2 = double.Parse(ScannerValue());
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
                        Console.WriteLine("Saindo...Volte sempre!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!Digite novamente");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (op != 5);
        }

        private static string ScannerValue()
        {
            string InputText;
            do
            {
                InputText = Console.ReadLine();

                if (Regex.IsMatch(InputText, @"^[0-9]+$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida...Digite novamente!");
                }
            } while (true);

            return InputText;
        } 
    }
}
