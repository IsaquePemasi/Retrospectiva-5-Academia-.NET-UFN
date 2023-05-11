using System;
using System.Reflection;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[,]
            {
                { 2, -3, 0, 5, 8 },
                { -1, 6, -4, 7, 9 },
                { 0, 1, -2, -8, 3 },
                { 4, -6, 2, -9, 10 },
                { 7, 0, -3, 1, 6 }
            };

            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;
            int zeros = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                    if (matriz[i, j] % 2 != 0)
                    {
                        impares++;
                    }
                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        zeros++;
                    }
                }
            }

            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares);
            Console.WriteLine("Quantidade de números positivos: " + positivos);
            Console.WriteLine("Quantidade de números negativos: " + negativos);
            Console.WriteLine("Quantidade de zeros: " + zeros);

        }
    }
}

//4) Popule uma matriz 5x5 e informe:
//-Quantos números são pares
//-Quantos números são impares
//-Quantos números são positivos
//-Quantos números são negativos
//-Quantos zeros existem!