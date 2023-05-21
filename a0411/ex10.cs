//10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
//Número de pessoas do sexo masculino.
//Número de pessoas do sexo feminino.
//Número de pessoas com idade inferior a 30 anos.
//Número de pessoas com idade superior a 60 anos.
//Média de idade das mulheres.

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int masculino = 0, feminino = 0, trinta = 0, sessenta = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("digite seu sexo: ");
                string sexo = Console.ReadLine().ToLower();

                if (sexo == "masculino")
                {
                    masculino++;
                }
                if (sexo == "feminino")
                {
                    feminino++;
                }
                if (idade < 30)
                {
                    trinta++;
                }
                if (idade > 60)
                {
                    sessenta++;
                }
            }
            int media = feminino % 50;
            Console.WriteLine(masculino + " pessoas do sexo masculino");
            Console.WriteLine(feminino + " pessoas do sexo feminino");
            Console.WriteLine(trinta + " pessoas com idade inferior a 30 anos");
            Console.WriteLine(sessenta + " pessoas com idade superior a 60 anos");
            Console.WriteLine("Média de idade das mulheres: " + media);
        }
    }
}