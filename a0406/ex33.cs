//18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

using System;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            int valor3 = int.Parse(Console.ReadLine());

            int maiorValor = valor1;

            if (valor2 > maiorValor)
            {
                maiorValor = valor2;
            }

            if (valor3 > maiorValor)
            {
                maiorValor = valor3;
            }

            Console.WriteLine("O maior valor é: " + maiorValor);
        }
    }
}
