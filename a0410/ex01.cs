//1 - Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
//pessoas e calcular a média das idades.

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                total = total + idade;
                Console.WriteLine(total);
            }
        }
    }
}

