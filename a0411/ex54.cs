//7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
//A cada solicitação, teste se o usuário informou um valor válido. 
//Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
//informe que ele está incorreto e saia do programa em VS. 
//Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
//informe que está errada e saia. Se estiver correta, solicite o salário. 
//Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
//Se estiver correto, mostre todos os valores lidos.

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu salario: ");
            double salario = double.Parse(Console.ReadLine());

            bool temNumero = nome.Any(char.IsDigit);

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || temNumero == true)
            {
                Console.WriteLine("nome incorreto.");
            }
            else if (idade <= 0)
            {
                Console.WriteLine("Idade incorreta");
            }
            else if (salario <= 0)
            {
                Console.WriteLine("Salario incorreto");
            }
            else
            {
                Console.WriteLine(nome);
                Console.WriteLine(idade);
                Console.WriteLine(salario);
            }
        }
    }
}