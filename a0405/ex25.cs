//10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
//O programa deve mostrar os dados do atleta mais novo e mais alto.

namespace testando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro atleta");
            Console.WriteLine("nome do atleta: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("idade do atleta: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("altura do atleta: ");
            double altura1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo atleta");
            Console.WriteLine("nome do atleta: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("idade do atleta: ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("altura do atleta: ");
            double altura2 = double.Parse(Console.ReadLine());

            if (idade1 < idade2)
            {
                Console.WriteLine("o atleta " + nome1 + " é mais novo ");
            }
            else
            {
                Console.WriteLine("o atleta " + nome2 + " é mais novo ");
            }
            if (altura1 > altura2)
            {
                Console.WriteLine("o atleta " + nome1 + " é mais alto ");
            }
            else
            {
                Console.WriteLine("o atleta " + nome2 + " é mais alto ");
            }
        }
    }
}