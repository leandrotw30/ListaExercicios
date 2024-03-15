namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da prova 1: ");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 1: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da prova 2: ");
            decimal peso2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 2: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaPonderada = (peso1 * nota1) + (peso2 * nota2) / (peso1 + peso2);

            Console.WriteLine("A média ponderada deste aluno é: " + mediaPonderada);
        }
    }
}
