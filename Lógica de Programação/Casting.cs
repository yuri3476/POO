using System;

namespace ConversãoImplicitaCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita 
            float x = 4.5f;

            double y = x;
            Console.WriteLine(y);

            //conversao explicita de tipos, tendo que usar um casting
            double a;
            float b;
            a = 5.1;
            b = (float)a;  //casting
            Console.WriteLine(b);

            //jogar um valor double em um int, mas vai ter perda de informação
            double c;
            int d;
            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);




        }
    }
}
