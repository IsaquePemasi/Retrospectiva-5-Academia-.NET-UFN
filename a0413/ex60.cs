namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[3];
            int[] vetor2 = new int[3];

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
                Console.WriteLine(vetor1[i] * vetor2[i]);
            }
            //Console.WriteLine(vetor1[0] + vetor2[0]);
        }
    }
}

//4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos
//elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.