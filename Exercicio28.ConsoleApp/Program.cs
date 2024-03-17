namespace Exercicio28.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 0; n <= 10; n++)
                {
                    Console.WriteLine(n + " X " + i + " = " + (i * n));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
