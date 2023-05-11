// 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
// formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
// os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do lado a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o tamanho do lado b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o tamanho do lado c: ");
        double c = double.Parse(Console.ReadLine());

        if (a < b + c && b < a + c && c < a + b)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo equilátero.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Triângulo isósceles.");
            }
            else
            {
                Console.WriteLine("Triângulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os lados não formam um triângulo.");
        }
    }
}