using System.Drawing;
using System;

namespace domingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int placarTimeCasa, placarTimeFora;
            Console.WriteLine("Digite o placar do jogo:");
            Console.Write("Time da casa: ");
            placarTimeCasa = int.Parse(Console.ReadLine());
            Console.Write("Time de fora: ");
            placarTimeFora = int.Parse(Console.ReadLine());

            if (placarTimeFora - placarTimeCasa > 2)
            {
                Console.WriteLine("O time de fora se classificou para a próxima fase!");
            }
            else
            {
                Console.WriteLine("Os dois times irão se enfrentar novamente em um novo jogo.");
            }
        }
    }
}

// 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
// na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
// enfrentar novamente em um novo jogo.
// ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
// ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
// plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.