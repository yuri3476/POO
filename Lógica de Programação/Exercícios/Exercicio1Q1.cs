using System;

namespace Exercicio1Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = (n1 + n2);



            Console.WriteLine($"SOMA = {soma}");



        }
    }
}
