//5.Modifique o programa em VS anterior para aceitar votos nulos 
//(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
//Ao final, informe o nome do candidato vencedor, o número de votos nulos 
//e o número de pessoas que votaram.

using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joao = 0, zeca = 0, branco = 0, nulo = 0, total;
            for (int i = 0; true; i++)
            {
                Console.WriteLine("Digite o nome de um candidato: ");
                Console.WriteLine("JOAO\nZECA\nBRANCO\nFIM");
                string candidato = Console.ReadLine().ToUpper();

                if (candidato == "JOAO")
                {
                    joao++;
                }
                if (candidato == "ZECA")
                {
                    zeca++;
                }
                if (candidato == "BRANCO")
                {
                    branco++;
                }
                if (candidato == "FIM")
                {
                    break;
                }
                if (candidato != "ZECA" && candidato != "JOAO" && candidato != "BRANCO" && candidato != "FIM")
                {
                    nulo++;
                }
            }
            total = joao + zeca + branco + nulo;
            Console.WriteLine("Numero de pessoas que votaram: " + total);
            Console.WriteLine("Numero de votos no JOAO: " + joao);
            Console.WriteLine("Numero de votos no ZECA: " + zeca);
            Console.WriteLine("Numero de votos em NULO: " + nulo);
            Console.WriteLine("Numero de votos em BRANCO: " + branco);
            if (joao > zeca && joao > nulo && joao > branco)
            {
                Console.WriteLine("JOAO ganhou a votação!");
            }
            if (zeca > joao && zeca > nulo && zeca > branco)
            {
                Console.WriteLine("ZECA ganhou a votação! ");
            }
            if (nulo > zeca && nulo > joao && nulo > branco)
            {
                Console.WriteLine("NULO ganhou a votação!");
            }
            if (branco > joao && branco > zeca && branco > nulo)
            {
                Console.WriteLine("BRANCO ganhou a votação!");
            }
        }
    }
}