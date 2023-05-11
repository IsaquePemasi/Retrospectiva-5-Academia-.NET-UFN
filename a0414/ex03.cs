using System;
using System.Reflection;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                matriz[i, 0] = rnd.Next(10);
                matriz[i, 1] = rnd.Next(10);
                matriz[i, 2] = rnd.Next(10);
                matriz[i, 3] = rnd.Next(10);
            }

            //for (int i = 0;i < 4; i++)
            //{
            //    //for (int j = 0; j < 4; j++)
            //    //{
            //    //    Console.Write(matriz[i,j] + "\t");


            //    //}
            //    Console.WriteLine();
            //}
            for (int i = 0; i < 4; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }


        }
    }
}

//3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!