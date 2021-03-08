using System;

namespace Lab3T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмірність простору: ");
            int n = int.Parse(Console.ReadLine());

            double[] A = new double[n];
            int s = 0;
            int f = 1;

            for (int i = 0; i < n; i++)
            {
                f = i;
                f *= i;
                double a = Math.Pow(-1, i) * i / f;

                A[i] = a;
            }

            for (int j = 0; j == A[0] + 1; j++)
            {
                if (j > 0) 
                {
                    s += j;
                }
            }
            Console.WriteLine(s);

            
        }
    }
}
