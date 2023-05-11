//9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
//o zoológico num determinado dia, imprimindo:
//Quantas pessoas tem entre 1 e 3 filhos.
//Quantas pessoas tem entre 4 e 7 filhos.
//Quantas pessoas tem mais de 8 filhos.
//Quantas pessoas não tem filhos.

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pessoas3 = 0, pessoas7 = 0, pessoas8 = 0, pessoas0 = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a quantidade de filhos: ");
                int filhos = int.Parse(Console.ReadLine());
                if (filhos >= 1 && filhos <= 3)
                {
                    pessoas3++;
                }
                if (filhos >= 4 && filhos <= 7)
                {
                    pessoas7++;
                }
                if (filhos >= 8)
                {
                    pessoas8++;
                }
                if (filhos == 0)
                {
                    pessoas0++;
                }

            }
            Console.WriteLine(pessoas3 + " pessoas tem entre 1 e 3 filhos");
            Console.WriteLine(pessoas7 + " pessoas tem entre 4 e 7 filhos");
            Console.WriteLine(pessoas8 + " pessoas tem mais de 8 filhos");
            Console.WriteLine(pessoas0 + " pessoas não tem filhos");
        }

    }
}

