using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Computador
    {
        public string marca;
        public string modelo;
        public string tipo;
        public int preco;

        public Computador()
        {

        }
        public Computador(string marca, string modelo, string tipo, int preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;
        }
        public void exibeDados()
        {
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("tipo: " + this.tipo);
            Console.WriteLine("preço: " + this.preco);
            Console.WriteLine("\n");
        }
    }
}
