using System;

namespace uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ordet  = Console.ReadLine();
            int Antal = int.Parse(Console.ReadLine());
            for (int i = 0; i < Antal; i++)
            {
                Console.Write(Ordet);
            }
            Console.ReadKey();
        }
    }
}
