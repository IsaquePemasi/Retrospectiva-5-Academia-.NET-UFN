// 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
// forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

using System;

namespace exerciciosAcademia
{
    class ex04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato DDMMAAAA:");

            string dataString = Console.ReadLine();

            int dia = int.Parse(dataString.Substring(0, 2));
            int mes = int.Parse(dataString.Substring(2, 2));
            int ano = int.Parse(dataString.Substring(4, 4));
            string dataAAAAMMDD = ano.ToString() + mes.ToString("D2") + dia.ToString("D2");

            string dataAAMMDD = dataString.Substring(6, 2) + dataString.Substring(2, 2) + dataString.Substring(0, 2);

            Console.WriteLine("Data no formato AAAAMMDD: " + dataAAAAMMDD);
            Console.WriteLine("Data no formato AAMMDD: " + dataAAMMDD);

            Console.ReadLine();
        }
    }
}
