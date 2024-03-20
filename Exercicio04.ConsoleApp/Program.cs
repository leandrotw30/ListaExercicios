using System.ComponentModel;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal quilometragemInicial = ObterDadosUsuario("Digite a quilometragem inicial do percurso do veículo: ");
            decimal quilometragemFinal = ObterDadosUsuario("Digite a quilometragem final do percurso do veículo: ");
            decimal consumoCombustivel = ObterDadosUsuario("Digite o consumo de combustível(em Litros): ");

            decimal distanciaPercorrida = CalculoDistanciaPercorrida(quilometragemInicial, quilometragemFinal);

            decimal consumoPorKm = CalculoConsumoPorKm(consumoCombustivel, distanciaPercorrida);

            MostrarResultado(consumoPorKm);
        }
        private static decimal ObterDadosUsuario(string texto)
        {
            Console.WriteLine(texto);
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            return valor;
        }
        static decimal CalculoDistanciaPercorrida(decimal quilometragemInicial, decimal quilometragemFinal)
        {
            return quilometragemFinal - quilometragemInicial;
        }
        static decimal CalculoConsumoPorKm(decimal consumoCombustivel, decimal distanciaPercorrida)
        {
            return consumoCombustivel / distanciaPercorrida;
        }
        static void MostrarResultado(decimal consumoPorKm)
        {
            Console.WriteLine("O consumo de combustível por Km é: " + consumoPorKm);
        }
    }
}
