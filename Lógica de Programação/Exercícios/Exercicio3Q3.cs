using System;

namespace Exercicio3Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o combustível abastecido: " +
                "\n1. Álcool \n2. Gasolina \n3. Diesel \n4. Fim");
            int num = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (num != 4)
            {
                if (num == 1)
                {
                    alcool += 1;
                    Console.WriteLine("Você digitou Álcool!");
                }
                else if (num == 2)
                {
                    gasolina += 1;
                    Console.WriteLine("Você digitou Gasolina!");
                }
                else if (num == 3)
                {
                    diesel += 1;
                    Console.WriteLine("Você digitou Diesel!");
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
                Console.WriteLine("-=-=-=-=-=-=");
                Console.WriteLine("Informe o combustível abastecido: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");




        }
    }
}
