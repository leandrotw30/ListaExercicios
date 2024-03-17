using System;

namespace Exercicio25.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro para o cálculo de fatorial: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;

            for (int i = valorA; i > 0; i--) //enquanto índice de valor inicial A for maior que 0, com repetição decremental, faça:
            {
                resultado = resultado * i;

                if (i == 1)
                {
                    Console.Write(i + " = " + resultado);
                }
                else
                {
                    Console.Write(i + " X ");
                }
            }
        }
    }
}
