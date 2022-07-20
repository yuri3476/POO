using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // matriz com 2 linhas e 3 colunas

            double[,] mat = new double[2, 3];

            // quantos elementos a matriz tem no total
            Console.WriteLine(mat.Length);

            // quanto é a quantidade de linhas
            Console.WriteLine(mat.Rank);

            // a dimensão 0 tem tamanho 2
            Console.WriteLine(mat.GetLength(0));

            // a dimensão 1 tem tamanho 3
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
