using System;
namespace exerciciosAcademia
{
    class ex09
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da mercadoria: ");
            double valorMercadoria = double.Parse(Console.ReadLine());

            double entrada = Math.Ceiling(valorMercadoria * 0.5);
            double prestacoes = Math.Ceiling((valorMercadoria - entrada) / 2);

            Console.WriteLine("Valor da entrada: R$ " + entrada.ToString("F2"));
            Console.WriteLine("Valor das duas prestações: R$ " + prestacoes.ToString("F2"));

            Console.ReadKey();
        }
    }
}
