//3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. 

using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; true; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                else
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("numero par");
                    }
                    if (num % 2 != 0)
                    {
                        Console.WriteLine("numero impar");
                    }
                    if (num % num == 0 && num % 1 == 0)
                    {
                        Console.WriteLine("numero primo");
                    }
                }
            }

        }
    }
}

