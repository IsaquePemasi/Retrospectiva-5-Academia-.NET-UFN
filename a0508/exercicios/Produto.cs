using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produto
    {
        public string nome;
        public Fabricante fabricante;
        public int preco;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("nome não pode ser nulo ou vazio");
                nome = value;
            }
        }
        public int Preco
        {
            get { return preco; }
            set
            {
                if (preco < 0)
                {
                    throw new ArgumentException("Preço vazio");
                }
                preco = value;
            }
        }
    }
}

//6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
//Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
//seja vazio e que o preço seja positivo. 