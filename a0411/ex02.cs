//2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
//informar um outro número. Caso positivo, o programa em VS deve ser repetido.

//Exemplo:
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.


//Deseja informar outro número (s/n)? S

//Digite um número inteiro positivo: 12
//Numero digitado: 20
//Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


//Deseja informar outro número (s/n)? N using System.ComponentModel;

using System.Drawing;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Valor incorreto! ");
                Console.WriteLine("Digite um número inteiro positivo");
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " é par");

                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine("Deseja informar um novo numero? (s/n) ");
            char novo = char.Parse(Console.ReadLine().ToLower());

            switch (novo)
            {
                case 's':
                    Console.WriteLine("Digite um numero inteiro positivo: ");
                    int num1 = int.Parse(Console.ReadLine());

                    if (num1 <= 0)
                    {
                        Console.WriteLine("Valor incorreto! ");
                        Console.WriteLine("Digite um número inteiro positivo");
                    }
                    else
                    {
                        for (int i = 0; i < num1; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i + " é par");

                            }
                            else
                            {
                                continue;
                            }
                        }
                    }; break;
                case 'n':
                    Console.WriteLine(); break;
            }

        }
    }
}

