namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite um valor para o vetor1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
                //if (vetor1[i] % 2 == 0)
                //{
                //    Console.WriteLine("O vetor de indice "+ i + "é par");
                //}
            }
            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] % 2 == 0)
                {
                    Console.WriteLine("O vetor de indice " + i + "é par");
                }
            }


        }
    }
}

//3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos
// e então mostre na tela o índice da posição dos valores correspondentes a números primos.