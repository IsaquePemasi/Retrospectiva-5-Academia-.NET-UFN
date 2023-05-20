// 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
// si os valores de duas variáveis A e B.

using System;

namespace exerciciosAcademia
{
    class ex03
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;

            Console.WriteLine("Antes da troca:");
            Console.WriteLine("A = " + A + " e B = " + B);

            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Depois da troca:");
            Console.WriteLine("A = " + A + " e B = " + B);

            Console.ReadLine();
        }
    }
}
