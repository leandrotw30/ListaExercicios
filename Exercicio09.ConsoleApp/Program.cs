namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notas = new List<double>();

            Console.WriteLine("Digite as notas do aluno ou digite 'S' para sair");
            Console.WriteLine("Digite a primeira nota do aluno: ");
            var notaDigitada = Console.ReadLine();

            while (!string.IsNullOrEmpty(notaDigitada) && !notaDigitada.Equals("S", StringComparison.InvariantCultureIgnoreCase))
            {
                double notaConvertida = Convert.ToDouble(notaDigitada);
                notas.Add(notaConvertida);
                Console.WriteLine("Digite a próxima nota do aluno");
                notaDigitada = Console.ReadLine();
            }
            double notasSomadas = 0;
            foreach (var nota in notas)
            {
                notasSomadas = notasSomadas + (1 / nota);
            }
            double resultado = notas.Count / notasSomadas;

            Console.WriteLine("A média harmônica deste aluno é: " + resultado);
        }       
    }
}
