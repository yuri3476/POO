using System;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = null; // erro

            Nullable<double> h = null;

            // maneira mais facil 
            // essa ? diz que essa variavel é um Nullable
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // diz se dentro da varial tem ou nao algum valor
            Console.WriteLine(y.HasValue);

            if (x.HasValue) 
            Console.WriteLine(x.Value); // pega o valor diretamente do X
            else
                Console.WriteLine("X is null");
            
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");


            double? g = null;
            double? j = 10;

            double a = g ?? 5; // se for nulo, joga o 5, se n for, joga o valor que a variavel vale
            double b = j ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
