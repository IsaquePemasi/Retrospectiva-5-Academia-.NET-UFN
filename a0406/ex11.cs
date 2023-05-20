//11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
//O programa deve exibir se a hora digitada está ou não válida. 
//Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

namespace testando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora: ");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os minutos: ");
            int minuto = int.Parse(Console.ReadLine());
            if (hora <= 24 && minuto <= 59)
            {
                Console.WriteLine("a hora digitada está correta");
            }
            else
            {
                Console.WriteLine("a hora digitada não está correta");
            }

        }
    }
}

