using System;

namespace Exercicio2Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o código do item e a quantidade deste item: ");

            string[] itens = Console.ReadLine().Split(' ');
            int codigo = int.Parse(itens[0]); 
            int qnt = int.Parse(itens[1]);
            double total = 0;
            if (codigo == 1)
            {
                total = qnt * 4.00;
                Console.WriteLine($"Total: {total}" );
            }

            else if (codigo == 2)
            {
                total = qnt * 4.50;
                Console.WriteLine($"Total: {total:F2}");
            }

            else if (codigo == 3)
            {
                total = qnt * 5.00;
                Console.WriteLine($"Total: {total:F2}");
            }

            else if (codigo == 4)
            {
                total = qnt * 2.00;
                Console.WriteLine($"Total: {total:F2}");
            }
            else if (codigo == 5)
            {
                total = qnt * 1.50;
                Console.WriteLine($"Total: {total:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}
