using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persitencia
    {
        /// <summary>
        /// metodo de classe que le um arquivo csv e exibe somente os nomes cadastrados
        /// </summary>
        /// <param name="nomeArquivo"></param>
        public static void lerArquivoExibeNomes(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[nome, email, dataNascimento]
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split("-");
                    Console.WriteLine(vetorLinha[0]);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }
    }
}
