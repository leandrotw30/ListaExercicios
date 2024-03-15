namespace Exercicio16.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do seu salário?");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double aumento = 0.15 * salario;

            double salarioFinal = salario + aumento - (0.08 * salario);

            Console.WriteLine("O seu salário inicial é de: " + salario + "\nO seu aumento é de: " + aumento + "\nO seu salário final é de: " + salarioFinal);
        }
    }
}
