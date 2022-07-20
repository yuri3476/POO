using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ao invés de instanciar igual método s1, apenas como está no s2 ja funciona
            int s1 = Calculadora.Sum(new int[] { 2, 3 });
            int s2 = Calculadora.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
