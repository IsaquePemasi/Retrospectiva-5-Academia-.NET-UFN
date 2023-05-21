namespace asja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 100; i=i+x)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//•Escreva um algoritmo leia pelo teclado um valor inteiro
//chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.