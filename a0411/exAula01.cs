namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a opção: ");


            for (int i = 0; i < 100; i++)
            {
                int opcao = int.Parse(Console.ReadLine());
                if (opcao >= 1 && opcao <= 4)
                {
                    Console.WriteLine("funcionou");
                    break;
                }
                else
                {
                    continue;
                }
            }

        }
    }
}