using System.Runtime.Intrinsics.X86;

namespace Exercicio18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auxiliar = 0;
            
            Console.WriteLine("Para exibir três valores em ordem decrescente, você precisará informar valores inteiros e diferentes entre si");
            Console.WriteLine("Informe o primeiro valor:");
            int primeiroValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int segundoValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor:");
            int terceiroValor = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Os valores em ordem decrescente são: " + primeiroValor + ", " + segundoValor + ", " + terceiroValor);

            Console.ReadKey();
        }
    }
}
