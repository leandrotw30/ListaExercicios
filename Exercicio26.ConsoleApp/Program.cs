namespace Exercicio26.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int valorA = 0; // valores iniciais da Fibonacci.
            int valorB = 1;
            int resultado = 0;

            Console.Write("0 1 ");

            while (resultado <= numero)
            {
                resultado = valorA + valorB;
                valorA = valorB;
                valorB = resultado;

                if (resultado <= numero)
                {
                    Console.Write(resultado + " ");
                }
            }
        }
    }
}
