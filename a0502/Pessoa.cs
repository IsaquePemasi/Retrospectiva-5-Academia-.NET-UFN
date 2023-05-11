using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void exibeDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
        }
    }
}