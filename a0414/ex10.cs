using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];

            // Leitura das matrizes A e B
            Console.WriteLine("Digite os valores da matriz A:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Cálculo da média das matrizes A e B
            double mediaA = 0;
            double mediaB = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mediaA += matrizA[i, j];
                    mediaB += matrizB[i, j];
                }
            }

            mediaA /= 16;
            mediaB /= 16;

            Console.WriteLine("Média da matriz A: " + mediaA);
            Console.WriteLine("Média da matriz B: " + mediaB);

            // Contagem de elementos abaixo, acima e na média
            int abaixoA = 0;
            int acimaA = 0;
            int igualA = 0;

            int abaixoB = 0;
            int acimaB = 0;
            int igualB = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrizA[i, j] < mediaA)
                    {
                        abaixoA++;
                    }
                    else if (matrizA[i, j] > mediaA)
                    {
                        acimaA++;
                    }
                    else
                    {
                        igualA++;
                    }

                    if (matrizB[i, j] < mediaB)
                    {
                        abaixoB++;
                    }
                    else if (matrizB[i, j] > mediaB)
                    {
                        acimaB++;
                    }
                    else
                    {
                        igualB++;
                    }
                }
            }

            Console.WriteLine("Matriz A: " + abaixoA + " elementos abaixo da média, " + acimaA + " elementos acima da média e " + igualA + " elementos iguais à média.");
            Console.WriteLine("Matriz B: " + abaixoB + " elementos abaixo da média, " + acimaB + " elementos acima da média e " + igualB + " elementos iguais à média.");
        }
    }
}

//10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão
//    abaixo, acima e na média.
