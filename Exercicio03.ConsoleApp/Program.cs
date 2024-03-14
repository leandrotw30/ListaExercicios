namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores das seguintes medidas de um cilindro:");
            Console.WriteLine("Raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro é: " + volume);
        }
    }
}
