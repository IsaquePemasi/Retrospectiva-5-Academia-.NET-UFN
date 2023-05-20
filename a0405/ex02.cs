namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine($"o numero {num} par");
            }
            else
            {
                Console.WriteLine($"o numero {num} ímpar");
            }
        }
    }
}

//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 