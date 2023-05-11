using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Agenda
    {
        private Pessoa[] pessoas = new Pessoa[10];
        private int numPessoas = 0;

        public void armazenaPessoa(string nome, int idade, float altura)
        {
            if (numPessoas < 10)
            {
                pessoas[numPessoas] = new Pessoa(nome, idade, altura);
                numPessoas++;
                Console.WriteLine($"Pessoa {nome} adicionada à agenda.");
            }
            else
            {
                Console.WriteLine("Agenda cheia. Não é possível adicionar mais pessoas.");
            }
        }

        public void removePessoa(string nome)
        {
            int index = buscaPessoaIndex(nome);
            if (index != -1)
            {
                Console.WriteLine($"Pessoa {pessoas[index].Nome} removida da agenda.");
                pessoas[index] = null;
                numPessoas--;
            }
            else
            {
                Console.WriteLine($"Pessoa {nome} não encontrada na agenda.");
            }
        }

        public Pessoa buscaPessoa(string nome)
        {
            int index = buscaPessoaIndex(nome);
            if (index != -1)
            {
                return pessoas[index];
            }
            else
            {
                Console.WriteLine($"Pessoa {nome} não encontrada na agenda.");
                return null;
            }
        }

        public void imprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (Pessoa p in pessoas)
            {
                if (p != null)
                {
                    Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}, Altura: {p.Altura}");
                }
            }
        }

        private int buscaPessoaIndex(string nome)
        {
            for (int i = 0; i < numPessoas; i++)
            {
                if (pessoas[i].Nome == nome)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
//14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
//  void armazenaPessoa(String nome, int idade, float altura);
//void removePessoa(String nome);
//Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
//void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda