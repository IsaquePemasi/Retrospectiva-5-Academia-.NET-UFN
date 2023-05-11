using System.Xml.Linq;

namespace aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc < 18)
            {
                Console.WriteLine("baixo peso");
            }
            if (imc > 18 && imc < 25)
            {
                Console.WriteLine("peso normal");
            }
            if (imc > 25 && imc < 30)
            {
                Console.WriteLine("sobrepeso");
            }
            if (imc > 30 & imc < 35)
            {
                Console.WriteLine("obesidade");
            }
            if (imc > 35)
            {
                Console.WriteLine("obesidade grau sério");

            }
        }

    }
}

//6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério