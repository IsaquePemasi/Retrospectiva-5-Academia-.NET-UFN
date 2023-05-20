// 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
// preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
// vendidas pelo vendedor, calcule e mostre: o salário do empregado

using System;
namespace exerciciosAcademia
{
    class ex13
    {
        static void Main()
        {
            Console.Write("Informe o valor do salário mínimo: R$");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Informe o preço de custo de cada bicicleta: R$");
            double precoCusto = double.Parse(Console.ReadLine());

            Console.Write("Informe o número de bicicletas vendidas pelo vendedor: ");
            int numBicicletas = int.Parse(Console.ReadLine());

            double precoVenda = precoCusto * 1.5;
            double comissao = precoCusto * 0.15 * numBicicletas;
            double salarioVendedor = 2 * salarioMinimo + comissao;

            Console.WriteLine("Salário do vendedor: R$" + salarioVendedor);
        }
    }
}
