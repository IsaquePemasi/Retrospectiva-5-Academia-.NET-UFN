//5 - Escreva um algoritmo para calcular o fatorial de um número.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numero;
        int resultado = 1;

        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }

        Console.WriteLine("O fatorial de " + numero + " é " + resultado);
    }
}
