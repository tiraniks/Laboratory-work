using System;

namespace Lab2T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення n = ");

            int n = int.Parse(Console.ReadLine());

            int[] k = new int[n];

            for (int i = 0; i < n; i++)
            {
                k[i] = 1;
            }

            if (n >= 2) 
            {
                for (int i = 0; i < n; i++)
                {
                    int x = 2 * k[i - 1] + 3 * k[i - 2];

                    k[i] = x;
                }              
            }

            Console.WriteLine(k);


        }
    }
}
