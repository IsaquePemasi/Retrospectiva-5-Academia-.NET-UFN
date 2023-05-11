namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.velocidade = 100;
            carro.Acelerar();
            Console.WriteLine(carro.velocidade);
            carro.Frear();
            Console.WriteLine(carro.velocidade);



        }
    }
}