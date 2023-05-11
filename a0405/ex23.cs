// 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
// Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
// Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
// E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
// total de vendas. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Recebe as informações do funcionário
        Console.Write("Código do funcionário: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Salário base do funcionário: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Total de vendas do funcionário: ");
        double totalVendas = double.Parse(Console.ReadLine());

        // Realiza o cálculo do salário final com base nas vendas
        double comissao = 0;

        if (totalVendas > 500 && totalVendas <= 1000)
        {
            comissao = totalVendas * 0.05;
        }
        else if (totalVendas > 1000 && totalVendas <= 5000)
        {
            comissao = totalVendas * 0.07;
        }
        else if (totalVendas > 5000)
        {
            comissao = totalVendas * 0.1;
        }

        double salarioFinal = salarioBase + comissao;

        // Exibe o resultado
        Console.WriteLine("\nCódigo: " + codigo);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário base: R$ " + salarioBase.ToString("F2"));
        Console.WriteLine("Comissão: R$ " + comissao.ToString("F2"));
        Console.WriteLine("Salário final: R$ " + salarioFinal.ToString("F2"));
    }
}