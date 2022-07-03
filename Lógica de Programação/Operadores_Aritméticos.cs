using System;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3; // resto da divisão
            Console.WriteLine(n3);

            double n4 = (double) 10 / 8.0; //casting para obter valor com as casas decimais
            Console.WriteLine(n4);


            //Cálculo da Bhaskara
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
