// 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
// o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
// Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

using System;

namespace exerciciosAcademia
{
    class ex07
    {
        static void Main(string[] args)
        {
            int numeroVendedor;
            double salarioFixo, totalVendas, percentualComissao, salarioTotal;

            Console.WriteLine("Informe o número do vendedor:");
            numeroVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salário fixo do vendedor:");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas efetuadas pelo vendedor:");
            totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissão sobre o total de vendas (ex: 0.1 para 10%):");
            percentualComissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioFixo + (totalVendas * percentualComissao);

            Console.WriteLine($"O vendedor de número {numeroVendedor} tem um salário total de {salarioTotal.ToString("C2")}");
        }
    }
}
