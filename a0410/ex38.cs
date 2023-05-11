// •Escreva um algoritmo que mostre todos os números de 20 a 5.
// •Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim.
namespace asja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o inicio ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o fim");
            int fim = int.Parse(Console.ReadLine());

            for (int i = inicio; i < fim; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}