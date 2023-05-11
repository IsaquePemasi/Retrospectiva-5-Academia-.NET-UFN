using System;
namespace exerciciosAcademia
{
    class ex12
    {
        static void Main()
        {
            Console.Write("Informe a marcação do odômetro no início do dia: ");
            double odometroInicio = double.Parse(Console.ReadLine());

            Console.Write("Informe a marcação do odômetro no final do dia: ");
            double odometroFim = double.Parse(Console.ReadLine());

            Console.Write("Informe o número de litros de combustível gasto: ");
            double litrosCombustivel = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor total recebido dos passageiros: ");
            double valorRecebido = double.Parse(Console.ReadLine());

            double totalQuilometragem = odometroFim - odometroInicio;
            double mediaConsumo = totalQuilometragem / litrosCombustivel;
            double lucroDia = valorRecebido - (litrosCombustivel * 6.90);

            Console.WriteLine("Média de consumo em Km/l: " + mediaConsumo);
            Console.WriteLine("Lucro líquido do dia: R$" + lucroDia);
        }
    }
}
