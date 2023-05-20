// 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
// se a média das duas notas for maior ou igual a 7,0. 

// Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
// é a média entre a nota do exame e a média das 2 notas. 
// Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
// escrever “Reprovado”.

using System.Xml.Linq;

namespace aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infomre a primeira nota do aluno: ");
            double n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota do aluno: ");
            double n2 = int.Parse(Console.ReadLine());
            double media = n1 + n2;
            if (media >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            if (media <= 7.0 && media >= 5.0)
            {
                Console.WriteLine("Sua nota foi " + media + ", você foi aprovado");
            }
            else
            {
                Console.WriteLine("Você foi reprovado");
            }
        }

    }
}

//5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
//se a média das duas notas for maior ou igual a 7, 0.

//Caso a média seja inferior a 7, 0, o programa deve ler a nota do exame e calcular a média final,
//é a média entre a nota do exame e a média das 2 notas.
//Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
//escrever “Reprovado”.