using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultaPeixe
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg,multa;
            Console.Write("Quantos kg você pescou? ");
            kg = double.Parse(Console.ReadLine());
            
            if (kg > 50)
            {
                multa = (kg - 50) * 5 + 100;
                Console.Write("Você pagara multa de: R$ "+ multa.ToString("n"));//.ToString("n") para deixar duas casas decimal depois da virgula ou (c)com o cifrão
            }
            else
            { 
                Console.Write("Você não pagara multa");
            }
            Console.ReadKey();
        }
    }
}
