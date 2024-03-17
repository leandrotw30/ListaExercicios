namespace Exercicio24.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre 1 e 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) 
            { 
                Console.WriteLine(i + " X " + n + " = " + (i * n));
            }
        }
    }
}
