//4.Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
//Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
//Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
//Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
//escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
//de votos em branco. 

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
            int joao = 0, zeca = 0, branco = 0;
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

                //switch (candidato)
                //{
                //    case "JOAO": Console.WriteLine(joao++);break;
                //    case "ZECA": Console.WriteLine(zeca++); break;
                //    case "BRANCO": Console.WriteLine(branco++); break;
                //    case "FIM":Console.WriteLine("FIM");break;
                //}


            }
            Console.WriteLine("Numero de votos no JOAO: " + joao);
            Console.WriteLine("Numero de votos no Zeca: " + zeca);
            Console.WriteLine("Numero de votos em BRANCO: " + branco);
        }
    }
}

