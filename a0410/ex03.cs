//3 - Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
//x lido utilizando laços de repetição, e mostre na tela.

namespace asja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor");
            int valor = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(valor * i);
            }
        }
    }
}