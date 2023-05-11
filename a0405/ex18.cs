using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            //Mostrar na tela qual dos professores tem o maior salário total.

            Console.WriteLine("digite o nome do primeiro professor(a): ");
            string p1 = Console.ReadLine();
            Console.WriteLine("digite o nome do segundo professor(a): ");
            string p2 = Console.ReadLine();
            Console.WriteLine("qual a quantida de horas dadas pelo professor(a) " + p1);
            double h1 = double.Parse(Console.ReadLine());
            Console.WriteLine("qual a quantida de horas dadas pelo professor(a) " + p2);
            double h2 = double.Parse(Console.ReadLine());
            Console.WriteLine("valor por hora do professor(a) " + p1);
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("valor por hora do professor(a) " + p2);
            double v2 = double.Parse(Console.ReadLine());
            double vph1 = v1 / h1;
            double vph2 = v2 / h2;
            if (vph1 > vph2)
            {
                Console.WriteLine("o professor(a) " + p1 + " recebe mais que o professor(a) " + p2);
            }
            else
            {
                Console.WriteLine("o professor(a) " + p2 + " recebe mais que o professor(a) " + p1);
            }
        }
    }
}