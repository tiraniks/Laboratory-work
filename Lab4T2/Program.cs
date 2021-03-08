using System;

namespace Lab4T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмірність матриці: ");
            int n = int.Parse(Console.ReadLine());

            

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] matrix = new double[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; n > 0; i++)
            {
                n--;
                for (int j = 0;  n>0 ; j++)
                {
                    n--;
                    if ((i + 1) * (j + 1) < 3)
                    {
                        matrix[i, j] = i + j + 2;
                    }
                    else 
                    {
                        double s = 0;
                        for (int k = 0; k < j + 2; k++)
                        {
                            s = +(Math.Pow(-1, k)) * k;
                        }
                        matrix[i, j] = s;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,8:f}", matrix[i,j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine( "  " , j);

                }
                Console.WriteLine("\n");
            }

            int emax = 0;

            int p = 1;

            int ind = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > emax)
                    {
                         ind = i + 1;
                    }
                }
                
            }

            for (int j = 0; j < n; j++)
            {
                p *= matrix[ind - 1][j];
            }
        }
    }
}
