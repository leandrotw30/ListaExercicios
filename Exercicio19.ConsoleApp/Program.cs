using System.Xml.Serialization;

namespace Exercicio19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para saber seu IMC, digite:");

            double peso = ObterMedidas("Digite o seu peso: ");
            double altura = ObterMedidas("Digite a sua altura: ");

            double imc = CalcularIMC(peso, altura);

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
        static double ObterMedidas(string texto)
        {
            Console.WriteLine(texto);
            double valor = Convert.ToDouble(Console.ReadLine());
            return valor; 
        }
        static double CalcularIMC(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}
