// 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
// isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
// de IPI (única) a ser acrescentada. 

using System;
namespace exerciciosAcademia
{
    class ex05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados para o Parafuso A:");
            Console.Write("Código: ");
            string codigoA = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Valor Unitário: ");
            double valorUnitarioA = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem de IPI: ");
            double ipiA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados para o Parafuso B:");
            Console.Write("Código: ");
            string codigoB = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("Valor Unitário: ");
            double valorUnitarioB = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem de IPI: ");
            double ipiB = double.Parse(Console.ReadLine());

            double valorTotalA = quantidadeA * valorUnitarioA * (1 + ipiA / 100);
            double valorTotalB = quantidadeB * valorUnitarioB * (1 + ipiB / 100);

            Console.WriteLine("Valor Total do Parafuso A: " + valorTotalA.ToString("F2"));
            Console.WriteLine("Valor Total do Parafuso B: " + valorTotalB.ToString("F2"));
        }
    }
}