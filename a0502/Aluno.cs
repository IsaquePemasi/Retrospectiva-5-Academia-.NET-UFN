using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Aluno
    {
        public int dataDeNascimento;
        public string nome;
        public int matricula;
        public int anoDeIngresso;
        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            Console.WriteLine("Nome: "+ this.nome);
            Console.WriteLine("Matricula: " + this.matricula);
            Console.WriteLine();
        }
        public Aluno(int dataDeNascimento)
        {
            this.dataDeNascimento = dataDeNascimento;
            Console.WriteLine("Data de nascimento: " + this.dataDeNascimento);
            Console.WriteLine();
        }
        public Aluno(string nome, int dataDeNascimento, int anoDeIngresso)
        {
            this.nome = nome;
            this.dataDeNascimento = dataDeNascimento;
            this.anoDeIngresso = anoDeIngresso;

            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Data de nascimento: " + this.dataDeNascimento);
            Console.WriteLine("Ano de ingresso: "+ this.anoDeIngresso);
            Console.WriteLine();
        }
    }
}
//2 - Criar uma classe chamada Aluno com 3 construtores, sendo que
//o primeiro recebe o nome e a matrícula do aluno,
//o segundo recebe apenas a data de nascimento do aluno e
//o terceiro construtor recebe o nome do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
//Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.