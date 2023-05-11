//7 Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
//um usuário. Apresente o resultado.

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            Console.WriteLine("Digite 20 numeros: ");
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    par++;
                }
                if (numero % 2 == 1)
                {
                    impar++;
                }
            }
            Console.WriteLine("Numero de pares = " + par);
            Console.WriteLine("Numero de impares = " + impar);
        }
    }
}

