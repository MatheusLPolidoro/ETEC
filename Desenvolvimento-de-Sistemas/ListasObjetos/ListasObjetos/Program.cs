using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListasObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este software ira controlar um cadastro de carros
            //CodVeiculo, Fabricante, Modelo, Cor e AnoModelo
            //Cadastro, Consulta, Exclusao

            int op; //Opcao do menu
            List<Carro> LstCarros = new List<Carro>();

            do
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Controle de veiculos:");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Sair");
                op = 0;
                try { 
                    op = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Aguarde...");
                }

                switch (op)
                {
                    case 1: //cadastrar
                        Carro obj = new Carro();
                        Console.WriteLine("Informe o fabricante:");
                        obj.Fabricante = Console.ReadLine();
                        Console.WriteLine("Informe o modelo:");
                        obj.Modelo = Console.ReadLine();
                        Console.WriteLine("Inorme a cor:");
                        obj.Cor = Console.ReadLine();
                        Console.WriteLine("Informe o ano de modelo");
                        obj.AnoModelo = int.Parse(Console.ReadLine());
                        obj.Codigo = LstCarros.Count + 1 ;
                        LstCarros.Add(obj); //add obj lista
                        Console.WriteLine("Carro cadastrado");
                        break;
                    case 2: //listar
                        if(LstCarros.Count > 0)
                        {
                            // exibir os dados dos veiculos
                            //Laços de repetição "para cada"
                            foreach (Carro item in LstCarros)
                            {
                                Console.WriteLine(item.RetornarDados());
                                Console.WriteLine("------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia");
                        }
                        Console.ReadKey();
                        break;
                    case 3: //excluir
                        int codExcluir;
                        Console.WriteLine("Informe o codigo para excluir o veiculo");
                        codExcluir = int.Parse(Console.ReadLine());
                        Carro c = new Carro(); //Carro vazio
                        foreach (Carro item in LstCarros)
                        {
                            if (item.Codigo == codExcluir)
                            {
                                c = item;
                            }    
                        }
                        LstCarros.Remove(c);
                        Console.WriteLine("Registro removido");
                        break;
                    case 4: //sair
                        break;
                    default:
                        Console.WriteLine("opcao invalida !");
                        break;
                }
            } while (op != 4);
        }
    }
}
