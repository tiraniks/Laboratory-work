using System;

namespace Lab4T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість стовпців: ");
            int m = int.Parse(Console.ReadLine());

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] a = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-10, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:f}", a[i, j]);
                }
                Console.WriteLine();
            }

            int s = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 0) 
                    {
                        s++;
                        break;
                    }
                }
            }

            if (s == 0)
            {
                Console.WriteLine("Таких рядків немає");
            }
            else 
            {
                Console.WriteLine("Рядків с нулями: ", s);
            }
        }
    }
}
