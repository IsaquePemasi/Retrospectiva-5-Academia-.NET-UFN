// 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
// marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
// dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

// Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

// Média do consumo = Total quilometragem/ quantidade de combustível gasto

// Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

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
