using System;
using System.Globalization;
namespace Exercicio1Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = (3.14159 * (raio * raio));

            Console.WriteLine("A =" +  area.ToString("F4", CultureInfo.InvariantCulture));






        }
    }
}
