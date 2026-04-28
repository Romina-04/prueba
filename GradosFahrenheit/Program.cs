using System;

namespace GradosFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la temperatura en grados Celsius:");
            
            string? entrada = Console.ReadLine();

            if (!string.IsNullOrEmpty(entrada))
            {
                double celsius = Convert.ToDouble(entrada);
                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"{celsius} grados Celsius equivalen a {fahrenheit} grados Fahrenheit.");
            }
        }
    }
}