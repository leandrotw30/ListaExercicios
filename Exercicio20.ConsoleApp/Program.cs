namespace Exercicio20.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer para saber se ele é par ou ímpar: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0) 
            {
                Console.WriteLine("Este número é par!");
            }
            else
            {
                Console.WriteLine("Este número é impar!");
            }
        }
    }
}
