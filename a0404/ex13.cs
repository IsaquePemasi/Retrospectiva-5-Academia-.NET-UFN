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
