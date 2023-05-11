using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class People
    {
        public int idade;
        public string nome;
        public People(int idade)
        {
            this.idade = idade;
        }
        public People(int idade, string nome)
        {
            this.idade = idade;
            this.nome = nome;
        }

        public void conteudo()
        {
            Console.WriteLine("Nome: "+this.nome);
            Console.WriteLine("Idade: "+this.idade);
        }
    }
}

//1 - Criar uma classe chamada People com 2 construtores, um que receba o nome e a idade da pessoa e 
//outro recebendo apenas a idade. Solicite ao usuário qual dos construtores ele gostaria de utilizar 
//na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo 
//dos parâmetros recebidos.