namespace aula3
{
    internal class Program
    {
        //int ultimo = vetor[i - 1];
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(vetor[9]);
            Console.WriteLine(vetor[8]);
            Console.WriteLine(vetor[7]);
            Console.WriteLine(vetor[6]);
            Console.WriteLine(vetor[5]);
            Console.WriteLine(vetor[4]);
            Console.WriteLine(vetor[3]);
            Console.WriteLine(vetor[2]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[0]);
        }
    }
}

//6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
//a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |