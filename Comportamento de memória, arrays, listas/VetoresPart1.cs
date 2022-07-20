using System;

namespace VetoresPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // meu vetor terá quantas "caixinhas"?
            int n = int.Parse(Console.ReadLine());

            // criação de um Vetor
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine()); 
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double avg = soma / n;
            Console.WriteLine($"AVERAGE HEIGHT: {avg:F2}");
        }
    }
}
