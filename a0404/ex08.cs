using System;

namespace exerciciosAcademia
{
    class ex08
    {
        static void Main(string[] args)
        {
            double temperaturaCelsius, temperaturaFahrenheit;

            Console.WriteLine("Informe a temperatura em graus Celsius:");
            temperaturaCelsius = double.Parse(Console.ReadLine());

            temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            Console.WriteLine($"A temperatura em graus Fahrenheit é: {temperaturaFahrenheit.ToString("F2")}");
        }
    }
}
