namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int maior = vetor[0];
            int menor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Array.Sort(vetor);

                Console.WriteLine(vetor[i]);
            }

        }
    }
}

//9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida
//ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.