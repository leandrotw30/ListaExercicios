namespace Exercicio13.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoPaozinhos = 0.12;
            double precoBroas = 1.50;

            Console.WriteLine("Digite a quantidade de paozinhos vendidos no dia:");
            double quantidadePaozinhos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas vendidas no dia:");
            double quantidadeBroas = Convert.ToDouble(Console.ReadLine());

            double arrecadacao = (quantidadePaozinhos * precoPaozinhos) + (quantidadeBroas * precoBroas);

            double poupanca = 0.1 * arrecadacao;

            Console.WriteLine("A arrecação total de paozinhos e broas no dia, foi de: " + arrecadacao);
            Console.WriteLine("Você deve guardar na conta poupança: " + poupanca);
        }
    }
}
