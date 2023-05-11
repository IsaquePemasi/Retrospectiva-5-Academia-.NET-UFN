using System;

namespace exerciciosAcademia
{


    class ex10
    {
        static void Main(string[] args)
        {
            int valorSaque, resto, nota;

            Console.Write("Digite o valor do saque: ");
            valorSaque = int.Parse(Console.ReadLine());

            Console.WriteLine("Distribuição das notas:");

            nota = 50;
            while (valorSaque != 0)
            {
                resto = valorSaque % nota;
                int qtdNotas = (valorSaque - resto) / nota;
                if (qtdNotas > 0)
                {
                    Console.WriteLine(qtdNotas + " nota(s) de R$" + nota);
                }
                valorSaque = resto;
                if (nota == 50) nota = 20;
                else if (nota == 20) nota = 10;
                else if (nota == 10) nota = 5;
                else if (nota == 5) nota = 2;
                else if (nota == 2) nota = 1;
            }

            Console.ReadKey();
        }
    }
}