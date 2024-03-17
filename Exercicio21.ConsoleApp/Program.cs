namespace Exercicio21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros:");
            Console.WriteLine("Primeiro valor: ");
            int primeiroValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            int segundoValor = Convert.ToInt32(Console.ReadLine());

            if (primeiroValor == segundoValor)
            {
                int resultado = primeiroValor + segundoValor;
                Console.WriteLine("A soma dos valores é " + resultado);
            }
            else
            {
                int resultado = primeiroValor * segundoValor;
                Console.WriteLine("A multiplacação dos valores é: " + resultado);
            }
        }
    }
}
