using System;

namespace Exercicio2Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um número: ");
            double n1 = double.Parse(Console.ReadLine());

            if (n1 >= 0.0 && n1 <= 25.0)
            {
                Console.WriteLine("Intervalo [0, 25] ");
            }

            else if (n1 >= 25 && n1 <= 50)
            {
                Console.WriteLine("Intervalo [25, 50] ");
            }

            else if (n1 >= 50 && n1 <= 75)
            {
                Console.WriteLine("Intervalo [50 75] ");
            }
            else if (n1 >= 75 && n1 <= 100)
            {
                Console.WriteLine("Intervalo [75, 100] ");
            }
            else
            {
                Console.WriteLine("Fora de intervalo!");
            }
        }
    }
}
