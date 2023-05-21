//2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

namespace asja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                n = int.Parse(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                }
                Console.WriteLine("Maior numero: " + maior);
            }
        }
    }
}