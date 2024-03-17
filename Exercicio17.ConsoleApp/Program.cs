using System;

namespace Exercicio17.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor para B");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor para C");
            int valorC = Convert.ToInt32(Console.ReadLine());

            if (valorA + valorB < valorC)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }
        }
    }
}
