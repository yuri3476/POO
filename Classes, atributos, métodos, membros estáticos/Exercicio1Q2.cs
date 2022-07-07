using System;

namespace Exercicio1Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1, F2;
            F1 = new Funcionario();
            F2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionáio: ");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F2.Salario = double.Parse(Console.ReadLine());

            double media = ((F1.Salario + F2.Salario) / 2.0);

            Console.WriteLine($"Salário médio: {media:F2}");



        }
    }
}
