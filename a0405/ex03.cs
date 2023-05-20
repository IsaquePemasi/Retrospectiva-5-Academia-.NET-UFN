namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
            Console.WriteLine("Digite quatro valores: ");
            int w = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int media = (w + x + y + z) / 4;
            if (w > media)
            {
                Console.WriteLine("O valor " + w + " é maior que a média ");
            }
            if (x > media)
            {
                Console.WriteLine("O valor " + x + " é maior que a média ");
            }
            if (y > media)
            {
                Console.WriteLine("O valor " + y + " é maior que a média ");
            }
            if (z > media)
            {
                Console.WriteLine("O valor " + z + " é maior que a média ");
            }
        }
    }
}