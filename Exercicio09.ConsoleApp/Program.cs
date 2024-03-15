namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notas = new List<decimal>();

            Console.WriteLine("Digite as notas do aluno ou digite 'S' para sair");
            Console.WriteLine("Digite a nota 1 do aluno: ");
            var notaDigitada = Console.ReadLine();
           
            while (string.IsNullOrEmpty(notaDigitada) && !notaDigitada.Equals("S",StringComparison.InvariantCultureIgnoreCase))
            {
                decimal notaConvertida = Convert.ToDecimal(notaDigitada);
                notas.Add(notaConvertida);
            }
        }
    }
}//a segunda linha dar o comando para o usuario dar a nota um do aluno, dar readline para ler a nota
// arrumar nullvalidação antes de notaDigitada no while
