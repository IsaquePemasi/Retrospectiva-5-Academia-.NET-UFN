namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0;
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    par++;
                }
                if (i % 2 != 0)
                {
                    impar++;
                }
            }
            Console.WriteLine($"Numero de pares: {par}");
            Console.WriteLine($"Numero de impares {impar}");
        }
    }
}

//1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre
//na tela a quantidade de números pares e ímpares.