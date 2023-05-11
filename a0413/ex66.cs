namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor[i] = 2;
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

        }
    }
}

//10.Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2.
//    Mostre os vetores lidos e o vetor resultado.