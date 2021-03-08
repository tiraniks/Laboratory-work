using System;

namespace Lab4T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість рядків і стовпців: ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 9);
                }
            }

            Console.WriteLine("\t Matrix ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:f}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
