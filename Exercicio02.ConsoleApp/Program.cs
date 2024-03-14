namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual temperatura você deseja converter de ºF para graus ºC?");
            double grausFahrenheit = Convert.ToDouble(Console.ReadLine());

            double grausCelsius = 5 / 9 * (grausFahrenheit - 32);

            Console.WriteLine("A temperatura equivalente em ºC é " + grausCelsius);
        }
    }
}
