// 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
// seu peso ideal, utilizando as seguintes fórmulas:
// Para homens: (72.7 * h) - 58
// Para mulheres: (62.1 * h) - 44.7

namespace domingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua altura: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Você é homem ou mulher");
            Console.WriteLine("1 - Homem");
            Console.WriteLine("2 - Mulher");
            short sexo = short.Parse(Console.ReadLine());
            double idealH = ((72.7 * h) - 58);
            double idealM = ((62.1 * h) - 44.7);
            switch (sexo)
            {
                case 1: Console.WriteLine("Seu peso ideal é " + idealH); break;
                case 2: Console.WriteLine("Seu peso ideal é " + idealM); break;
                default: Console.WriteLine("Escolha uma das alternativas"); break;
            }
        }
    }
}