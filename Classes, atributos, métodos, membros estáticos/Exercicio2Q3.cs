using System;

namespace Exercicio2Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();


            Console.Write("Nome do aluno: ");
            a.Alunos = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());

            if (a.NotaFinal() >= 60)
            {
                Console.WriteLine();
                Console.WriteLine($"NOTA FINAL = {a.NotaFinal():F2}");
                Console.WriteLine("APROVADO!");
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"NOTA FINAL = {a.NotaFinal():F2}");
                Console.WriteLine("REPROVADO!");
                Console.WriteLine($"FALTARAM {60 - a.NotaFinal()} PONTOS!");
            }

        }
    }
}
