//1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

using System;

namespace exerciciosAcademia
{
    class ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            double media = (num1 + num2) / 2;

            Console.WriteLine("A média aritmética entre " + num1 + " e " + num2 + " é: " + media);
            Console.ReadKey();
        }
    }
}