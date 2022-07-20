using System;

namespace TiposReferênciaTiposValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // os dois estao certos, para iniciar 

            // tipo struct não precisa colocar Point p = new Point(); , pq é um tipo valor
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            // ele recria as coixinhas 
            p = new Point();
            Console.WriteLine(p);           



        }
    }
}
