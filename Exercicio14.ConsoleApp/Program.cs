using System.IO.Pipes;

namespace Exercicio14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoCompleto = 365;

            Console.WriteLine("Olá, qual o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasDeVida = idade * anoCompleto;

            Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias.");
        }
    }
}
