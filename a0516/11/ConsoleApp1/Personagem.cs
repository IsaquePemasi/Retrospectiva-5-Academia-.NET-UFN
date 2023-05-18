using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Poder { get; set; }

        // Construtor sem parâmetros
        public Personagem()
        {
        }

        // Construtor com parâmetros
        public Personagem(string nome, int poder)
        {
            Nome = nome;
            Poder = poder;
        }

        // Método para exibir os dados do personagem
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Poder: {Poder}");
        }
    }
}
//1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
//O programa deverá informar o nome do personagem que possuir o maior poder.

//Regras que deverão ser seguidas para a implementação do algoritmo:

//É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
//A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
//Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
//irá receber o nome e o poder de um personagem