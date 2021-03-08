using System;

namespace Lab4T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Кількість стовпців: ");
            int m = int.Parse(Console.ReadLine());

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m ; j++)
                {
                    Console.Write("{0,8:f}", matrix[i,j]);
                }
                Console.WriteLine();
            }

            double d = 1;

            for (int i = 0; n > 0 ; i++)
            {
                n--;
                for (int j = 0; n > 0; j++)
                {
                    n--;
                    if (i%2 != 0 || j%2 != 0)
                    {
                        if (matrix[i,j]<0)
                        {
                            d = matrix[i,j];
                        }
                    }
                }
            }

            Console.WriteLine("Добуток від'ємних елементів матриці з обома непарними індексами = {0}", d);
        }    
    }
}
