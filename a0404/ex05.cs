// 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
// (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
// consumido para percorrê-la (medido em l).

using System;

namespace exerciciosAcademia
{
    class ex05
    {
        static void Main(string[] args)
        {
            double distanciaTotal, volumeCombustivel, consumoMedio;

            Console.WriteLine("Digite a distância total percorrida (em km): ");
            distanciaTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o volume de combustível consumido (em litros): ");
            volumeCombustivel = double.Parse(Console.ReadLine());

            consumoMedio = distanciaTotal / volumeCombustivel;

            Console.WriteLine("O consumo médio do automóvel é de: " + consumoMedio.ToString("F2") + " Km/l");
            Console.ReadLine();
        }
    }
}
