using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Fabricante
    {
        public string nome;
        public string endereco;
        public string cidade;

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
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }
}
//6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
//Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
//seja vazio e que o preço seja positivo. 