using System;
using System.Reflection;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] m = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = rnd.Next(10);

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m[i, j] + "\t");

                }
                Console.WriteLine();
            }

        }
    }
}

//6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
//Random random = new Random();
//int randomNumber = random.Next(0, 100);