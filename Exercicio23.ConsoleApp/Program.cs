using System.Runtime.Serialization;

namespace Exercicio23.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            
            for (int i = 1; i < 500; i++)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.Write("A soma total dos números ímpares, múltiplos de três, entre 1 e 500 é: " + soma);

            Console.ReadKey();
        }
    }
}
