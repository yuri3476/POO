using System;
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

         
            Console.WriteLine($"Produtos: " +
                $"\n{produto1}, cujo preço é $ {preco1:F2} " +
                $"\n{produto2}, cujo preço é $ {preco2:F2}" +
                $"\n\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero} " +
                $"\n\nMedida com oito casas decimais: {medida:F8}" +
                $"\nArredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal envariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("---------------------------------------");
 
        }
    }
}
