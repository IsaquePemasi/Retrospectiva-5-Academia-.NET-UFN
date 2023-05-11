//2) Solicite ao usuário, preencher uma Matriz 3x3

//Informe ao usuário:
//*A soma dos elementos de cada linha
//	-Ex: Linha 1: 30

//         Linha 2: 17
//* A soma dos elementos de cada coluna
//	-Ex: Coluna 1: 23

//         Coluna 2: 36

using System;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];


            Console.WriteLine("preencha uma Matriz 3x3");

            for (int linha = 0; linha < 3; linha++)
            {

                matriz[linha, 0] = int.Parse(Console.ReadLine());
                matriz[linha, 1] = int.Parse(Console.ReadLine());
                matriz[linha, 2] = int.Parse(Console.ReadLine());
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t ");
                }
                Console.WriteLine();

            }
        }
    }
}

