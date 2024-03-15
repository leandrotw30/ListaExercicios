using System.Formats.Asn1;

namespace Exercicio12.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as dimensões do terreno!");
            Console.WriteLine("Digite o comprimento:");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a largura:");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            decimal area = comprimento * largura;

            Console.WriteLine("A área do terreno equivale a: " + area);
        }
    }
}
