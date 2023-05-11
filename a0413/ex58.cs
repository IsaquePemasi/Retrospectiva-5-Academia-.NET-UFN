namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite um valor para o vetor1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite um valor para o vetor2: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine(vetor1[i] + vetor2[i]);
            }
            //Console.WriteLine(vetor1[0] + vetor2[0]);
        }
    }
}

//2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos
//e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.