namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[3];

            for (int i = 0; i < vetor.Length; i++)
            {
                int menor = vetor[0];
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());

                //int menor = vetor[0];
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
                Console.WriteLine($"menor: {menor}");

            }

        }
    }
}

//5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.