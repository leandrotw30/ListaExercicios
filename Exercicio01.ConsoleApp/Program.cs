namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores das seguintes medidas da caixa retangular:");
            Console.WriteLine("Comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa retangular é: " + volume);
        }
    }
}
