namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quilometragem inicial do percurso do veículo: ");
            decimal quilometragemInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a quilometragem final do percurso do veículo: ");
            decimal quilometragemFinal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o consumo de combustível (em Litros): ");
            decimal consumoCombustivel = Convert.ToDecimal(Console.ReadLine());

            decimal distanciaPercorrida = quilometragemFinal - quilometragemInicial;

            decimal consumoPorKm = consumoCombustivel / distanciaPercorrida;

            Console.WriteLine("O consumo de combustível por Km é: " + consumoPorKm);
        }
    }
}
