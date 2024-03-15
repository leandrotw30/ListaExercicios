namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = (4 / 3) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine("O volume da esfera é: " + volume);
        }
    }
}
