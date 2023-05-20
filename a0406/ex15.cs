//15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
//da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
//e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
//Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

using System.Drawing;
using System;

namespace domingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedindo o tamanho da área a ser pintada em metros quadrados
            Console.Write("Digite o tamanho da área a ser pintada em metros quadrados: ");
            double area = double.Parse(Console.ReadLine());

            // Calculando a quantidade de tinta necessária em litros
            double litrosDeTinta = area / 3;

            // Calculando a quantidade de latas de tinta necessárias
            int latasDeTinta = (int)Math.Ceiling(litrosDeTinta / 18);

            // Calculando o preço total das latas de tinta
            double precoTotal = latasDeTinta * 80;

            // Exibindo os resultados para o usuário
            Console.WriteLine($"Quantidade de latas de tinta a serem compradas: {latasDeTinta}");
            Console.WriteLine($"Preço total das latas de tinta: R$ {precoTotal:f2}");
        }
    }
}