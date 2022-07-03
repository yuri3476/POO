using System;

namespace Exercicio1Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o código da peça 1: ");
            int cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número da peça 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe valor da peça 1: ");
            double valor1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Informe o código da peça 2: ");
            int cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número da peça 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe valor da peça 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            double total = ((num1 * valor1) + (num2 * valor2));

            Console.WriteLine($"VALOR A PAGAR: {total:F2}");


        }
    }
}
