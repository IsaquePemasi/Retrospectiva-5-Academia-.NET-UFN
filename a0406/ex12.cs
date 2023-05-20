// 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
// número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
// R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
// armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
// No final do processamento, exibir o salário total e o salário excedente do operário.

using System.Drawing;
using System;

namespace domingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, numeroHoras, horasExcedentes;
            double salario, salarioExcedente;

            Console.Write("Digite o código do operário: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            numeroHoras = int.Parse(Console.ReadLine());

            if (numeroHoras <= 50)
            {
                salario = numeroHoras * 10.0;
                horasExcedentes = 0;
                salarioExcedente = 0.0;
            }
            else
            {
                salario = 50 * 10.0;
                horasExcedentes = numeroHoras - 50;
                salarioExcedente = horasExcedentes * 20.0;
            }

            Console.WriteLine("Código do operário: " + codigo);
            Console.WriteLine("Salário total: R$ " + salario.ToString("F2"));
            Console.WriteLine("Salário excedente: R$ " + salarioExcedente.ToString("F2"));
        }
    }
}