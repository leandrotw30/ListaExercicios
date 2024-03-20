using System.Runtime.Intrinsics.X86;

namespace Exercicio18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auxiliar = 0;

            Console.WriteLine("Para exibir três valores em ordem decrescente, você precisará informar valores inteiros e diferentes entre si");

            int primeiroValor = ObterValorNumerico("Digite o primeiro valor: ");
            
            int segundoValor = ObterValorNumerico("Digite o segundo valor: ");

            int terceiroValor = ObterValorNumerico("Digite o terceiro valor: ");

            if (primeiroValor < segundoValor)
            {
                auxiliar = primeiroValor;
                primeiroValor = segundoValor;
                segundoValor = auxiliar;
            }
            if (primeiroValor < terceiroValor)
            {
                auxiliar = primeiroValor;
                primeiroValor = terceiroValor;
                terceiroValor = auxiliar;
            }
            if (segundoValor < terceiroValor)
            {
                auxiliar = segundoValor;
                segundoValor = terceiroValor;
                terceiroValor = auxiliar;
            }

            MostrarResultado(primeiroValor, segundoValor, terceiroValor);
        }
        private static int ObterValorNumerico(string texto)
        {
            Console.WriteLine(texto);
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }
        private static void MostrarResultado(int primeiroValor, int segundoValor, int terceiroValor)
        {
            Console.WriteLine("Os valores em ordem decrescente são: " + primeiroValor + ", " + segundoValor + ", " + terceiroValor);

            Console.ReadKey();
        }
    }
}
