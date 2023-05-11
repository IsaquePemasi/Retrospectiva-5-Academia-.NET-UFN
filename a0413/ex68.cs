namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] V = new int[10];
            int N, i;
            bool existe = false;

            Console.WriteLine("Digite 10 números inteiros:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("V[{0}] = ", i);
                V[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número inteiro para buscar no vetor: ");
            N = int.Parse(Console.ReadLine());

            Console.Write("O número fornecido existe nas posições: ");
            for (i = 0; i < 10; i++)
            {
                if (V[i] == N)
                {
                    Console.Write(i + " ");
                    existe = true;
                }
            }

            if (!existe)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
        }
    }
}

//12.Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no
//    vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".