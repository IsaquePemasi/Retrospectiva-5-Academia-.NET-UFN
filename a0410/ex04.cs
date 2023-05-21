//4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
//elevado na y sem utilizar a função pow.

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            Console.WriteLine("Insira o valor da base: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o expoente: ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i <= y; i++)
            {
                total = total * x;
                Console.WriteLine(total);
            }

        }
    }
}

