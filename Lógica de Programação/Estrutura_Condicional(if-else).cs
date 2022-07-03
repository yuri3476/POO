using System;

namespace EstruturaCondicional_if_else_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int y = 10;

            Console.WriteLine("Bom dia");
            // estrutura condicional simples

            if (y > 5)
            {
                Console.WriteLine("Boa tarde");
            }
            Console.WriteLine("------------------------");
            // estrutura condicional composta 

            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
            Console.WriteLine("------------------------");

            // estrutura condicional encadeamento

            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());
            
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
