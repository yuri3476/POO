﻿using System;

namespace MembrosEstaticosPart1
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}" );
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de Pi: {Pi:F2}");
        }


        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
