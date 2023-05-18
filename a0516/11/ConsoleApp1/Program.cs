using System.Runtime.Intrinsics.X86;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Personagem personagem1 = CriarPersonagem();
            //Personagem personagem2 = CriarPersonagem();
            //Personagem personagem3 = CriarPersonagem();

            //Personagem personagemMaisPoderoso = ObterPersonagemMaisPoderoso(personagem1, personagem2, personagem3);

            //Console.WriteLine($"O personagem mais poderoso é: {personagemMaisPoderoso.Nome}");
            //Console.ReadLine();

            //static Personagem CriarPersonagem()
            //{
            //    Console.WriteLine("Digite o nome do personagem:");
            //    string nome = Console.ReadLine();

            //    Console.WriteLine("Digite o poder do personagem (de 0 a 10):");
            //    int poder = Convert.ToInt32(Console.ReadLine());

            //    return new Personagem(nome, poder);
            //}

            //static Personagem ObterPersonagemMaisPoderoso(params Personagem[] personagens)
            //{
            //    Personagem personagemMaisPoderoso = personagens[0];

            //    for (int i = 1; i < personagens.Length; i++)
            //    {
            //        if (personagens[i].Poder > personagemMaisPoderoso.Poder)
            //        {
            //            personagemMaisPoderoso = personagens[i];
            //        }
            //    }

            //    return personagemMaisPoderoso;
            //}

        //    2
        //    int contadorCachorros = 0;
        //    int contadorGatos = 0;
        //    int contadorPeixes = 0;

        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Animal animal = new Animal();

        //        Console.WriteLine($"Digite o nome do animal {i}:");
        //        animal.Nome = Console.ReadLine();

        //        Console.WriteLine($"Digite o tipo do animal {i} (Cachorro, Gato ou Peixe):");
        //        animal.Tipo = Console.ReadLine();

        //        while (animal.Tipo != "Cachorro" && animal.Tipo != "Gato" && animal.Tipo != "Peixe")
        //        {
        //            Console.WriteLine("Tipo inválido. Digite novamente o tipo do animal:");
        //            animal.Tipo = Console.ReadLine();
        //        }

        //        if (animal.Tipo == "Cachorro")
        //            contadorCachorros++;
        //        else if (animal.Tipo == "Gato")
        //            contadorGatos++;
        //        else if (animal.Tipo == "Peixe")
        //            contadorPeixes++;
        //    }

        //    Console.WriteLine("Total de animais informados:");
        //    Console.WriteLine($"Cachorros: {contadorCachorros}");
        //    Console.WriteLine($"Gatos: {contadorGatos}");
        //    Console.WriteLine($"Peixes: {contadorPeixes}");

        //    Console.ReadLine();
        //
        }
    }
}