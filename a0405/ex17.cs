using static System.Net.Mime.MediaTypeNames;

namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.
            Console.WriteLine("digite a base do triangulo: ");
            int bases = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura do triangulo");
            int altura = int.Parse(Console.ReadLine());
            int area = (bases * altura) / 2;
            Console.WriteLine("area do triangulo: " + area);
        }
    }
}