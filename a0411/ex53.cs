//6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
//ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
//Ao final, mostre a idade digitada.

using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Aula
{
    internal class Program
    {
        int idade;
        static void Main(string[] args)
        {
            Informe();
        }

        static void Informe()
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade <= 0)
            {
                Informe();
            }
            else
            {
                Console.WriteLine("Idade correta");
                Console.WriteLine("Idade digitada: " + idade);
            }

        }
    }
}