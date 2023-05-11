// 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
// plus: você pode gerar o número de forma randomica (função random c#).

using System;

class Program
{
    static void Main(string[] args)
    {
        // Geração de um número aleatório entre 1 e 100 (inclusive)
        Random rand = new Random();
        int numSecreto = rand.Next(1, 101);

        // Variáveis para armazenar o número escolhido pelo jogador e as dicas sobre se o número secreto é maior ou menor
        int numEscolhido;
        string dica;

        // Loop de 3 tentativas
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Tentativa {0}: Digite um número entre 1 e 100: ", i);
            numEscolhido = int.Parse(Console.ReadLine());

            if (numEscolhido == numSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número secreto!");
                return;
            }
            else if (numEscolhido < numSecreto)
            {
                dica = "é maior";
            }
            else
            {
                dica = "é menor";
            }

            Console.WriteLine("Dica: o número secreto {0} do que o número escolhido.", dica);
        }

        // Se o jogador não acertou após as 3 tentativas, mostra a mensagem de derrota e o número secreto
        Console.WriteLine("Você perdeu! O número secreto era {0}.", numSecreto);
    }
}
