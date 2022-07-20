using System;
using System.Collections.Generic;

namespace ListaParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            //.add adicionar elementos no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // .insert adiciona elementos na posição que eu quiser da lista
            list.Insert(2, "Marco");

            
 
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // mostrar o tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            // primeiro nome da lista que começa com a letra que eu escolher
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            // a última ocorrencia de que começa com a letra escolhida
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // qual posição está quem começa com a letra escolhida
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // escontrar a ultima posição do elemento que começa com a letra escolhida
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);


            // pegar os nomes que possuem apenas 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }


            list.Remove("Alex");
            Console.WriteLine("------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveAt(1);
            Console.WriteLine("------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveRange(2, 2);
            Console.WriteLine("------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
        
    }
}
