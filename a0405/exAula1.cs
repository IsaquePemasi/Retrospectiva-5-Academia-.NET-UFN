namespace exerciciosAcademia
{
    internal class ex14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salario atual:");
            int salario = int.Parse(Console.ReadLine());
            if (salario <= 900)
            {
                Console.WriteLine("seu salario atual" + salario);
                Console.WriteLine("seu aumento foi de " + (salario * 0.05 - salario));
                Console.WriteLine("Seu salario + bonus " + salario * 0.05);

            }
            if (salario <= 1400 && salario > 900)
            {
                Console.WriteLine("seu salario atual" + salario);
                Console.WriteLine("seu aumento foi de " + (salario * 0.08 - salario));
                Console.WriteLine("seu salario + bonus " + salario * 0.08);
            }
            if (salario > 1400)
            {
                Console.WriteLine("seu salario atual" + salario);
                Console.WriteLine("seu aumento foi de " + (salario * 0.10 - salario));
                Console.WriteLine("seu salario + bonus " + salario * 0.10);
            }
        }
    }
}