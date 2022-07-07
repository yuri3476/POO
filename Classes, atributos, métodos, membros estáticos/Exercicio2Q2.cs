using System;

namespace Exercicio2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {f.Nome}, $ {f.SalarioLiquido():F2}");

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem: ");
            double porcent = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f}:F2");
        }
    }
}
