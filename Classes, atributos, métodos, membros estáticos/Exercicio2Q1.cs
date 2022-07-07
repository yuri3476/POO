using System;

namespace Exercicio2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");

            Retangulo r = new Retangulo();

            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Área: {r.Area():F2}");
            Console.WriteLine($"Perímetro: {r.Perimetro():F2}");
            Console.WriteLine($"Diagonal: {r.Diagonal():F2}");

        }
    }
}
