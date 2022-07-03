using System;
using System.Globalization;

namespace Exercicio1Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o número do funcionário: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor recebido por hora: ");
            double salario = double.Parse(Console.ReadLine());

            double total = horas * salario;

            Console.WriteLine($"NUMBER = {n1}");
            Console.WriteLine("SALARY = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
