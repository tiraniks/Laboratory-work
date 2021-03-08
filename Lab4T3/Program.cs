using System;

namespace Lab4T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмірність матриці: ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] a = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }           

            double[,] b = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = rand.Next(-100, 100);
                }
            }

            Console.WriteLine("\t Matrix A");

            for (int i = 0; i < n; i++)
            {                
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:f}", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t Matrix B");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:f}", b[i, j]);
                }
                Console.WriteLine();
            }

            double[,] c = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = rand.Next(0, 0);
                }
            }

            Console.WriteLine("\t Matrix c= a + b");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];

                    Console.Write("{0,8:f}", c[i, j]);
                }
                Console.WriteLine();
            }

            
        }
    }
}
