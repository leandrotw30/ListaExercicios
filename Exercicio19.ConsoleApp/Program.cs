using System.Xml.Serialization;

namespace Exercicio19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para saber seu IMC, digite:");
            Console.WriteLine("Seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine("Sua condição atual é: ");

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc < 25.0)
            {
                Console.WriteLine("Peso normal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso.");
            }
            else
            {
                Console.WriteLine("Obesidade.");
            }
        }
    }
}
