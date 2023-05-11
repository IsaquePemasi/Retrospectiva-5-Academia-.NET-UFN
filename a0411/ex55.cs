//8.Faça um programa em VS que solicite um numero inteiro. Se
// o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
//Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Verifica();
        }

        static void Verifica()
        {
            int numero;
            Console.WriteLine("Digite um numero inteiro: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out numero);
            if (isNumber == true)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("numero par");
                }
                else
                {
                    Console.WriteLine("numero impar");
                }
            }
            else
            {
                Verifica();
            }
        }
    }
}

