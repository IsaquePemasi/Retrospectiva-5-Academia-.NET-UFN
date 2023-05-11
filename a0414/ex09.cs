using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matriz = new int[3, 3];
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = rnd.Next(10);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        Console.WriteLine("O numero existe no vetor");
                    }
                    else
                    {
                        Console.WriteLine("O numero existe no vetor");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}

// 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
// Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.