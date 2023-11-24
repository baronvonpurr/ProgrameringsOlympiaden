using System;
using System.Runtime.ConstrainedExecution;

namespace uppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Antal rader: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Antal Kolumner: ");
            int m = int.Parse(Console.ReadLine());
            int mincolumn = 0;
            string[] row = new string[n];
            
            for (int p = 0; p < n; p++)
            {
                Console.Write($"Rad{p}: ");
                row[p] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                string activerow = row[i];
                for (int j = 0; j < m; j++)
                {
                    string tecken = activerow[j].ToString();
                    if (tecken != "*" && mincolumn <= j)
                    {
                        Console.Write(activerow[j]);
                        mincolumn = j;
                    }
                    else
                    {
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
