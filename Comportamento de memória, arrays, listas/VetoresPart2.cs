﻿using System;

namespace VetoresPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Produto[] vect = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Produto { Name = name, Price = price };
            }

            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double avg = soma / n;
            Console.WriteLine($"AVERAGE PRICE: {avg:F2}");

        }
    }
}
