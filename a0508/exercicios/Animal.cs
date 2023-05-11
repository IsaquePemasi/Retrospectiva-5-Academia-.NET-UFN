using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public string nome;
        public string especie;
        public string idade;

        public void EmitirSom(string especie)
        {
            if (especie == "cachorro")
            {
                Console.WriteLine("Au Au");
            }
            if (especie == "gato")
            {
                Console.WriteLine("Miau");
            }
        }

    }
}
//10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
//EmitirSom, que imprime na tela o som do animal.