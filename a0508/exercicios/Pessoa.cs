using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public string Nome
        {
            get
            {
                return nome;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Valor vazio");
                }
                nome = value; 
            }
        } 
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (idade<=0)
                {
                    Console.WriteLine("Idade menor, ou igual, a zero");
                }
                idade = value;
            }
        }
    }
}

//4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
//que o nome não seja vazio e que a idade seja maior que zero.
