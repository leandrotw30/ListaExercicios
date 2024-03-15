namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de seu salário base:");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor do seu total de vendas:");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor de sua comissão:");
            int comissao = Convert.ToInt32(Console.ReadLine());

            decimal salarioTotal = salarioBase + (totalVendas * (comissao / 100));
            
            Console.WriteLine("O seu salário total é: " + salarioTotal);
        }
    }
}
