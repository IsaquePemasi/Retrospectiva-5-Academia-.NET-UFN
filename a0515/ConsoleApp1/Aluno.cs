using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno: Pessoa
    {
        public string Matricula { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine("Nome: " + this.Nome + "\nIdade: " + this.Idade + "\nMatricula: "+ this.Matricula);
        }
    }
}

//Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de 
//Pessoa. A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade 
//adicional Disciplina. Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa. Em seguida, criar um 
//método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor
//que imprime o nome, a idade e a disciplina do professor.