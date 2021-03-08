using System;

namespace Lab3T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення n = ");
            int n = int.Parse(Console.ReadLine());
            int b = n;

            double p = n;

            int[] k = new int[Convert.ToInt32(p)];
            int[] A = new int[n];
            int[] B = new int[n];

            for (int i  = 0; n > 0 ; i++)
            {
                int a = int.Parse(Console.ReadLine());
                n--;
                if (a > 0)
                {
                    A[i]=a;
                }
                else 
                {
                    B[i]=a;
                }
            }

            k = A;

            k = B;

            for (int i = 0; b > 0  ; i++)
            {
                b--;
                Console.Write("{0},", k[i]);
            }
        }
    }
}
