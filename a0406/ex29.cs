// 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
// link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
// do arquivo usando este link (em minutos).

namespace domingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Informe o tamanho do arquivo para download (em MB): ");
                double tamanhoArquivo = double.Parse(Console.ReadLine());

                Console.Write("Informe a velocidade do link de internet (em Mbps): ");
                double velocidadeInternet = double.Parse(Console.ReadLine());

                double tempoDownloadSegundos = (tamanhoArquivo * 8) / (velocidadeInternet * 1000000);
                double tempoDownloadMinutos = tempoDownloadSegundos / 60;

                Console.WriteLine("O tempo aproximado de download do arquivo é de " + Math.Round(tempoDownloadMinutos, 2) + " minutos.");
            }
        }
    }
}