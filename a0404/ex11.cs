// 11) Escreva um algoritmo para ler o número de eleitores de um município, 
// o número de votos brancos, nulos e válidos. 
// Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

using System;

namespace exerciciosAcademia
{
    class ex11
    {
        static void Main(string[] args)
        {
            int eleitores, votosBrancos, votosNulos, votosValidos;
            double percentualBrancos, percentualNulos, percentualValidos;

            Console.Write("Digite o número de eleitores do município: ");
            eleitores = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos em branco: ");
            votosBrancos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos válidos: ");
            votosValidos = int.Parse(Console.ReadLine());

            percentualBrancos = (double)votosBrancos / eleitores * 100;
            percentualNulos = (double)votosNulos / eleitores * 100;
            percentualValidos = (double)votosValidos / eleitores * 100;

            Console.WriteLine("Percentual de votos em branco: {0:f2}%", percentualBrancos);
            Console.WriteLine("Percentual de votos nulos: {0:f2}%", percentualNulos);
            Console.WriteLine("Percentual de votos válidos: {0:f2}%", percentualValidos);

            Console.ReadKey();
        }
    }
}
