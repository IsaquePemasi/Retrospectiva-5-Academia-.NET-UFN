namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int maior = vetor[0];
            int menor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Array.Reverse(vetor);

                Console.WriteLine(vetor[i]);
            }

        }
    }
}

//11.Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos
//    na ordem inversa.