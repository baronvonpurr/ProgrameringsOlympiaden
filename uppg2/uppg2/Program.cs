using System;
using System.Data.SqlTypes;

namespace uppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tretal = 0;
            int antal = 0;

            Console.Write("Skriv in ett nummer: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; tretal < N ; i++)
            {
                tretal = i * (i + 1) * (i + 2);
                antal++;
            }
            Console.WriteLine(antal - 1);
            Console.ReadKey();
        }
    }
}
