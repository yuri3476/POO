using System;

namespace Exercicio3Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida! ");
                Console.Write("Digite sua senha novamente: ");
                senha = int.Parse(Console.ReadLine());  
            }
            Console.WriteLine("Acesso Permitido!");



        }
    }
}
