// 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
// para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
// realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
// notas de menor valor fossem distribuídas em número mínimo possível. 
// Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
// uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
// Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
// de acordo com o critério da “distribuição ótima”.

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