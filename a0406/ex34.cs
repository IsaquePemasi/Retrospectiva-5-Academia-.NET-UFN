// 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            int valor3 = int.Parse(Console.ReadLine());

            int menorValor, meioValor, maiorValor;

            if (valor1 < valor2 && valor1 < valor3)
            {
                menorValor = valor1;

                if (valor2 < valor3)
                {
                    meioValor = valor2;
                    maiorValor = valor3;
                }
                else
                {
                    meioValor = valor3;
                    maiorValor = valor2;
                }
            }
            else if (valor2 < valor3)
            {
                menorValor = valor2;

                if (valor1 < valor3)
                {
                    meioValor = valor1;
                    maiorValor = valor3;
                }
                else
                {
                    meioValor = valor3;
                    maiorValor = valor1;
                }
            }
            else
            {
                menorValor = valor3;

                if (valor1 < valor2)
                {
                    meioValor = valor1;
                    maiorValor = valor2;
                }
                else
                {
                    meioValor = valor2;
                    maiorValor = valor1;
                }
            }

            Console.WriteLine($"Valores em ordem crescente: {menorValor}, {meioValor}, {maiorValor}");
        }
    }
}