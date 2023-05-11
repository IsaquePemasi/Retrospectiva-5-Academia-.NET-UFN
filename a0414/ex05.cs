using System;
using System.Reflection;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz1 = new double[2, 3]
            {
                {1.5, 2.4, 3.7},
                {4.0, 5.9 ,6.2}
            };
            double[,] matriz2 = new double[2, 3]
{
                {1.4, 2.3, 3.4},
                {4.2, 5.7 ,6.3}
};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz2[i, j] + matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

//5) Leia duas matrizes 2x3 de números double. 
//Imprima a soma destas duas matrizes.