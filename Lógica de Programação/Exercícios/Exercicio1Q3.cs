using System;

namespace Exercicio1Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor: ");
            int n4 = int.Parse(Console.ReadLine());

            int diferenca = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"DIFERENCA = {diferenca}");

        }
    }
}
