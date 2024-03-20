using System;

namespace Exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual temperatura você deseja converter de ºC para ºF?");
            double grausCelsius = Convert.ToDouble(Console.ReadLine());

            double grausFahrenheit = 9 / 5 * (grausCelsius + 32);

            Console.WriteLine("A temperatura equivalente em ºF é: " + grausFahrenheit);
        }
    }
}
