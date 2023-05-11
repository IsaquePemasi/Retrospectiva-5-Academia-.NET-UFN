using System;

namespace exerciciosAcademia
{
    class ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro números para calcular a média aritmética:");

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());

            double media = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("A média aritmética é: " + media);

            Console.ReadLine();
        }
    }
}
