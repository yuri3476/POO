using System;

namespace Exercicio2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }


        }
    }
}
