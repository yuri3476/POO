using System;

namespace Exercicio1Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe valor A: ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Informe o valor B: ");
            double n2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Informe o valor C: ");
            double n3 = double.Parse(Console.ReadLine());

            double triangulo = ((n1 * n3) / 2);
            double circulo = (3.14159 * (n3 * n3));
            double trapezio = ((n1 + n2) * n3) / 2;
            double quadrado = n2 * n2;
            double retangulo = n1 * n2;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");








        }
    }
}
