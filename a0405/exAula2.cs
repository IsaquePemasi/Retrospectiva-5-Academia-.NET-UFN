/*
•Dados três números, verificar se eles podem representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.

•Para que três números representem os lados de um triângulo é necessário que cada um deles seja menor que a soma dos outros dois.

•Um triângulo é equilátero se tem os três lados iguais,  isósceles se tem apenas dois lados iguais e escaleno se tem todos os lados distintos.

*/
namespace exerciciosAcademia
{
    internal class ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os três números:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo com os valores informados");
            }
        }
    }
}
