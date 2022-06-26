using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasObjetos
{
    internal class Carro
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        private string fabricante;
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private int anoModelo;
        public int AnoModelo
        {
            get { return anoModelo; }
            set { anoModelo = value; }
        }

        //Retornar Dados 

        public string RetornarDados()
        {
            string resultado = " ";

            resultado =  "Codigo: "           + Codigo;         
            resultado += "\nFabricante: "    + Fabricante;
            resultado += "\nModelo: "        + Modelo;
            resultado += "\nCor: "           + Cor;
            resultado += "\nAno de Modelo: " + AnoModelo;

            return resultado;

        }
    }
}
