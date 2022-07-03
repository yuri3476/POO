using System;

namespace Exercicio2Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a hora inicial e final do jogo: ");

            string[]  valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            int duracao;
            if (A < B)
            {
                duracao = B - A;
            }
            else
            {
                duracao = 24 - A + B;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + "HORA(S)");
        }
    }
}
