using System;

namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // se utilizar o ref, tem que sempre iniciar a variável com algum valor
            int a = 10;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);

            // out nao precisa ter sido iniciada
            int b = 10;
            int triple;
            Calculadora.Triples(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
